namespace EventHorizon.Blazor.BabylonJS.Pages;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop.Callbacks;

public partial class MeshBuilderExample : IDisposable
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
        var light1 = new HemisphericLight("HemisphericLight", new Vector3(1, 1, 0), scene);

        var columns = 6m;
        var rows = 1m;

        var faceUV = new Vector4[6];

        for (var i = 0; i < 6; i++)
        {
            faceUV[i] = new Vector4(i / columns, 0, (i + 1) / columns, 1m / rows);
        }

        var mat = new StandardMaterial("mat", scene);
        var texture = new Texture("https://assets.babylonjs.com/environments/numbers.jpg", scene);
        mat.diffuseTexture = texture;

        var alpha = 1;
        var red = new Color4(1, 0, 0, alpha);
        var blue = new Color4(0, 0, 1, alpha);
        var green = new Color4(0, 1, 0, alpha);

        var options = new
        {
            faceUV,
            wrap = true,
            width = 1,
            height = 2,
            depth = 3,
            faceColors = new List<Color4> { green, green, green, green, blue, red },
        };

        var box = MeshBuilder.CreateBox("box", options, scene);
        box.material = mat;

        var camera = new ArcRotateCamera(
            "ArcRotateCamera",
            (decimal)(Math.PI / 2),
            (decimal)(Math.PI / 4),
            10,
            new Vector3(0, 1, 0),
            scene
        );
        scene.activeCamera = camera;
        camera.attachControl(false);

        engine.runRenderLoop(new ActionCallback(() => Task.Run(() => scene.render(true, false))));

        _engine = engine;
    }
}
