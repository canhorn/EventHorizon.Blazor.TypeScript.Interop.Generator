using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabylonJS;
using BabylonJS.GUI;
using EventHorizon.Blazor.BabylonJS.Model;

namespace EventHorizon.Blazor.BabylonJS.Pages
{
    public partial class ButtonExample
    {
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                CreateScene();
            }
        }

        public void CreateScene()
        {
            var canvas = Canvas.GetElementById(
                "game-window"
            );
            var engine = new Engine(
                canvas,
                true
            );
            var scene = new Scene(
                engine
            );
            var light0 = new PointLight(
                "Omni",
                new Vector3(
                    0,
                    100,
                    8
                ),
                scene
            );
            var light1 = new HemisphericLight(
                "HemisphericLight",
                new Vector3(
                    0,
                    100,
                    8
                ),
                scene
            );
            var advancedTexture = AdvancedDynamicTexture.CreateFullscreenUI("UI");
            var button = Button.CreateSimpleButton(
                "button", "Click Me"
            );
            button.width = "130px";
            button.height = "35px";
            button.color = "white";
            button.background = "green";
            button.onPointerClickObservable.add((Vector2WithInfo arg1, EventState state) =>
            {
                var x = arg1.x.ToString();
                var fds = arg1.buttonIndex;
                var vector = new Vector3(2.1m, 3.2m, 4.1m);
                Console.WriteLine(
                    $"Clicked: {arg1.x}, {arg1.y}"
                );
                var xx = vector.getClassName();
                return Task.CompletedTask;
            });
            advancedTexture.addControl(
                button
            );
            var freeCamera = new FreeCamera(
                "FreeCamera",
                new Vector3(
                    0,
                    0,
                    -100
                ),
                scene
            )
            {
                rotation = new Vector3(
                    0,
                    0,
                    0
                ),
            };
            scene.activeCamera = freeCamera;
            freeCamera.attachControl(
                canvas,
                false
            );
            engine.runRenderLoop(() => Task.Run(() => scene.render(true, false)));
        }
    }
}
