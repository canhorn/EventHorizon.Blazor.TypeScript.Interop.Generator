namespace EventHorizon.Blazor.BabylonJS.Pages;

using System;
using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Physics : IDisposable
{
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    private Engine? _engine;
    private Scene? _scene;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await CreateSceneAsync();
        }
    }

    public void Dispose()
    {
        _engine?.dispose();
    }

    public async Task CreateSceneAsync()
    {
        var canvas = Canvas.GetElementById("game-window");
        var engine = new Engine(canvas, true);

        // This creates a basic Babylon Scene object (non-mesh)
        var scene = new Scene(engine);

        // This creates and positions a free camera (non-mesh)
        var camera = new BABYLON.FreeCamera("camera1", new BABYLON.Vector3(0, 5, -10), scene);

        // This targets the camera to scene origin
        camera.setTarget(BABYLON.Vector3.Zero());

        // This attaches the camera to the canvas
        camera.attachControl(canvas, true);

        // This creates a light, aiming 0,1,0 - to the sky (non-mesh)
        var light = new BABYLON.HemisphericLight("light", new BABYLON.Vector3(0, 1, 0), scene);

        // Default intensity is 1. Let's dim the light a small amount
        light.intensity = 0.7M;

        // enable physics in the scene
        await EventHorizonBlazorInterop.RunScript(
            "setupPhysics",
            "const setup = async () => {window.HK = await HavokPhysics()}; setup()",
            new { }
        );
        await JSRuntime.InvokeVoidAsync("HavokPhysics");
        scene.enablePhysics(new Vector3(0, -9.81m, 0), new HavokPlugin(true));

        // Our built-in 'sphere' shape.
        var sphere = BABYLON.MeshBuilder.CreateSphere(
            "sphere",
            new { diameter = 2, segments = 32 },
            scene
        );

        // Move the sphere upward at 4 units
        sphere.position.y = 4;

        // Our built-in 'ground' shape.
        var ground = BABYLON.MeshBuilder.CreateGround(
            "ground",
            new { width = 10, height = 10 },
            scene
        );

        // Create a sphere shape and the associated body. Size will be determined automatically.
        // BABYLON.PhysicsShapeType.SPHERE = 0
        var sphereAggregate = new BABYLON.PhysicsAggregate(
            sphere,
            0,
            new PhysicsAggregateParametersCachedEntity(
                new ClientObject(new { mass = 1, restitution = 0.75 })
            ),
            // new { mass = 1, restitution = 0.75 },
            scene
        );

        // Create a static box shape.
        // BABYLON.PhysicsShapeType.BOX = 3
        var groundAggregate = new BABYLON.PhysicsAggregate(
            ground,
            3,
            new PhysicsAggregateParametersCachedEntity(new ClientObject(new { mass = 0 })),
            scene
        );

        //When clicking the display, sphere will jump.
        scene.onPointerObservable.add(
            (pointerInfo, eventState) =>
            {
                // PointerEventTypes.POINTERDOWN
                if (pointerInfo.type != 1)
                {
                    return Task.CompletedTask;
                }

                sphereAggregate.body.applyImpulse(new Vector3(0, 10, 0), sphere.absolutePosition);

                return Task.CompletedTask;
            }
        );

        _scene = scene;
        _scene.activeCamera = camera;
        engine.runRenderLoop(new ActionCallback(() => Task.Run(() => _scene.render(true, false))));

        _engine = engine;
    }
}
