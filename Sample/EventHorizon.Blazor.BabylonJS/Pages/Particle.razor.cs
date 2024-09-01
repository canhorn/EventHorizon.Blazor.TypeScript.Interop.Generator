namespace EventHorizon.Blazor.BabylonJS.Pages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BABYLON;
using BABYLON.GUI;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop.Callbacks;

public partial class Particle : IDisposable
{
    private IDictionary<string, AnimationGroup> _animationMap =
        new Dictionary<string, AnimationGroup>();
    private AnimationGroup? _runningAnimation;
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
        scene.clearColor = new Color4(0, 0, 0, 0);
        var light0 = new PointLight("Omni", new Vector3(0, 100, 8), scene);
        var light1 = new HemisphericLight("HemisphericLight", new Vector3(0, 100, 8), scene);
        var advancedTexture = AdvancedDynamicTexture.CreateFullscreenUI("UI");
        var UiPanel = new StackPanel("name")
        {
            width = "220px",
            fontSize = "14px",
            horizontalAlignment = Control.HORIZONTAL_ALIGNMENT_RIGHT,
            verticalAlignment = Control.VERTICAL_ALIGNMENT_CENTER
        };
        advancedTexture.addControl(UiPanel);

        var house = SceneLoader.ImportMesh(
            null,
            "assets/",
            "Player.glb",
            scene,
            new Interop.Callbacks.ActionCallback<
                AbstractMesh[],
                IParticleSystem[],
                Skeleton[],
                AnimationGroup[],
                TransformNode[],
                Geometry[],
                Light[],
                ISpriteManager[]
            >(
                (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
                {
                    foreach (var animation in arg4)
                    {
                        animation.stop();
                        _animationMap.Add(animation.name, animation);
                        AddRunAnimationButton(UiPanel, animation.name);
                    }
                    if (_animationMap.Count > 0)
                    {
                        _runningAnimation = _animationMap.First().Value;
                        _runningAnimation.start(true);
                    }
                    return Task.CompletedTask;
                }
            )
        );
        var camera = new ArcRotateCamera(
            "ArcRotateCamera",
            (decimal)(System.Math.PI / 2),
            (decimal)(System.Math.PI / 4),
            3,
            new Vector3(0, 1, 0),
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

    private void AddRunAnimationButton(StackPanel uiPanel, string name)
    {
        var button = Button.CreateSimpleButton($"but_{name}", name);
        button.paddingTop = "10px";
        button.width = "100px";
        button.height = "50px";
        button.color = "white";
        button.background = "green";
        button.onPointerDownObservable.add(
            (_, __) =>
            {
                if (_runningAnimation != null)
                {
                    _runningAnimation.stop();
                    _runningAnimation = null;
                }
                if (_animationMap.ContainsKey(name))
                {
                    _animationMap[name].play(true);
                    _runningAnimation = _animationMap[name];
                }

                return Task.CompletedTask;
            }
        );
        uiPanel.addControl(button);
    }
}
