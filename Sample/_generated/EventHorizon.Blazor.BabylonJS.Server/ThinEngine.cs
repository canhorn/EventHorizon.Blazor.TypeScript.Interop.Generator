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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ThinEngine>))]
    public class ThinEngine : CachedEntityObject
    {
        #region Static Accessors
        
        public static async ValueTask<string> get_NpmPackage()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.NpmPackage"
                );
        }

        
        public static async ValueTask<string> get_Version()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.Version"
                );
        }

        
        public static async ValueTask<string> get_ShadersRepository()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.ShadersRepository"
                );
        }
        public static ValueTask set_ShadersRepository(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.ShadersRepository",
                    value
                );
        }

        
        public static async ValueTask<bool> get_IsSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "ThinEngine.IsSupported"
                );
        }

        
        public static async ValueTask<bool> get_HasMajorPerformanceCaveat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "ThinEngine.HasMajorPerformanceCaveat"
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<CachedEntity[]> get_ExceptionList()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    "BABYLON",
                    "ThinEngine.ExceptionList",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public static ValueTask set_ExceptionList(CachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.ExceptionList",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_CollisionsEpsilon()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ThinEngine.CollisionsEpsilon"
                );
        }
        public static ValueTask set_CollisionsEpsilon(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.CollisionsEpsilon",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<bool> isSupported()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "isSupported" }
                }
            );
        }

        public static async ValueTask<decimal> CeilingPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "CeilingPOT" }, x
                }
            );
        }

        public static async ValueTask<decimal> FloorPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "FloorPOT" }, x
                }
            );
        }

        public static async ValueTask<decimal> NearestPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "NearestPOT" }, x
                }
            );
        }

        public static async ValueTask<decimal> GetExponentOfTwo(decimal value, decimal max, System.Nullable<decimal> mode = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "GetExponentOfTwo" }, value, max, mode
                }
            );
        }

        public static async ValueTask<decimal> QueueNewFrame(ActionCallback func, object requester = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "QueueNewFrame" }, func, requester
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<string> get_description()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "description"
                );
        }

        
        public async ValueTask<bool> get_supportsUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "supportsUniformBuffers"
                );
        }

        
        public async ValueTask<bool> get_needPOTTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needPOTTextures"
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleContextLost",
                    value
                );
        }

        private IViewportLikeCachedEntity __currentViewport;
        public async ValueTask<IViewportLikeCachedEntity> get_currentViewport()
        {
            if(__currentViewport == null)
            {
                __currentViewport = await EventHorizonBlazorInterop.GetClass<IViewportLikeCachedEntity>(
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

        private InternalTexture __emptyTexture;
        public async ValueTask<InternalTexture> get_emptyTexture()
        {
            if(__emptyTexture == null)
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
            if(__emptyTexture3D == null)
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
            if(__emptyTexture2DArray == null)
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
            if(__emptyCubeTexture == null)
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

        
        public async ValueTask<decimal> get_webGLVersion()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "webGLVersion"
                );
        }

        
        public async ValueTask<bool> get_isStencilEnable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStencilEnable"
                );
        }

        private DepthCullingState __depthCullingState;
        public async ValueTask<DepthCullingState> get_depthCullingState()
        {
            if(__depthCullingState == null)
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
            if(__alphaState == null)
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
            if(__stencilState == null)
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
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_forcePOTTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forcePOTTextures"
                );
        }
        public ValueTask set_forcePOTTextures(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forcePOTTextures",
                    value
                );
        }

        
        public async ValueTask<bool> get_isFullscreen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFullscreen"
                );
        }
        public ValueTask set_isFullscreen(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isFullscreen",
                    value
                );
        }

        
        public async ValueTask<bool> get_cullBackFaces()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cullBackFaces"
                );
        }
        public ValueTask set_cullBackFaces(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullBackFaces",
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderEvenInBackground",
                    value
                );
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

        
        public async ValueTask<bool> get_validateShaderPrograms()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "validateShaderPrograms"
                );
        }
        public ValueTask set_validateShaderPrograms(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "validateShaderPrograms",
                    value
                );
        }

        
        public async ValueTask<bool> get_useReverseDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReverseDepthBuffer"
                );
        }
        public ValueTask set_useReverseDepthBuffer(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useReverseDepthBuffer",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableUniformBuffers"
                );
        }
        public ValueTask set_disableUniformBuffers(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableUniformBuffers",
                    value
                );
        }

        private Observable<ThinEngine> __onContextLostObservable;
        public async ValueTask<Observable<ThinEngine>> get_onContextLostObservable()
        {
            if(__onContextLostObservable == null)
            {
                __onContextLostObservable = await EventHorizonBlazorInterop.GetClass<Observable<ThinEngine>>(
                    this.___guid,
                    "onContextLostObservable",
                    (entity) =>
                    {
                        return new Observable<ThinEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onContextLostObservable;
        }
        public ValueTask set_onContextLostObservable(Observable<ThinEngine> value)
        {
__onContextLostObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onContextLostObservable",
                    value
                );
        }

        private Observable<ThinEngine> __onContextRestoredObservable;
        public async ValueTask<Observable<ThinEngine>> get_onContextRestoredObservable()
        {
            if(__onContextRestoredObservable == null)
            {
                __onContextRestoredObservable = await EventHorizonBlazorInterop.GetClass<Observable<ThinEngine>>(
                    this.___guid,
                    "onContextRestoredObservable",
                    (entity) =>
                    {
                        return new Observable<ThinEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onContextRestoredObservable;
        }
        public ValueTask set_onContextRestoredObservable(Observable<ThinEngine> value)
        {
__onContextRestoredObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onContextRestoredObservable",
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableVertexArrayObjects",
                    value
                );
        }

        private HostInformationCachedEntity __hostInformation;
        public async ValueTask<HostInformationCachedEntity> get_hostInformation()
        {
            if(__hostInformation == null)
            {
                __hostInformation = await EventHorizonBlazorInterop.GetClass<HostInformationCachedEntity>(
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
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hostInformation",
                    value
                );
        }

        
        public async ValueTask<bool> get_premultipliedAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
        }

        private Observable<Texture> __onBeforeTextureInitObservable;
        public async ValueTask<Observable<Texture>> get_onBeforeTextureInitObservable()
        {
            if(__onBeforeTextureInitObservable == null)
            {
                __onBeforeTextureInitObservable = await EventHorizonBlazorInterop.GetClass<Observable<Texture>>(
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

        
        public async ValueTask<bool> get_enableUnpackFlipYCached()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableUnpackFlipYCached"
                );
        }
        public ValueTask set_enableUnpackFlipYCached(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableUnpackFlipYCached",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ThinEngine() : base() { } 

        public ThinEngine(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<ThinEngine> NewThinEngine(
            HTMLCanvasElement canvasOrContext, System.Nullable<bool> antialias = null, EngineOptions options = null, System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );

            return new ThinEngine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> areAllEffectsReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "areAllEffectsReady" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask resetTextureCache()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetTextureCache" }
                }
            );
        }

        public async ValueTask<CachedEntity> getGlInfo()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getGlInfo" }
                }
            );
        }

        public async ValueTask setHardwareScalingLevel(decimal level)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setHardwareScalingLevel" }, level
                }
            );
        }

        public async ValueTask<decimal> getHardwareScalingLevel()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHardwareScalingLevel" }
                }
            );
        }

        public async ValueTask<InternalTexture[]> getLoadedTexturesCache()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLoadedTexturesCache" }
                }
            );
        }

        public async ValueTask<EngineCapabilitiesCachedEntity> getCaps()
        {
            return await EventHorizonBlazorInterop.FuncClass<EngineCapabilitiesCachedEntity>(
                entity => new EngineCapabilitiesCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCaps" }
                }
            );
        }

        public async ValueTask stopRenderLoop(ActionCallback renderFunction = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopRenderLoop" }, renderFunction
                }
            );
        }

        public async ValueTask<HTMLCanvasElementCachedEntity> getRenderingCanvas()
        {
            return await EventHorizonBlazorInterop.FuncClass<HTMLCanvasElementCachedEntity>(
                entity => new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingCanvas" }
                }
            );
        }

        public async ValueTask<WindowCachedEntity> getHostWindow()
        {
            return await EventHorizonBlazorInterop.FuncClass<WindowCachedEntity>(
                entity => new WindowCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getHostWindow" }
                }
            );
        }

        public async ValueTask<decimal> getRenderWidth(System.Nullable<bool> useScreen = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderWidth" }, useScreen
                }
            );
        }

        public async ValueTask<decimal> getRenderHeight(System.Nullable<bool> useScreen = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderHeight" }, useScreen
                }
            );
        }

        public async ValueTask runRenderLoop(ActionCallback renderFunction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "runRenderLoop" }, renderFunction
                }
            );
        }

        public async ValueTask clear(IColor4Like color, bool backBuffer, bool depth, System.Nullable<bool> stencil = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }, color, backBuffer, depth, stencil
                }
            );
        }

        public async ValueTask setViewport(IViewportLike viewport, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setViewport" }, viewport, requiredWidth, requiredHeight
                }
            );
        }

        public async ValueTask beginFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public async ValueTask endFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endFrame" }
                }
            );
        }

        public async ValueTask resize()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }

        public async ValueTask<bool> setSize(decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public async ValueTask bindFramebuffer(InternalTexture texture, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null, System.Nullable<bool> forceFullscreenViewport = null, System.Nullable<decimal> lodLevel = null, System.Nullable<decimal> layer = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindFramebuffer" }, texture, faceIndex, requiredWidth, requiredHeight, forceFullscreenViewport, lodLevel, layer
                }
            );
        }

        public async ValueTask unBindFramebuffer(InternalTexture texture, System.Nullable<bool> disableGenerateMipMaps = null, ActionCallback onBeforeUnbind = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unBindFramebuffer" }, texture, disableGenerateMipMaps, onBeforeUnbind
                }
            );
        }

        public async ValueTask flushFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "flushFramebuffer" }
                }
            );
        }

        public async ValueTask restoreDefaultFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreDefaultFramebuffer" }
                }
            );
        }

        public async ValueTask<DataBuffer> createVertexBuffer(decimal[] data)
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createVertexBuffer" }, data
                }
            );
        }

        public async ValueTask<DataBuffer> createDynamicVertexBuffer(decimal[] data)
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDynamicVertexBuffer" }, data
                }
            );
        }

        public async ValueTask<DataBuffer> createIndexBuffer(decimal[] indices, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createIndexBuffer" }, indices, updatable
                }
            );
        }

        public async ValueTask bindArrayBuffer(DataBuffer buffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindArrayBuffer" }, buffer
                }
            );
        }

        public async ValueTask updateArrayBuffer(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateArrayBuffer" }, data
                }
            );
        }

        public async ValueTask<WebGLVertexArrayObjectCachedEntity> recordVertexArrayObject(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLVertexArrayObjectCachedEntity>(
                entity => new WebGLVertexArrayObjectCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "recordVertexArrayObject" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public async ValueTask bindVertexArrayObject(WebGLVertexArrayObject vertexArrayObject, DataBuffer indexBuffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindVertexArrayObject" }, vertexArrayObject, indexBuffer
                }
            );
        }

        public async ValueTask bindBuffersDirectly(DataBuffer vertexBuffer, DataBuffer indexBuffer, decimal[] vertexDeclaration, decimal vertexStrideSize, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindBuffersDirectly" }, vertexBuffer, indexBuffer, vertexDeclaration, vertexStrideSize, effect
                }
            );
        }

        public async ValueTask bindBuffers(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindBuffers" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public async ValueTask unbindInstanceAttributes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindInstanceAttributes" }
                }
            );
        }

        public async ValueTask releaseVertexArrayObject(WebGLVertexArrayObject vao)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseVertexArrayObject" }, vao
                }
            );
        }

        public async ValueTask updateAndBindInstancesBuffer(DataBuffer instancesBuffer, decimal[] data, decimal[] offsetLocations)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateAndBindInstancesBuffer" }, instancesBuffer, data, offsetLocations
                }
            );
        }

        public async ValueTask bindInstancesBuffer(DataBuffer instancesBuffer, InstancingAttributeInfo[] attributesInfo, System.Nullable<bool> computeStride = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindInstancesBuffer" }, instancesBuffer, attributesInfo, computeStride
                }
            );
        }

        public async ValueTask disableInstanceAttributeByName(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableInstanceAttributeByName" }, name
                }
            );
        }

        public async ValueTask disableInstanceAttribute(decimal attributeLocation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableInstanceAttribute" }, attributeLocation
                }
            );
        }

        public async ValueTask disableAttributeByIndex(decimal attributeLocation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableAttributeByIndex" }, attributeLocation
                }
            );
        }

        public async ValueTask draw(bool useTriangles, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "draw" }, useTriangles, indexStart, indexCount, instancesCount
                }
            );
        }

        public async ValueTask drawPointClouds(decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawPointClouds" }, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public async ValueTask drawUnIndexed(bool useTriangles, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawUnIndexed" }, useTriangles, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public async ValueTask drawElementsType(decimal fillMode, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawElementsType" }, fillMode, indexStart, indexCount, instancesCount
                }
            );
        }

        public async ValueTask drawArraysType(decimal fillMode, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawArraysType" }, fillMode, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public async ValueTask<Effect> createEffect(object baseName, string[] attributesNamesOrOptions, string[] uniformsNamesOrEngine, string[] samplers = null, string defines = null, IEffectFallbacks fallbacks = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, object indexParameters = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createEffect" }, baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, defines, fallbacks, onCompiled, onError, indexParameters
                }
            );
        }

        public async ValueTask<WebGLProgramCachedEntity> createRawShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createRawShaderProgram" }, pipelineContext, vertexCode, fragmentCode, context, transformFeedbackVaryings
                }
            );
        }

        public async ValueTask<WebGLProgramCachedEntity> createShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, string defines = null, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createShaderProgram" }, pipelineContext, vertexCode, fragmentCode, defines, context, transformFeedbackVaryings
                }
            );
        }

        public async ValueTask<IPipelineContextCachedEntity> createPipelineContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPipelineContext" }
                }
            );
        }

        public async ValueTask<WebGLUniformLocationCachedEntity[]> getUniforms(IPipelineContext pipelineContext, string[] uniformsNames)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" }, pipelineContext, uniformsNames
                }
            );
        }

        public async ValueTask<decimal[]> getAttributes(IPipelineContext pipelineContext, string[] attributesNames)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" }, pipelineContext, attributesNames
                }
            );
        }

        public async ValueTask enableEffect(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableEffect" }, effect
                }
            );
        }

        public async ValueTask<bool> setInt(WebGLUniformLocation uniform, decimal value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, uniform, value
                }
            );
        }

        public async ValueTask<bool> setIntArray(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setIntArray2(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray2" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setIntArray3(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray3" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setIntArray4(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray4" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setArray(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setArray2(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray2" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setArray3(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray3" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setArray4(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray4" }, uniform, array
                }
            );
        }

        public async ValueTask<bool> setMatrices(WebGLUniformLocation uniform, decimal[] matrices)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrices" }, uniform, matrices
                }
            );
        }

        public async ValueTask<bool> setMatrix3x3(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniform, matrix
                }
            );
        }

        public async ValueTask<bool> setMatrix2x2(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniform, matrix
                }
            );
        }

        public async ValueTask<bool> setFloat(WebGLUniformLocation uniform, decimal value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, uniform, value
                }
            );
        }

        public async ValueTask<bool> setFloat2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat2" }, uniform, x, y
                }
            );
        }

        public async ValueTask<bool> setFloat3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat3" }, uniform, x, y, z
                }
            );
        }

        public async ValueTask<bool> setFloat4(WebGLUniformLocation uniform, decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat4" }, uniform, x, y, z, w
                }
            );
        }

        public async ValueTask applyStates()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyStates" }
                }
            );
        }

        public async ValueTask setColorWrite(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setColorWrite" }, enable
                }
            );
        }

        public async ValueTask<bool> getColorWrite()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getColorWrite" }
                }
            );
        }

        public async ValueTask clearInternalTexturesCache()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearInternalTexturesCache" }
                }
            );
        }

        public async ValueTask wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "wipeCaches" }, bruteForce
                }
            );
        }

        public async ValueTask<InternalTexture> createTexture(bool noMipmap, bool invertY, ISceneLike scene, string url = null, System.Nullable<decimal> samplingMode = null, ActionCallback onLoad = null, ActionCallback<string, CachedEntity> onError = null, string buffer = null, InternalTexture fallback = null, System.Nullable<decimal> format = null, string forcedExtension = null, string mimeType = null, object loaderOptions = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createTexture" }, url, noMipmap, invertY, scene, samplingMode, onLoad, onError, buffer, fallback, format, forcedExtension, mimeType, loaderOptions
                }
            );
        }

        public async ValueTask updateTextureSamplingMode(decimal samplingMode, InternalTexture texture, System.Nullable<bool> generateMipMaps = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureSamplingMode" }, samplingMode, texture, generateMipMaps
                }
            );
        }

        public async ValueTask updateTextureWrappingMode(InternalTexture texture, System.Nullable<decimal> wrapU = null, System.Nullable<decimal> wrapV = null, System.Nullable<decimal> wrapR = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureWrappingMode" }, texture, wrapU, wrapV, wrapR
                }
            );
        }

        public async ValueTask updateTextureData(InternalTexture texture, ArrayBufferView imageData, decimal xOffset, decimal yOffset, decimal width, decimal height, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> lod = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureData" }, texture, imageData, xOffset, yOffset, width, height, faceIndex, lod
                }
            );
        }

        public async ValueTask bindSamplers(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindSamplers" }, effect
                }
            );
        }

        public async ValueTask unbindAllTextures()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindAllTextures" }
                }
            );
        }

        public async ValueTask setTexture(decimal channel, WebGLUniformLocation uniform, ThinTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, channel, uniform, texture
                }
            );
        }

        public async ValueTask setTextureArray(decimal channel, WebGLUniformLocation uniform, ThinTexture[] textures)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, uniform, textures
                }
            );
        }

        public async ValueTask unbindAllAttributes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindAllAttributes" }
                }
            );
        }

        public async ValueTask releaseEffects()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseEffects" }
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

        #region attachContextLostEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextLostEventEnabled = false;
        private readonly IDictionary<string, Func<Task>> _attachContextLostEventActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> attachContextLostEvent(
            Func<Task> callback
        )
        {
            await SetupAttachContextLostEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextLostEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupAttachContextLostEventLoop()
        {
            if (_isAttachContextLostEventEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "attachContextLostEvent",
                "CallAttachContextLostEventActions",
                _invokableReference
            );
            _isAttachContextLostEventEnabled = true;
        }

        [JSInvokable]
        public async Task CallAttachContextLostEventActions()
        {
            foreach (var action in _attachContextLostEventActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region attachContextRestoredEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextRestoredEventEnabled = false;
        private readonly IDictionary<string, Func<Task>> _attachContextRestoredEventActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> attachContextRestoredEvent(
            Func<Task> callback
        )
        {
            await SetupAttachContextRestoredEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextRestoredEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupAttachContextRestoredEventLoop()
        {
            if (_isAttachContextRestoredEventEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "attachContextRestoredEvent",
                "CallAttachContextRestoredEventActions",
                _invokableReference
            );
            _isAttachContextRestoredEventEnabled = true;
        }

        [JSInvokable]
        public async Task CallAttachContextRestoredEventActions()
        {
            foreach (var action in _attachContextRestoredEventActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<decimal> getError()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getError" }
                }
            );
        }

        public async ValueTask<decimal[]> readPixels(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> hasAlpha = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "readPixels" }, x, y, width, height, hasAlpha
                }
            );
        }

        public async ValueTask<Document> getHostDocument()
        {
            return await EventHorizonBlazorInterop.FuncClass<Document>(
                entity => new Document() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getHostDocument" }
                }
            );
        }
        #endregion
    }
}