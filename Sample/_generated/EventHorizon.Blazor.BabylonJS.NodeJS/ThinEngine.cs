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
    public class ThinEngine : AbstractEngine
    {
        #region Static Accessors

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

                EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.ShadersRepository", value);
            }
        }

        public static ValueTask<bool> IsSupportedAsync
        {
            get
            {
                return EventHorizonBlazorInterop.Get<ValueTask<bool>>(
                    "BABYLON",
                    "ThinEngine.IsSupportedAsync"
                );
            }
        }

        public static bool IsSupported
        {
            get { return EventHorizonBlazorInterop.Get<bool>("BABYLON", "ThinEngine.IsSupported"); }
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

                EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.ExceptionList", value);
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

                EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.CollisionsEpsilon", value);
            }
        }
        #endregion

        #region Static Methods
        public static bool isSupported()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "isSupported" } }
            );
        }

        public static decimal CeilingPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "CeilingPOT" }, x }
            );
        }

        public static decimal FloorPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "FloorPOT" }, x }
            );
        }

        public static decimal NearestPOT(decimal x)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "NearestPOT" }, x }
            );
        }

        public static decimal GetExponentOfTwo(decimal value, decimal max, decimal mode)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "GetExponentOfTwo" },
                    value,
                    max,
                    mode
                }
            );
        }

        public static decimal QueueNewFrame(ActionCallback func, object requester = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "QueueNewFrame" },
                    func,
                    requester
                }
            );
        }
        #endregion

        #region Accessors

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public decimal version
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "version"); }
        }

        public bool supportsUniformBuffers
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsUniformBuffers");
            }
        }

        public bool needPOTTextures
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "needPOTTextures"); }
        }

        public decimal webGLVersion
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webGLVersion"); }
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
        #endregion

        #region Properties

        public bool forcePOTTextures
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "forcePOTTextures"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "forcePOTTextures", value);
            }
        }

        public bool validateShaderPrograms
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "validateShaderPrograms");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "validateShaderPrograms", value);
            }
        }

        public bool disableUniformBuffers
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableUniformBuffers");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableUniformBuffers", value);
            }
        }

        public bool enableUnpackFlipYCached
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableUnpackFlipYCached");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableUnpackFlipYCached", value);
            }
        }
        #endregion

        #region Constructor
        public ThinEngine()
            : base() { }

        public ThinEngine(ICachedEntity entity)
            : base(entity) { }

        public ThinEngine(
            HTMLCanvasElement canvasOrContext,
            System.Nullable<bool> antialias = null,
            EngineOptions options = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                canvasOrContext,
                antialias,
                options,
                adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }

        public ThinEngine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                antialias,
                options,
                adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void snapshotRenderingReset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "snapshotRenderingReset" } }
            );
        }

        public bool areAllEffectsReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "areAllEffectsReady" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public CachedEntity getInfo()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getInfo" } }
            );
        }

        public CachedEntity getGlInfo()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getGlInfo" } }
            );
        }

        public string extractDriverInfo()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "extractDriverInfo" } }
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

        public void endFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "endFrame" } }
            );
        }

        public void bindFramebuffer(
            RenderTargetWrapper rtWrapper,
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
                    rtWrapper,
                    faceIndex,
                    requiredWidth,
                    requiredHeight,
                    forceFullscreenViewport,
                    lodLevel,
                    layer
                }
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

        public void generateMipmaps(InternalTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generateMipmaps" }, texture }
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

        public void flushFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "flushFramebuffer" } }
            );
        }

        public void restoreDefaultFramebuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDefaultFramebuffer" } }
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

        public DataBuffer createIndexBuffer(
            decimal[] indices,
            System.Nullable<bool> updatable = null,
            string _label = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createIndexBuffer" },
                    indices,
                    updatable,
                    _label
                }
            );
        }

        public void bindArrayBuffer(DataBuffer buffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindArrayBuffer" }, buffer }
            );
        }

        public void updateArrayBuffer(decimal[] data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateArrayBuffer" }, data }
            );
        }

        public WebGLVertexArrayObject recordVertexArrayObject(
            object vertexBuffers,
            DataBuffer indexBuffer,
            Effect effect,
            object overrideVertexBuffers = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLVertexArrayObject>(
                entity => new WebGLVertexArrayObject() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "recordVertexArrayObject" },
                    vertexBuffers,
                    indexBuffer,
                    effect,
                    overrideVertexBuffers
                }
            );
        }

        public void bindVertexArrayObject(
            WebGLVertexArrayObject vertexArrayObject,
            DataBuffer indexBuffer
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindVertexArrayObject" },
                    vertexArrayObject,
                    indexBuffer
                }
            );
        }

        public void bindBuffersDirectly(
            DataBuffer vertexBuffer,
            DataBuffer indexBuffer,
            decimal[] vertexDeclaration,
            decimal vertexStrideSize,
            Effect effect
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindBuffersDirectly" },
                    vertexBuffer,
                    indexBuffer,
                    vertexDeclaration,
                    vertexStrideSize,
                    effect
                }
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

        public void unbindInstanceAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindInstanceAttributes" } }
            );
        }

        public void releaseVertexArrayObject(WebGLVertexArrayObject vao)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseVertexArrayObject" }, vao }
            );
        }

        public void updateAndBindInstancesBuffer(
            DataBuffer instancesBuffer,
            decimal[] data,
            decimal[] offsetLocations
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateAndBindInstancesBuffer" },
                    instancesBuffer,
                    data,
                    offsetLocations
                }
            );
        }

        public void bindInstancesBuffer(
            DataBuffer instancesBuffer,
            InstancingAttributeInfo[] attributesInfo,
            System.Nullable<bool> computeStride = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindInstancesBuffer" },
                    instancesBuffer,
                    attributesInfo,
                    computeStride
                }
            );
        }

        public void disableInstanceAttributeByName(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttributeByName" },
                    name
                }
            );
        }

        public void disableInstanceAttribute(decimal attributeLocation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttribute" },
                    attributeLocation
                }
            );
        }

        public void disableAttributeByIndex(decimal attributeLocation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableAttributeByIndex" },
                    attributeLocation
                }
            );
        }

        public void draw(
            bool useTriangles,
            decimal indexStart,
            decimal indexCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "draw" },
                    useTriangles,
                    indexStart,
                    indexCount,
                    instancesCount
                }
            );
        }

        public void drawPointClouds(
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawPointClouds" },
                    verticesStart,
                    verticesCount,
                    instancesCount
                }
            );
        }

        public void drawUnIndexed(
            bool useTriangles,
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawUnIndexed" },
                    useTriangles,
                    verticesStart,
                    verticesCount,
                    instancesCount
                }
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

        public Effect createEffect(
            string baseName,
            string[] attributesNamesOrOptions,
            string[] uniformsNamesOrEngine,
            string[] samplers = null,
            string defines = null,
            IEffectFallbacks fallbacks = null,
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

        public WebGLProgramCachedEntity createRawShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRawShaderProgram" },
                    pipelineContext,
                    vertexCode,
                    fragmentCode,
                    context,
                    transformFeedbackVaryings
                }
            );
        }

        public WebGLProgramCachedEntity createShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            string defines = null,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createShaderProgram" },
                    pipelineContext,
                    vertexCode,
                    fragmentCode,
                    defines,
                    context,
                    transformFeedbackVaryings
                }
            );
        }

        public string inlineShaderCode(string code)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "inlineShaderCode" }, code }
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

        public WebGLUniformLocationCachedEntity[] getUniforms(
            IPipelineContext pipelineContext,
            string[] uniformsNames
        )
        {
            return EventHorizonBlazorInterop.FuncArrayClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" },
                    pipelineContext,
                    uniformsNames
                }
            );
        }

        public decimal[] getAttributes(IPipelineContext pipelineContext, string[] attributesNames)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" },
                    pipelineContext,
                    attributesNames
                }
            );
        }

        public void enableEffect(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableEffect" }, effect }
            );
        }

        public bool setInt(WebGLUniformLocation uniform, decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt" }, uniform, value }
            );
        }

        public bool setInt2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt2" }, uniform, x, y }
            );
        }

        public bool setInt3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt3" }, uniform, x, y, z }
            );
        }

        public bool setInt4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt4" }, uniform, x, y, z, w }
            );
        }

        public bool setIntArray(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray" }, uniform, array }
            );
        }

        public bool setIntArray2(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray2" }, uniform, array }
            );
        }

        public bool setIntArray3(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray3" }, uniform, array }
            );
        }

        public bool setIntArray4(WebGLUniformLocation uniform, Int32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray4" }, uniform, array }
            );
        }

        public bool setUInt(WebGLUniformLocation uniform, decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt" }, uniform, value }
            );
        }

        public bool setUInt2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt2" }, uniform, x, y }
            );
        }

        public bool setUInt3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt3" }, uniform, x, y, z }
            );
        }

        public bool setUInt4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt4" }, uniform, x, y, z, w }
            );
        }

        public bool setUIntArray(WebGLUniformLocation uniform, Uint32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray" }, uniform, array }
            );
        }

        public bool setUIntArray2(WebGLUniformLocation uniform, Uint32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray2" }, uniform, array }
            );
        }

        public bool setUIntArray3(WebGLUniformLocation uniform, Uint32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray3" }, uniform, array }
            );
        }

        public bool setUIntArray4(WebGLUniformLocation uniform, Uint32Array array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray4" }, uniform, array }
            );
        }

        public bool setArray(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray" }, uniform, array }
            );
        }

        public bool setArray2(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray2" }, uniform, array }
            );
        }

        public bool setArray3(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray3" }, uniform, array }
            );
        }

        public bool setArray4(WebGLUniformLocation uniform, decimal[] array)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray4" }, uniform, array }
            );
        }

        public bool setMatrices(WebGLUniformLocation uniform, decimal[] matrices)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrices" }, uniform, matrices }
            );
        }

        public bool setMatrix3x3(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, uniform, matrix }
            );
        }

        public bool setMatrix2x2(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, uniform, matrix }
            );
        }

        public bool setFloat(WebGLUniformLocation uniform, decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat" }, uniform, value }
            );
        }

        public bool setFloat2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat2" }, uniform, x, y }
            );
        }

        public bool setFloat3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat3" }, uniform, x, y, z }
            );
        }

        public bool setFloat4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat4" }, uniform, x, y, z, w }
            );
        }

        public void applyStates()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyStates" } }
            );
        }

        public void wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wipeCaches" }, bruteForce }
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

        public void updateTextureDimensions(
            InternalTexture texture,
            decimal width,
            decimal height,
            System.Nullable<decimal> depth = null
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

        public void updateTextureData(
            InternalTexture texture,
            ArrayBufferView imageData,
            decimal xOffset,
            decimal yOffset,
            decimal width,
            decimal height,
            System.Nullable<decimal> faceIndex = null,
            System.Nullable<decimal> lod = null,
            System.Nullable<bool> generateMipMaps = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureData" },
                    texture,
                    imageData,
                    xOffset,
                    yOffset,
                    width,
                    height,
                    faceIndex,
                    lod,
                    generateMipMaps
                }
            );
        }

        public void bindSamplers(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindSamplers" }, effect }
            );
        }

        public void unbindAllTextures()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindAllTextures" } }
            );
        }

        public void setTexture(
            decimal channel,
            WebGLUniformLocation uniform,
            ThinTexture texture,
            string name
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" },
                    channel,
                    uniform,
                    texture,
                    name
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

        public void unbindAllAttributes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindAllAttributes" } }
            );
        }

        public void releaseEffects()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseEffects" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        #region attachContextLostEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextLostEventEnabled = false;
        private readonly IDictionary<
            string,
            Func<WebGLContextEvent, Task>
        > _attachContextLostEventActionMap =
            new Dictionary<string, Func<WebGLContextEvent, Task>>();

        public string attachContextLostEvent(Func<WebGLContextEvent, Task> callback)
        {
            SetupAttachContextLostEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextLostEventActionMap.Add(handle, callback);

            return handle;
        }

        public bool attachContextLostEvent_Remove(string handle)
        {
            return _attachContextLostEventActionMap.Remove(handle);
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
        public async Task CallAttachContextLostEventActions(WebGLContextEvent @event)
        {
            foreach (var action in _attachContextLostEventActionMap.Values)
            {
                await action(@event);
            }
        }
        #endregion

        #region attachContextRestoredEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextRestoredEventEnabled = false;
        private readonly IDictionary<
            string,
            Func<WebGLContextEvent, Task>
        > _attachContextRestoredEventActionMap =
            new Dictionary<string, Func<WebGLContextEvent, Task>>();

        public string attachContextRestoredEvent(Func<WebGLContextEvent, Task> callback)
        {
            SetupAttachContextRestoredEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextRestoredEventActionMap.Add(handle, callback);

            return handle;
        }

        public bool attachContextRestoredEvent_Remove(string handle)
        {
            return _attachContextRestoredEventActionMap.Remove(handle);
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
        public async Task CallAttachContextRestoredEventActions(WebGLContextEvent @event)
        {
            foreach (var action in _attachContextRestoredEventActionMap.Values)
            {
                await action(@event);
            }
        }
        #endregion

        public decimal getError()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getError" } }
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
        #endregion
    }
}
