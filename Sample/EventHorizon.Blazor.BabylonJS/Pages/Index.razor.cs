using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabylonJS;
using EventHorizon.Blazor.BabylonJS.Model;

namespace EventHorizon.Blazor.BabylonJS.Pages
{
    public partial class Index
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
                    2,
                    8
                ),
                scene
            );
            var box1 = Mesh.CreateBox(
                "b1",
                1.0m,
                scene
            );
            var box2 = Mesh.CreateBox(
                "b1",
                1.0m,
                scene
            );
            box2.position = new Vector3(
                2m,
                0,
                0
            );
            var freeCamera = new FreeCamera(
                "FreeCamera",
                new Vector3(
                    0,
                    0,
                    5
                ),
                scene
            )
            {
                rotation = new Vector3(
                    0m,
                    (decimal)System.Math.PI,
                    0m
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
