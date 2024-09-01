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

        public CachedEntity parallelShaderCompile
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parallelShaderCompile",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "parallelShaderCompile", value);
            }
        }

        private ShaderProcessingContextCachedEntity __shaderProcessingContext;
        public ShaderProcessingContextCachedEntity shaderProcessingContext
        {
            get
            {
                if (__shaderProcessingContext == null)
                {
                    __shaderProcessingContext =
                        EventHorizonBlazorInterop.GetClass<ShaderProcessingContextCachedEntity>(
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
            set
            {
                __shaderProcessingContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "shaderProcessingContext", value);
            }
        }

        private IPipelineContextCachedEntity __existingPipelineContext;
        public IPipelineContextCachedEntity existingPipelineContext
        {
            get
            {
                if (__existingPipelineContext == null)
                {
                    __existingPipelineContext =
                        EventHorizonBlazorInterop.GetClass<IPipelineContextCachedEntity>(
                            this.___guid,
                            "existingPipelineContext",
                            (entity) =>
                            {
                                return new IPipelineContextCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __existingPipelineContext;
            }
            set
            {
                __existingPipelineContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "existingPipelineContext", value);
            }
        }

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        private WebGL2RenderingContextCachedEntity __context;
        public WebGL2RenderingContextCachedEntity context
        {
            get
            {
                if (__context == null)
                {
                    __context =
                        EventHorizonBlazorInterop.GetClass<WebGL2RenderingContextCachedEntity>(
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
            set
            {
                __context = null;
                EventHorizonBlazorInterop.Set(this.___guid, "context", value);
            }
        }

        public bool createAsRaw
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "createAsRaw"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "createAsRaw", value);
            }
        }

        public string vertex
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "vertex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "vertex", value);
            }
        }

        public string fragment
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fragment"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fragment", value);
            }
        }

        public string defines
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "defines"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
            }
        }

        public string[] transformFeedbackVaryings
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "transformFeedbackVaryings"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "transformFeedbackVaryings", value);
            }
        }
        #endregion

        #region Constructor
        public ICreateAndPreparePipelineContextOptionsCachedEntity()
            : base() { }

        public ICreateAndPreparePipelineContextOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void rebuildRebind(
            string vertexSourceCode,
            string fragmentSourceCode,
            ActionCallback<IPipelineContext> onCompiled,
            ActionCallback<string> onError
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void onRenderingStateCompiled(IPipelineContext pipelineContext = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
