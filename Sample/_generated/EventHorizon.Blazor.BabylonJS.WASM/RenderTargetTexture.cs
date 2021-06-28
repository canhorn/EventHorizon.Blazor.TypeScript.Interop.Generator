/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RenderTargetTexture>))]
    public class RenderTargetTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal REFRESHRATE_RENDER_ONCE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONCE"
                );
            }
        }

        
        public static decimal REFRESHRATE_RENDER_ONEVERYFRAME
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYFRAME"
                );
            }
        }

        
        public static decimal REFRESHRATE_RENDER_ONEVERYTWOFRAMES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYTWOFRAMES"
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
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "renderList",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __renderTargetOptions = EventHorizonBlazorInterop.GetClass<RenderTargetCreationOptions>(
                    this.___guid,
                    "renderTargetOptions",
                    (entity) =>
                    {
                        return new RenderTargetCreationOptions() { ___guid = entity.___guid };
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
                __boundingBoxSize = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "boundingBoxSize",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingBoxSize;
            }
            set
            {
__boundingBoxSize = null;
                EventHorizonBlazorInterop.Set(
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
                __depthStencilTexture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
                    this.___guid,
                    "depthStencilTexture",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool renderParticles
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderParticles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderSprites"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderSprites",
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
                __activeCamera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "activeCamera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __activeCamera;
            }
            set
            {
__activeCamera = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCameraPostProcesses"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreCameraViewport"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreCameraViewport",
                    value
                );
            }
        }

        private Observable<RenderTargetTexture> __onBeforeBindObservable;
        public Observable<RenderTargetTexture> onBeforeBindObservable
        {
            get
            {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
                    this.___guid,
                    "onBeforeBindObservable",
                    (entity) =>
                    {
                        return new Observable<RenderTargetTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeBindObservable;
            }
            set
            {
__onBeforeBindObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeBindObservable",
                    value
                );
            }
        }

        private Observable<RenderTargetTexture> __onAfterUnbindObservable;
        public Observable<RenderTargetTexture> onAfterUnbindObservable
        {
            get
            {
            if(__onAfterUnbindObservable == null)
            {
                __onAfterUnbindObservable = EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
                    this.___guid,
                    "onAfterUnbindObservable",
                    (entity) =>
                    {
                        return new Observable<RenderTargetTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterUnbindObservable;
            }
            set
            {
__onAfterUnbindObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterUnbindObservable",
                    value
                );
            }
        }

// onBeforeRenderObservable is not supported by the platform yet

// onAfterRenderObservable is not supported by the platform yet

        private Observable<Engine> __onClearObservable;
        public Observable<Engine> onClearObservable
        {
            get
            {
            if(__onClearObservable == null)
            {
                __onClearObservable = EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onClearObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onClearObservable;
            }
            set
            {
__onClearObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onClearObservable",
                    value
                );
            }
        }

        private Observable<RenderTargetTexture> __onResizeObservable;
        public Observable<RenderTargetTexture> onResizeObservable
        {
            get
            {
            if(__onResizeObservable == null)
            {
                __onResizeObservable = EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
                    this.___guid,
                    "onResizeObservable",
                    (entity) =>
                    {
                        return new Observable<RenderTargetTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onResizeObservable;
            }
            set
            {
__onResizeObservable = null;
                EventHorizonBlazorInterop.Set(
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
                __clearColor = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearColor;
            }
            set
            {
__clearColor = null;
                EventHorizonBlazorInterop.Set(
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
                __boundingBoxPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "boundingBoxPosition",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingBoxPosition;
            }
            set
            {
__boundingBoxPosition = null;
                EventHorizonBlazorInterop.Set(
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
            string name, decimal size, Scene scene, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> doNotChangeAspectRatio = null, System.Nullable<decimal> type = null, System.Nullable<bool> isCube = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> generateDepthBuffer = null, System.Nullable<bool> generateStencilBuffer = null, System.Nullable<bool> isMulti = null, System.Nullable<decimal> format = null, System.Nullable<bool> delayAllocation = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
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

        public bool renderListPredicate_Remove(
            string handle
        )
        {
            return _renderListPredicateActionMap.Remove(
                handle
            );
        }

        private void SetupRenderListPredicateLoop()
        {
            if (_isRenderListPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public bool getCustomRenderList_Remove(
            string handle
        )
        {
            return _getCustomRenderListActionMap.Remove(
                handle
            );
        }

        private void SetupGetCustomRenderListLoop()
        {
            if (_isGetCustomRenderListEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        #region customIsReadyFunction TODO: Get Comments as metadata identification
        private bool _isCustomIsReadyFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customIsReadyFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string customIsReadyFunction(
            Func<Task> callback
        )
        {
            SetupCustomIsReadyFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _customIsReadyFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customIsReadyFunction_Remove(
            string handle
        )
        {
            return _customIsReadyFunctionActionMap.Remove(
                handle
            );
        }

        private void SetupCustomIsReadyFunctionLoop()
        {
            if (_isCustomIsReadyFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customIsReadyFunction",
                "CallCustomIsReadyFunctionActions",
                _invokableReference
            );
            _isCustomIsReadyFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomIsReadyFunctionActions()
        {
            foreach (var action in _customIsReadyFunctionActionMap.Values)
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

        public bool customRenderFunction_Remove(
            string handle
        )
        {
            return _customRenderFunctionActionMap.Remove(
                handle
            );
        }

        private void SetupCustomRenderFunctionLoop()
        {
            if (_isCustomRenderFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createDepthStencilTexture" }, comparisonFunction, bilinearFiltering, generateStencil
                }
            );
        }

        public void resetRefreshCounter()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public void addPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addPostProcess" }, postProcess
                }
            );
        }

        public void clearPostProcesses(System.Nullable<bool> dispose = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearPostProcesses" }, dispose
                }
            );
        }

        public void removePostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removePostProcess" }, postProcess
                }
            );
        }

        public decimal getRenderSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public decimal getRenderWidth()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderWidth" }
                }
            );
        }

        public decimal getRenderHeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderHeight" }
                }
            );
        }

        public decimal getRenderLayers()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderLayers" }
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public Matrix getReflectionTextureMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public void resize(decimal size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, size
                }
            );
        }

        public void render(System.Nullable<bool> useCameraPostProcess = null, System.Nullable<bool> dumpForDebug = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess, dumpForDebug
                }
            );
        }

        public void setRenderingOrder(decimal renderingGroupId, ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null, ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null, ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public void setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil
                }
            );
        }

        public RenderTargetTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void disposeFramebufferObjects()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disposeFramebufferObjects" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freeRenderingGroups" }
                }
            );
        }

        public decimal getViewCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getViewCount" }
                }
            );
        }
        #endregion
    }
}