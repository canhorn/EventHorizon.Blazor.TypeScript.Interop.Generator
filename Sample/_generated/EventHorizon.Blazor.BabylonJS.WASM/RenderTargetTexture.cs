/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class RenderTargetTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal REFRESHRATE_RENDER_ONCE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".RenderTargetTexture.REFRESHRATE_RENDER_ONCE"
                );
            }
        }

        
        public static decimal REFRESHRATE_RENDER_ONEVERYFRAME
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYFRAME"
                );
            }
        }

        
        public static decimal REFRESHRATE_RENDER_ONEVERYTWOFRAMES
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYTWOFRAMES"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public AbstractMesh[] renderList
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "renderList",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderList",
                    value
                );
            }
        }

        private RenderTargetCreationOptions __renderTargetOptions;
        public RenderTargetCreationOptions renderTargetOptions
        {
            get
            {
            if(__renderTargetOptions == null)
            {
                __renderTargetOptions = EventHorizonBlazorInteropt.GetClass<RenderTargetCreationOptions>(
                    this.___guid,
                    "renderTargetOptions",
                    (entity) =>
                    {
                        return new RenderTargetCreationOptions(entity);
                    }
                );
            }
            return __renderTargetOptions;
            }
        }

        private Vector3 __boundingBoxSize;
        public Vector3 boundingBoxSize
        {
            get
            {
            if(__boundingBoxSize == null)
            {
                __boundingBoxSize = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "boundingBoxSize",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __boundingBoxSize;
            }
            set
            {
__boundingBoxSize = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "boundingBoxSize",
                    value
                );
            }
        }

        private InternalTexture __depthStencilTexture;
        public InternalTexture depthStencilTexture
        {
            get
            {
            if(__depthStencilTexture == null)
            {
                __depthStencilTexture = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "depthStencilTexture",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __depthStencilTexture;
            }
        }

        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }

        
        public decimal refreshRate
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "refreshRate",
                    value
                );
            }
        }

        
        public bool canRescale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool isCube
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isCube"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isCube",
                    value
                );
            }
        }

        
        public bool renderParticles
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderParticles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderParticles",
                    value
                );
            }
        }

        
        public bool renderSprites
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderSprites"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderSprites",
                    value
                );
            }
        }

        
        public decimal coordinatesMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "coordinatesMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "coordinatesMode",
                    value
                );
            }
        }

        private Camera __activeCamera;
        public Camera activeCamera
        {
            get
            {
            if(__activeCamera == null)
            {
                __activeCamera = EventHorizonBlazorInteropt.GetClass<Camera>(
                    this.___guid,
                    "activeCamera",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            return __activeCamera;
            }
            set
            {
__activeCamera = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "activeCamera",
                    value
                );
            }
        }

        
        public bool useCameraPostProcesses
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useCameraPostProcesses"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useCameraPostProcesses",
                    value
                );
            }
        }

        
        public bool ignoreCameraViewport
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "ignoreCameraViewport"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ignoreCameraViewport",
                    value
                );
            }
        }

        private Observable __onBeforeBindObservable;
        public Observable onBeforeBindObservable
        {
            get
            {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeBindObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeBindObservable;
            }
            set
            {
__onBeforeBindObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeBindObservable",
                    value
                );
            }
        }

        private Observable __onAfterUnbindObservable;
        public Observable onAfterUnbindObservable
        {
            get
            {
            if(__onAfterUnbindObservable == null)
            {
                __onAfterUnbindObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterUnbindObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterUnbindObservable;
            }
            set
            {
__onAfterUnbindObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterUnbindObservable",
                    value
                );
            }
        }

        private Observable __onBeforeRenderObservable;
        public Observable onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
            }
        }

        private Observable __onAfterRenderObservable;
        public Observable onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderObservable;
            }
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
            }
        }

        private Observable __onClearObservable;
        public Observable onClearObservable
        {
            get
            {
            if(__onClearObservable == null)
            {
                __onClearObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onClearObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onClearObservable;
            }
            set
            {
__onClearObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onClearObservable",
                    value
                );
            }
        }

        private Observable __onResizeObservable;
        public Observable onResizeObservable
        {
            get
            {
            if(__onResizeObservable == null)
            {
                __onResizeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onResizeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onResizeObservable;
            }
            set
            {
__onResizeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onResizeObservable",
                    value
                );
            }
        }

        private Color4 __clearColor;
        public Color4 clearColor
        {
            get
            {
            if(__clearColor == null)
            {
                __clearColor = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __clearColor;
            }
            set
            {
__clearColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
            }
        }

        private Vector3 __boundingBoxPosition;
        public Vector3 boundingBoxPosition
        {
            get
            {
            if(__boundingBoxPosition == null)
            {
                __boundingBoxPosition = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "boundingBoxPosition",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __boundingBoxPosition;
            }
            set
            {
__boundingBoxPosition = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "boundingBoxPosition",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public RenderTargetTexture() : base() { }

        public RenderTargetTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public RenderTargetTexture(
            string name, Scene scene, System.Nullable<decimal> size = null, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> doNotChangeAspectRatio = null, System.Nullable<decimal> type = null, System.Nullable<bool> isCube = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> generateDepthBuffer = null, System.Nullable<bool> generateStencilBuffer = null, System.Nullable<bool> isMulti = null, System.Nullable<decimal> format = null, System.Nullable<bool> delayAllocation = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                name, size, scene, generateMipMaps, doNotChangeAspectRatio, type, isCube, samplingMode, generateDepthBuffer, generateStencilBuffer, isMulti, format, delayAllocation
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region renderListPredicate TODO: Get Comments as metadata identification
        private bool _isRenderListPredicateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _renderListPredicateActionMap = new Dictionary<string, Func<Task>>();

        public string renderListPredicate(
            Func<Task> callback
        )
        {
            SetupRenderListPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _renderListPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRenderListPredicateLoop()
        {
            if (_isRenderListPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "renderListPredicate",
                "CallRenderListPredicateActions",
                _invokableReference
            );
            _isRenderListPredicateEnabled = true;
        }

        [JSInvokable]
        public async Task CallRenderListPredicateActions()
        {
            foreach (var action in _renderListPredicateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getCustomRenderList TODO: Get Comments as metadata identification
        private bool _isGetCustomRenderListEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getCustomRenderListActionMap = new Dictionary<string, Func<Task>>();

        public string getCustomRenderList(
            Func<Task> callback
        )
        {
            SetupGetCustomRenderListLoop();

            var handle = Guid.NewGuid().ToString();
            _getCustomRenderListActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetCustomRenderListLoop()
        {
            if (_isGetCustomRenderListEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getCustomRenderList",
                "CallGetCustomRenderListActions",
                _invokableReference
            );
            _isGetCustomRenderListEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetCustomRenderListActions()
        {
            foreach (var action in _getCustomRenderListActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region customRenderFunction TODO: Get Comments as metadata identification
        private bool _isCustomRenderFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customRenderFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string customRenderFunction(
            Func<Task> callback
        )
        {
            SetupCustomRenderFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _customRenderFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCustomRenderFunctionLoop()
        {
            if (_isCustomRenderFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "customRenderFunction",
                "CallCustomRenderFunctionActions",
                _invokableReference
            );
            _isCustomRenderFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomRenderFunctionActions()
        {
            foreach (var action in _customRenderFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void createDepthStencilTexture(System.Nullable<decimal> comparisonFunction = null, System.Nullable<bool> bilinearFiltering = null, System.Nullable<bool> generateStencil = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createDepthStencilTexture" }, comparisonFunction, bilinearFiltering, generateStencil
                }
            );
        }

        public void resetRefreshCounter()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public void addPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addPostProcess" }, postProcess
                }
            );
        }

        public void clearPostProcesses(System.Nullable<bool> dispose = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearPostProcesses" }, dispose
                }
            );
        }

        public void removePostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removePostProcess" }, postProcess
                }
            );
        }

        public decimal getRenderSize()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public decimal getRenderWidth()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderWidth" }
                }
            );
        }

        public decimal getRenderHeight()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderHeight" }
                }
            );
        }

        public decimal getRenderLayers()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderLayers" }
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public Matrix getReflectionTextureMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public void resize(decimal size)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }, size
                }
            );
        }

        public void render(System.Nullable<bool> useCameraPostProcess = null, System.Nullable<bool> dumpForDebug = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess, dumpForDebug
                }
            );
        }

        public void setRenderingOrder(decimal renderingGroupId, SubMesh opaqueSortCompareFn = null, SubMesh alphaTestSortCompareFn = null, SubMesh transparentSortCompareFn = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public void setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil
                }
            );
        }

        public RenderTargetTexture clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void disposeFramebufferObjects()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disposeFramebufferObjects" }
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

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeRenderingGroups" }
                }
            );
        }

        public decimal getViewCount()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getViewCount" }
                }
            );
        }
        #endregion
    }
}