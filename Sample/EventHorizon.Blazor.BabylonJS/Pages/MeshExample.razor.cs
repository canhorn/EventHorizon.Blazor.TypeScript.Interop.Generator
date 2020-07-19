using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabylonJS;
using EventHorizon.Blazor.BabylonJS.Model;

namespace EventHorizon.Blazor.BabylonJS.Pages
{
    public partial class MeshExample
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
            var house = SceneLoader.ImportMesh(
                null,
                "assets/",
                "House.gltf",
                scene
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
