namespace EventHorizon.Blazor.Server.BabylonJS.Pages
{
    using System;
    using System.Threading.Tasks;
    using BABYLON;
    using EventHorizon.Blazor.Server.BabylonJS.Model;
    using EventHorizon.Blazor.Server.Interop.Callbacks;

    public partial class MeshExample : IAsyncDisposable
    {
        private Engine _engine;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await CreateScene();
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_engine is not null)
            {
                await _engine.dispose();
            }
        }

        public async Task CreateScene()
        {
            var canvas = await Canvas.GetElementById("game-window");
            var engine = await Engine.NewEngine(canvas, true);
            var scene = await Scene.NewScene(engine);
            var light0 = await PointLight.NewPointLight(
                "Omni",
                await Vector3.NewVector3(0, 100, 8),
                scene
            );
            var light1 = await HemisphericLight.NewHemisphericLight(
                "HemisphericLight",
                await Vector3.NewVector3(0, 100, 8),
                scene
            );
            var house = await SceneLoader.ImportMesh(null, "assets/", "House.gltf", scene);
            var freeCamera = await FreeCamera.NewFreeCamera(
                "FreeCamera",
                await Vector3.NewVector3(0, 0, -100),
                scene
            );
            await freeCamera.set_rotation(await Vector3.NewVector3(0, 0, 0));

            await scene.set_activeCamera(freeCamera);
            await freeCamera.attachControl(false);
            await engine.runRenderLoop(
                new ActionCallback(() => Task.Run(() => scene.render(true, false)))
            );

            _engine = engine;
        }
    }
}
