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

    public interface ICreateAndPreparePipelineContextOptions : ICachedEntity { }

    [JsonConverter(
        typeof(CachedEntityConverter<ICreateAndPreparePipelineContextOptionsCachedEntity>)
    )]
    public class ICreateAndPreparePipelineContextOptionsCachedEntity
        : CachedEntityObject,
            ICreateAndPreparePipelineContextOptions
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<CachedEntity> get_parallelShaderCompile()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "parallelShaderCompile",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_parallelShaderCompile(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "parallelShaderCompile", value);
        }

        private ShaderProcessingContextCachedEntity __shaderProcessingContext;

        public async ValueTask<ShaderProcessingContextCachedEntity> get_shaderProcessingContext()
        {
            if (__shaderProcessingContext == null)
            {
                __shaderProcessingContext =
                    await EventHorizonBlazorInterop.GetClass<ShaderProcessingContextCachedEntity>(
                        this.___guid,
                        "shaderProcessingContext",
                        (entity) =>
                        {
                            return new ShaderProcessingContextCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __shaderProcessingContext;
        }

        public ValueTask set_shaderProcessingContext(ShaderProcessingContextCachedEntity value)
        {
            __shaderProcessingContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "shaderProcessingContext", value);
        }

        private IPipelineContextCachedEntity __existingPipelineContext;

        public async ValueTask<IPipelineContextCachedEntity> get_existingPipelineContext()
        {
            if (__existingPipelineContext == null)
            {
                __existingPipelineContext =
                    await EventHorizonBlazorInterop.GetClass<IPipelineContextCachedEntity>(
                        this.___guid,
                        "existingPipelineContext",
                        (entity) =>
                        {
                            return new IPipelineContextCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __existingPipelineContext;
        }

        public ValueTask set_existingPipelineContext(IPipelineContextCachedEntity value)
        {
            __existingPipelineContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "existingPipelineContext", value);
        }

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        private WebGL2RenderingContextCachedEntity __context;

        public async ValueTask<WebGL2RenderingContextCachedEntity> get_context()
        {
            if (__context == null)
            {
                __context =
                    await EventHorizonBlazorInterop.GetClass<WebGL2RenderingContextCachedEntity>(
                        this.___guid,
                        "context",
                        (entity) =>
                        {
                            return new WebGL2RenderingContextCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __context;
        }

        public ValueTask set_context(WebGL2RenderingContextCachedEntity value)
        {
            __context = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "context", value);
        }

        public async ValueTask<bool> get_createAsRaw()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "createAsRaw");
        }

        public ValueTask set_createAsRaw(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "createAsRaw", value);
        }

        public async ValueTask<string> get_vertex()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "vertex");
        }

        public ValueTask set_vertex(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "vertex", value);
        }

        public async ValueTask<string> get_fragment()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fragment");
        }

        public ValueTask set_fragment(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fragment", value);
        }

        public async ValueTask<string> get_defines()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "defines");
        }

        public ValueTask set_defines(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
        }

        public async ValueTask<string[]> get_transformFeedbackVaryings()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                this.___guid,
                "transformFeedbackVaryings"
            );
        }

        public ValueTask set_transformFeedbackVaryings(string[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "transformFeedbackVaryings", value);
        }
        #endregion

        #region Constructor
        public ICreateAndPreparePipelineContextOptionsCachedEntity()
            : base() { }

        public ICreateAndPreparePipelineContextOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask rebuildRebind(
            string vertexSourceCode,
            string fragmentSourceCode,
            ActionCallback<IPipelineContext> onCompiled,
            ActionCallback<string> onError
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rebuildRebind" },
                    vertexSourceCode,
                    fragmentSourceCode,
                    onCompiled,
                    onError
                }
            );
        }

        public async ValueTask onRenderingStateCompiled(IPipelineContext pipelineContext = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onRenderingStateCompiled" },
                    pipelineContext
                }
            );
        }
        #endregion
    }
}
