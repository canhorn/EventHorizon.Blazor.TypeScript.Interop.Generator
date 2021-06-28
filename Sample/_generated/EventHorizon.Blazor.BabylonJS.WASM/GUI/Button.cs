/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Button>))]
    public class Button : Rectangle
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Button CreateImageButton(string name, string text, string imageUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageButton" }, name, text, imageUrl
                }
            );
        }

        public static Button CreateImageOnlyButton(string name, string imageUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageOnlyButton" }, name, imageUrl
                }
            );
        }

        public static Button CreateSimpleButton(string name, string text)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateSimpleButton" }, name, text
                }
            );
        }

        public static Button CreateImageWithCenterTextButton(string name, string text, string imageUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
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
        public Image image
        {
            get
            {
            if(__image == null)
            {
                __image = EventHorizonBlazorInterop.GetClass<Image>(
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
        }

        private TextBlock __textBlock;
        public TextBlock textBlock
        {
            get
            {
            if(__textBlock == null)
            {
                __textBlock = EventHorizonBlazorInterop.GetClass<TextBlock>(
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
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public bool delegatePickingToChildren
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "delegatePickingToChildren"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delegatePickingToChildren",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Button() : base() { }

        public Button(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Button(
            string name = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Button" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region pointerEnterAnimation TODO: Get Comments as metadata identification
        private bool _isPointerEnterAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerEnterAnimationActionMap = new Dictionary<string, Func<Task>>();

        public string pointerEnterAnimation(
            Func<Task> callback
        )
        {
            SetupPointerEnterAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerEnterAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerEnterAnimation_Remove(
            string handle
        )
        {
            return _pointerEnterAnimationActionMap.Remove(
                handle
            );
        }

        private void SetupPointerEnterAnimationLoop()
        {
            if (_isPointerEnterAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string pointerOutAnimation(
            Func<Task> callback
        )
        {
            SetupPointerOutAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerOutAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerOutAnimation_Remove(
            string handle
        )
        {
            return _pointerOutAnimationActionMap.Remove(
                handle
            );
        }

        private void SetupPointerOutAnimationLoop()
        {
            if (_isPointerOutAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string pointerDownAnimation(
            Func<Task> callback
        )
        {
            SetupPointerDownAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerDownAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerDownAnimation_Remove(
            string handle
        )
        {
            return _pointerDownAnimationActionMap.Remove(
                handle
            );
        }

        private void SetupPointerDownAnimationLoop()
        {
            if (_isPointerDownAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string pointerUpAnimation(
            Func<Task> callback
        )
        {
            SetupPointerUpAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerUpAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerUpAnimation_Remove(
            string handle
        )
        {
            return _pointerUpAnimationActionMap.Remove(
                handle
            );
        }

        private void SetupPointerUpAnimationLoop()
        {
            if (_isPointerUpAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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