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

        public async ValueTask<int> get_shaderLanguage()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "shaderLanguage");
        }

        public ValueTask set_shaderLanguage(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shaderLanguage", value);
        }

        private RegExp __uniformRegexp;

        public async ValueTask<RegExp> get_uniformRegexp()
        {
            if (__uniformRegexp == null)
            {
                __uniformRegexp = await EventHorizonBlazorInterop.GetClass<RegExp>(
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

        public ValueTask set_uniformRegexp(RegExp value)
        {
            __uniformRegexp = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "uniformRegexp", value);
        }

        private RegExp __uniformBufferRegexp;

        public async ValueTask<RegExp> get_uniformBufferRegexp()
        {
            if (__uniformBufferRegexp == null)
            {
                __uniformBufferRegexp = await EventHorizonBlazorInterop.GetClass<RegExp>(
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

        public ValueTask set_uniformBufferRegexp(RegExp value)
        {
            __uniformBufferRegexp = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "uniformBufferRegexp", value);
        }

        private RegExp __textureRegexp;

        public async ValueTask<RegExp> get_textureRegexp()
        {
            if (__textureRegexp == null)
            {
                __textureRegexp = await EventHorizonBlazorInterop.GetClass<RegExp>(
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

        public ValueTask set_textureRegexp(RegExp value)
        {
            __textureRegexp = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "textureRegexp", value);
        }

        public async ValueTask<bool> get_noPrecision()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "noPrecision");
        }

        public ValueTask set_noPrecision(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "noPrecision", value);
        }

        public async ValueTask<bool> get_parseGLES3()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "parseGLES3");
        }

        public ValueTask set_parseGLES3(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "parseGLES3", value);
        }

        public async ValueTask<string> get_attributeKeywordName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "attributeKeywordName"
            );
        }

        public ValueTask set_attributeKeywordName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "attributeKeywordName", value);
        }

        public async ValueTask<string> get_varyingVertexKeywordName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "varyingVertexKeywordName"
            );
        }

        public ValueTask set_varyingVertexKeywordName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "varyingVertexKeywordName", value);
        }

        public async ValueTask<string> get_varyingFragmentKeywordName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "varyingFragmentKeywordName"
            );
        }

        public ValueTask set_varyingFragmentKeywordName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "varyingFragmentKeywordName", value);
        }
        #endregion

        #region Constructor
        public IShaderProcessorCachedEntity()
            : base() { }

        public IShaderProcessorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<string> preProcessShaderCode(string code, bool isFragment)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "preProcessShaderCode" },
                    code,
                    isFragment
                }
            );
        }

        public async ValueTask<string> attributeProcessor(
            string attribute,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "attributeProcessor" },
                    attribute,
                    preProcessors,
                    processingContext
                }
            );
        }

        public async ValueTask<bool> varyingCheck(string varying, bool isFragment)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "varyingCheck" }, varying, isFragment }
            );
        }

        public async ValueTask<string> varyingProcessor(
            string varying,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
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

        public async ValueTask<string> uniformProcessor(
            string uniform,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
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

        public async ValueTask<string> uniformBufferProcessor(
            string uniformBuffer,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "uniformBufferProcessor" },
                    uniformBuffer,
                    isFragment,
                    processingContext
                }
            );
        }

        public async ValueTask<string> textureProcessor(
            string texture,
            bool isFragment,
            object preProcessors,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
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

        public async ValueTask<string> endOfUniformBufferProcessor(
            string closingBracketLine,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "endOfUniformBufferProcessor" },
                    closingBracketLine,
                    isFragment,
                    processingContext
                }
            );
        }

        public async ValueTask<string> lineProcessor(
            string line,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "lineProcessor" },
                    line,
                    isFragment,
                    processingContext
                }
            );
        }

        public async ValueTask<string> preProcessor(
            string code,
            string[] defines,
            object preProcessors,
            bool isFragment,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
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

        public async ValueTask<string> postProcessor(
            string code,
            string[] defines,
            bool isFragment,
            ShaderProcessingContext processingContext,
            decimal patameters
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
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

        public async ValueTask initializeShaders(ShaderProcessingContext processingContext)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeShaders" },
                    processingContext
                }
            );
        }

        public async ValueTask<CachedEntity> finalizeShaders(
            string vertexCode,
            string fragmentCode,
            ShaderProcessingContext processingContext
        )
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
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
