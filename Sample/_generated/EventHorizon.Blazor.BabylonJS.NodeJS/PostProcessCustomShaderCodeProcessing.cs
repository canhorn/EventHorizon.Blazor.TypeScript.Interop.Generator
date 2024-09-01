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

    [JsonConverter(typeof(CachedEntityConverter<PostProcessCustomShaderCodeProcessing>))]
    public class PostProcessCustomShaderCodeProcessing : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static string processCodeAfterIncludes(
            string postProcessName,
            string shaderType,
            string code
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
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

        public static string processFinalCode(
            string postProcessName,
            string shaderType,
            string code
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
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

        public static string defineCustomBindings(
            string postProcessName,
            string[] uniforms,
            string[] samplers,
            string defines = null
        )
        {
            return EventHorizonBlazorInterop.Func<string>(
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

        public static void bindCustomBindings(string postProcessName, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
