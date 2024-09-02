namespace EventHorizon.Blazor.Server.BabylonJS.Pages;

using System;
using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.Server.BabylonJS.Model;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Physics : IDisposable
{
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    private Engine _engine;
    private Scene _scene;

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
        var canvas = await Canvas.GetElementById("game-window");
        var engine = await Engine.NewEngine(canvas, true);

        // This creates a basic Babylon Scene object (non-mesh)
        var scene = await Scene.NewScene(engine);

        // This creates and positions a free camera (non-mesh)
        var camera = await FreeCamera.NewFreeCamera(
            "camera1",
            await Vector3.NewVector3(0, 5, -10),
            scene
        );

        // This targets the camera to scene origin
        await camera.setTarget(await Vector3.Zero());

        // This attaches the camera to the canvas
        await camera.attachControl(canvas, true);

        // This creates a light, aiming 0,1,0 - to the sky (non-mesh)
        var light = await HemisphericLight.NewHemisphericLight(
            "light",
            await Vector3.NewVector3(0, 1, 0),
            scene
        );

        // Default intensity is 1. Let's dim the light a small amount
        await light.set_intensity(0.7M);

        // enable physics in the scene
        await EventHorizonBlazorInterop.RunScript(
            "setupPhysics",
            "const setup = async () => {window.HK = await HavokPhysics()}; setup()",
            new { }
        );
        await JSRuntime.InvokeVoidAsync("HavokPhysics");
        await scene.enablePhysics(
            await Vector3.NewVector3(0, -9.81m, 0),
            await HavokPlugin.NewHavokPlugin(true)
        );

        // Our built-in 'sphere' shape.
        var sphere = await MeshBuilder.CreateSphere(
            "sphere",
            new { diameter = 2, segments = 32 },
            scene
        );

        // Move the sphere upward at 4 units
        await (await sphere.get_position()).set_y(4);

        // Our built-in 'ground' shape.
        var ground = await MeshBuilder.CreateGround(
            "ground",
            new { width = 10, height = 10 },
            scene
        );

        // Create a sphere shape and the associated body. Size will be determined automatically.
        // BABYLON.PhysicsShapeType.SPHERE = 0
        var sphereAggregate = await BABYLON.PhysicsAggregate.NewPhysicsAggregate(
            sphere,
            0,
            new PhysicsAggregateParametersCachedEntity(
                await ClientObject.NewClientObject(new { mass = 1, restitution = 0.75 })
            ),
            // new { mass = 1, restitution = 0.75 },
            scene
        );

        // Create a static box shape.
        // BABYLON.PhysicsShapeType.BOX = 3
        var groundAggregate = await BABYLON.PhysicsAggregate.NewPhysicsAggregate(
            ground,
            3,
            new PhysicsAggregateParametersCachedEntity(
                await ClientObject.NewClientObject(new { mass = 0 })
            ),
            scene
        );

        //When clicking the display, sphere will jump.
        await (await scene.get_onPointerObservable()).add(
            async (pointerInfo, eventState) =>
            {
                // PointerEventTypes.POINTERDOWN
                if (await pointerInfo.get_type() != 1)
                {
                    return;
                }

                await (await sphereAggregate.get_body()).applyImpulse(
                    await Vector3.NewVector3(0, 10, 0),
                    await sphere.get_absolutePosition()
                );
            }
        );

        _scene = scene;
        await _scene.set_activeCamera(camera);
        await engine.runRenderLoop(
            new ActionCallback(() => Task.Run(() => _scene.render(true, false)))
        );

        _engine = engine;
    }
}
