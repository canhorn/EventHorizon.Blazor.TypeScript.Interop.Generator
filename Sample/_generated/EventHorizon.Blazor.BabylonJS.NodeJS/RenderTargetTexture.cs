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
    public class RenderTargetTexture : Texture, IRenderTargetTexture
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

                EventHorizonBlazorInterop.Set(this.___guid, "renderList", value);
            }
        }

        public PostProcess[] postProcesses
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
        }

        public decimal[] renderPassIds
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "renderPassIds");
            }
        }

        public decimal currentRefreshId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "currentRefreshId"); }
        }

        public bool isMulti
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti"); }
        }

        private RenderTargetCreationOptionsCachedEntity __renderTargetOptions;
        public RenderTargetCreationOptionsCachedEntity renderTargetOptions
        {
            get
            {
                if (__renderTargetOptions == null)
                {
                    __renderTargetOptions =
                        EventHorizonBlazorInterop.GetClass<RenderTargetCreationOptionsCachedEntity>(
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
        }

        private RenderTargetWrapper __renderTarget;
        public RenderTargetWrapper renderTarget
        {
            get
            {
                if (__renderTarget == null)
                {
                    __renderTarget = EventHorizonBlazorInterop.GetClass<RenderTargetWrapper>(
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
        }

        private Vector3 __boundingBoxSize;
        public Vector3 boundingBoxSize
        {
            get
            {
                if (__boundingBoxSize == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "boundingBoxSize", value);
            }
        }

        private InternalTexture __depthStencilTexture;
        public InternalTexture depthStencilTexture
        {
            get
            {
                if (__depthStencilTexture == null)
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
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
            }
        }

        public decimal refreshRate
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "refreshRate"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "refreshRate", value);
            }
        }

        public bool canRescale
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRescale"); }
        }
        #endregion

        #region Properties

        public bool renderParticles
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderParticles"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderParticles", value);
            }
        }

        public bool renderSprites
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderSprites"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderSprites", value);
            }
        }

        public bool forceLayerMaskCheck
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "forceLayerMaskCheck"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "forceLayerMaskCheck", value);
            }
        }

        private Camera __activeCamera;
        public Camera activeCamera
        {
            get
            {
                if (__activeCamera == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "activeCamera", value);
            }
        }

        public bool useCameraPostProcesses
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useCameraPostProcesses");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useCameraPostProcesses", value);
            }
        }

        public bool ignoreCameraViewport
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ignoreCameraViewport");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ignoreCameraViewport", value);
            }
        }

        private Observable<RenderTargetTexture> __onBeforeBindObservable;
        public Observable<RenderTargetTexture> onBeforeBindObservable
        {
            get
            {
                if (__onBeforeBindObservable == null)
                {
                    __onBeforeBindObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<RenderTargetTexture>
                    >(
                        this.___guid,
                        "onBeforeBindObservable",
                        (entity) =>
                        {
                            return new Observable<RenderTargetTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onBeforeBindObservable;
            }
            set
            {
                __onBeforeBindObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeforeBindObservable", value);
            }
        }

        private Observable<RenderTargetTexture> __onAfterUnbindObservable;
        public Observable<RenderTargetTexture> onAfterUnbindObservable
        {
            get
            {
                if (__onAfterUnbindObservable == null)
                {
                    __onAfterUnbindObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<RenderTargetTexture>
                    >(
                        this.___guid,
                        "onAfterUnbindObservable",
                        (entity) =>
                        {
                            return new Observable<RenderTargetTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onAfterUnbindObservable;
            }
            set
            {
                __onAfterUnbindObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onAfterUnbindObservable", value);
            }
        }

        // onBeforeRenderObservable is not supported by the platform yet

        // onAfterRenderObservable is not supported by the platform yet

        private Observable<AbstractEngine> __onClearObservable;
        public Observable<AbstractEngine> onClearObservable
        {
            get
            {
                if (__onClearObservable == null)
                {
                    __onClearObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onClearObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onClearObservable", value);
            }
        }

        private Observable<RenderTargetTexture> __onResizeObservable;
        public Observable<RenderTargetTexture> onResizeObservable
        {
            get
            {
                if (__onResizeObservable == null)
                {
                    __onResizeObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<RenderTargetTexture>
                    >(
                        this.___guid,
                        "onResizeObservable",
                        (entity) =>
                        {
                            return new Observable<RenderTargetTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onResizeObservable;
            }
            set
            {
                __onResizeObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onResizeObservable", value);
            }
        }

        private Color4 __clearColor;
        public Color4 clearColor
        {
            get
            {
                if (__clearColor == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "clearColor", value);
            }
        }

        public bool skipInitialClear
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "skipInitialClear"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "skipInitialClear", value);
            }
        }

        public decimal renderPassId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderPassId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderPassId", value);
            }
        }

        private Vector3 __boundingBoxPosition;
        public Vector3 boundingBoxPosition
        {
            get
            {
                if (__boundingBoxPosition == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "boundingBoxPosition", value);
            }
        }
        #endregion

        #region Constructor
        public RenderTargetTexture()
            : base() { }

        public RenderTargetTexture(ICachedEntity entity)
            : base(entity) { }

        public RenderTargetTexture(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                name,
                size,
                scene,
                options
            );
            ___guid = entity.___guid;
        }

        public RenderTargetTexture(
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
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
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
            ___guid = entity.___guid;
        }

        public RenderTargetTexture(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public RenderTargetTexture(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetTexture" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool renderListPredicate(AbstractMesh AbstractMesh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "renderListPredicate" }, AbstractMesh }
            );
        }

        public AbstractMesh[] getCustomRenderList(
            decimal layerOrFace,
            Immutable<T> renderList,
            decimal renderListLength
        )
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
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

        public bool customIsReadyFunction(
            AbstractMesh mesh,
            decimal refreshRate,
            System.Nullable<bool> preWarm = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "customIsReadyFunction" },
                    mesh,
                    refreshRate,
                    preWarm
                }
            );
        }

        public void customRenderFunction(
            SmartArray<SubMesh> opaqueSubMeshes,
            SmartArray<SubMesh> alphaTestSubMeshes,
            SmartArray<SubMesh> transparentSubMeshes,
            SmartArray<SubMesh> depthOnlySubMeshes,
            ActionCallback beforeTransparents = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setMaterialForRendering(AbstractMesh mesh, Material material = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMaterialForRendering" },
                    mesh,
                    material
                }
            );
        }

        public void createDepthStencilTexture(
            System.Nullable<decimal> comparisonFunction = null,
            System.Nullable<bool> bilinearFiltering = null,
            System.Nullable<bool> generateStencil = null,
            System.Nullable<decimal> samples = null,
            System.Nullable<decimal> format = null,
            string label = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void resetRefreshCounter()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetRefreshCounter" } }
            );
        }

        public void addPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addPostProcess" }, postProcess }
            );
        }

        public void clearPostProcesses(System.Nullable<bool> dispose = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearPostProcesses" }, dispose }
            );
        }

        public void removePostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removePostProcess" }, postProcess }
            );
        }

        public decimal getRenderSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderSize" } }
            );
        }

        public decimal getRenderWidth()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderWidth" } }
            );
        }

        public decimal getRenderHeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderHeight" } }
            );
        }

        public decimal getRenderLayers()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderLayers" } }
            );
        }

        public void disableRescaling()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disableRescaling" } }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public Matrix getReflectionTextureMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getReflectionTextureMatrix" } }
            );
        }

        public void resize(decimal size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, size }
            );
        }

        public void render(
            System.Nullable<bool> useCameraPostProcess = null,
            System.Nullable<bool> dumpForDebug = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" },
                    useCameraPostProcess,
                    dumpForDebug
                }
            );
        }

        public bool isReadyForRendering()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForRendering" } }
            );
        }

        public void setRenderingOrder(
            decimal renderingGroupId,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setRenderingAutoClearDepthStencil(
            decimal renderingGroupId,
            bool autoClearDepthStencil
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" },
                    renderingGroupId,
                    autoClearDepthStencil
                }
            );
        }

        public RenderTargetTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public void disposeFramebufferObjects()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeFramebufferObjects" } }
            );
        }

        public void releaseInternalTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseInternalTexture" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "freeRenderingGroups" } }
            );
        }

        public decimal getViewCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getViewCount" } }
            );
        }
        #endregion
    }
}
