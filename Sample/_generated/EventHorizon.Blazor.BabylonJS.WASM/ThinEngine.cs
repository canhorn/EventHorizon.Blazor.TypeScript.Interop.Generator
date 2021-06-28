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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ThinEngine>))]
    public class ThinEngine : CachedEntityObject
    {
        #region Static Accessors
        
        public static string NpmPackage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.NpmPackage"
                );
            }
        }

        
        public static string Version
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.Version"
                );
            }
        }

        
        public static string ShadersRepository
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ThinEngine.ShadersRepository"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.ShadersRepository",
                    value
                );
            }
        }

        
        public static bool IsSupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "ThinEngine.IsSupported"
                );
            }
        }

        
        public static bool HasMajorPerformanceCaveat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "ThinEngine.HasMajorPerformanceCaveat"
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static CachedEntity[] ExceptionList
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    "BABYLON",
                    "ThinEngine.ExceptionList",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.ExceptionList",
                    value
                );
            }
        }

        
        public static decimal CollisionsEpsilon
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ThinEngine.CollisionsEpsilon"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ThinEngine.CollisionsEpsilon",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static bool isSupported()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "isSupported" }
                }
            );
        }

        public static decimal CeilingPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "CeilingPOT" }, x
                }
            );
        }

        public static decimal FloorPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "FloorPOT" }, x
                }
            );
        }

        public static decimal NearestPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "NearestPOT" }, x
                }
            );
        }

        public static decimal GetExponentOfTwo(decimal value, decimal max, System.Nullable<decimal> mode = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "GetExponentOfTwo" }, value, max, mode
                }
            );
        }

        public static decimal QueueNewFrame(ActionCallback func, object requester = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "QueueNewFrame" }, func, requester
                }
            );
        }
        #endregion

        #region Accessors
        
        public string description
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "description"
                );
            }
        }

        
        public bool supportsUniformBuffers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "supportsUniformBuffers"
                );
            }
        }

        
        public bool needPOTTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needPOTTextures"
                );
            }
        }

        
        public bool doNotHandleContextLost
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotHandleContextLost"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleContextLost",
                    value
                );
            }
        }

        private IViewportLikeCachedEntity __currentViewport;
        public IViewportLikeCachedEntity currentViewport
        {
            get
            {
            if(__currentViewport == null)
            {
                __currentViewport = EventHorizonBlazorInterop.GetClass<IViewportLikeCachedEntity>(
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

        private InternalTexture __emptyTexture;
        public InternalTexture emptyTexture
        {
            get
            {
            if(__emptyTexture == null)
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
            if(__emptyTexture3D == null)
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
            if(__emptyTexture2DArray == null)
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
            if(__emptyCubeTexture == null)
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

        
        public decimal webGLVersion
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "webGLVersion"
                );
            }
        }

        
        public bool isStencilEnable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStencilEnable"
                );
            }
        }

        private DepthCullingState __depthCullingState;
        public DepthCullingState depthCullingState
        {
            get
            {
            if(__depthCullingState == null)
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
            if(__alphaState == null)
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
            if(__stencilState == null)
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
        #endregion

        #region Properties
        
        public bool forcePOTTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forcePOTTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forcePOTTextures",
                    value
                );
            }
        }

        
        public bool isFullscreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFullscreen"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isFullscreen",
                    value
                );
            }
        }

        
        public bool cullBackFaces
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cullBackFaces"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullBackFaces",
                    value
                );
            }
        }

        
        public bool renderEvenInBackground
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderEvenInBackground"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderEvenInBackground",
                    value
                );
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventCacheWipeBetweenFrames",
                    value
                );
            }
        }

        
        public bool validateShaderPrograms
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "validateShaderPrograms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "validateShaderPrograms",
                    value
                );
            }
        }

        
        public bool useReverseDepthBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReverseDepthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useReverseDepthBuffer",
                    value
                );
            }
        }

        
        public bool disableUniformBuffers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableUniformBuffers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableUniformBuffers",
                    value
                );
            }
        }

        private Observable<ThinEngine> __onContextLostObservable;
        public Observable<ThinEngine> onContextLostObservable
        {
            get
            {
            if(__onContextLostObservable == null)
            {
                __onContextLostObservable = EventHorizonBlazorInterop.GetClass<Observable<ThinEngine>>(
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
            set
            {
__onContextLostObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onContextLostObservable",
                    value
                );
            }
        }

        private Observable<ThinEngine> __onContextRestoredObservable;
        public Observable<ThinEngine> onContextRestoredObservable
        {
            get
            {
            if(__onContextRestoredObservable == null)
            {
                __onContextRestoredObservable = EventHorizonBlazorInterop.GetClass<Observable<ThinEngine>>(
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
            set
            {
__onContextRestoredObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onContextRestoredObservable",
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableVertexArrayObjects",
                    value
                );
            }
        }

        private HostInformationCachedEntity __hostInformation;
        public HostInformationCachedEntity hostInformation
        {
            get
            {
            if(__hostInformation == null)
            {
                __hostInformation = EventHorizonBlazorInterop.GetClass<HostInformationCachedEntity>(
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
            set
            {
__hostInformation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hostInformation",
                    value
                );
            }
        }

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
        }

        private Observable<Texture> __onBeforeTextureInitObservable;
        public Observable<Texture> onBeforeTextureInitObservable
        {
            get
            {
            if(__onBeforeTextureInitObservable == null)
            {
                __onBeforeTextureInitObservable = EventHorizonBlazorInterop.GetClass<Observable<Texture>>(
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeTextureInitObservable",
                    value
                );
            }
        }

        
        public bool enableUnpackFlipYCached
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableUnpackFlipYCached"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableUnpackFlipYCached",
                    value
                );
            }
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

        public ThinEngine(
            HTMLCanvasElement canvasOrContext, System.Nullable<bool> antialias = null, EngineOptions options = null, System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool areAllEffectsReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "areAllEffectsReady" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void resetTextureCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetTextureCache" }
                }
            );
        }

        public CachedEntity getGlInfo()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getGlInfo" }
                }
            );
        }

        public void setHardwareScalingLevel(decimal level)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setHardwareScalingLevel" }, level
                }
            );
        }

        public decimal getHardwareScalingLevel()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHardwareScalingLevel" }
                }
            );
        }

        public InternalTexture[] getLoadedTexturesCache()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLoadedTexturesCache" }
                }
            );
        }

        public EngineCapabilitiesCachedEntity getCaps()
        {
            return EventHorizonBlazorInterop.FuncClass<EngineCapabilitiesCachedEntity>(
                entity => new EngineCapabilitiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCaps" }
                }
            );
        }

        public void stopRenderLoop(ActionCallback renderFunction = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopRenderLoop" }, renderFunction
                }
            );
        }

        public HTMLCanvasElementCachedEntity getRenderingCanvas()
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLCanvasElementCachedEntity>(
                entity => new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRenderingCanvas" }
                }
            );
        }

        public WindowCachedEntity getHostWindow()
        {
            return EventHorizonBlazorInterop.FuncClass<WindowCachedEntity>(
                entity => new WindowCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHostWindow" }
                }
            );
        }

        public decimal getRenderWidth(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderWidth" }, useScreen
                }
            );
        }

        public decimal getRenderHeight(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderHeight" }, useScreen
                }
            );
        }

        public void runRenderLoop(ActionCallback renderFunction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "runRenderLoop" }, renderFunction
                }
            );
        }

        public void clear(IColor4Like color, bool backBuffer, bool depth, System.Nullable<bool> stencil = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }, color, backBuffer, depth, stencil
                }
            );
        }

        public void setViewport(IViewportLike viewport, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setViewport" }, viewport, requiredWidth, requiredHeight
                }
            );
        }

        public void beginFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public void endFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "endFrame" }
                }
            );
        }

        public void resize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }

        public bool setSize(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public void bindFramebuffer(InternalTexture texture, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null, System.Nullable<bool> forceFullscreenViewport = null, System.Nullable<decimal> lodLevel = null, System.Nullable<decimal> layer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindFramebuffer" }, texture, faceIndex, requiredWidth, requiredHeight, forceFullscreenViewport, lodLevel, layer
                }
            );
        }

        public void unBindFramebuffer(InternalTexture texture, System.Nullable<bool> disableGenerateMipMaps = null, ActionCallback onBeforeUnbind = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unBindFramebuffer" }, texture, disableGenerateMipMaps, onBeforeUnbind
                }
            );
        }

        public void flushFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "flushFramebuffer" }
                }
            );
        }

        public void restoreDefaultFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "restoreDefaultFramebuffer" }
                }
            );
        }

        public DataBuffer createVertexBuffer(decimal[] data)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createVertexBuffer" }, data
                }
            );
        }

        public DataBuffer createDynamicVertexBuffer(decimal[] data)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDynamicVertexBuffer" }, data
                }
            );
        }

        public DataBuffer createIndexBuffer(decimal[] indices, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createIndexBuffer" }, indices, updatable
                }
            );
        }

        public void bindArrayBuffer(DataBuffer buffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindArrayBuffer" }, buffer
                }
            );
        }

        public void updateArrayBuffer(decimal[] data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateArrayBuffer" }, data
                }
            );
        }

        public WebGLVertexArrayObjectCachedEntity recordVertexArrayObject(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLVertexArrayObjectCachedEntity>(
                entity => new WebGLVertexArrayObjectCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "recordVertexArrayObject" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public void bindVertexArrayObject(WebGLVertexArrayObject vertexArrayObject, DataBuffer indexBuffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindVertexArrayObject" }, vertexArrayObject, indexBuffer
                }
            );
        }

        public void bindBuffersDirectly(DataBuffer vertexBuffer, DataBuffer indexBuffer, decimal[] vertexDeclaration, decimal vertexStrideSize, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBuffersDirectly" }, vertexBuffer, indexBuffer, vertexDeclaration, vertexStrideSize, effect
                }
            );
        }

        public void bindBuffers(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBuffers" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public void unbindInstanceAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbindInstanceAttributes" }
                }
            );
        }

        public void releaseVertexArrayObject(WebGLVertexArrayObject vao)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseVertexArrayObject" }, vao
                }
            );
        }

        public void updateAndBindInstancesBuffer(DataBuffer instancesBuffer, decimal[] data, decimal[] offsetLocations)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateAndBindInstancesBuffer" }, instancesBuffer, data, offsetLocations
                }
            );
        }

        public void bindInstancesBuffer(DataBuffer instancesBuffer, InstancingAttributeInfo[] attributesInfo, System.Nullable<bool> computeStride = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindInstancesBuffer" }, instancesBuffer, attributesInfo, computeStride
                }
            );
        }

        public void disableInstanceAttributeByName(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttributeByName" }, name
                }
            );
        }

        public void disableInstanceAttribute(decimal attributeLocation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttribute" }, attributeLocation
                }
            );
        }

        public void disableAttributeByIndex(decimal attributeLocation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableAttributeByIndex" }, attributeLocation
                }
            );
        }

        public void draw(bool useTriangles, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "draw" }, useTriangles, indexStart, indexCount, instancesCount
                }
            );
        }

        public void drawPointClouds(decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawPointClouds" }, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public void drawUnIndexed(bool useTriangles, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawUnIndexed" }, useTriangles, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public void drawElementsType(decimal fillMode, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawElementsType" }, fillMode, indexStart, indexCount, instancesCount
                }
            );
        }

        public void drawArraysType(decimal fillMode, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawArraysType" }, fillMode, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public Effect createEffect(object baseName, string[] attributesNamesOrOptions, string[] uniformsNamesOrEngine, string[] samplers = null, string defines = null, IEffectFallbacks fallbacks = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, object indexParameters = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createEffect" }, baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, defines, fallbacks, onCompiled, onError, indexParameters
                }
            );
        }

        public WebGLProgramCachedEntity createRawShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRawShaderProgram" }, pipelineContext, vertexCode, fragmentCode, context, transformFeedbackVaryings
                }
            );
        }

        public WebGLProgramCachedEntity createShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, string defines = null, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createShaderProgram" }, pipelineContext, vertexCode, fragmentCode, defines, context, transformFeedbackVaryings
                }
            );
        }

        public IPipelineContextCachedEntity createPipelineContext()
        {
            return EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPipelineContext" }
                }
            );
        }

        public WebGLUniformLocationCachedEntity[] getUniforms(IPipelineContext pipelineContext, string[] uniformsNames)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" }, pipelineContext, uniformsNames
                }
            );
        }

        public decimal[] getAttributes(IPipelineContext pipelineContext, string[] attributesNames)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" }, pipelineContext, attributesNames
                }
            );
        }

        public void enableEffect(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableEffect" }, effect
                }
            );
        }

        public bool setInt(WebGLUniformLocation uniform, decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setInt" }, uniform, value
                }
            );
        }

        public bool setIntArray(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setIntArray" }, uniform, array
                }
            );
        }

        public bool setIntArray2(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setIntArray2" }, uniform, array
                }
            );
        }

        public bool setIntArray3(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setIntArray3" }, uniform, array
                }
            );
        }

        public bool setIntArray4(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setIntArray4" }, uniform, array
                }
            );
        }

        public bool setArray(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setArray" }, uniform, array
                }
            );
        }

        public bool setArray2(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setArray2" }, uniform, array
                }
            );
        }

        public bool setArray3(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setArray3" }, uniform, array
                }
            );
        }

        public bool setArray4(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setArray4" }, uniform, array
                }
            );
        }

        public bool setMatrices(WebGLUniformLocation uniform, decimal[] matrices)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setMatrices" }, uniform, matrices
                }
            );
        }

        public bool setMatrix3x3(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniform, matrix
                }
            );
        }

        public bool setMatrix2x2(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniform, matrix
                }
            );
        }

        public bool setFloat(WebGLUniformLocation uniform, decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setFloat" }, uniform, value
                }
            );
        }

        public bool setFloat2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setFloat2" }, uniform, x, y
                }
            );
        }

        public bool setFloat3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setFloat3" }, uniform, x, y, z
                }
            );
        }

        public bool setFloat4(WebGLUniformLocation uniform, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setFloat4" }, uniform, x, y, z, w
                }
            );
        }

        public void applyStates()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyStates" }
                }
            );
        }

        public void setColorWrite(bool enable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColorWrite" }, enable
                }
            );
        }

        public bool getColorWrite()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "getColorWrite" }
                }
            );
        }

        public void clearInternalTexturesCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearInternalTexturesCache" }
                }
            );
        }

        public void wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "wipeCaches" }, bruteForce
                }
            );
        }

        public InternalTexture createTexture(bool noMipmap, bool invertY, ISceneLike scene, string url = null, System.Nullable<decimal> samplingMode = null, ActionCallback onLoad = null, ActionCallback<string, CachedEntity> onError = null, string buffer = null, InternalTexture fallback = null, System.Nullable<decimal> format = null, string forcedExtension = null, string mimeType = null, object loaderOptions = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createTexture" }, url, noMipmap, invertY, scene, samplingMode, onLoad, onError, buffer, fallback, format, forcedExtension, mimeType, loaderOptions
                }
            );
        }

        public void updateTextureSamplingMode(decimal samplingMode, InternalTexture texture, System.Nullable<bool> generateMipMaps = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureSamplingMode" }, samplingMode, texture, generateMipMaps
                }
            );
        }

        public void updateTextureWrappingMode(InternalTexture texture, System.Nullable<decimal> wrapU = null, System.Nullable<decimal> wrapV = null, System.Nullable<decimal> wrapR = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureWrappingMode" }, texture, wrapU, wrapV, wrapR
                }
            );
        }

        public void updateTextureData(InternalTexture texture, ArrayBufferView imageData, decimal xOffset, decimal yOffset, decimal width, decimal height, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> lod = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureData" }, texture, imageData, xOffset, yOffset, width, height, faceIndex, lod
                }
            );
        }

        public void bindSamplers(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindSamplers" }, effect
                }
            );
        }

        public void unbindAllTextures()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbindAllTextures" }
                }
            );
        }

        public void setTexture(decimal channel, WebGLUniformLocation uniform, ThinTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, channel, uniform, texture
                }
            );
        }

        public void setTextureArray(decimal channel, WebGLUniformLocation uniform, ThinTexture[] textures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, uniform, textures
                }
            );
        }

        public void unbindAllAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbindAllAttributes" }
                }
            );
        }

        public void releaseEffects()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseEffects" }
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

        #region attachContextLostEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextLostEventEnabled = false;
        private readonly IDictionary<string, Func<Task>> _attachContextLostEventActionMap = new Dictionary<string, Func<Task>>();

        public string attachContextLostEvent(
            Func<Task> callback
        )
        {
            SetupAttachContextLostEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextLostEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool attachContextLostEvent_Remove(
            string handle
        )
        {
            return _attachContextLostEventActionMap.Remove(
                handle
            );
        }

        private void SetupAttachContextLostEventLoop()
        {
            if (_isAttachContextLostEventEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string attachContextRestoredEvent(
            Func<Task> callback
        )
        {
            SetupAttachContextRestoredEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextRestoredEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool attachContextRestoredEvent_Remove(
            string handle
        )
        {
            return _attachContextRestoredEventActionMap.Remove(
                handle
            );
        }

        private void SetupAttachContextRestoredEventLoop()
        {
            if (_isAttachContextRestoredEventEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public decimal getError()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getError" }
                }
            );
        }

        public decimal[] readPixels(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> hasAlpha = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "readPixels" }, x, y, width, height, hasAlpha
                }
            );
        }

        public Document getHostDocument()
        {
            return EventHorizonBlazorInterop.FuncClass<Document>(
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