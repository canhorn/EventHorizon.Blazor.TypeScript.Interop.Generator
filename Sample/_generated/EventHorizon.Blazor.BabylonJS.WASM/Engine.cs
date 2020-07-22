/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Engine : ThinEngine
    {
        #region Static Accessors
        
        public static string NpmPackage
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "Engine.NpmPackage"
                );
            }
        }

        
        public static string Version
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "Engine.Version"
                );
            }
        }

        
        public static Engine[] Instances
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Engine>(
                    "BABYLON",
                    "Engine.Instances",
                    (entity) =>
                    {
                        return new Engine() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private static Engine __LastCreatedEngine;
        public static Engine LastCreatedEngine
        {
            get
            {
            if(__LastCreatedEngine == null)
            {
                __LastCreatedEngine = EventHorizonBlazorInteropt.GetClass<Engine>(
                    "BABYLON",
                    "Engine.LastCreatedEngine",
                    (entity) =>
                    {
                        return new Engine() { ___guid = entity.___guid };
                    }
                );
            }
            return __LastCreatedEngine;
            }
        }

        private static Scene __LastCreatedScene;
        public static Scene LastCreatedScene
        {
            get
            {
            if(__LastCreatedScene == null)
            {
                __LastCreatedScene = EventHorizonBlazorInteropt.GetClass<Scene>(
                    "BABYLON",
                    "Engine.LastCreatedScene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __LastCreatedScene;
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal ALPHA_DISABLE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_DISABLE"
                );
            }
        }

        
        public static decimal ALPHA_ADD
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_ADD"
                );
            }
        }

        
        public static decimal ALPHA_COMBINE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_COMBINE"
                );
            }
        }

        
        public static decimal ALPHA_SUBTRACT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_SUBTRACT"
                );
            }
        }

        
        public static decimal ALPHA_MULTIPLY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_MULTIPLY"
                );
            }
        }

        
        public static decimal ALPHA_MAXIMIZED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_MAXIMIZED"
                );
            }
        }

        
        public static decimal ALPHA_ONEONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_ONEONE"
                );
            }
        }

        
        public static decimal ALPHA_PREMULTIPLIED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED"
                );
            }
        }

        
        public static decimal ALPHA_PREMULTIPLIED_PORTERDUFF
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED_PORTERDUFF"
                );
            }
        }

        
        public static decimal ALPHA_INTERPOLATE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_INTERPOLATE"
                );
            }
        }

        
        public static decimal ALPHA_SCREENMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_SCREENMODE"
                );
            }
        }

        
        public static decimal DELAYLOADSTATE_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NONE"
                );
            }
        }

        
        public static decimal DELAYLOADSTATE_LOADED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADED"
                );
            }
        }

        
        public static decimal DELAYLOADSTATE_LOADING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADING"
                );
            }
        }

        
        public static decimal DELAYLOADSTATE_NOTLOADED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NOTLOADED"
                );
            }
        }

        
        public static decimal NEVER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.NEVER"
                );
            }
        }

        
        public static decimal ALWAYS
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.ALWAYS"
                );
            }
        }

        
        public static decimal LESS
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.LESS"
                );
            }
        }

        
        public static decimal EQUAL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.EQUAL"
                );
            }
        }

        
        public static decimal LEQUAL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.LEQUAL"
                );
            }
        }

        
        public static decimal GREATER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.GREATER"
                );
            }
        }

        
        public static decimal GEQUAL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.GEQUAL"
                );
            }
        }

        
        public static decimal NOTEQUAL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.NOTEQUAL"
                );
            }
        }

        
        public static decimal KEEP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.KEEP"
                );
            }
        }

        
        public static decimal REPLACE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.REPLACE"
                );
            }
        }

        
        public static decimal INCR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.INCR"
                );
            }
        }

        
        public static decimal DECR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DECR"
                );
            }
        }

        
        public static decimal INVERT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.INVERT"
                );
            }
        }

        
        public static decimal INCR_WRAP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.INCR_WRAP"
                );
            }
        }

        
        public static decimal DECR_WRAP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.DECR_WRAP"
                );
            }
        }

        
        public static decimal TEXTURE_CLAMP_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CLAMP_ADDRESSMODE"
                );
            }
        }

        
        public static decimal TEXTURE_WRAP_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_WRAP_ADDRESSMODE"
                );
            }
        }

        
        public static decimal TEXTURE_MIRROR_ADDRESSMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_MIRROR_ADDRESSMODE"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_ALPHA
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_ALPHA"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_LUMINANCE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_LUMINANCE_ALPHA
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE_ALPHA"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RGB
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RGBA
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_R
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_R"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RG
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RG"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RED_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED_INTEGER"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_R_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_R_INTEGER"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RG_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RG_INTEGER"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RGB_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB_INTEGER"
                );
            }
        }

        
        public static decimal TEXTUREFORMAT_RGBA_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA_INTEGER"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_BYTE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_BYTE"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_FLOAT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_HALF_FLOAT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_HALF_FLOAT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_BYTE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_BYTE"
                );
            }
        }

        
        public static decimal TEXTURETYPE_SHORT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_SHORT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_SHORT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_INT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_INT"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INTEGER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INTEGER"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_SHORT_5_6_5
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_6_5"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INT_24_8
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_24_8"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV"
                );
            }
        }

        
        public static decimal TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV"
                );
            }
        }

        
        public static decimal TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal TEXTURE_BILINEAR_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_BILINEAR_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal TEXTURE_TRILINEAR_SAMPLINGMODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_TRILINEAR_SAMPLINGMODE"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_NEAREST_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPLINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_LINEAR_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPNEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_LINEAR_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPLINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_NEAREST_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPNEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_LINEAR_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPNEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_LINEAR_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPLINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_LINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_NEAREST_NEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_NEAREST_MIPNEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPNEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_NEAREST_MIPLINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPLINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_LINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR"
                );
            }
        }

        
        public static decimal TEXTURE_LINEAR_NEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST"
                );
            }
        }

        
        public static decimal TEXTURE_EXPLICIT_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EXPLICIT_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_SPHERICAL_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SPHERICAL_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_PLANAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PLANAR_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_CUBIC_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CUBIC_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_PROJECTION_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PROJECTION_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_SKYBOX_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SKYBOX_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_INVCUBIC_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_INVCUBIC_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_EQUIRECTANGULAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EQUIRECTANGULAR_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_FIXED_EQUIRECTANGULAR_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MODE"
                );
            }
        }

        
        public static decimal TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE"
                );
            }
        }

        
        public static decimal SCALEMODE_FLOOR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_FLOOR"
                );
            }
        }

        
        public static decimal SCALEMODE_NEAREST
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_NEAREST"
                );
            }
        }

        
        public static decimal SCALEMODE_CEILING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_CEILING"
                );
            }
        }

        private static IAudioEngineCachedEntity __audioEngine;
        public static IAudioEngineCachedEntity audioEngine
        {
            get
            {
            if(__audioEngine == null)
            {
                __audioEngine = EventHorizonBlazorInteropt.GetClass<IAudioEngineCachedEntity>(
                    "BABYLON",
                    "Engine.audioEngine",
                    (entity) =>
                    {
                        return new IAudioEngineCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __audioEngine;
            }
            set
            {
__audioEngine = null;
                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Engine.audioEngine",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
// MarkAllMaterialsAsDirty is not supported by the platform yet

        public static ILoadingScreenCachedEntity DefaultLoadingScreenFactory(HTMLCanvasElementCachedEntity canvas)
        {
            return EventHorizonBlazorInteropt.FuncClass<ILoadingScreenCachedEntity>(
                entity => new ILoadingScreenCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Engine", "DefaultLoadingScreenFactory" }, canvas
                }
            );
        }

        #region AudioEngineFactory TODO: Get Comments as metadata identification
        private static bool IsAudioEngineFactoryEnabled = false;
        private static readonly IDictionary<string, Func<Task>> AudioEngineFactoryActionMap = new Dictionary<string, Func<Task>>();

        public static string AudioEngineFactory(
            Func<Task> callback
        )
        {
            SetupAudioEngineFactoryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            AudioEngineFactoryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupAudioEngineFactoryStaticLoop()
        {
            if (IsAudioEngineFactoryEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Engine.AudioEngineFactory",
                "CallAudioEngineFactoryStaticActions"
            );
            IsAudioEngineFactoryEnabled = true;
        }

        [JSInvokable]
        public static async Task CallAudioEngineFactoryStaticActions()
        {
            foreach (var action in AudioEngineFactoryActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region OfflineProviderFactory TODO: Get Comments as metadata identification
        private static bool IsOfflineProviderFactoryEnabled = false;
        private static readonly IDictionary<string, Func<Task>> OfflineProviderFactoryActionMap = new Dictionary<string, Func<Task>>();

        public static string OfflineProviderFactory(
            Func<Task> callback
        )
        {
            SetupOfflineProviderFactoryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            OfflineProviderFactoryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupOfflineProviderFactoryStaticLoop()
        {
            if (IsOfflineProviderFactoryEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Engine.OfflineProviderFactory",
                "CallOfflineProviderFactoryStaticActions"
            );
            IsOfflineProviderFactoryEnabled = true;
        }

        [JSInvokable]
        public static async Task CallOfflineProviderFactoryStaticActions()
        {
            foreach (var action in OfflineProviderFactoryActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion

        #region Accessors
        private PerformanceMonitor __performanceMonitor;
        public PerformanceMonitor performanceMonitor
        {
            get
            {
            if(__performanceMonitor == null)
            {
                __performanceMonitor = EventHorizonBlazorInteropt.GetClass<PerformanceMonitor>(
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

        private ILoadingScreenCachedEntity __loadingScreen;
        public ILoadingScreenCachedEntity loadingScreen
        {
            get
            {
            if(__loadingScreen == null)
            {
                __loadingScreen = EventHorizonBlazorInteropt.GetClass<ILoadingScreenCachedEntity>(
                    this.___guid,
                    "loadingScreen",
                    (entity) =>
                    {
                        return new ILoadingScreenCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __loadingScreen;
            }
            set
            {
__loadingScreen = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "loadingScreen",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public bool enableOfflineSupport
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableOfflineSupport"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableOfflineSupport",
                    value
                );
            }
        }

        
        public bool disableManifestCheck
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableManifestCheck"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableManifestCheck",
                    value
                );
            }
        }

        
        public Scene[] scenes
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Scene>(
                    this.___guid,
                    "scenes",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scenes",
                    value
                );
            }
        }

        private Observable<Scene> __onNewSceneAddedObservable;
        public Observable<Scene> onNewSceneAddedObservable
        {
            get
            {
            if(__onNewSceneAddedObservable == null)
            {
                __onNewSceneAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onNewSceneAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewSceneAddedObservable;
            }
            set
            {
__onNewSceneAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewSceneAddedObservable",
                    value
                );
            }
        }

        
        public PostProcess[] postProcesses
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "postProcesses",
                    value
                );
            }
        }

        
        public bool isPointerLock
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPointerLock"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isPointerLock",
                    value
                );
            }
        }

        private Observable<Engine> __onResizeObservable;
        public Observable<Engine> onResizeObservable
        {
            get
            {
            if(__onResizeObservable == null)
            {
                __onResizeObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onResizeObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onResizeObservable;
            }
            set
            {
__onResizeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onResizeObservable",
                    value
                );
            }
        }

        private Observable<Engine> __onCanvasBlurObservable;
        public Observable<Engine> onCanvasBlurObservable
        {
            get
            {
            if(__onCanvasBlurObservable == null)
            {
                __onCanvasBlurObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onCanvasBlurObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCanvasBlurObservable;
            }
            set
            {
__onCanvasBlurObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCanvasBlurObservable",
                    value
                );
            }
        }

        private Observable<Engine> __onCanvasFocusObservable;
        public Observable<Engine> onCanvasFocusObservable
        {
            get
            {
            if(__onCanvasFocusObservable == null)
            {
                __onCanvasFocusObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onCanvasFocusObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCanvasFocusObservable;
            }
            set
            {
__onCanvasFocusObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCanvasFocusObservable",
                    value
                );
            }
        }

        private Observable<PointerEvent> __onCanvasPointerOutObservable;
        public Observable<PointerEvent> onCanvasPointerOutObservable
        {
            get
            {
            if(__onCanvasPointerOutObservable == null)
            {
                __onCanvasPointerOutObservable = EventHorizonBlazorInteropt.GetClass<Observable<PointerEvent>>(
                    this.___guid,
                    "onCanvasPointerOutObservable",
                    (entity) =>
                    {
                        return new Observable<PointerEvent>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCanvasPointerOutObservable;
            }
            set
            {
__onCanvasPointerOutObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCanvasPointerOutObservable",
                    value
                );
            }
        }

        private Observable<Engine> __onBeginFrameObservable;
        public Observable<Engine> onBeginFrameObservable
        {
            get
            {
            if(__onBeginFrameObservable == null)
            {
                __onBeginFrameObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onBeginFrameObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeginFrameObservable;
            }
            set
            {
__onBeginFrameObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeginFrameObservable",
                    value
                );
            }
        }

        private ICustomAnimationFrameRequesterCachedEntity __customAnimationFrameRequester;
        public ICustomAnimationFrameRequesterCachedEntity customAnimationFrameRequester
        {
            get
            {
            if(__customAnimationFrameRequester == null)
            {
                __customAnimationFrameRequester = EventHorizonBlazorInteropt.GetClass<ICustomAnimationFrameRequesterCachedEntity>(
                    this.___guid,
                    "customAnimationFrameRequester",
                    (entity) =>
                    {
                        return new ICustomAnimationFrameRequesterCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __customAnimationFrameRequester;
            }
            set
            {
__customAnimationFrameRequester = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "customAnimationFrameRequester",
                    value
                );
            }
        }

        private Observable<Engine> __onEndFrameObservable;
        public Observable<Engine> onEndFrameObservable
        {
            get
            {
            if(__onEndFrameObservable == null)
            {
                __onEndFrameObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onEndFrameObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEndFrameObservable;
            }
            set
            {
__onEndFrameObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onEndFrameObservable",
                    value
                );
            }
        }

        private Observable<Engine> __onBeforeShaderCompilationObservable;
        public Observable<Engine> onBeforeShaderCompilationObservable
        {
            get
            {
            if(__onBeforeShaderCompilationObservable == null)
            {
                __onBeforeShaderCompilationObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onBeforeShaderCompilationObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeShaderCompilationObservable;
            }
            set
            {
__onBeforeShaderCompilationObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeShaderCompilationObservable",
                    value
                );
            }
        }

        private Observable<Engine> __onAfterShaderCompilationObservable;
        public Observable<Engine> onAfterShaderCompilationObservable
        {
            get
            {
            if(__onAfterShaderCompilationObservable == null)
            {
                __onAfterShaderCompilationObservable = EventHorizonBlazorInteropt.GetClass<Observable<Engine>>(
                    this.___guid,
                    "onAfterShaderCompilationObservable",
                    (entity) =>
                    {
                        return new Observable<Engine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterShaderCompilationObservable;
            }
            set
            {
__onAfterShaderCompilationObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterShaderCompilationObservable",
                    value
                );
            }
        }

        
        public decimal canvasTabIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "canvasTabIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "canvasTabIndex",
                    value
                );
            }
        }

        
        public bool disablePerformanceMonitorInBackground
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disablePerformanceMonitorInBackground"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disablePerformanceMonitorInBackground",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Engine() : base() { }

        public Engine(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Engine(
            HTMLCanvasElementCachedEntity canvasOrContext, System.Nullable<bool> antialias = null, EngineOptionsCachedEntity options = null, System.Nullable<bool> adaptToDeviceRatio = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Engine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity getInputElement()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getInputElement" }
                }
            );
        }

        public decimal getAspectRatio(IViewportOwnerLikeCachedEntity viewportOwner, System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAspectRatio" }, viewportOwner, useScreen
                }
            );
        }

        public decimal getScreenAspectRatio()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getScreenAspectRatio" }
                }
            );
        }

        public ClientRect getRenderingCanvasClientRect()
        {
            return EventHorizonBlazorInteropt.FuncClass<ClientRect>(
                entity => new ClientRect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingCanvasClientRect" }
                }
            );
        }

        public ClientRect getInputElementClientRect()
        {
            return EventHorizonBlazorInteropt.FuncClass<ClientRect>(
                entity => new ClientRect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInputElementClientRect" }
                }
            );
        }

        public bool isDeterministicLockStep()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDeterministicLockStep" }
                }
            );
        }

        public decimal getLockstepMaxSteps()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getLockstepMaxSteps" }
                }
            );
        }

        public decimal getTimeStep()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTimeStep" }
                }
            );
        }

        public void generateMipMapsForCubemap(InternalTexture texture, System.Nullable<bool> unbind = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "generateMipMapsForCubemap" }, texture, unbind
                }
            );
        }

        public void setState(bool culling, System.Nullable<decimal> zOffset = null, System.Nullable<bool> force = null, System.Nullable<bool> reverseSide = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setState" }, culling, zOffset, force, reverseSide
                }
            );
        }

        public void setZOffset(decimal value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setZOffset" }, value
                }
            );
        }

        public decimal getZOffset()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getZOffset" }
                }
            );
        }

        public void setDepthBuffer(bool enable)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthBuffer" }, enable
                }
            );
        }

        public bool getDepthWrite()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthWrite" }
                }
            );
        }

        public void setDepthWrite(bool enable)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthWrite" }, enable
                }
            );
        }

        public bool getStencilBuffer()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilBuffer" }
                }
            );
        }

        public void setStencilBuffer(bool enable)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilBuffer" }, enable
                }
            );
        }

        public decimal getStencilMask()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilMask" }
                }
            );
        }

        public void setStencilMask(decimal mask)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilMask" }, mask
                }
            );
        }

        public decimal getStencilFunction()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunction" }
                }
            );
        }

        public decimal getStencilFunctionReference()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunctionReference" }
                }
            );
        }

        public decimal getStencilFunctionMask()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunctionMask" }
                }
            );
        }

        public void setStencilFunction(decimal stencilFunc)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunction" }, stencilFunc
                }
            );
        }

        public void setStencilFunctionReference(decimal reference)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunctionReference" }, reference
                }
            );
        }

        public void setStencilFunctionMask(decimal mask)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunctionMask" }, mask
                }
            );
        }

        public decimal getStencilOperationFail()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationFail" }
                }
            );
        }

        public decimal getStencilOperationDepthFail()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationDepthFail" }
                }
            );
        }

        public decimal getStencilOperationPass()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationPass" }
                }
            );
        }

        public void setStencilOperationFail(decimal operation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationFail" }, operation
                }
            );
        }

        public void setStencilOperationDepthFail(decimal operation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationDepthFail" }, operation
                }
            );
        }

        public void setStencilOperationPass(decimal operation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationPass" }, operation
                }
            );
        }

        public void setDitheringState(bool value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDitheringState" }, value
                }
            );
        }

        public void setRasterizerState(bool value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRasterizerState" }, value
                }
            );
        }

        public decimal getDepthFunction()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthFunction" }
                }
            );
        }

        public void setDepthFunction(decimal depthFunc)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunction" }, depthFunc
                }
            );
        }

        public void setDepthFunctionToGreater()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToGreater" }
                }
            );
        }

        public void setDepthFunctionToGreaterOrEqual()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToGreaterOrEqual" }
                }
            );
        }

        public void setDepthFunctionToLess()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToLess" }
                }
            );
        }

        public void setDepthFunctionToLessOrEqual()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToLessOrEqual" }
                }
            );
        }

        public void cacheStencilState()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cacheStencilState" }
                }
            );
        }

        public void restoreStencilState()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreStencilState" }
                }
            );
        }

        public IViewportLikeCachedEntity setDirectViewport(decimal x, decimal y, decimal width, decimal height)
        {
            return EventHorizonBlazorInteropt.FuncClass<IViewportLikeCachedEntity>(
                entity => new IViewportLikeCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectViewport" }, x, y, width, height
                }
            );
        }

        public void scissorClear(decimal x, decimal y, decimal width, decimal height, IColor4LikeCachedEntity clearColor)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scissorClear" }, x, y, width, height, clearColor
                }
            );
        }

        public void enableScissor(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableScissor" }, x, y, width, height
                }
            );
        }

        public void disableScissor()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableScissor" }
                }
            );
        }

        public Observable<IDisplayChangedEventArgsCachedEntity> initWebVR()
        {
            return EventHorizonBlazorInteropt.FuncClass<Observable<IDisplayChangedEventArgsCachedEntity>>(
                entity => new Observable<IDisplayChangedEventArgsCachedEntity>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "initWebVR" }
                }
            );
        }

        public void disableVR()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableVR" }
                }
            );
        }

        public bool isVRPresenting()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVRPresenting" }
                }
            );
        }

        public string getVertexShaderSource(WebGLProgramCachedEntity program)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getVertexShaderSource" }, program
                }
            );
        }

        public string getFragmentShaderSource(WebGLProgramCachedEntity program)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getFragmentShaderSource" }, program
                }
            );
        }

        public void setDepthStencilTexture(decimal channel, WebGLUniformLocationCachedEntity uniform, RenderTargetTexture texture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthStencilTexture" }, channel, uniform, texture
                }
            );
        }

        public void setTextureFromPostProcess(decimal channel, PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcess" }, channel, postProcess
                }
            );
        }

        public void setTextureFromPostProcessOutput(decimal channel, PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcessOutput" }, channel, postProcess
                }
            );
        }

        public void switchFullscreen(bool requestPointerLock)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchFullscreen" }, requestPointerLock
                }
            );
        }

        public void enterFullscreen(bool requestPointerLock)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enterFullscreen" }, requestPointerLock
                }
            );
        }

        public void exitFullscreen()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "exitFullscreen" }
                }
            );
        }

        public void enterPointerlock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enterPointerlock" }
                }
            );
        }

        public void exitPointerlock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "exitPointerlock" }
                }
            );
        }

        public void beginFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public void endFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endFrame" }
                }
            );
        }

        public void resize()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }

        public void setSize(decimal width, decimal height)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public void updateDynamicVertexBuffer(DataBuffer vertexBuffer, DataArray data, System.Nullable<decimal> byteOffset = null, System.Nullable<decimal> byteLength = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDynamicVertexBuffer" }, vertexBuffer, data, byteOffset, byteLength
                }
            );
        }

        public WebGLProgramCachedEntity createShaderProgram(IPipelineContextCachedEntity pipelineContext, string vertexCode, string fragmentCode, string defines = null, WebGLRenderingContextCachedEntity context = null, string[] transformFeedbackVaryings = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createShaderProgram" }, pipelineContext, vertexCode, fragmentCode, defines, context, transformFeedbackVaryings
                }
            );
        }

        public decimal getFps()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFps" }
                }
            );
        }

        public decimal getDeltaTime()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDeltaTime" }
                }
            );
        }

        public void updateDynamicIndexBuffer(DataBuffer indexBuffer, decimal[] indices, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDynamicIndexBuffer" }, indexBuffer, indices, offset
                }
            );
        }

        public decimal updateRenderTargetTextureSampleCount(InternalTexture texture, decimal samples)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "updateRenderTargetTextureSampleCount" }, texture, samples
                }
            );
        }

        public void updateTextureComparisonFunction(InternalTexture texture, decimal comparisonFunction)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureComparisonFunction" }, texture, comparisonFunction
                }
            );
        }

        public DataBuffer createInstancesBuffer(decimal capacity)
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createInstancesBuffer" }, capacity
                }
            );
        }

        public void deleteInstancesBuffer(WebGLBuffer buffer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteInstancesBuffer" }, buffer
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void displayLoadingUI()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "displayLoadingUI" }
                }
            );
        }

        public void hideLoadingUI()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "hideLoadingUI" }
                }
            );
        }
        #endregion
    }
}