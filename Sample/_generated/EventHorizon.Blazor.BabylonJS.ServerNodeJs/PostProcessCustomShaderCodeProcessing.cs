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

    [JsonConverter(typeof(CachedEntityConverter<PostProcessCustomShaderCodeProcessing>))]
    public class PostProcessCustomShaderCodeProcessing : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<string> processCodeAfterIncludes(
            string postProcessName,
            string shaderType,
            string code
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "PostProcessCustomShaderCodeProcessing",
                        "processCodeAfterIncludes"
                    },
                    postProcessName,
                    shaderType,
                    code
                }
            );
        }

        public static async ValueTask<string> processFinalCode(
            string postProcessName,
            string shaderType,
            string code
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "PostProcessCustomShaderCodeProcessing",
                        "processFinalCode"
                    },
                    postProcessName,
                    shaderType,
                    code
                }
            );
        }

        public static async ValueTask<string> defineCustomBindings(
            string postProcessName,
            string[] uniforms,
            string[] samplers,
            string defines = null
        )
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "PostProcessCustomShaderCodeProcessing",
                        "defineCustomBindings"
                    },
                    postProcessName,
                    defines,
                    uniforms,
                    samplers
                }
            );
        }

        public static async ValueTask bindCustomBindings(string postProcessName, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "PostProcessCustomShaderCodeProcessing",
                        "bindCustomBindings"
                    },
                    postProcessName,
                    effect
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PostProcessCustomShaderCodeProcessing()
            : base() { }

        public PostProcessCustomShaderCodeProcessing(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
