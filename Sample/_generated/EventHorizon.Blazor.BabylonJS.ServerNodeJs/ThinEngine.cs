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

    [JsonConverter(typeof(CachedEntityConverter<ThinEngine>))]
    public class ThinEngine : AbstractEngine
    {
        #region Static Accessors

        public static async ValueTask<string> get_ShadersRepository()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "ThinEngine.ShadersRepository"
            );
        }

        public static ValueTask set_ShadersRepository(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.ShadersRepository", value);
        }

        public static async ValueTask<bool> get_IsSupportedAsync()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "ThinEngine.IsSupportedAsync"
            );
        }

        public static async ValueTask<bool> get_IsSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>("BABYLON", "ThinEngine.IsSupported");
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
            return EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.ExceptionList", value);
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
            return EventHorizonBlazorInterop.Set("BABYLON", "ThinEngine.CollisionsEpsilon", value);
        }
        #endregion

        #region Static Methods
        public static async ValueTask<bool> isSupported()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "isSupported" } }
            );
        }

        public static async ValueTask<decimal> CeilingPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "CeilingPOT" }, x }
            );
        }

        public static async ValueTask<decimal> FloorPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "FloorPOT" }, x }
            );
        }

        public static async ValueTask<decimal> NearestPOT(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "ThinEngine", "NearestPOT" }, x }
            );
        }

        public static async ValueTask<decimal> GetExponentOfTwo(
            decimal value,
            decimal max,
            decimal mode
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ThinEngine", "GetExponentOfTwo" },
                    value,
                    max,
                    mode
                }
            );
        }

        public static async ValueTask<decimal> QueueNewFrame(
            ActionCallback func,
            object requester = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
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

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<decimal> get_version()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "version");
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
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "needPOTTextures");
        }

        public async ValueTask<decimal> get_webGLVersion()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webGLVersion");
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
        #endregion

        #region Properties

        public async ValueTask<bool> get_forcePOTTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "forcePOTTextures");
        }

        public ValueTask set_forcePOTTextures(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "forcePOTTextures", value);
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
            return EventHorizonBlazorInterop.Set(this.___guid, "validateShaderPrograms", value);
        }

        public async ValueTask<bool> get_disableUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableUniformBuffers");
        }

        public ValueTask set_disableUniformBuffers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableUniformBuffers", value);
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
            return EventHorizonBlazorInterop.Set(this.___guid, "enableUnpackFlipYCached", value);
        }
        #endregion

        #region Constructor
        public ThinEngine()
            : base() { }

        public ThinEngine(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<ThinEngine> NewThinEngine(
            HTMLCanvasElement canvasOrContext,
            System.Nullable<bool> antialias = null,
            EngineOptions options = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                canvasOrContext,
                antialias,
                options,
                adaptToDeviceRatio
            );

            return new ThinEngine(entity);
        }

        public static async ValueTask<ThinEngine> NewThinEngine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinEngine" },
                antialias,
                options,
                adaptToDeviceRatio
            );

            return new ThinEngine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask snapshotRenderingReset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "snapshotRenderingReset" } }
            );
        }

        public async ValueTask<bool> areAllEffectsReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "areAllEffectsReady" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<CachedEntity> getInfo()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getInfo" } }
            );
        }

        public async ValueTask<CachedEntity> getGlInfo()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getGlInfo" } }
            );
        }

        public async ValueTask<string> extractDriverInfo()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "extractDriverInfo" } }
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

        public async ValueTask endFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "endFrame" } }
            );
        }

        public async ValueTask bindFramebuffer(
            RenderTargetWrapper rtWrapper,
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

        public async ValueTask generateMipmaps(InternalTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generateMipmaps" }, texture }
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

        public async ValueTask flushFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "flushFramebuffer" } }
            );
        }

        public async ValueTask restoreDefaultFramebuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDefaultFramebuffer" } }
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

        public async ValueTask<DataBuffer> createIndexBuffer(
            decimal[] indices,
            System.Nullable<bool> updatable = null,
            string _label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
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

        public async ValueTask bindArrayBuffer(DataBuffer buffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindArrayBuffer" }, buffer }
            );
        }

        public async ValueTask updateArrayBuffer(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateArrayBuffer" }, data }
            );
        }

        public async ValueTask<WebGLVertexArrayObject> recordVertexArrayObject(
            object vertexBuffers,
            DataBuffer indexBuffer,
            Effect effect,
            object overrideVertexBuffers = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLVertexArrayObject>(
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

        public async ValueTask bindVertexArrayObject(
            WebGLVertexArrayObject vertexArrayObject,
            DataBuffer indexBuffer
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindVertexArrayObject" },
                    vertexArrayObject,
                    indexBuffer
                }
            );
        }

        public async ValueTask bindBuffersDirectly(
            DataBuffer vertexBuffer,
            DataBuffer indexBuffer,
            decimal[] vertexDeclaration,
            decimal vertexStrideSize,
            Effect effect
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask unbindInstanceAttributes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindInstanceAttributes" } }
            );
        }

        public async ValueTask releaseVertexArrayObject(WebGLVertexArrayObject vao)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseVertexArrayObject" }, vao }
            );
        }

        public async ValueTask updateAndBindInstancesBuffer(
            DataBuffer instancesBuffer,
            decimal[] data,
            decimal[] offsetLocations
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateAndBindInstancesBuffer" },
                    instancesBuffer,
                    data,
                    offsetLocations
                }
            );
        }

        public async ValueTask bindInstancesBuffer(
            DataBuffer instancesBuffer,
            InstancingAttributeInfo[] attributesInfo,
            System.Nullable<bool> computeStride = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindInstancesBuffer" },
                    instancesBuffer,
                    attributesInfo,
                    computeStride
                }
            );
        }

        public async ValueTask disableInstanceAttributeByName(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttributeByName" },
                    name
                }
            );
        }

        public async ValueTask disableInstanceAttribute(decimal attributeLocation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableInstanceAttribute" },
                    attributeLocation
                }
            );
        }

        public async ValueTask disableAttributeByIndex(decimal attributeLocation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableAttributeByIndex" },
                    attributeLocation
                }
            );
        }

        public async ValueTask draw(
            bool useTriangles,
            decimal indexStart,
            decimal indexCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask drawPointClouds(
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawPointClouds" },
                    verticesStart,
                    verticesCount,
                    instancesCount
                }
            );
        }

        public async ValueTask drawUnIndexed(
            bool useTriangles,
            decimal verticesStart,
            decimal verticesCount,
            System.Nullable<decimal> instancesCount = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<Effect> createEffect(
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

        public async ValueTask<WebGLProgramCachedEntity> createRawShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
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

        public async ValueTask<WebGLProgramCachedEntity> createShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            string defines = null,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
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

        public async ValueTask<string> inlineShaderCode(string code)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "inlineShaderCode" }, code }
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

        public async ValueTask<WebGLUniformLocationCachedEntity[]> getUniforms(
            IPipelineContext pipelineContext,
            string[] uniformsNames
        )
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" },
                    pipelineContext,
                    uniformsNames
                }
            );
        }

        public async ValueTask<decimal[]> getAttributes(
            IPipelineContext pipelineContext,
            string[] attributesNames
        )
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" },
                    pipelineContext,
                    attributesNames
                }
            );
        }

        public async ValueTask enableEffect(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableEffect" }, effect }
            );
        }

        public async ValueTask<bool> setInt(WebGLUniformLocation uniform, decimal value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt" }, uniform, value }
            );
        }

        public async ValueTask<bool> setInt2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt2" }, uniform, x, y }
            );
        }

        public async ValueTask<bool> setInt3(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt3" }, uniform, x, y, z }
            );
        }

        public async ValueTask<bool> setInt4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setInt4" }, uniform, x, y, z, w }
            );
        }

        public async ValueTask<bool> setIntArray(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray" }, uniform, array }
            );
        }

        public async ValueTask<bool> setIntArray2(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray2" }, uniform, array }
            );
        }

        public async ValueTask<bool> setIntArray3(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray3" }, uniform, array }
            );
        }

        public async ValueTask<bool> setIntArray4(WebGLUniformLocation uniform, Int32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setIntArray4" }, uniform, array }
            );
        }

        public async ValueTask<bool> setUInt(WebGLUniformLocation uniform, decimal value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt" }, uniform, value }
            );
        }

        public async ValueTask<bool> setUInt2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt2" }, uniform, x, y }
            );
        }

        public async ValueTask<bool> setUInt3(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt3" }, uniform, x, y, z }
            );
        }

        public async ValueTask<bool> setUInt4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUInt4" }, uniform, x, y, z, w }
            );
        }

        public async ValueTask<bool> setUIntArray(WebGLUniformLocation uniform, Uint32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray" }, uniform, array }
            );
        }

        public async ValueTask<bool> setUIntArray2(WebGLUniformLocation uniform, Uint32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray2" }, uniform, array }
            );
        }

        public async ValueTask<bool> setUIntArray3(WebGLUniformLocation uniform, Uint32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray3" }, uniform, array }
            );
        }

        public async ValueTask<bool> setUIntArray4(WebGLUniformLocation uniform, Uint32Array array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setUIntArray4" }, uniform, array }
            );
        }

        public async ValueTask<bool> setArray(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray" }, uniform, array }
            );
        }

        public async ValueTask<bool> setArray2(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray2" }, uniform, array }
            );
        }

        public async ValueTask<bool> setArray3(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray3" }, uniform, array }
            );
        }

        public async ValueTask<bool> setArray4(WebGLUniformLocation uniform, decimal[] array)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setArray4" }, uniform, array }
            );
        }

        public async ValueTask<bool> setMatrices(WebGLUniformLocation uniform, decimal[] matrices)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrices" }, uniform, matrices }
            );
        }

        public async ValueTask<bool> setMatrix3x3(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, uniform, matrix }
            );
        }

        public async ValueTask<bool> setMatrix2x2(WebGLUniformLocation uniform, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, uniform, matrix }
            );
        }

        public async ValueTask<bool> setFloat(WebGLUniformLocation uniform, decimal value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat" }, uniform, value }
            );
        }

        public async ValueTask<bool> setFloat2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat2" }, uniform, x, y }
            );
        }

        public async ValueTask<bool> setFloat3(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat3" }, uniform, x, y, z }
            );
        }

        public async ValueTask<bool> setFloat4(
            WebGLUniformLocation uniform,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setFloat4" }, uniform, x, y, z, w }
            );
        }

        public async ValueTask applyStates()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyStates" } }
            );
        }

        public async ValueTask wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wipeCaches" }, bruteForce }
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

        public async ValueTask updateTextureDimensions(
            InternalTexture texture,
            decimal width,
            decimal height,
            System.Nullable<decimal> depth = null
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

        public async ValueTask updateTextureData(
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
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask bindSamplers(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindSamplers" }, effect }
            );
        }

        public async ValueTask unbindAllTextures()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindAllTextures" } }
            );
        }

        public async ValueTask setTexture(
            decimal channel,
            WebGLUniformLocation uniform,
            ThinTexture texture,
            string name
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask unbindAllAttributes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindAllAttributes" } }
            );
        }

        public async ValueTask releaseEffects()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseEffects" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<string> attachContextLostEvent(
            Func<WebGLContextEvent, Task> callback
        )
        {
            await SetupAttachContextLostEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextLostEventActionMap.Add(handle, callback);

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

        public async ValueTask<string> attachContextRestoredEvent(
            Func<WebGLContextEvent, Task> callback
        )
        {
            await SetupAttachContextRestoredEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextRestoredEventActionMap.Add(handle, callback);

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
        public async Task CallAttachContextRestoredEventActions(WebGLContextEvent @event)
        {
            foreach (var action in _attachContextRestoredEventActionMap.Values)
            {
                await action(@event);
            }
        }
        #endregion

        public async ValueTask<decimal> getError()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getError" } }
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
        #endregion
    }
}
