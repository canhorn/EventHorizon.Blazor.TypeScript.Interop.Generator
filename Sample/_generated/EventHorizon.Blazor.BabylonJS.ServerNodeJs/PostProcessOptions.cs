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

    [JsonConverter(typeof(CachedEntityConverter<PostProcessOptions>))]
    public class PostProcessOptions : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.width"
            );
        }

        public static ValueTask set_width(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.width", value);
        }

        public static async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.height"
            );
        }

        public static ValueTask set_height(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.height", value);
        }

        public static async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.samplingMode"
            );
        }

        public static ValueTask set_samplingMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.samplingMode",
                value
            );
        }

        public static async ValueTask<decimal> get_textureType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.textureType"
            );
        }

        public static ValueTask set_textureType(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.textureType",
                value
            );
        }

        public static async ValueTask<decimal> get_textureFormat()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.textureFormat"
            );
        }

        public static ValueTask set_textureFormat(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.textureFormat",
                value
            );
        }

        public static async ValueTask<string[]> get_uniforms()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                "BABYLON",
                "PostProcessOptions.uniforms"
            );
        }

        public static ValueTask set_uniforms(string[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.uniforms", value);
        }

        public static async ValueTask<string[]> get_samplers()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                "BABYLON",
                "PostProcessOptions.samplers"
            );
        }

        public static ValueTask set_samplers(string[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.samplers", value);
        }

        public static async ValueTask<string[]> get_uniformBuffers()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                "BABYLON",
                "PostProcessOptions.uniformBuffers"
            );
        }

        public static ValueTask set_uniformBuffers(string[] value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.uniformBuffers",
                value
            );
        }

        public static async ValueTask<string> get_defines()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "PostProcessOptions.defines"
            );
        }

        public static ValueTask set_defines(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.defines", value);
        }

        private static Camera __camera;

        public static async ValueTask<Camera> get_camera()
        {
            if (__camera == null)
            {
                __camera = await EventHorizonBlazorInterop.GetClass<Camera>(
                    "BABYLON",
                    "PostProcessOptions.camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
        }

        public static ValueTask set_camera(Camera value)
        {
            __camera = null;
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.camera", value);
        }

        private static AbstractEngine __engine;

        public static async ValueTask<AbstractEngine> get_engine()
        {
            if (__engine == null)
            {
                __engine = await EventHorizonBlazorInterop.GetClass<AbstractEngine>(
                    "BABYLON",
                    "PostProcessOptions.engine",
                    (entity) =>
                    {
                        return new AbstractEngine() { ___guid = entity.___guid };
                    }
                );
            }
            return __engine;
        }

        public static ValueTask set_engine(AbstractEngine value)
        {
            __engine = null;
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.engine", value);
        }

        public static async ValueTask<int> get_shaderLanguage()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                "BABYLON",
                "PostProcessOptions.shaderLanguage"
            );
        }

        public static ValueTask set_shaderLanguage(int value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.shaderLanguage",
                value
            );
        }

        public static async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PostProcessOptions.size"
            );
        }

        public static ValueTask set_size(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.size", value);
        }

        public static async ValueTask<bool> get_reusable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PostProcessOptions.reusable"
            );
        }

        public static ValueTask set_reusable(bool value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.reusable", value);
        }

        public static async ValueTask<bool> get_blockCompilation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PostProcessOptions.blockCompilation"
            );
        }

        public static ValueTask set_blockCompilation(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.blockCompilation",
                value
            );
        }

        public static async ValueTask<string> get_vertexUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "PostProcessOptions.vertexUrl"
            );
        }

        public static ValueTask set_vertexUrl(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.vertexUrl", value);
        }

        public static async ValueTask<CachedEntity> get_indexParameters()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "PostProcessOptions.indexParameters",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_indexParameters(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PostProcessOptions.indexParameters",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PostProcessOptions()
            : base() { }

        public PostProcessOptions(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
