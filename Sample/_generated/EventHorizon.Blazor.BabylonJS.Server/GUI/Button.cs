/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Button>))]
    public class Button : Rectangle
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Button> CreateImageButton(string name, string text, string imageUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageButton" }, name, text, imageUrl
                }
            );
        }

        public static async ValueTask<Button> CreateImageOnlyButton(string name, string imageUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageOnlyButton" }, name, imageUrl
                }
            );
        }

        public static async ValueTask<Button> CreateSimpleButton(string name, string text)
        {
            return await EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateSimpleButton" }, name, text
                }
            );
        }

        public static async ValueTask<Button> CreateImageWithCenterTextButton(string name, string text, string imageUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageWithCenterTextButton" }, name, text, imageUrl
                }
            );
        }
        #endregion

        #region Accessors
        private Image __image;
        public async ValueTask<Image> get_image()
        {
            if(__image == null)
            {
                __image = await EventHorizonBlazorInterop.GetClass<Image>(
                    this.___guid,
                    "image",
                    (entity) =>
                    {
                        return new Image() { ___guid = entity.___guid };
                    }
                );
            }
            return __image;
        }

        private TextBlock __textBlock;
        public async ValueTask<TextBlock> get_textBlock()
        {
            if(__textBlock == null)
            {
                __textBlock = await EventHorizonBlazorInterop.GetClass<TextBlock>(
                    this.___guid,
                    "textBlock",
                    (entity) =>
                    {
                        return new TextBlock() { ___guid = entity.___guid };
                    }
                );
            }
            return __textBlock;
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<bool> get_delegatePickingToChildren()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "delegatePickingToChildren"
                );
        }
        public ValueTask set_delegatePickingToChildren(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delegatePickingToChildren",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Button() : base() { }

        public Button(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Button> NewButton(
            string name = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Button" },
                name
            );

            return new Button(entity);
        }
        #endregion

        #region Methods
        #region pointerEnterAnimation TODO: Get Comments as metadata identification
        private bool _isPointerEnterAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerEnterAnimationActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> pointerEnterAnimation(
            Func<Task> callback
        )
        {
            await SetupPointerEnterAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerEnterAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerEnterAnimationLoop()
        {
            if (_isPointerEnterAnimationEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerEnterAnimation",
                "CallPointerEnterAnimationActions",
                _invokableReference
            );
            _isPointerEnterAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerEnterAnimationActions()
        {
            foreach (var action in _pointerEnterAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerOutAnimation TODO: Get Comments as metadata identification
        private bool _isPointerOutAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerOutAnimationActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> pointerOutAnimation(
            Func<Task> callback
        )
        {
            await SetupPointerOutAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerOutAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerOutAnimationLoop()
        {
            if (_isPointerOutAnimationEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerOutAnimation",
                "CallPointerOutAnimationActions",
                _invokableReference
            );
            _isPointerOutAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerOutAnimationActions()
        {
            foreach (var action in _pointerOutAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerDownAnimation TODO: Get Comments as metadata identification
        private bool _isPointerDownAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerDownAnimationActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> pointerDownAnimation(
            Func<Task> callback
        )
        {
            await SetupPointerDownAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerDownAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerDownAnimationLoop()
        {
            if (_isPointerDownAnimationEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerDownAnimation",
                "CallPointerDownAnimationActions",
                _invokableReference
            );
            _isPointerDownAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerDownAnimationActions()
        {
            foreach (var action in _pointerDownAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerUpAnimation TODO: Get Comments as metadata identification
        private bool _isPointerUpAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerUpAnimationActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> pointerUpAnimation(
            Func<Task> callback
        )
        {
            await SetupPointerUpAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerUpAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerUpAnimationLoop()
        {
            if (_isPointerUpAnimationEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerUpAnimation",
                "CallPointerUpAnimationActions",
                _invokableReference
            );
            _isPointerUpAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerUpAnimationActions()
        {
            foreach (var action in _pointerUpAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}