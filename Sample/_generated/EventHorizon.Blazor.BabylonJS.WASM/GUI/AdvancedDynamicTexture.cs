/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class AdvancedDynamicTexture : DynamicTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static AdvancedDynamicTexture CreateForMesh(AbstractMesh mesh, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> supportPointerMove = null, System.Nullable<bool> onlyAlphaTesting = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture", "CreateForMesh" }, mesh, width, height, supportPointerMove, onlyAlphaTesting
                }
            );
        }

        public static AdvancedDynamicTexture CreateFullscreenUI(string name, System.Nullable<bool> foreground = null, Scene scene = null, System.Nullable<decimal> sampling = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture", "CreateFullscreenUI" }, name, foreground, scene, sampling
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal numLayoutCalls
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "numLayoutCalls"
                );
            }
        }

        
        public decimal numRenderCalls
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "numRenderCalls"
                );
            }
        }

        
        public decimal renderScale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderScale",
                    value
                );
            }
        }

        
        public string background
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "background"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "background",
                    value
                );
            }
        }

        
        public decimal idealWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "idealWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "idealWidth",
                    value
                );
            }
        }

        
        public decimal idealHeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "idealHeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "idealHeight",
                    value
                );
            }
        }

        
        public bool useSmallestIdeal
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useSmallestIdeal"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useSmallestIdeal",
                    value
                );
            }
        }

        
        public bool renderAtIdealSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderAtIdealSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderAtIdealSize",
                    value
                );
            }
        }

        
        public decimal idealRatio
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "idealRatio"
                );
            }
        }

        private Layer __layer;
        public Layer layer
        {
            get
            {
            if(__layer == null)
            {
                __layer = EventHorizonBlazorInteropt.GetClass<Layer>(
                    this.___guid,
                    "layer",
                    (entity) =>
                    {
                        return new Layer() { ___guid = entity.___guid };
                    }
                );
            }
            return __layer;
            }
        }

        private Container __rootContainer;
        public Container rootContainer
        {
            get
            {
            if(__rootContainer == null)
            {
                __rootContainer = EventHorizonBlazorInteropt.GetClass<Container>(
                    this.___guid,
                    "rootContainer",
                    (entity) =>
                    {
                        return new Container() { ___guid = entity.___guid };
                    }
                );
            }
            return __rootContainer;
            }
        }

        private IFocusableControlCachedEntity __focusedControl;
        public IFocusableControlCachedEntity focusedControl
        {
            get
            {
            if(__focusedControl == null)
            {
                __focusedControl = EventHorizonBlazorInteropt.GetClass<IFocusableControlCachedEntity>(
                    this.___guid,
                    "focusedControl",
                    (entity) =>
                    {
                        return new IFocusableControlCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __focusedControl;
            }
            set
            {
__focusedControl = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "focusedControl",
                    value
                );
            }
        }

        
        public bool isForeground
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isForeground"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isForeground",
                    value
                );
            }
        }

        
        public string clipboardData
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "clipboardData"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "clipboardData",
                    value
                );
            }
        }

        
        public bool useInvalidateRectOptimization
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useInvalidateRectOptimization"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useInvalidateRectOptimization",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Observable<ClipboardInfo> __onClipboardObservable;
        public Observable<ClipboardInfo> onClipboardObservable
        {
            get
            {
            if(__onClipboardObservable == null)
            {
                __onClipboardObservable = EventHorizonBlazorInteropt.GetClass<Observable<ClipboardInfo>>(
                    this.___guid,
                    "onClipboardObservable",
                    (entity) =>
                    {
                        return new Observable<ClipboardInfo>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onClipboardObservable;
            }
            set
            {
__onClipboardObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onClipboardObservable",
                    value
                );
            }
        }

        private Observable<Control> __onControlPickedObservable;
        public Observable<Control> onControlPickedObservable
        {
            get
            {
            if(__onControlPickedObservable == null)
            {
                __onControlPickedObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
                    this.___guid,
                    "onControlPickedObservable",
                    (entity) =>
                    {
                        return new Observable<Control>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onControlPickedObservable;
            }
            set
            {
__onControlPickedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onControlPickedObservable",
                    value
                );
            }
        }

        private Observable<AdvancedDynamicTexture> __onBeginLayoutObservable;
        public Observable<AdvancedDynamicTexture> onBeginLayoutObservable
        {
            get
            {
            if(__onBeginLayoutObservable == null)
            {
                __onBeginLayoutObservable = EventHorizonBlazorInteropt.GetClass<Observable<AdvancedDynamicTexture>>(
                    this.___guid,
                    "onBeginLayoutObservable",
                    (entity) =>
                    {
                        return new Observable<AdvancedDynamicTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeginLayoutObservable;
            }
            set
            {
__onBeginLayoutObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeginLayoutObservable",
                    value
                );
            }
        }

        private Observable<AdvancedDynamicTexture> __onEndLayoutObservable;
        public Observable<AdvancedDynamicTexture> onEndLayoutObservable
        {
            get
            {
            if(__onEndLayoutObservable == null)
            {
                __onEndLayoutObservable = EventHorizonBlazorInteropt.GetClass<Observable<AdvancedDynamicTexture>>(
                    this.___guid,
                    "onEndLayoutObservable",
                    (entity) =>
                    {
                        return new Observable<AdvancedDynamicTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEndLayoutObservable;
            }
            set
            {
__onEndLayoutObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onEndLayoutObservable",
                    value
                );
            }
        }

        private Observable<AdvancedDynamicTexture> __onBeginRenderObservable;
        public Observable<AdvancedDynamicTexture> onBeginRenderObservable
        {
            get
            {
            if(__onBeginRenderObservable == null)
            {
                __onBeginRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable<AdvancedDynamicTexture>>(
                    this.___guid,
                    "onBeginRenderObservable",
                    (entity) =>
                    {
                        return new Observable<AdvancedDynamicTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeginRenderObservable;
            }
            set
            {
__onBeginRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeginRenderObservable",
                    value
                );
            }
        }

        private Observable<AdvancedDynamicTexture> __onEndRenderObservable;
        public Observable<AdvancedDynamicTexture> onEndRenderObservable
        {
            get
            {
            if(__onEndRenderObservable == null)
            {
                __onEndRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable<AdvancedDynamicTexture>>(
                    this.___guid,
                    "onEndRenderObservable",
                    (entity) =>
                    {
                        return new Observable<AdvancedDynamicTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEndRenderObservable;
            }
            set
            {
__onEndRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onEndRenderObservable",
                    value
                );
            }
        }

        
        public bool premulAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "premulAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "premulAlpha",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AdvancedDynamicTexture() : base() { }

        public AdvancedDynamicTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AdvancedDynamicTexture(
            string name, Scene scene, System.Nullable<decimal> width = null, System.Nullable<decimal> height = null, System.Nullable<bool> generateMipMaps = null, System.Nullable<decimal> samplingMode = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture" },
                name, width, height, scene, generateMipMaps, samplingMode
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Container[] getChildren()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

// getDescendants is not supported by the platform yet

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        #region executeOnAllControls TODO: Get Comments as metadata identification
        private bool _isExecuteOnAllControlsEnabled = false;
        private readonly IDictionary<string, Func<Control, Task>> _executeOnAllControlsActionMap = new Dictionary<string, Func<Control, Task>>();

        public string executeOnAllControls(
            Func<Control, Task> callback
        )
        {
            SetupExecuteOnAllControlsLoop();

            var handle = Guid.NewGuid().ToString();
            _executeOnAllControlsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupExecuteOnAllControlsLoop()
        {
            if (_isExecuteOnAllControlsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "executeOnAllControls",
                "CallExecuteOnAllControlsActions",
                _invokableReference
            );
            _isExecuteOnAllControlsEnabled = true;
        }

        [JSInvokable]
        public async Task CallExecuteOnAllControlsActions(Control control)
        {
            foreach (var action in _executeOnAllControlsActionMap.Values)
            {
                await action(control);
            }
        }
        #endregion

        public void invalidateRect(decimal invalidMinX, decimal invalidMinY, decimal invalidMaxX, decimal invalidMaxY)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "invalidateRect" }, invalidMinX, invalidMinY, invalidMaxX, invalidMaxY
                }
            );
        }

        public void markAsDirty()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }
                }
            );
        }

        public Style createStyle()
        {
            return EventHorizonBlazorInteropt.FuncClass<Style>(
                entity => new Style() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createStyle" }
                }
            );
        }

        public AdvancedDynamicTexture addControl(Control control)
        {
            return EventHorizonBlazorInteropt.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addControl" }, control
                }
            );
        }

        public AdvancedDynamicTexture removeControl(Control control)
        {
            return EventHorizonBlazorInteropt.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeControl" }, control
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public Vector2 getProjectedPosition(Vector3 position, Matrix worldMatrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getProjectedPosition" }, position, worldMatrix
                }
            );
        }

        public void attach()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attach" }
                }
            );
        }

        public void registerClipboardEvents()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "registerClipboardEvents" }
                }
            );
        }

        public void unRegisterClipboardEvents()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unRegisterClipboardEvents" }
                }
            );
        }

        public void attachToMesh(AbstractMesh mesh, System.Nullable<bool> supportPointerMove = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachToMesh" }, mesh, supportPointerMove
                }
            );
        }

        public void moveFocusToControl(IFocusableControlCachedEntity control)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "moveFocusToControl" }, control
                }
            );
        }
        #endregion
    }
}