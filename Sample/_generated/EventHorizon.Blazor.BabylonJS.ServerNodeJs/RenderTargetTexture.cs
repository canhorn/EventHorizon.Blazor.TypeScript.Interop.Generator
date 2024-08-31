/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<RenderTargetTexture>))]
    public class RenderTargetTexture : Texture, IRenderTargetTexture
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
            return EventHorizonBlazorInterop.Set(this.___guid, "renderList", value);
        }

        public async ValueTask<PostProcess[]> get_postProcesses()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<PostProcess>(
                this.___guid,
                "postProcesses",
                (entity) =>
                {
                    return new PostProcess() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<decimal[]> get_renderPassIds()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "renderPassIds");
        }

        public async ValueTask<decimal> get_currentRefreshId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "currentRefreshId");
        }

        public async ValueTask<bool> get_isMulti()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti");
        }

        private RenderTargetCreationOptionsCachedEntity __renderTargetOptions;

        public async ValueTask<RenderTargetCreationOptionsCachedEntity> get_renderTargetOptions()
        {
            if (__renderTargetOptions == null)
            {
                __renderTargetOptions =
                    await EventHorizonBlazorInterop.GetClass<RenderTargetCreationOptionsCachedEntity>(
                        this.___guid,
                        "renderTargetOptions",
                        (entity) =>
                        {
                            return new RenderTargetCreationOptionsCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __renderTargetOptions;
        }

        private RenderTargetWrapper __renderTarget;

        public async ValueTask<RenderTargetWrapper> get_renderTarget()
        {
            if (__renderTarget == null)
            {
                __renderTarget = await EventHorizonBlazorInterop.GetClass<RenderTargetWrapper>(
                    this.___guid,
                    "renderTarget",
                    (entity) =>
                    {
                        return new RenderTargetWrapper() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderTarget;
        }

        private Vector3 __boundingBoxSize;

        public async ValueTask<Vector3> get_boundingBoxSize()
        {
            if (__boundingBoxSize == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "boundingBoxSize", value);
        }

        private InternalTexture __depthStencilTexture;

        public async ValueTask<InternalTexture> get_depthStencilTexture()
        {
            if (__depthStencilTexture == null)
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
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples");
        }

        public ValueTask set_samples(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
        }

        public async ValueTask<decimal> get_refreshRate()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "refreshRate");
        }

        public ValueTask set_refreshRate(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "refreshRate", value);
        }

        public async ValueTask<bool> get_canRescale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRescale");
        }
        #endregion

        #region Properties

        public async ValueTask<bool> get_renderParticles()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderParticles");
        }

        public ValueTask set_renderParticles(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderParticles", value);
        }

        public async ValueTask<bool> get_renderSprites()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderSprites");
        }

        public ValueTask set_renderSprites(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderSprites", value);
        }

        public async ValueTask<bool> get_forceLayerMaskCheck()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "forceLayerMaskCheck");
        }

        public ValueTask set_forceLayerMaskCheck(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "forceLayerMaskCheck", value);
        }

        private Camera __activeCamera;

        public async ValueTask<Camera> get_activeCamera()
        {
            if (__activeCamera == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "activeCamera", value);
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
            return EventHorizonBlazorInterop.Set(this.___guid, "useCameraPostProcesses", value);
        }

        public async ValueTask<bool> get_ignoreCameraViewport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ignoreCameraViewport");
        }

        public ValueTask set_ignoreCameraViewport(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ignoreCameraViewport", value);
        }

        private Observable<RenderTargetTexture> __onBeforeBindObservable;

        public async ValueTask<Observable<RenderTargetTexture>> get_onBeforeBindObservable()
        {
            if (__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<RenderTargetTexture>
                >(
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
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeforeBindObservable", value);
        }

        private Observable<RenderTargetTexture> __onAfterUnbindObservable;

        public async ValueTask<Observable<RenderTargetTexture>> get_onAfterUnbindObservable()
        {
            if (__onAfterUnbindObservable == null)
            {
                __onAfterUnbindObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<RenderTargetTexture>
                >(
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
            return EventHorizonBlazorInterop.Set(this.___guid, "onAfterUnbindObservable", value);
        }

        // onBeforeRenderObservable is not supported by the platform yet

        // onAfterRenderObservable is not supported by the platform yet

        private Observable<AbstractEngine> __onClearObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onClearObservable()
        {
            if (__onClearObservable == null)
            {
                __onClearObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<AbstractEngine>
                >(
                    this.___guid,
                    "onClearObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onClearObservable;
        }

        public ValueTask set_onClearObservable(Observable<AbstractEngine> value)
        {
            __onClearObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onClearObservable", value);
        }

        private Observable<RenderTargetTexture> __onResizeObservable;

        public async ValueTask<Observable<RenderTargetTexture>> get_onResizeObservable()
        {
            if (__onResizeObservable == null)
            {
                __onResizeObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<RenderTargetTexture>
                >(
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
            return EventHorizonBlazorInterop.Set(this.___guid, "onResizeObservable", value);
        }

        private Color4 __clearColor;

        public async ValueTask<Color4> get_clearColor()
        {
            if (__clearColor == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "clearColor", value);
        }

        public async ValueTask<bool> get_skipInitialClear()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "skipInitialClear");
        }

        public ValueTask set_skipInitialClear(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "skipInitialClear", value);
        }

        public async ValueTask<decimal> get_renderPassId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderPassId");
        }

        public ValueTask set_renderPassId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderPassId", value);
        }

        private Vector3 __boundingBoxPosition;

        public async ValueTask<Vector3> get_boundingBoxPosition()
        {
            if (__boundingBoxPosition == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "boundingBoxPosition", value);
        }
        #endregion

        #region Constructor
        public RenderTargetTexture()
            : base() { }

        public RenderTargetTexture(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<RenderTargetTexture> NewRenderTargetTexture(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                name,
                size,
                scene,
                options
            );

            return new RenderTargetTexture(entity);
        }

        public static async ValueTask<RenderTargetTexture> NewRenderTargetTexture(
            string url = null,
            Scene sceneOrEngine = null,
            System.Nullable<bool> noMipmapOrOptions = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            ActionCallback onLoad = null,
            ActionCallback<string, CachedEntity> onError = null,
            string buffer = null,
            System.Nullable<bool> deleteBuffer = null,
            System.Nullable<decimal> format = null,
            string mimeType = null,
            object loaderOptions = null,
            System.Nullable<decimal> creationFlags = null,
            string forcedExtension = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                url,
                sceneOrEngine,
                noMipmapOrOptions,
                invertY,
                samplingMode,
                onLoad,
                onError,
                buffer,
                deleteBuffer,
                format,
                mimeType,
                loaderOptions,
                creationFlags,
                forcedExtension
            );

            return new RenderTargetTexture(entity);
        }

        public static async ValueTask<RenderTargetTexture> NewRenderTargetTexture(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                sceneOrEngine,
                internalTexture
            );

            return new RenderTargetTexture(entity);
        }

        public static async ValueTask<RenderTargetTexture> NewRenderTargetTexture(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                internalTexture
            );

            return new RenderTargetTexture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> renderListPredicate(AbstractMesh AbstractMesh)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "renderListPredicate" }, AbstractMesh }
            );
        }

        public async ValueTask<AbstractMesh[]> getCustomRenderList(
            decimal layerOrFace,
            Immutable<T> renderList,
            decimal renderListLength
        )
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCustomRenderList" },
                    layerOrFace,
                    renderList,
                    renderListLength
                }
            );
        }

        public async ValueTask<bool> customIsReadyFunction(
            AbstractMesh mesh,
            decimal refreshRate,
            System.Nullable<bool> preWarm = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "customIsReadyFunction" },
                    mesh,
                    refreshRate,
                    preWarm
                }
            );
        }

        public async ValueTask customRenderFunction(
            SmartArray<SubMesh> opaqueSubMeshes,
            SmartArray<SubMesh> alphaTestSubMeshes,
            SmartArray<SubMesh> transparentSubMeshes,
            SmartArray<SubMesh> depthOnlySubMeshes,
            ActionCallback beforeTransparents = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "customRenderFunction" },
                    opaqueSubMeshes,
                    alphaTestSubMeshes,
                    transparentSubMeshes,
                    depthOnlySubMeshes,
                    beforeTransparents
                }
            );
        }

        public async ValueTask setMaterialForRendering(AbstractMesh mesh, Material material = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMaterialForRendering" },
                    mesh,
                    material
                }
            );
        }

        public async ValueTask createDepthStencilTexture(
            System.Nullable<decimal> comparisonFunction = null,
            System.Nullable<bool> bilinearFiltering = null,
            System.Nullable<bool> generateStencil = null,
            System.Nullable<decimal> samples = null,
            System.Nullable<decimal> format = null,
            string label = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createDepthStencilTexture" },
                    comparisonFunction,
                    bilinearFiltering,
                    generateStencil,
                    samples,
                    format,
                    label
                }
            );
        }

        public async ValueTask resetRefreshCounter()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetRefreshCounter" } }
            );
        }

        public async ValueTask addPostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addPostProcess" }, postProcess }
            );
        }

        public async ValueTask clearPostProcesses(System.Nullable<bool> dispose = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearPostProcesses" }, dispose }
            );
        }

        public async ValueTask removePostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removePostProcess" }, postProcess }
            );
        }

        public async ValueTask<decimal> getRenderSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderSize" } }
            );
        }

        public async ValueTask<decimal> getRenderWidth()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderWidth" } }
            );
        }

        public async ValueTask<decimal> getRenderHeight()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderHeight" } }
            );
        }

        public async ValueTask<decimal> getRenderLayers()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderLayers" } }
            );
        }

        public async ValueTask disableRescaling()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disableRescaling" } }
            );
        }

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public async ValueTask<Matrix> getReflectionTextureMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getReflectionTextureMatrix" } }
            );
        }

        public async ValueTask resize(decimal size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, size }
            );
        }

        public async ValueTask render(
            System.Nullable<bool> useCameraPostProcess = null,
            System.Nullable<bool> dumpForDebug = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" },
                    useCameraPostProcess,
                    dumpForDebug
                }
            );
        }

        public async ValueTask<bool> isReadyForRendering()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForRendering" } }
            );
        }

        public async ValueTask setRenderingOrder(
            decimal renderingGroupId,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingOrder" },
                    renderingGroupId,
                    opaqueSortCompareFn,
                    alphaTestSortCompareFn,
                    transparentSortCompareFn
                }
            );
        }

        public async ValueTask setRenderingAutoClearDepthStencil(
            decimal renderingGroupId,
            bool autoClearDepthStencil
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" },
                    renderingGroupId,
                    autoClearDepthStencil
                }
            );
        }

        public async ValueTask<RenderTargetTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public async ValueTask disposeFramebufferObjects()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeFramebufferObjects" } }
            );
        }

        public async ValueTask releaseInternalTexture()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseInternalTexture" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask freeRenderingGroups()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "freeRenderingGroups" } }
            );
        }

        public async ValueTask<decimal> getViewCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getViewCount" } }
            );
        }
        #endregion
    }
}
