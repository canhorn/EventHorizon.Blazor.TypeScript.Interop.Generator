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

    [JsonConverter(typeof(CachedEntityConverter<AbstractEngine>))]
    public class AbstractEngine : CachedEntityObject
    {
        #region Static Accessors

        public static async ValueTask<string> get_NpmPackage()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "AbstractEngine.NpmPackage"
            );
        }

        public static async ValueTask<string> get_Version()
        {
            return await EventHorizonBlazorInterop.Get<string>("BABYLON", "AbstractEngine.Version");
        }
        #endregion

        #region Static Properties
        private static IAudioEngineCachedEntity __audioEngine;

        public static async ValueTask<IAudioEngineCachedEntity> get_audioEngine()
        {
            if (__audioEngine == null)
            {
                __audioEngine = await EventHorizonBlazorInterop.GetClass<IAudioEngineCachedEntity>(
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

        public static ValueTask set_audioEngine(IAudioEngineCachedEntity value)
        {
            __audioEngine = null;
            return EventHorizonBlazorInterop.Set("BABYLON", "AbstractEngine.audioEngine", value);
        }
        #endregion

        #region Static Methods
        public static async ValueTask<ILoadingScreenCachedEntity> DefaultLoadingScreenFactory(
            HTMLCanvasElement canvas
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ILoadingScreenCachedEntity>(
                entity => new ILoadingScreenCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AbstractEngine", "DefaultLoadingScreenFactory" },
                    canvas
                }
            );
        }

        public static async ValueTask<IAudioEngineCachedEntity> AudioEngineFactory(
            CachedEntity hostElement,
            AudioContext audioContext,
            AudioDestinationNode audioDestination
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IAudioEngineCachedEntity>(
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

        public static async ValueTask<IOfflineProviderCachedEntity> OfflineProviderFactory(
            string urlToScene,
            ActionResultCallback<bool, CachedEntity> callbackManifestChecked,
            bool disableManifestCheck
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IOfflineProviderCachedEntity>(
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

        public async ValueTask<decimal> get_frameId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "frameId");
        }

        public async ValueTask<bool> get_isWebGPU()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isWebGPU");
        }

        public async ValueTask<string> get_shaderPlatformName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "shaderPlatformName");
        }

        public async ValueTask<bool> get_useReverseDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useReverseDepthBuffer");
        }

        public ValueTask set_useReverseDepthBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useReverseDepthBuffer", value);
        }

        private DepthCullingState __depthCullingState;

        public async ValueTask<DepthCullingState> get_depthCullingState()
        {
            if (__depthCullingState == null)
            {
                __depthCullingState = await EventHorizonBlazorInterop.GetClass<DepthCullingState>(
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

        private AlphaState __alphaState;

        public async ValueTask<AlphaState> get_alphaState()
        {
            if (__alphaState == null)
            {
                __alphaState = await EventHorizonBlazorInterop.GetClass<AlphaState>(
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

        private StencilState __stencilState;

        public async ValueTask<StencilState> get_stencilState()
        {
            if (__stencilState == null)
            {
                __stencilState = await EventHorizonBlazorInterop.GetClass<StencilState>(
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

        private StencilStateComposer __stencilStateComposer;

        public async ValueTask<StencilStateComposer> get_stencilStateComposer()
        {
            if (__stencilStateComposer == null)
            {
                __stencilStateComposer =
                    await EventHorizonBlazorInterop.GetClass<StencilStateComposer>(
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

        public async ValueTask<bool> get_isDisposed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed");
        }

        public async ValueTask<bool> get_snapshotRendering()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "snapshotRendering");
        }

        public ValueTask set_snapshotRendering(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "snapshotRendering", value);
        }

        public async ValueTask<decimal> get_snapshotRenderingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "snapshotRenderingMode"
            );
        }

        public ValueTask set_snapshotRenderingMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "snapshotRenderingMode", value);
        }

        private InternalTexture __emptyTexture;

        public async ValueTask<InternalTexture> get_emptyTexture()
        {
            if (__emptyTexture == null)
            {
                __emptyTexture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
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

        private InternalTexture __emptyTexture3D;

        public async ValueTask<InternalTexture> get_emptyTexture3D()
        {
            if (__emptyTexture3D == null)
            {
                __emptyTexture3D = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
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

        private InternalTexture __emptyTexture2DArray;

        public async ValueTask<InternalTexture> get_emptyTexture2DArray()
        {
            if (__emptyTexture2DArray == null)
            {
                __emptyTexture2DArray = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
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

        private InternalTexture __emptyCubeTexture;

        public async ValueTask<InternalTexture> get_emptyCubeTexture()
        {
            if (__emptyCubeTexture == null)
            {
                __emptyCubeTexture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
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

        public async ValueTask<ActionCallback[]> get_activeRenderLoops()
        {
            return await EventHorizonBlazorInterop.GetArray<ActionCallback>(
                this.___guid,
                "activeRenderLoops"
            );
        }

        private PerformanceMonitor __performanceMonitor;

        public async ValueTask<PerformanceMonitor> get_performanceMonitor()
        {
            if (__performanceMonitor == null)
            {
                __performanceMonitor = await EventHorizonBlazorInterop.GetClass<PerformanceMonitor>(
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

        public async ValueTask<bool> get_compatibilityMode()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "compatibilityMode");
        }

        public ValueTask set_compatibilityMode(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "compatibilityMode", value);
        }

        public async ValueTask<bool> get_needPOTTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "needPOTTextures");
        }

        private IViewportLikeCachedEntity __currentViewport;

        public async ValueTask<IViewportLikeCachedEntity> get_currentViewport()
        {
            if (__currentViewport == null)
            {
                __currentViewport =
                    await EventHorizonBlazorInterop.GetClass<IViewportLikeCachedEntity>(
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

        public async ValueTask<string> get_description()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "description");
        }

        public async ValueTask<bool> get_supportsUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "supportsUniformBuffers"
            );
        }

        public async ValueTask<decimal> get_version()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "version");
        }

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<bool> get_doNotHandleContextLost()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "doNotHandleContextLost"
            );
        }

        public ValueTask set_doNotHandleContextLost(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleContextLost", value);
        }

        public async ValueTask<bool> get_isStencilEnable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStencilEnable");
        }
        #endregion

        #region Properties
        private Observable<AbstractEngine> __onCanvasBlurObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onCanvasBlurObservable()
        {
            if (__onCanvasBlurObservable == null)
            {
                __onCanvasBlurObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onCanvasBlurObservable(Observable<AbstractEngine> value)
        {
            __onCanvasBlurObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onCanvasBlurObservable", value);
        }

        private Observable<AbstractEngine> __onCanvasFocusObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onCanvasFocusObservable()
        {
            if (__onCanvasFocusObservable == null)
            {
                __onCanvasFocusObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onCanvasFocusObservable(Observable<AbstractEngine> value)
        {
            __onCanvasFocusObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onCanvasFocusObservable", value);
        }

        private Observable<Scene> __onNewSceneAddedObservable;

        public async ValueTask<Observable<Scene>> get_onNewSceneAddedObservable()
        {
            if (__onNewSceneAddedObservable == null)
            {
                __onNewSceneAddedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onNewSceneAddedObservable(Observable<Scene> value)
        {
            __onNewSceneAddedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onNewSceneAddedObservable", value);
        }

        private Observable<AbstractEngine> __onResizeObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onResizeObservable()
        {
            if (__onResizeObservable == null)
            {
                __onResizeObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onResizeObservable(Observable<AbstractEngine> value)
        {
            __onResizeObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onResizeObservable", value);
        }

        private Observable<PointerEvent> __onCanvasPointerOutObservable;

        public async ValueTask<Observable<PointerEvent>> get_onCanvasPointerOutObservable()
        {
            if (__onCanvasPointerOutObservable == null)
            {
                __onCanvasPointerOutObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onCanvasPointerOutObservable(Observable<PointerEvent> value)
        {
            __onCanvasPointerOutObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onCanvasPointerOutObservable",
                value
            );
        }

        public async ValueTask<bool> get_disablePerformanceMonitorInBackground()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "disablePerformanceMonitorInBackground"
            );
        }

        public ValueTask set_disablePerformanceMonitorInBackground(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "disablePerformanceMonitorInBackground",
                value
            );
        }

        public async ValueTask<bool> get_disableVertexArrayObjects()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "disableVertexArrayObjects"
            );
        }

        public ValueTask set_disableVertexArrayObjects(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableVertexArrayObjects", value);
        }

        private HostInformationCachedEntity __hostInformation;

        public async ValueTask<HostInformationCachedEntity> get_hostInformation()
        {
            if (__hostInformation == null)
            {
                __hostInformation =
                    await EventHorizonBlazorInterop.GetClass<HostInformationCachedEntity>(
                        this.___guid,
                        "hostInformation",
                        (entity) =>
                        {
                            return new HostInformationCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __hostInformation;
        }

        public ValueTask set_hostInformation(HostInformationCachedEntity value)
        {
            __hostInformation = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "hostInformation", value);
        }

        public async ValueTask<bool> get_isFullscreen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFullscreen");
        }

        public ValueTask set_isFullscreen(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isFullscreen", value);
        }

        public async ValueTask<bool> get_enableOfflineSupport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableOfflineSupport");
        }

        public ValueTask set_enableOfflineSupport(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enableOfflineSupport", value);
        }

        public async ValueTask<bool> get_disableManifestCheck()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableManifestCheck");
        }

        public ValueTask set_disableManifestCheck(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableManifestCheck", value);
        }

        public async ValueTask<bool> get_disableContextMenu()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableContextMenu");
        }

        public ValueTask set_disableContextMenu(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableContextMenu", value);
        }

        public async ValueTask<decimal> get_currentRenderPassId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "currentRenderPassId"
            );
        }

        public ValueTask set_currentRenderPassId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "currentRenderPassId", value);
        }

        public async ValueTask<bool> get_isPointerLock()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPointerLock");
        }

        public ValueTask set_isPointerLock(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isPointerLock", value);
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

        public ValueTask set_postProcesses(PostProcess[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "postProcesses", value);
        }

        public async ValueTask<decimal> get_canvasTabIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "canvasTabIndex");
        }

        public ValueTask set_canvasTabIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "canvasTabIndex", value);
        }

        public async ValueTask<bool> get_isNDCHalfZRange()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNDCHalfZRange");
        }

        public async ValueTask<bool> get_hasOriginBottomLeft()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasOriginBottomLeft");
        }

        public async ValueTask<bool> get_useExactSrgbConversions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useExactSrgbConversions"
            );
        }

        public async ValueTask<Scene[]> get_scenes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Scene>(
                this.___guid,
                "scenes",
                (entity) =>
                {
                    return new Scene() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_scenes(Scene[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "scenes", value);
        }

        private Observable<Texture> __onBeforeTextureInitObservable;

        public async ValueTask<Observable<Texture>> get_onBeforeTextureInitObservable()
        {
            if (__onBeforeTextureInitObservable == null)
            {
                __onBeforeTextureInitObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeforeTextureInitObservable(Observable<Texture> value)
        {
            __onBeforeTextureInitObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onBeforeTextureInitObservable",
                value
            );
        }

        public async ValueTask<bool> get_renderEvenInBackground()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "renderEvenInBackground"
            );
        }

        public ValueTask set_renderEvenInBackground(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderEvenInBackground", value);
        }

        public async ValueTask<bool> get_preventCacheWipeBetweenFrames()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "preventCacheWipeBetweenFrames"
            );
        }

        public ValueTask set_preventCacheWipeBetweenFrames(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "preventCacheWipeBetweenFrames",
                value
            );
        }

        private Observable<AbstractEngine> __onBeforeShaderCompilationObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onBeforeShaderCompilationObservable()
        {
            if (__onBeforeShaderCompilationObservable == null)
            {
                __onBeforeShaderCompilationObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeforeShaderCompilationObservable(Observable<AbstractEngine> value)
        {
            __onBeforeShaderCompilationObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onBeforeShaderCompilationObservable",
                value
            );
        }

        private Observable<AbstractEngine> __onAfterShaderCompilationObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onAfterShaderCompilationObservable()
        {
            if (__onAfterShaderCompilationObservable == null)
            {
                __onAfterShaderCompilationObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAfterShaderCompilationObservable(Observable<AbstractEngine> value)
        {
            __onAfterShaderCompilationObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAfterShaderCompilationObservable",
                value
            );
        }

        private Observable<AbstractEngine> __onBeginFrameObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onBeginFrameObservable()
        {
            if (__onBeginFrameObservable == null)
            {
                __onBeginFrameObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeginFrameObservable(Observable<AbstractEngine> value)
        {
            __onBeginFrameObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeginFrameObservable", value);
        }

        private Observable<AbstractEngine> __onEndFrameObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onEndFrameObservable()
        {
            if (__onEndFrameObservable == null)
            {
                __onEndFrameObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onEndFrameObservable(Observable<AbstractEngine> value)
        {
            __onEndFrameObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onEndFrameObservable", value);
        }

        private Observable<AbstractEngine> __onContextLostObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onContextLostObservable()
        {
            if (__onContextLostObservable == null)
            {
                __onContextLostObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onContextLostObservable(Observable<AbstractEngine> value)
        {
            __onContextLostObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onContextLostObservable", value);
        }

        private Observable<AbstractEngine> __onContextRestoredObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onContextRestoredObservable()
        {
            if (__onContextRestoredObservable == null)
            {
                __onContextRestoredObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onContextRestoredObservable(Observable<AbstractEngine> value)
        {
            __onContextRestoredObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onContextRestoredObservable",
                value
            );
        }

        public async ValueTask<decimal> get_startTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "startTime");
        }

        public async ValueTask<bool> get_premultipliedAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "premultipliedAlpha");
        }

        public ValueTask set_premultipliedAlpha(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "premultipliedAlpha", value);
        }

        public async ValueTask<bool> get_adaptToDeviceRatio()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptToDeviceRatio");
        }

        public ValueTask set_adaptToDeviceRatio(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "adaptToDeviceRatio", value);
        }

        public async ValueTask<bool> get_cullBackFaces()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "cullBackFaces");
        }

        public ValueTask set_cullBackFaces(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "cullBackFaces", value);
        }

        private Observable<AbstractEngine> __onDisposeObservable;

        public async ValueTask<Observable<AbstractEngine>> get_onDisposeObservable()
        {
            if (__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<
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
        #endregion

        #region Constructor
        public AbstractEngine()
            : base() { }

        public AbstractEngine(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<AbstractEngine> NewAbstractEngine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AbstractEngine" },
                antialias,
                options,
                adaptToDeviceRatio
            );

            return new AbstractEngine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> areAllEffectsReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "areAllEffectsReady" } }
            );
        }

        public async ValueTask setTexture(
            decimal channel,
            WebGLUniformLocation unused,
            ThinTexture texture,
            string name
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask bindSamplers(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindSamplers" }, effect }
            );
        }

        public async ValueTask wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wipeCaches" }, bruteForce }
            );
        }

        public async ValueTask setColorWrite(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColorWrite" }, enable }
            );
        }

        public async ValueTask<bool> getColorWrite()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getColorWrite" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask stopRenderLoop(ActionCallback renderFunction = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stopRenderLoop" }, renderFunction }
            );
        }

        public async ValueTask beginFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginFrame" } }
            );
        }

        public async ValueTask endFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "endFrame" } }
            );
        }

        public async ValueTask runRenderLoop(ActionCallback renderFunction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "runRenderLoop" }, renderFunction }
            );
        }

        public async ValueTask<bool> getDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getDepthBuffer" } }
            );
        }

        public async ValueTask setDepthBuffer(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDepthBuffer" }, enable }
            );
        }

        public async ValueTask setZOffset(decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setZOffset" }, value }
            );
        }

        public async ValueTask<decimal> getZOffset()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getZOffset" } }
            );
        }

        public async ValueTask setZOffsetUnits(decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setZOffsetUnits" }, value }
            );
        }

        public async ValueTask<decimal> getZOffsetUnits()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getZOffsetUnits" } }
            );
        }

        public async ValueTask<WindowCachedEntity> getHostWindow()
        {
            return await EventHorizonBlazorInterop.FuncClass<WindowCachedEntity>(
                entity => new WindowCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getHostWindow" } }
            );
        }

        public async ValueTask<ArrayBufferView> readPixels(
            decimal x,
            decimal y,
            decimal width,
            decimal height,
            System.Nullable<bool> hasAlpha = null,
            System.Nullable<bool> flushRenderer = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<ArrayBufferView>(
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

        public async ValueTask flushFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "flushFramebuffer" } }
            );
        }

        public async ValueTask applyStates()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyStates" } }
            );
        }

        public async ValueTask bindFramebuffer(
            RenderTargetWrapper texture,
            System.Nullable<decimal> faceIndex = null,
            System.Nullable<decimal> requiredWidth = null,
            System.Nullable<decimal> requiredHeight = null,
            System.Nullable<bool> forceFullscreenViewport = null,
            System.Nullable<decimal> lodLevel = null,
            System.Nullable<decimal> layer = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask updateTextureWrappingMode(
            InternalTexture texture,
            System.Nullable<decimal> wrapU = null,
            System.Nullable<decimal> wrapV = null,
            System.Nullable<decimal> wrapR = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask restoreDefaultFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDefaultFramebuffer" } }
            );
        }

        public async ValueTask drawElementsType(
            decimal fillMode,
            decimal indexStart,
            decimal indexCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask unBindFramebuffer(
            RenderTargetWrapper texture,
            System.Nullable<bool> disableGenerateMipMaps = null,
            ActionCallback onBeforeUnbind = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unBindFramebuffer" },
                    texture,
                    disableGenerateMipMaps,
                    onBeforeUnbind
                }
            );
        }

        public async ValueTask<string> extractDriverInfo()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "extractDriverInfo" } }
            );
        }

        public async ValueTask bindBuffers(
            object vertexBuffers,
            DataBuffer indexBuffer,
            Effect effect,
            object overrideVertexBuffers = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask enableEffect(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableEffect" }, effect }
            );
        }

        public async ValueTask setState(
            bool culling,
            System.Nullable<decimal> zOffset = null,
            System.Nullable<bool> force = null,
            System.Nullable<bool> reverseSide = null,
            System.Nullable<bool> cullBackFaces = null,
            IStencilState stencil = null,
            System.Nullable<decimal> zOffsetUnits = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<IMaterialContextCachedEntity> createMaterialContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<IMaterialContextCachedEntity>(
                entity => new IMaterialContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createMaterialContext" } }
            );
        }

        public async ValueTask<IDrawContextCachedEntity> createDrawContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<IDrawContextCachedEntity>(
                entity => new IDrawContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createDrawContext" } }
            );
        }

        public async ValueTask<Effect> createEffect(
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
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
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

        public async ValueTask clear(
            IColor4Like color,
            bool backBuffer,
            bool depth,
            System.Nullable<bool> stencil = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<DataBuffer> createIndexBuffer(
            decimal[] indices,
            System.Nullable<bool> _updatable = null,
            string label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
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

        public async ValueTask drawArraysType(
            decimal fillMode,
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask releaseEffects()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseEffects" } }
            );
        }

        public async ValueTask setViewport(
            IViewportLike viewport,
            System.Nullable<decimal> requiredWidth = null,
            System.Nullable<decimal> requiredHeight = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" },
                    viewport,
                    requiredWidth,
                    requiredHeight
                }
            );
        }

        public async ValueTask updateTextureSamplingMode(
            decimal samplingMode,
            InternalTexture texture,
            System.Nullable<bool> generateMipMaps = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureSamplingMode" },
                    samplingMode,
                    texture,
                    generateMipMaps
                }
            );
        }

        public async ValueTask setTextureArray(
            decimal channel,
            WebGLUniformLocation uniform,
            ThinTexture[] textures,
            string name
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask unbindInstanceAttributes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindInstanceAttributes" } }
            );
        }

        public async ValueTask<IImageCachedEntity> createCanvasImage()
        {
            return await EventHorizonBlazorInterop.FuncClass<IImageCachedEntity>(
                entity => new IImageCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createCanvasImage" } }
            );
        }

        public async ValueTask<IPipelineContextCachedEntity> createPipelineContext(
            ShaderProcessingContext shaderProcessingContext
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPipelineContext" },
                    shaderProcessingContext
                }
            );
        }

        public async ValueTask<string> inlineShaderCode(string code)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "inlineShaderCode" }, code }
            );
        }

        public async ValueTask bindUniformBufferBase(
            DataBuffer buffer,
            decimal _location,
            string name
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBufferBase" },
                    buffer,
                    _location,
                    name
                }
            );
        }

        public async ValueTask bindUniformBlock(
            IPipelineContext pipelineContext,
            string blockName,
            decimal index
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBlock" },
                    pipelineContext,
                    blockName,
                    index
                }
            );
        }

        public async ValueTask<Document> getHostDocument()
        {
            return await EventHorizonBlazorInterop.FuncClass<Document>(
                entity => new Document() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getHostDocument" } }
            );
        }

        public async ValueTask<InternalTexture[]> getLoadedTexturesCache()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLoadedTexturesCache" } }
            );
        }

        public async ValueTask clearInternalTexturesCache()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearInternalTexturesCache" } }
            );
        }

        public async ValueTask<EngineCapabilitiesCachedEntity> getCaps()
        {
            return await EventHorizonBlazorInterop.FuncClass<EngineCapabilitiesCachedEntity>(
                entity => new EngineCapabilitiesCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCaps" } }
            );
        }

        public async ValueTask resetTextureCache()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetTextureCache" } }
            );
        }

        public async ValueTask<HTMLCanvasElementCachedEntity> getRenderingCanvas()
        {
            return await EventHorizonBlazorInterop.FuncClass<HTMLCanvasElementCachedEntity>(
                entity => new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderingCanvas" } }
            );
        }

        public async ValueTask<AudioContext> getAudioContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<AudioContext>(
                entity => new AudioContext() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAudioContext" } }
            );
        }

        public async ValueTask<AudioDestinationNode> getAudioDestination()
        {
            return await EventHorizonBlazorInterop.FuncClass<AudioDestinationNode>(
                entity => new AudioDestinationNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAudioDestination" } }
            );
        }

        public async ValueTask setHardwareScalingLevel(decimal level)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHardwareScalingLevel" }, level }
            );
        }

        public async ValueTask<decimal> getHardwareScalingLevel()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHardwareScalingLevel" } }
            );
        }

        public async ValueTask<AbstractEngineOptionsCachedEntity> getCreationOptions()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractEngineOptionsCachedEntity>(
                entity => new AbstractEngineOptionsCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCreationOptions" } }
            );
        }

        public async ValueTask resize(System.Nullable<bool> forceSetSize = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, forceSetSize }
            );
        }

        public async ValueTask<bool> setSize(
            decimal width,
            decimal height,
            System.Nullable<bool> forceSetSize = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" },
                    width,
                    height,
                    forceSetSize
                }
            );
        }

        public async ValueTask<DataBuffer> createDynamicUniformBuffer(
            decimal[] elements,
            string label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDynamicUniformBuffer" },
                    elements,
                    label
                }
            );
        }

        public async ValueTask<DataBuffer> createUniformBuffer(
            decimal[] elements,
            string label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createUniformBuffer" },
                    elements,
                    label
                }
            );
        }

        public async ValueTask updateUniformBuffer(
            DataBuffer uniformBuffer,
            decimal[] elements,
            System.Nullable<decimal> offset = null,
            System.Nullable<decimal> count = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<DataBuffer> createDynamicVertexBuffer(
            decimal[] data,
            string _label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDynamicVertexBuffer" },
                    data,
                    _label
                }
            );
        }

        public async ValueTask<DataBuffer> createVertexBuffer(
            decimal[] data,
            System.Nullable<bool> _updatable = null,
            string _label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
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

        public async ValueTask updateTextureDimensions(
            InternalTexture texture,
            decimal width,
            decimal height,
            decimal depth
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<InternalTexture> createTexture(
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
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public async ValueTask<InternalTexture> createRawTexture(
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
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public async ValueTask<InternalTexture> createRawTexture3D(
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
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public async ValueTask<InternalTexture> createRawTexture2DArray(
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
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public async ValueTask<decimal> getRenderWidth(System.Nullable<bool> useScreen = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderWidth" }, useScreen }
            );
        }

        public async ValueTask<decimal> getRenderHeight(System.Nullable<bool> useScreen = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRenderHeight" }, useScreen }
            );
        }

        public async ValueTask<CachedEntity> createVideoElement(MediaTrackConstraints constraints)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "createVideoElement" }, constraints }
            );
        }

        public async ValueTask<decimal> getFps()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getFps" } }
            );
        }

        public async ValueTask<decimal> getDeltaTime()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDeltaTime" } }
            );
        }

        public async ValueTask<bool> isDeterministicLockStep()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDeterministicLockStep" } }
            );
        }

        public async ValueTask<decimal> getLockstepMaxSteps()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLockstepMaxSteps" } }
            );
        }

        public async ValueTask<decimal> getTimeStep()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTimeStep" } }
            );
        }

        public async ValueTask<ImageBitmap> createImageBitmap(
            ImageBitmapSource image,
            ImageBitmapOptions options = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<ImageBitmap>(
                entity => new ImageBitmap() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createImageBitmap" }, image, options }
            );
        }

        public async ValueTask<decimal[]> resizeImageBitmap(
            HTMLImageElement image,
            decimal bufferWidth,
            decimal bufferHeight
        )
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "resizeImageBitmap" },
                    image,
                    bufferWidth,
                    bufferHeight
                }
            );
        }

        public async ValueTask<decimal> getError()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getError" } }
            );
        }

        public async ValueTask<CachedEntity> getFontOffset(string font)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getFontOffset" }, font }
            );
        }

        public async ValueTask<ICanvasCachedEntity> createCanvas(decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.FuncClass<ICanvasCachedEntity>(
                entity => new ICanvasCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createCanvas" }, width, height }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
