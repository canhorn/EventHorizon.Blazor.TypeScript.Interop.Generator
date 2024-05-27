namespace EventHorizon.Blazor.BabylonJS.Pages;

using BABYLON;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop.Callbacks;

public partial class Home
{
    private Engine? _engine;

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            CreateScene();
        }
    }

    public void Dispose()
    {
        _engine?.dispose();
    }

    public void CreateScene()
    {
        var canvas = Canvas.GetElementById("game-window");
        var engine = new Engine(canvas, true);
        var scene = new Scene(engine);
        var light0 = new PointLight("Omni", new Vector3(0, 2, 8), scene);
        var box1 = Mesh.CreateBox("b1", 1.0m, scene);
        var box2 = Mesh.CreateBox("b1", 1.0m, scene);
        box2.position = new Vector3(2m, 0, 0);
        var camera = new ArcRotateCamera(
            "ArcRotateCamera",
            (decimal)(System.Math.PI / 2),
            (decimal)(System.Math.PI / 4),
            6,
            new Vector3(1, 0, 0),
            scene
        )
        {
            lowerRadiusLimit = 2,
            upperRadiusLimit = 10,
            wheelDeltaPercentage = 0.01m
        };
        scene.activeCamera = camera;
        camera.attachControl(false);
        engine.runRenderLoop(new ActionCallback(() => Task.Run(() => scene.render(true, false))));

        _engine = engine;
    }
}
