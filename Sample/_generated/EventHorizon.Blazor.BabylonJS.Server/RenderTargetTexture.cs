/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<RenderTargetTexture>))]
    public class RenderTargetTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_REFRESHRATE_RENDER_ONCE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONCE"
                );
        }

        
        public static async ValueTask<decimal> get_REFRESHRATE_RENDER_ONEVERYFRAME()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYFRAME"
                );
        }

        
        public static async ValueTask<decimal> get_REFRESHRATE_RENDER_ONEVERYTWOFRAMES()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderTargetTexture.REFRESHRATE_RENDER_ONEVERYTWOFRAMES"
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<AbstractMesh[]> get_renderList()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "renderList",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_renderList(AbstractMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderList",
                    value
                );
        }

        private RenderTargetCreationOptions __renderTargetOptions;
        public async ValueTask<RenderTargetCreationOptions> get_renderTargetOptions()
        {
            if(__renderTargetOptions == null)
            {
                __renderTargetOptions = await EventHorizonBlazorInterop.GetClass<RenderTargetCreationOptions>(
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

        private Vector3 __boundingBoxSize;
        public async ValueTask<Vector3> get_boundingBoxSize()
        {
            if(__boundingBoxSize == null)
            {
                __boundingBoxSize = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_boundingBoxSize(Vector3 value)
        {
__boundingBoxSize = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBoxSize",
                    value
                );
        }

        private InternalTexture __depthStencilTexture;
        public async ValueTask<InternalTexture> get_depthStencilTexture()
        {
            if(__depthStencilTexture == null)
            {
                __depthStencilTexture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
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

        
        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
        }
        public ValueTask set_samples(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
        }

        
        public async ValueTask<decimal> get_refreshRate()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
        }
        public ValueTask set_refreshRate(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refreshRate",
                    value
                );
        }

        
        public async ValueTask<bool> get_canRescale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_renderParticles()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderParticles"
                );
        }
        public ValueTask set_renderParticles(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderParticles",
                    value
                );
        }

        
        public async ValueTask<bool> get_renderSprites()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderSprites"
                );
        }
        public ValueTask set_renderSprites(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderSprites",
                    value
                );
        }

        private Camera __activeCamera;
        public async ValueTask<Camera> get_activeCamera()
        {
            if(__activeCamera == null)
            {
                __activeCamera = await EventHorizonBlazorInterop.GetClass<Camera>(
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
        public ValueTask set_activeCamera(Camera value)
        {
__activeCamera = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeCamera",
                    value
                );
        }

        
        public async ValueTask<bool> get_useCameraPostProcesses()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCameraPostProcesses"
                );
        }
        public ValueTask set_useCameraPostProcesses(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCameraPostProcesses",
                    value
                );
        }

        
        public async ValueTask<bool> get_ignoreCameraViewport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreCameraViewport"
                );
        }
        public ValueTask set_ignoreCameraViewport(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreCameraViewport",
                    value
                );
        }

        private Observable<RenderTargetTexture> __onBeforeBindObservable;
        public async ValueTask<Observable<RenderTargetTexture>> get_onBeforeBindObservable()
        {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = await EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
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
        public ValueTask set_onBeforeBindObservable(Observable<RenderTargetTexture> value)
        {
__onBeforeBindObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeBindObservable",
                    value
                );
        }

        private Observable<RenderTargetTexture> __onAfterUnbindObservable;
        public async ValueTask<Observable<RenderTargetTexture>> get_onAfterUnbindObservable()
        {
            if(__onAfterUnbindObservable == null)
            {
                __onAfterUnbindObservable = await EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
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
        public ValueTask set_onAfterUnbindObservable(Observable<RenderTargetTexture> value)
        {
__onAfterUnbindObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterUnbindObservable",
                    value
                );
        }

// onBeforeRenderObservable is not supported by the platform yet

// onAfterRenderObservable is not supported by the platform yet

        private Observable<Engine> __onClearObservable;
        public async ValueTask<Observable<Engine>> get_onClearObservable()
        {
            if(__onClearObservable == null)
            {
                __onClearObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onClearObservable(Observable<Engine> value)
        {
__onClearObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onClearObservable",
                    value
                );
        }

        private Observable<RenderTargetTexture> __onResizeObservable;
        public async ValueTask<Observable<RenderTargetTexture>> get_onResizeObservable()
        {
            if(__onResizeObservable == null)
            {
                __onResizeObservable = await EventHorizonBlazorInterop.GetClass<Observable<RenderTargetTexture>>(
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
        public ValueTask set_onResizeObservable(Observable<RenderTargetTexture> value)
        {
__onResizeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onResizeObservable",
                    value
                );
        }

        private Color4 __clearColor;
        public async ValueTask<Color4> get_clearColor()
        {
            if(__clearColor == null)
            {
                __clearColor = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_clearColor(Color4 value)
        {
__clearColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
        }

        private Vector3 __boundingBoxPosition;
        public async ValueTask<Vector3> get_boundingBoxPosition()
        {
            if(__boundingBoxPosition == null)
            {
                __boundingBoxPosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_boundingBoxPosition(Vector3 value)
        {
__boundingBoxPosition = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBoxPosition",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public RenderTargetTexture() : base() { }

        public RenderTargetTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<RenderTargetTexture> NewRenderTargetTexture(
            string name, decimal size, Scene scene, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> doNotChangeAspectRatio = null, System.Nullable<decimal> type = null, System.Nullable<bool> isCube = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> generateDepthBuffer = null, System.Nullable<bool> generateStencilBuffer = null, System.Nullable<bool> isMulti = null, System.Nullable<decimal> format = null, System.Nullable<bool> delayAllocation = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                name, size, scene, generateMipMaps, doNotChangeAspectRatio, type, isCube, samplingMode, generateDepthBuffer, generateStencilBuffer, isMulti, format, delayAllocation
            );

            return new RenderTargetTexture(entity);
        }
        #endregion

        #region Methods
        #region renderListPredicate TODO: Get Comments as metadata identification
        private bool _isRenderListPredicateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _renderListPredicateActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> renderListPredicate(
            Func<Task> callback
        )
        {
            await SetupRenderListPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _renderListPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupRenderListPredicateLoop()
        {
            if (_isRenderListPredicateEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> getCustomRenderList(
            Func<Task> callback
        )
        {
            await SetupGetCustomRenderListLoop();

            var handle = Guid.NewGuid().ToString();
            _getCustomRenderListActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetCustomRenderListLoop()
        {
            if (_isGetCustomRenderListEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> customIsReadyFunction(
            Func<Task> callback
        )
        {
            await SetupCustomIsReadyFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _customIsReadyFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomIsReadyFunctionLoop()
        {
            if (_isCustomIsReadyFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> customRenderFunction(
            Func<Task> callback
        )
        {
            await SetupCustomRenderFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _customRenderFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomRenderFunctionLoop()
        {
            if (_isCustomRenderFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask createDepthStencilTexture(System.Nullable<decimal> comparisonFunction = null, System.Nullable<bool> bilinearFiltering = null, System.Nullable<bool> generateStencil = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createDepthStencilTexture" }, comparisonFunction, bilinearFiltering, generateStencil
                }
            );
        }

        public async ValueTask resetRefreshCounter()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public async ValueTask addPostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addPostProcess" }, postProcess
                }
            );
        }

        public async ValueTask clearPostProcesses(System.Nullable<bool> dispose = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearPostProcesses" }, dispose
                }
            );
        }

        public async ValueTask removePostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removePostProcess" }, postProcess
                }
            );
        }

        public async ValueTask<decimal> getRenderSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public async ValueTask<decimal> getRenderWidth()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderWidth" }
                }
            );
        }

        public async ValueTask<decimal> getRenderHeight()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderHeight" }
                }
            );
        }

        public async ValueTask<decimal> getRenderLayers()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderLayers" }
                }
            );
        }

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public async ValueTask<Matrix> getReflectionTextureMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public async ValueTask resize(decimal size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }, size
                }
            );
        }

        public async ValueTask render(System.Nullable<bool> useCameraPostProcess = null, System.Nullable<bool> dumpForDebug = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess, dumpForDebug
                }
            );
        }

        public async ValueTask setRenderingOrder(decimal renderingGroupId, ActionCallback<SubMesh, SubMesh> opaqueSortCompareFn = null, ActionCallback<SubMesh, SubMesh> alphaTestSortCompareFn = null, ActionCallback<SubMesh, SubMesh> transparentSortCompareFn = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public async ValueTask setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil
                }
            );
        }

        public async ValueTask<RenderTargetTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public async ValueTask disposeFramebufferObjects()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disposeFramebufferObjects" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask freeRenderingGroups()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeRenderingGroups" }
                }
            );
        }

        public async ValueTask<decimal> getViewCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getViewCount" }
                }
            );
        }
        #endregion
    }
}