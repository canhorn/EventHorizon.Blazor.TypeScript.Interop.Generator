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

    [JsonConverter(typeof(CachedEntityConverter<AbstractEngine>))]
    public class AbstractEngine : CachedEntityObject
    {
        #region Static Accessors

        public static string NpmPackage
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "AbstractEngine.NpmPackage"
                );
            }
        }

        public static string Version
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>("BABYLON", "AbstractEngine.Version");
            }
        }
        #endregion

        #region Static Properties
        private static IAudioEngineCachedEntity __audioEngine;
        public static IAudioEngineCachedEntity audioEngine
        {
            get
            {
                if (__audioEngine == null)
                {
                    __audioEngine = EventHorizonBlazorInterop.GetClass<IAudioEngineCachedEntity>(
                        "BABYLON",
                        "AbstractEngine.audioEngine",
                        (entity) =>
                        {
                            return new IAudioEngineCachedEntity() { ___guid = entity.___guid };
                        }
                    );
                }
                return __audioEngine;
            }
            set
            {
                __audioEngine = null;
                EventHorizonBlazorInterop.Set("BABYLON", "AbstractEngine.audioEngine", value);
            }
        }
        #endregion

        #region Static Methods
        public static ILoadingScreenCachedEntity DefaultLoadingScreenFactory(
            HTMLCanvasElement canvas
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ILoadingScreenCachedEntity>(
                entity => new ILoadingScreenCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AbstractEngine", "DefaultLoadingScreenFactory" },
                    canvas
                }
            );
        }

        public static IAudioEngineCachedEntity AudioEngineFactory(
            CachedEntity hostElement,
            AudioContext audioContext,
            AudioDestinationNode audioDestination
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IAudioEngineCachedEntity>(
                entity => new IAudioEngineCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AbstractEngine", "AudioEngineFactory" },
                    hostElement,
                    audioContext,
                    audioDestination
                }
            );
        }

        public static IOfflineProviderCachedEntity OfflineProviderFactory(
            string urlToScene,
            ActionResultCallback<bool, CachedEntity> callbackManifestChecked,
            bool disableManifestCheck
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IOfflineProviderCachedEntity>(
                entity => new IOfflineProviderCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AbstractEngine", "OfflineProviderFactory" },
                    urlToScene,
                    callbackManifestChecked,
                    disableManifestCheck
                }
            );
        }
        #endregion

        #region Accessors

        public decimal frameId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "frameId"); }
        }

        public bool isWebGPU
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isWebGPU"); }
        }

        public string shaderPlatformName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(this.___guid, "shaderPlatformName");
            }
        }

        public bool useReverseDepthBuffer
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useReverseDepthBuffer");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useReverseDepthBuffer", value);
            }
        }

        private DepthCullingState __depthCullingState;
        public DepthCullingState depthCullingState
        {
            get
            {
                if (__depthCullingState == null)
                {
                    __depthCullingState = EventHorizonBlazorInterop.GetClass<DepthCullingState>(
                        this.___guid,
                        "depthCullingState",
                        (entity) =>
                        {
                            return new DepthCullingState() { ___guid = entity.___guid };
                        }
                    );
                }
                return __depthCullingState;
            }
        }

        private AlphaState __alphaState;
        public AlphaState alphaState
        {
            get
            {
                if (__alphaState == null)
                {
                    __alphaState = EventHorizonBlazorInterop.GetClass<AlphaState>(
                        this.___guid,
                        "alphaState",
                        (entity) =>
                        {
                            return new AlphaState() { ___guid = entity.___guid };
                        }
                    );
                }
                return __alphaState;
            }
        }

        private StencilState __stencilState;
        public StencilState stencilState
        {
            get
            {
                if (__stencilState == null)
                {
                    __stencilState = EventHorizonBlazorInterop.GetClass<StencilState>(
                        this.___guid,
                        "stencilState",
                        (entity) =>
                        {
                            return new StencilState() { ___guid = entity.___guid };
                        }
                    );
                }
                return __stencilState;
            }
        }

        private StencilStateComposer __stencilStateComposer;
        public StencilStateComposer stencilStateComposer
        {
            get
            {
                if (__stencilStateComposer == null)
                {
                    __stencilStateComposer =
                        EventHorizonBlazorInterop.GetClass<StencilStateComposer>(
                            this.___guid,
                            "stencilStateComposer",
                            (entity) =>
                            {
                                return new StencilStateComposer() { ___guid = entity.___guid };
                            }
                        );
                }
                return __stencilStateComposer;
            }
        }

        public bool isDisposed
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed"); }
        }

        public bool snapshotRendering
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "snapshotRendering"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "snapshotRendering", value);
            }
        }

        public decimal snapshotRenderingMode
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "snapshotRenderingMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "snapshotRenderingMode", value);
            }
        }

        private InternalTexture __emptyTexture;
        public InternalTexture emptyTexture
        {
            get
            {
                if (__emptyTexture == null)
                {
                    __emptyTexture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
                        this.___guid,
                        "emptyTexture",
                        (entity) =>
                        {
                            return new InternalTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __emptyTexture;
            }
        }

        private InternalTexture __emptyTexture3D;
        public InternalTexture emptyTexture3D
        {
            get
            {
                if (__emptyTexture3D == null)
                {
                    __emptyTexture3D = EventHorizonBlazorInterop.GetClass<InternalTexture>(
                        this.___guid,
                        "emptyTexture3D",
                        (entity) =>
                        {
                            return new InternalTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __emptyTexture3D;
            }
        }

        private InternalTexture __emptyTexture2DArray;
        public InternalTexture emptyTexture2DArray
        {
            get
            {
                if (__emptyTexture2DArray == null)
                {
                    __emptyTexture2DArray = EventHorizonBlazorInterop.GetClass<InternalTexture>(
                        this.___guid,
                        "emptyTexture2DArray",
                        (entity) =>
                        {
                            return new InternalTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __emptyTexture2DArray;
            }
        }

        private InternalTexture __emptyCubeTexture;
        public InternalTexture emptyCubeTexture
        {
            get
            {
                if (__emptyCubeTexture == null)
                {
                    __emptyCubeTexture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
                        this.___guid,
                        "emptyCubeTexture",
                        (entity) =>
                        {
                            return new InternalTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __emptyCubeTexture;
            }
        }

        public ActionCallback[] activeRenderLoops
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<ActionCallback>(
                    this.___guid,
                    "activeRenderLoops"
                );
            }
        }

        private PerformanceMonitor __performanceMonitor;
        public PerformanceMonitor performanceMonitor
        {
            get
            {
                if (__performanceMonitor == null)
                {
                    __performanceMonitor = EventHorizonBlazorInterop.GetClass<PerformanceMonitor>(
                        this.___guid,
                        "performanceMonitor",
                        (entity) =>
                        {
                            return new PerformanceMonitor() { ___guid = entity.___guid };
                        }
                    );
                }
                return __performanceMonitor;
            }
        }

        public bool compatibilityMode
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "compatibilityMode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "compatibilityMode", value);
            }
        }

        public bool needPOTTextures
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "needPOTTextures"); }
        }

        private IViewportLikeCachedEntity __currentViewport;
        public IViewportLikeCachedEntity currentViewport
        {
            get
            {
                if (__currentViewport == null)
                {
                    __currentViewport =
                        EventHorizonBlazorInterop.GetClass<IViewportLikeCachedEntity>(
                            this.___guid,
                            "currentViewport",
                            (entity) =>
                            {
                                return new IViewportLikeCachedEntity() { ___guid = entity.___guid };
                            }
                        );
                }
                return __currentViewport;
            }
        }

        public string description
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "description"); }
        }

        public bool supportsUniformBuffers
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsUniformBuffers");
            }
        }

        public decimal version
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "version"); }
        }

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public bool doNotHandleContextLost
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotHandleContextLost");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleContextLost", value);
            }
        }

        public bool isStencilEnable
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStencilEnable"); }
        }
        #endregion

        #region Properties
        private Observable<AbstractEngine> __onCanvasBlurObservable;
        public Observable<AbstractEngine> onCanvasBlurObservable
        {
            get
            {
                if (__onCanvasBlurObservable == null)
                {
                    __onCanvasBlurObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onCanvasBlurObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onCanvasBlurObservable;
            }
            set
            {
                __onCanvasBlurObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCanvasBlurObservable", value);
            }
        }

        private Observable<AbstractEngine> __onCanvasFocusObservable;
        public Observable<AbstractEngine> onCanvasFocusObservable
        {
            get
            {
                if (__onCanvasFocusObservable == null)
                {
                    __onCanvasFocusObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onCanvasFocusObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onCanvasFocusObservable;
            }
            set
            {
                __onCanvasFocusObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCanvasFocusObservable", value);
            }
        }

        private Observable<Scene> __onNewSceneAddedObservable;
        public Observable<Scene> onNewSceneAddedObservable
        {
            get
            {
                if (__onNewSceneAddedObservable == null)
                {
                    __onNewSceneAddedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Scene>
                    >(
                        this.___guid,
                        "onNewSceneAddedObservable",
                        (entity) =>
                        {
                            return new Observable<Scene>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onNewSceneAddedObservable;
            }
            set
            {
                __onNewSceneAddedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onNewSceneAddedObservable", value);
            }
        }

        private Observable<AbstractEngine> __onResizeObservable;
        public Observable<AbstractEngine> onResizeObservable
        {
            get
            {
                if (__onResizeObservable == null)
                {
                    __onResizeObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onResizeObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
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

        private Observable<PointerEvent> __onCanvasPointerOutObservable;
        public Observable<PointerEvent> onCanvasPointerOutObservable
        {
            get
            {
                if (__onCanvasPointerOutObservable == null)
                {
                    __onCanvasPointerOutObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<PointerEvent>
                    >(
                        this.___guid,
                        "onCanvasPointerOutObservable",
                        (entity) =>
                        {
                            return new Observable<PointerEvent>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onCanvasPointerOutObservable;
            }
            set
            {
                __onCanvasPointerOutObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCanvasPointerOutObservable", value);
            }
        }

        public bool disablePerformanceMonitorInBackground
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disablePerformanceMonitorInBackground"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disablePerformanceMonitorInBackground",
                    value
                );
            }
        }

        public bool disableVertexArrayObjects
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableVertexArrayObjects"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableVertexArrayObjects", value);
            }
        }

        private HostInformationCachedEntity __hostInformation;
        public HostInformationCachedEntity hostInformation
        {
            get
            {
                if (__hostInformation == null)
                {
                    __hostInformation =
                        EventHorizonBlazorInterop.GetClass<HostInformationCachedEntity>(
                            this.___guid,
                            "hostInformation",
                            (entity) =>
                            {
                                return new HostInformationCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __hostInformation;
            }
            set
            {
                __hostInformation = null;
                EventHorizonBlazorInterop.Set(this.___guid, "hostInformation", value);
            }
        }

        public bool isFullscreen
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFullscreen"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isFullscreen", value);
            }
        }

        public bool enableOfflineSupport
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableOfflineSupport");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableOfflineSupport", value);
            }
        }

        public bool disableManifestCheck
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableManifestCheck");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableManifestCheck", value);
            }
        }

        public bool disableContextMenu
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableContextMenu"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableContextMenu", value);
            }
        }

        public decimal currentRenderPassId
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "currentRenderPassId");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "currentRenderPassId", value);
            }
        }

        public bool isPointerLock
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPointerLock"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isPointerLock", value);
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
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "postProcesses", value);
            }
        }

        public decimal canvasTabIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "canvasTabIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "canvasTabIndex", value);
            }
        }

        public bool isNDCHalfZRange
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNDCHalfZRange"); }
        }

        public bool hasOriginBottomLeft
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasOriginBottomLeft"); }
        }

        public bool useExactSrgbConversions
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useExactSrgbConversions");
            }
        }

        public Scene[] scenes
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Scene>(
                    this.___guid,
                    "scenes",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "scenes", value);
            }
        }

        private Observable<Texture> __onBeforeTextureInitObservable;
        public Observable<Texture> onBeforeTextureInitObservable
        {
            get
            {
                if (__onBeforeTextureInitObservable == null)
                {
                    __onBeforeTextureInitObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Texture>
                    >(
                        this.___guid,
                        "onBeforeTextureInitObservable",
                        (entity) =>
                        {
                            return new Observable<Texture>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBeforeTextureInitObservable;
            }
            set
            {
                __onBeforeTextureInitObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeforeTextureInitObservable", value);
            }
        }

        public bool renderEvenInBackground
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderEvenInBackground");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderEvenInBackground", value);
            }
        }

        public bool preventCacheWipeBetweenFrames
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventCacheWipeBetweenFrames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "preventCacheWipeBetweenFrames", value);
            }
        }

        private Observable<AbstractEngine> __onBeforeShaderCompilationObservable;
        public Observable<AbstractEngine> onBeforeShaderCompilationObservable
        {
            get
            {
                if (__onBeforeShaderCompilationObservable == null)
                {
                    __onBeforeShaderCompilationObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onBeforeShaderCompilationObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBeforeShaderCompilationObservable;
            }
            set
            {
                __onBeforeShaderCompilationObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShaderCompilationObservable",
                    value
                );
            }
        }

        private Observable<AbstractEngine> __onAfterShaderCompilationObservable;
        public Observable<AbstractEngine> onAfterShaderCompilationObservable
        {
            get
            {
                if (__onAfterShaderCompilationObservable == null)
                {
                    __onAfterShaderCompilationObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onAfterShaderCompilationObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onAfterShaderCompilationObservable;
            }
            set
            {
                __onAfterShaderCompilationObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShaderCompilationObservable",
                    value
                );
            }
        }

        private Observable<AbstractEngine> __onBeginFrameObservable;
        public Observable<AbstractEngine> onBeginFrameObservable
        {
            get
            {
                if (__onBeginFrameObservable == null)
                {
                    __onBeginFrameObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onBeginFrameObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBeginFrameObservable;
            }
            set
            {
                __onBeginFrameObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeginFrameObservable", value);
            }
        }

        private Observable<AbstractEngine> __onEndFrameObservable;
        public Observable<AbstractEngine> onEndFrameObservable
        {
            get
            {
                if (__onEndFrameObservable == null)
                {
                    __onEndFrameObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onEndFrameObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onEndFrameObservable;
            }
            set
            {
                __onEndFrameObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onEndFrameObservable", value);
            }
        }

        private Observable<AbstractEngine> __onContextLostObservable;
        public Observable<AbstractEngine> onContextLostObservable
        {
            get
            {
                if (__onContextLostObservable == null)
                {
                    __onContextLostObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onContextLostObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onContextLostObservable;
            }
            set
            {
                __onContextLostObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onContextLostObservable", value);
            }
        }

        private Observable<AbstractEngine> __onContextRestoredObservable;
        public Observable<AbstractEngine> onContextRestoredObservable
        {
            get
            {
                if (__onContextRestoredObservable == null)
                {
                    __onContextRestoredObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onContextRestoredObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onContextRestoredObservable;
            }
            set
            {
                __onContextRestoredObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onContextRestoredObservable", value);
            }
        }

        public decimal startTime
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "startTime"); }
        }

        public bool premultipliedAlpha
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "premultipliedAlpha"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "premultipliedAlpha", value);
            }
        }

        public bool adaptToDeviceRatio
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptToDeviceRatio"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "adaptToDeviceRatio", value);
            }
        }

        public bool cullBackFaces
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "cullBackFaces"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cullBackFaces", value);
            }
        }

        private Observable<AbstractEngine> __onDisposeObservable;
        public Observable<AbstractEngine> onDisposeObservable
        {
            get
            {
                if (__onDisposeObservable == null)
                {
                    __onDisposeObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AbstractEngine>
                    >(
                        this.___guid,
                        "onDisposeObservable",
                        (entity) =>
                        {
                            return new Observable<AbstractEngine>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onDisposeObservable;
            }
        }
        #endregion

        #region Constructor
        public AbstractEngine()
            : base() { }

        public AbstractEngine(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AbstractEngine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AbstractEngine" },
                antialias,
                options,
                adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool areAllEffectsReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "areAllEffectsReady" } }
            );
        }

        public void setTexture(
            decimal channel,
            WebGLUniformLocation unused,
            ThinTexture texture,
            string name
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" },
                    channel,
                    unused,
                    texture,
                    name
                }
            );
        }

        public void bindSamplers(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindSamplers" }, effect }
            );
        }

        public void wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wipeCaches" }, bruteForce }
            );
        }

        public void setColorWrite(bool enable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColorWrite" }, enable }
            );
        }

        public bool getColorWrite()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getColorWrite" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void stopRenderLoop(ActionCallback renderFunction = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stopRenderLoop" }, renderFunction }
            );
        }

        public void beginFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginFrame" } }
            );
        }

        public void endFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "endFrame" } }
            );
        }

        public void runRenderLoop(ActionCallback renderFunction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "runRenderLoop" }, renderFunction }
            );
        }

        public bool getDepthBuffer()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getDepthBuffer" } }
            );
        }

        public void setDepthBuffer(bool enable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDepthBuffer" }, enable }
            );
        }

        public void setZOffset(decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setZOffset" }, value }
            );
        }

        public decimal getZOffset()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getZOffset" } }
            );
        }

        public void setZOffsetUnits(decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setZOffsetUnits" }, value }
            );
        }

        public decimal getZOffsetUnits()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getZOffsetUnits" } }
            );
        }

        public WindowCachedEntity getHostWindow()
        {
            return EventHorizonBlazorInterop.FuncClass<WindowCachedEntity>(
                entity => new WindowCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getHostWindow" } }
            );
        }

        public ValueTask<ArrayBufferView> readPixels(
            decimal x,
            decimal y,
            decimal width,
            decimal height,
            System.Nullable<bool> hasAlpha = null,
            System.Nullable<bool> flushRenderer = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<ArrayBufferView>(
                entity => new ArrayBufferView() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "readPixels" },
                    x,
                    y,
                    width,
                    height,
                    hasAlpha,
                    flushRenderer
                }
            );
        }

        public void flushFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "flushFramebuffer" } }
            );
        }

        public void applyStates()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyStates" } }
            );
        }

        public void bindFramebuffer(
            RenderTargetWrapper texture,
            System.Nullable<decimal> faceIndex = null,
            System.Nullable<decimal> requiredWidth = null,
            System.Nullable<decimal> requiredHeight = null,
            System.Nullable<bool> forceFullscreenViewport = null,
            System.Nullable<decimal> lodLevel = null,
            System.Nullable<decimal> layer = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindFramebuffer" },
                    texture,
                    faceIndex,
                    requiredWidth,
                    requiredHeight,
                    forceFullscreenViewport,
                    lodLevel,
                    layer
                }
            );
        }

        public void updateTextureWrappingMode(
            InternalTexture texture,
            System.Nullable<decimal> wrapU = null,
            System.Nullable<decimal> wrapV = null,
            System.Nullable<decimal> wrapR = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureWrappingMode" },
                    texture,
                    wrapU,
                    wrapV,
                    wrapR
                }
            );
        }

        public void restoreDefaultFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDefaultFramebuffer" } }
            );
        }

        public void drawElementsType(
            decimal fillMode,
            decimal indexStart,
            decimal indexCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawElementsType" },
                    fillMode,
                    indexStart,
                    indexCount,
                    instancesCount
                }
            );
        }

        public void unBindFramebuffer(
            RenderTargetWrapper texture,
            System.Nullable<bool> disableGenerateMipMaps = null,
            ActionCallback onBeforeUnbind = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unBindFramebuffer" },
                    texture,
                    disableGenerateMipMaps,
                    onBeforeUnbind
                }
            );
        }

        public string extractDriverInfo()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "extractDriverInfo" } }
            );
        }

        public void bindBuffers(
            object vertexBuffers,
            DataBuffer indexBuffer,
            Effect effect,
            object overrideVertexBuffers = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBuffers" },
                    vertexBuffers,
                    indexBuffer,
                    effect,
                    overrideVertexBuffers
                }
            );
        }

        public void enableEffect(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableEffect" }, effect }
            );
        }

        public void setState(
            bool culling,
            System.Nullable<decimal> zOffset = null,
            System.Nullable<bool> force = null,
            System.Nullable<bool> reverseSide = null,
            System.Nullable<bool> cullBackFaces = null,
            IStencilState stencil = null,
            System.Nullable<decimal> zOffsetUnits = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setState" },
                    culling,
                    zOffset,
                    force,
                    reverseSide,
                    cullBackFaces,
                    stencil,
                    zOffsetUnits
                }
            );
        }

        public IMaterialContextCachedEntity createMaterialContext()
        {
            return EventHorizonBlazorInterop.FuncClass<IMaterialContextCachedEntity>(
                entity => new IMaterialContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createMaterialContext" } }
            );
        }

        public IDrawContextCachedEntity createDrawContext()
        {
            return EventHorizonBlazorInterop.FuncClass<IDrawContextCachedEntity>(
                entity => new IDrawContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createDrawContext" } }
            );
        }

        public Effect createEffect(
            string baseName,
            string[] attributesNamesOrOptions,
            string[] uniformsNamesOrEngine,
            string[] samplers = null,
            string defines = null,
            EffectFallbacks fallbacks = null,
            ActionCallback<Effect> onCompiled = null,
            ActionCallback<Effect, string> onError = null,
            object indexParameters = null,
            System.Nullable<int> shaderLanguage = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createEffect" },
                    baseName,
                    attributesNamesOrOptions,
                    uniformsNamesOrEngine,
                    samplers,
                    defines,
                    fallbacks,
                    onCompiled,
                    onError,
                    indexParameters,
                    shaderLanguage
                }
            );
        }

        public void clear(
            IColor4Like color,
            bool backBuffer,
            bool depth,
            System.Nullable<bool> stencil = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" },
                    color,
                    backBuffer,
                    depth,
                    stencil
                }
            );
        }

        public DataBuffer createIndexBuffer(
            decimal[] indices,
            System.Nullable<bool> _updatable = null,
            string label = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createIndexBuffer" },
                    indices,
                    _updatable,
                    label
                }
            );
        }

        public void drawArraysType(
            decimal fillMode,
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawArraysType" },
                    fillMode,
                    verticesStart,
                    verticesCount,
                    instancesCount
                }
            );
        }

        public void releaseEffects()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseEffects" } }
            );
        }

        public void setViewport(
            IViewportLike viewport,
            System.Nullable<decimal> requiredWidth = null,
            System.Nullable<decimal> requiredHeight = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" },
                    viewport,
                    requiredWidth,
                    requiredHeight
                }
            );
        }

        public void updateTextureSamplingMode(
            decimal samplingMode,
            InternalTexture texture,
            System.Nullable<bool> generateMipMaps = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureSamplingMode" },
                    samplingMode,
                    texture,
                    generateMipMaps
                }
            );
        }

        public void setTextureArray(
            decimal channel,
            WebGLUniformLocation uniform,
            ThinTexture[] textures,
            string name
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureArray" },
                    channel,
                    uniform,
                    textures,
                    name
                }
            );
        }

        public void unbindInstanceAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindInstanceAttributes" } }
            );
        }

        public IImageCachedEntity createCanvasImage()
        {
            return EventHorizonBlazorInterop.FuncClass<IImageCachedEntity>(
                entity => new IImageCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createCanvasImage" } }
            );
        }

        public IPipelineContextCachedEntity createPipelineContext(
            ShaderProcessingContext shaderProcessingContext
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPipelineContext" },
                    shaderProcessingContext
                }
            );
        }

        public string inlineShaderCode(string code)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "inlineShaderCode" }, code }
            );
        }

        public void bindUniformBufferBase(DataBuffer buffer, decimal _location, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBufferBase" },
                    buffer,
                    _location,
                    name
                }
            );
        }

        public void bindUniformBlock(
            IPipelineContext pipelineContext,
            string blockName,
            decimal index
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBlock" },
                    pipelineContext,
                    blockName,
                    index
                }
            );
        }

        public Document getHostDocument()
        {
            return EventHorizonBlazorInterop.FuncClass<Document>(
                entity => new Document() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getHostDocument" } }
            );
        }

        public InternalTexture[] getLoadedTexturesCache()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLoadedTexturesCache" } }
            );
        }

        public void clearInternalTexturesCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearInternalTexturesCache" } }
            );
        }

        public EngineCapabilitiesCachedEntity getCaps()
        {
            return EventHorizonBlazorInterop.FuncClass<EngineCapabilitiesCachedEntity>(
                entity => new EngineCapabilitiesCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCaps" } }
            );
        }

        public void resetTextureCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetTextureCache" } }
            );
        }

        public HTMLCanvasElementCachedEntity getRenderingCanvas()
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCanvasElementCachedEntity>(
                entity => new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderingCanvas" } }
            );
        }

        public AudioContext getAudioContext()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioContext>(
                entity => new AudioContext() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAudioContext" } }
            );
        }

        public AudioDestinationNode getAudioDestination()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioDestinationNode>(
                entity => new AudioDestinationNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAudioDestination" } }
            );
        }

        public void setHardwareScalingLevel(decimal level)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHardwareScalingLevel" }, level }
            );
        }

        public decimal getHardwareScalingLevel()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHardwareScalingLevel" } }
            );
        }

        public AbstractEngineOptionsCachedEntity getCreationOptions()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractEngineOptionsCachedEntity>(
                entity => new AbstractEngineOptionsCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCreationOptions" } }
            );
        }

        public void resize(System.Nullable<bool> forceSetSize = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, forceSetSize }
            );
        }

        public bool setSize(
            decimal width,
            decimal height,
            System.Nullable<bool> forceSetSize = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" },
                    width,
                    height,
                    forceSetSize
                }
            );
        }

        public DataBuffer createDynamicUniformBuffer(decimal[] elements, string label = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDynamicUniformBuffer" },
                    elements,
                    label
                }
            );
        }

        public DataBuffer createUniformBuffer(decimal[] elements, string label = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createUniformBuffer" },
                    elements,
                    label
                }
            );
        }

        public void updateUniformBuffer(
            DataBuffer uniformBuffer,
            decimal[] elements,
            System.Nullable<decimal> offset = null,
            System.Nullable<decimal> count = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformBuffer" },
                    uniformBuffer,
                    elements,
                    offset,
                    count
                }
            );
        }

        public DataBuffer createDynamicVertexBuffer(decimal[] data, string _label = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDynamicVertexBuffer" },
                    data,
                    _label
                }
            );
        }

        public DataBuffer createVertexBuffer(
            decimal[] data,
            System.Nullable<bool> _updatable = null,
            string _label = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createVertexBuffer" },
                    data,
                    _updatable,
                    _label
                }
            );
        }

        public void updateTextureDimensions(
            InternalTexture texture,
            decimal width,
            decimal height,
            decimal depth
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureDimensions" },
                    texture,
                    width,
                    height,
                    depth
                }
            );
        }

        public InternalTexture createTexture(
            bool noMipmap,
            bool invertY,
            ISceneLike scene,
            string url = null,
            System.Nullable<decimal> samplingMode = null,
            ActionCallback<InternalTexture> onLoad = null,
            ActionCallback<string, CachedEntity> onError = null,
            string buffer = null,
            InternalTexture fallback = null,
            System.Nullable<decimal> format = null,
            string forcedExtension = null,
            string mimeType = null,
            object loaderOptions = null,
            System.Nullable<decimal> creationFlags = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTexture" },
                    url,
                    noMipmap,
                    invertY,
                    scene,
                    samplingMode,
                    onLoad,
                    onError,
                    buffer,
                    fallback,
                    format,
                    forcedExtension,
                    mimeType,
                    loaderOptions,
                    creationFlags,
                    useSRGBBuffer
                }
            );
        }

        public InternalTexture createRawTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            decimal format,
            bool generateMipMaps,
            bool invertY,
            decimal samplingMode,
            string compression = null,
            System.Nullable<decimal> type = null,
            System.Nullable<decimal> creationFlags = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRawTexture" },
                    data,
                    width,
                    height,
                    format,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    compression,
                    type,
                    creationFlags,
                    useSRGBBuffer
                }
            );
        }

        public InternalTexture createRawTexture3D(
            ArrayBufferView data,
            decimal width,
            decimal height,
            decimal depth,
            decimal format,
            bool generateMipMaps,
            bool invertY,
            decimal samplingMode,
            string compression = null,
            System.Nullable<decimal> textureType = null,
            System.Nullable<decimal> creationFlags = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRawTexture3D" },
                    data,
                    width,
                    height,
                    depth,
                    format,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    compression,
                    textureType,
                    creationFlags
                }
            );
        }

        public InternalTexture createRawTexture2DArray(
            ArrayBufferView data,
            decimal width,
            decimal height,
            decimal depth,
            decimal format,
            bool generateMipMaps,
            bool invertY,
            decimal samplingMode,
            string compression = null,
            System.Nullable<decimal> textureType = null,
            System.Nullable<decimal> creationFlags = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRawTexture2DArray" },
                    data,
                    width,
                    height,
                    depth,
                    format,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    compression,
                    textureType,
                    creationFlags
                }
            );
        }

        public decimal getRenderWidth(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderWidth" }, useScreen }
            );
        }

        public decimal getRenderHeight(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderHeight" }, useScreen }
            );
        }

        public CachedEntity createVideoElement(MediaTrackConstraints constraints)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "createVideoElement" }, constraints }
            );
        }

        public decimal getFps()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getFps" } }
            );
        }

        public decimal getDeltaTime()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDeltaTime" } }
            );
        }

        public bool isDeterministicLockStep()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDeterministicLockStep" } }
            );
        }

        public decimal getLockstepMaxSteps()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLockstepMaxSteps" } }
            );
        }

        public decimal getTimeStep()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTimeStep" } }
            );
        }

        public ValueTask<ImageBitmap> createImageBitmap(
            ImageBitmapSource image,
            ImageBitmapOptions options = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<ImageBitmap>(
                entity => new ImageBitmap() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createImageBitmap" }, image, options }
            );
        }

        public decimal[] resizeImageBitmap(
            HTMLImageElement image,
            decimal bufferWidth,
            decimal bufferHeight
        )
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "resizeImageBitmap" },
                    image,
                    bufferWidth,
                    bufferHeight
                }
            );
        }

        public decimal getError()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getError" } }
            );
        }

        public CachedEntity getFontOffset(string font)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getFontOffset" }, font }
            );
        }

        public ICanvasCachedEntity createCanvas(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<ICanvasCachedEntity>(
                entity => new ICanvasCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createCanvas" }, width, height }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
