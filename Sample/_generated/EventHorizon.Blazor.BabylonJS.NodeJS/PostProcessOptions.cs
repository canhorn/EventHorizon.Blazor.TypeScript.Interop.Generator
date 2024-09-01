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

    [JsonConverter(typeof(CachedEntityConverter<PostProcessOptions>))]
    public class PostProcessOptions : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal width
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PostProcessOptions.width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.width", value);
            }
        }

        public static decimal height
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PostProcessOptions.height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.height", value);
            }
        }

        public static decimal samplingMode
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PostProcessOptions.samplingMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.samplingMode", value);
            }
        }

        public static decimal textureType
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PostProcessOptions.textureType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.textureType", value);
            }
        }

        public static decimal textureFormat
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PostProcessOptions.textureFormat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.textureFormat", value);
            }
        }

        public static string[] uniforms
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<string>(
                    "BABYLON",
                    "PostProcessOptions.uniforms"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.uniforms", value);
            }
        }

        public static string[] samplers
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<string>(
                    "BABYLON",
                    "PostProcessOptions.samplers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.samplers", value);
            }
        }

        public static string[] uniformBuffers
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<string>(
                    "BABYLON",
                    "PostProcessOptions.uniformBuffers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PostProcessOptions.uniformBuffers",
                    value
                );
            }
        }

        public static string defines
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "PostProcessOptions.defines"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.defines", value);
            }
        }

        private static Camera __camera;
        public static Camera camera
        {
            get
            {
                if (__camera == null)
                {
                    __camera = EventHorizonBlazorInterop.GetClass<Camera>(
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
            set
            {
                __camera = null;
                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.camera", value);
            }
        }

        private static AbstractEngine __engine;
        public static AbstractEngine engine
        {
            get
            {
                if (__engine == null)
                {
                    __engine = EventHorizonBlazorInterop.GetClass<AbstractEngine>(
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
            set
            {
                __engine = null;
                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.engine", value);
            }
        }

        public static int shaderLanguage
        {
            get
            {
                return EventHorizonBlazorInterop.Get<int>(
                    "BABYLON",
                    "PostProcessOptions.shaderLanguage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PostProcessOptions.shaderLanguage",
                    value
                );
            }
        }

        public static decimal size
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "PostProcessOptions.size");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.size", value);
            }
        }

        public static bool reusable
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "PostProcessOptions.reusable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.reusable", value);
            }
        }

        public static bool blockCompilation
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "PostProcessOptions.blockCompilation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PostProcessOptions.blockCompilation",
                    value
                );
            }
        }

        public static string vertexUrl
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "PostProcessOptions.vertexUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PostProcessOptions.vertexUrl", value);
            }
        }

        public static CachedEntity indexParameters
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "PostProcessOptions.indexParameters",
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
                    "PostProcessOptions.indexParameters",
                    value
                );
            }
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
