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

    public interface IShaderProcessor : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IShaderProcessorCachedEntity>))]
    public class IShaderProcessorCachedEntity : CachedEntityObject, IShaderProcessor
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

        public int shaderLanguage
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "shaderLanguage"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shaderLanguage", value);
            }
        }

        private RegExp __uniformRegexp;
        public RegExp uniformRegexp
        {
            get
            {
                if (__uniformRegexp == null)
                {
                    __uniformRegexp = EventHorizonBlazorInterop.GetClass<RegExp>(
                        this.___guid,
                        "uniformRegexp",
                        (entity) =>
                        {
                            return new RegExp() { ___guid = entity.___guid };
                        }
                    );
                }
                return __uniformRegexp;
            }
            set
            {
                __uniformRegexp = null;
                EventHorizonBlazorInterop.Set(this.___guid, "uniformRegexp", value);
            }
        }

        private RegExp __uniformBufferRegexp;
        public RegExp uniformBufferRegexp
        {
            get
            {
                if (__uniformBufferRegexp == null)
                {
                    __uniformBufferRegexp = EventHorizonBlazorInterop.GetClass<RegExp>(
                        this.___guid,
                        "uniformBufferRegexp",
                        (entity) =>
                        {
                            return new RegExp() { ___guid = entity.___guid };
                        }
                    );
                }
                return __uniformBufferRegexp;
            }
            set
            {
                __uniformBufferRegexp = null;
                EventHorizonBlazorInterop.Set(this.___guid, "uniformBufferRegexp", value);
            }
        }

        private RegExp __textureRegexp;
        public RegExp textureRegexp
        {
            get
            {
                if (__textureRegexp == null)
                {
                    __textureRegexp = EventHorizonBlazorInterop.GetClass<RegExp>(
                        this.___guid,
                        "textureRegexp",
                        (entity) =>
                        {
                            return new RegExp() { ___guid = entity.___guid };
                        }
                    );
                }
                return __textureRegexp;
            }
            set
            {
                __textureRegexp = null;
                EventHorizonBlazorInterop.Set(this.___guid, "textureRegexp", value);
            }
        }

        public bool noPrecision
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "noPrecision"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "noPrecision", value);
            }
        }

        public bool parseGLES3
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "parseGLES3"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "parseGLES3", value);
            }
        }

        public string attributeKeywordName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(this.___guid, "attributeKeywordName");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "attributeKeywordName", value);
            }
        }

        public string varyingVertexKeywordName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "varyingVertexKeywordName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "varyingVertexKeywordName", value);
            }
        }

        public string varyingFragmentKeywordName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "varyingFragmentKeywordName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "varyingFragmentKeywordName", value);
            }
        }
        #endregion

        #region Constructor
        public IShaderProcessorCachedEntity()
            : base() { }

        public IShaderProcessorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public string preProcessShaderCode(string code, bool isFragment)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "preProcessShaderCode" },
                    code,
                    isFragment
                }
            );
        }

        public string attributeProcessor(
            string attribute,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "attributeProcessor" },
                    attribute,
                    preProcessors,
                    processingContext
                }
            );
        }

        public bool varyingCheck(string varying, bool isFragment)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "varyingCheck" }, varying, isFragment }
            );
        }

        public string varyingProcessor(
            string varying,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "varyingProcessor" },
                    varying,
                    isFragment,
                    preProcessors,
                    processingContext
                }
            );
        }

        public string uniformProcessor(
            string uniform,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "uniformProcessor" },
                    uniform,
                    isFragment,
                    preProcessors,
                    processingContext
                }
            );
        }

        public string uniformBufferProcessor(
            string uniformBuffer,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "uniformBufferProcessor" },
                    uniformBuffer,
                    isFragment,
                    processingContext
                }
            );
        }

        public string textureProcessor(
            string texture,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "textureProcessor" },
                    texture,
                    isFragment,
                    preProcessors,
                    processingContext
                }
            );
        }

        public string endOfUniformBufferProcessor(
            string closingBracketLine,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "endOfUniformBufferProcessor" },
                    closingBracketLine,
                    isFragment,
                    processingContext
                }
            );
        }

        public string lineProcessor(
            string line,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "lineProcessor" },
                    line,
                    isFragment,
                    processingContext
                }
            );
        }

        public string preProcessor(
            string code,
            string[] defines,
            object preProcessors,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "preProcessor" },
                    code,
                    defines,
                    preProcessors,
                    isFragment,
                    processingContext
                }
            );
        }

        public string postProcessor(
            string code,
            string[] defines,
            bool isFragment,
            ShaderProcessingContext processingContext,
            decimal patameters
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "postProcessor" },
                    code,
                    defines,
                    isFragment,
                    processingContext,
                    patameters
                }
            );
        }

        public void initializeShaders(ShaderProcessingContext processingContext)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeShaders" },
                    processingContext
                }
            );
        }

        public CachedEntity finalizeShaders(
            string vertexCode,
            string fragmentCode,
            ShaderProcessingContext processingContext
        )
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "finalizeShaders" },
                    vertexCode,
                    fragmentCode,
                    processingContext
                }
            );
        }
        #endregion
    }
}
