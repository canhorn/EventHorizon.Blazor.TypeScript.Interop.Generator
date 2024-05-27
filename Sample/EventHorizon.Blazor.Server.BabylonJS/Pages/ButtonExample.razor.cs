namespace EventHorizon.Blazor.Server.BabylonJS.Pages
{
    using System;
    using System.Threading.Tasks;
    using BABYLON;
    using BABYLON.GUI;
    using EventHorizon.Blazor.Server.BabylonJS.Model;
    using EventHorizon.Blazor.Server.Interop.Callbacks;

    public partial class ButtonExample : IAsyncDisposable
    {
        private Engine _engine;

        public Vector2 ClickPosition { get; set; }
        public decimal ClickPosition_X { get; set; }
        public decimal ClickPosition_Y { get; set; }

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
            var advancedTexture = await AdvancedDynamicTexture.CreateFullscreenUI("UI");
            var button = await Button.CreateSimpleButton("button", "Click Me");
            await button.set_width("90%");
            await button.set_height("90%");
            await button.set_color("white");
            await button.set_background("green");

            await (await button.get_onPointerClickObservable()).add(
                async (Vector2WithInfo arg1, EventState state) =>
                {
                    var x = (await arg1.get_x()).ToString();
                    var fds = await arg1.get_buttonIndex();
                    var vector = await Vector3.NewVector3(2.1m, 3.2m, 4.1m);
                    Console.WriteLine($"Clicked: {await arg1.get_x()}, {await arg1.get_y()}");
                    var xx = await vector.getClassName();
                    ClickPosition = arg1;
                    ClickPosition_X = await ClickPosition.get_x();
                    ClickPosition_Y = await ClickPosition.get_y();
                    await InvokeAsync(StateHasChanged);
                }
            );
            await advancedTexture.addControl(button);
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
