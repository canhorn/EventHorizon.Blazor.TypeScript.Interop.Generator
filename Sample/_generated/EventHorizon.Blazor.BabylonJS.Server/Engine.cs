/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Engine>))]
    public class Engine : ThinEngine
    {
        #region Static Accessors
        
        public static async ValueTask<string> get_NpmPackage()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Engine.NpmPackage"
                );
        }

        
        public static async ValueTask<string> get_Version()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Engine.Version"
                );
        }

        
        public static async ValueTask<Engine[]> get_Instances()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Engine>(
                    "BABYLON",
                    "Engine.Instances",
                    (entity) =>
                    {
                        return new Engine() { ___guid = entity.___guid };
                    }
                );
        }

        private static Engine __LastCreatedEngine;
        public static async ValueTask<Engine> get_LastCreatedEngine()
        {
            if(__LastCreatedEngine == null)
            {
                __LastCreatedEngine = await EventHorizonBlazorInterop.GetClass<Engine>(
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

        private static Scene __LastCreatedScene;
        public static async ValueTask<Scene> get_LastCreatedScene()
        {
            if(__LastCreatedScene == null)
            {
                __LastCreatedScene = await EventHorizonBlazorInterop.GetClass<Scene>(
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
        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_ALPHA_DISABLE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_DISABLE"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_ADD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_ADD"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_COMBINE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_COMBINE"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_SUBTRACT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_SUBTRACT"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_MULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_MULTIPLY"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_MAXIMIZED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_MAXIMIZED"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_ONEONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_ONEONE"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_PREMULTIPLIED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_PREMULTIPLIED_PORTERDUFF()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED_PORTERDUFF"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_INTERPOLATE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_INTERPOLATE"
                );
        }

        
        public static async ValueTask<decimal> get_ALPHA_SCREENMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_SCREENMODE"
                );
        }

        
        public static async ValueTask<decimal> get_DELAYLOADSTATE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_DELAYLOADSTATE_LOADED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADED"
                );
        }

        
        public static async ValueTask<decimal> get_DELAYLOADSTATE_LOADING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADING"
                );
        }

        
        public static async ValueTask<decimal> get_DELAYLOADSTATE_NOTLOADED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NOTLOADED"
                );
        }

        
        public static async ValueTask<decimal> get_NEVER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.NEVER"
                );
        }

        
        public static async ValueTask<decimal> get_ALWAYS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALWAYS"
                );
        }

        
        public static async ValueTask<decimal> get_LESS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.LESS"
                );
        }

        
        public static async ValueTask<decimal> get_EQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.EQUAL"
                );
        }

        
        public static async ValueTask<decimal> get_LEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.LEQUAL"
                );
        }

        
        public static async ValueTask<decimal> get_GREATER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.GREATER"
                );
        }

        
        public static async ValueTask<decimal> get_GEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.GEQUAL"
                );
        }

        
        public static async ValueTask<decimal> get_NOTEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.NOTEQUAL"
                );
        }

        
        public static async ValueTask<decimal> get_KEEP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.KEEP"
                );
        }

        
        public static async ValueTask<decimal> get_REPLACE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.REPLACE"
                );
        }

        
        public static async ValueTask<decimal> get_INCR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.INCR"
                );
        }

        
        public static async ValueTask<decimal> get_DECR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DECR"
                );
        }

        
        public static async ValueTask<decimal> get_INVERT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.INVERT"
                );
        }

        
        public static async ValueTask<decimal> get_INCR_WRAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.INCR_WRAP"
                );
        }

        
        public static async ValueTask<decimal> get_DECR_WRAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DECR_WRAP"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_CLAMP_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CLAMP_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_WRAP_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_WRAP_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_MIRROR_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_MIRROR_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_ALPHA()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_ALPHA"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_LUMINANCE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_LUMINANCE_ALPHA()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE_ALPHA"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RGB()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RGBA()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_R()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_R"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RG()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RG"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RED_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_R_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_R_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RG_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RG_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RGB_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTUREFORMAT_RGBA_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_BYTE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_BYTE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_FLOAT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_HALF_FLOAT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_HALF_FLOAT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_BYTE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_BYTE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_SHORT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_SHORT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_SHORT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_INT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_INT"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INTEGER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INTEGER"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_SHORT_5_6_5()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_6_5"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INT_24_8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_24_8"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_BILINEAR_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_BILINEAR_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_TRILINEAR_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_TRILINEAR_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_NEAREST_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_LINEAR_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_LINEAR_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_NEAREST_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_LINEAR_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_LINEAR_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_NEAREST_NEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_NEAREST_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_NEAREST_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_LINEAR_NEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_EXPLICIT_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EXPLICIT_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_SPHERICAL_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SPHERICAL_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_PLANAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PLANAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_CUBIC_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CUBIC_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_PROJECTION_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PROJECTION_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_SKYBOX_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SKYBOX_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_INVCUBIC_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_INVCUBIC_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_EQUIRECTANGULAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EQUIRECTANGULAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_FIXED_EQUIRECTANGULAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_SCALEMODE_FLOOR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_FLOOR"
                );
        }

        
        public static async ValueTask<decimal> get_SCALEMODE_NEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_NEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_SCALEMODE_CEILING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_CEILING"
                );
        }

        private static IAudioEngineCachedEntity __audioEngine;
        public static async ValueTask<IAudioEngineCachedEntity> get_audioEngine()
        {
            if(__audioEngine == null)
            {
                __audioEngine = await EventHorizonBlazorInterop.GetClass<IAudioEngineCachedEntity>(
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
        public static ValueTask set_audioEngine(IAudioEngineCachedEntity value)
        {
__audioEngine = null;
                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Engine.audioEngine",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask MarkAllMaterialsAsDirty(decimal flag, ActionCallback<Material> predicate = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Engine", "MarkAllMaterialsAsDirty" }, flag, predicate
                }
            );
        }

        public static async ValueTask<ILoadingScreenCachedEntity> DefaultLoadingScreenFactory(HTMLCanvasElement canvas)
        {
            return await EventHorizonBlazorInterop.FuncClass<ILoadingScreenCachedEntity>(
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

        public static async ValueTask<string> AudioEngineFactory(
            Func<Task> callback
        )
        {
            await SetupAudioEngineFactoryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            AudioEngineFactoryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static async ValueTask SetupAudioEngineFactoryStaticLoop()
        {
            if (IsAudioEngineFactoryEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.Server",
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

        public static async ValueTask<string> OfflineProviderFactory(
            Func<Task> callback
        )
        {
            await SetupOfflineProviderFactoryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            OfflineProviderFactoryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static async ValueTask SetupOfflineProviderFactoryStaticLoop()
        {
            if (IsOfflineProviderFactoryEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.Server",
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
        public async ValueTask<PerformanceMonitor> get_performanceMonitor()
        {
            if(__performanceMonitor == null)
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

        private ILoadingScreenCachedEntity __loadingScreen;
        public async ValueTask<ILoadingScreenCachedEntity> get_loadingScreen()
        {
            if(__loadingScreen == null)
            {
                __loadingScreen = await EventHorizonBlazorInterop.GetClass<ILoadingScreenCachedEntity>(
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
        public ValueTask set_loadingScreen(ILoadingScreenCachedEntity value)
        {
__loadingScreen = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingScreen",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_enableOfflineSupport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableOfflineSupport"
                );
        }
        public ValueTask set_enableOfflineSupport(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableOfflineSupport",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableManifestCheck()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableManifestCheck"
                );
        }
        public ValueTask set_disableManifestCheck(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableManifestCheck",
                    value
                );
        }

        
        public async ValueTask<Scene[]> get_scenes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Scene>(
                    this.___guid,
                    "scenes",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_scenes(Scene[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scenes",
                    value
                );
        }

        private Observable<Scene> __onNewSceneAddedObservable;
        public async ValueTask<Observable<Scene>> get_onNewSceneAddedObservable()
        {
            if(__onNewSceneAddedObservable == null)
            {
                __onNewSceneAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onNewSceneAddedObservable(Observable<Scene> value)
        {
__onNewSceneAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewSceneAddedObservable",
                    value
                );
        }

        
        public async ValueTask<PostProcess[]> get_postProcesses()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_postProcesses(PostProcess[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcesses",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPointerLock()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPointerLock"
                );
        }
        public ValueTask set_isPointerLock(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPointerLock",
                    value
                );
        }

        private Observable<Engine> __onResizeObservable;
        public async ValueTask<Observable<Engine>> get_onResizeObservable()
        {
            if(__onResizeObservable == null)
            {
                __onResizeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onResizeObservable(Observable<Engine> value)
        {
__onResizeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onResizeObservable",
                    value
                );
        }

        private Observable<Engine> __onCanvasBlurObservable;
        public async ValueTask<Observable<Engine>> get_onCanvasBlurObservable()
        {
            if(__onCanvasBlurObservable == null)
            {
                __onCanvasBlurObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onCanvasBlurObservable(Observable<Engine> value)
        {
__onCanvasBlurObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCanvasBlurObservable",
                    value
                );
        }

        private Observable<Engine> __onCanvasFocusObservable;
        public async ValueTask<Observable<Engine>> get_onCanvasFocusObservable()
        {
            if(__onCanvasFocusObservable == null)
            {
                __onCanvasFocusObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onCanvasFocusObservable(Observable<Engine> value)
        {
__onCanvasFocusObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCanvasFocusObservable",
                    value
                );
        }

        private Observable<PointerEvent> __onCanvasPointerOutObservable;
        public async ValueTask<Observable<PointerEvent>> get_onCanvasPointerOutObservable()
        {
            if(__onCanvasPointerOutObservable == null)
            {
                __onCanvasPointerOutObservable = await EventHorizonBlazorInterop.GetClass<Observable<PointerEvent>>(
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
        public ValueTask set_onCanvasPointerOutObservable(Observable<PointerEvent> value)
        {
__onCanvasPointerOutObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCanvasPointerOutObservable",
                    value
                );
        }

        private Observable<Engine> __onBeginFrameObservable;
        public async ValueTask<Observable<Engine>> get_onBeginFrameObservable()
        {
            if(__onBeginFrameObservable == null)
            {
                __onBeginFrameObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onBeginFrameObservable(Observable<Engine> value)
        {
__onBeginFrameObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeginFrameObservable",
                    value
                );
        }

        private ICustomAnimationFrameRequesterCachedEntity __customAnimationFrameRequester;
        public async ValueTask<ICustomAnimationFrameRequesterCachedEntity> get_customAnimationFrameRequester()
        {
            if(__customAnimationFrameRequester == null)
            {
                __customAnimationFrameRequester = await EventHorizonBlazorInterop.GetClass<ICustomAnimationFrameRequesterCachedEntity>(
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
        public ValueTask set_customAnimationFrameRequester(ICustomAnimationFrameRequesterCachedEntity value)
        {
__customAnimationFrameRequester = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customAnimationFrameRequester",
                    value
                );
        }

        private Observable<Engine> __onEndFrameObservable;
        public async ValueTask<Observable<Engine>> get_onEndFrameObservable()
        {
            if(__onEndFrameObservable == null)
            {
                __onEndFrameObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onEndFrameObservable(Observable<Engine> value)
        {
__onEndFrameObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onEndFrameObservable",
                    value
                );
        }

        private Observable<Engine> __onBeforeShaderCompilationObservable;
        public async ValueTask<Observable<Engine>> get_onBeforeShaderCompilationObservable()
        {
            if(__onBeforeShaderCompilationObservable == null)
            {
                __onBeforeShaderCompilationObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onBeforeShaderCompilationObservable(Observable<Engine> value)
        {
__onBeforeShaderCompilationObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShaderCompilationObservable",
                    value
                );
        }

        private Observable<Engine> __onAfterShaderCompilationObservable;
        public async ValueTask<Observable<Engine>> get_onAfterShaderCompilationObservable()
        {
            if(__onAfterShaderCompilationObservable == null)
            {
                __onAfterShaderCompilationObservable = await EventHorizonBlazorInterop.GetClass<Observable<Engine>>(
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
        public ValueTask set_onAfterShaderCompilationObservable(Observable<Engine> value)
        {
__onAfterShaderCompilationObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShaderCompilationObservable",
                    value
                );
        }

        
        public async ValueTask<decimal> get_canvasTabIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "canvasTabIndex"
                );
        }
        public ValueTask set_canvasTabIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvasTabIndex",
                    value
                );
        }

        
        public async ValueTask<bool> get_disablePerformanceMonitorInBackground()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disablePerformanceMonitorInBackground"
                );
        }
        public ValueTask set_disablePerformanceMonitorInBackground(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disablePerformanceMonitorInBackground",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Engine() : base() { }

        public Engine(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Engine> NewEngine(
            HTMLCanvasElement canvasOrContext, System.Nullable<bool> antialias = null, EngineOptions options = null, System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Engine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );

            return new Engine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<CachedEntity> getInputElement()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getInputElement" }
                }
            );
        }

        public async ValueTask<decimal> getAspectRatio(IViewportOwnerLike viewportOwner, System.Nullable<bool> useScreen = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAspectRatio" }, viewportOwner, useScreen
                }
            );
        }

        public async ValueTask<decimal> getScreenAspectRatio()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getScreenAspectRatio" }
                }
            );
        }

        public async ValueTask<ClientRect> getRenderingCanvasClientRect()
        {
            return await EventHorizonBlazorInterop.FuncClass<ClientRect>(
                entity => new ClientRect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingCanvasClientRect" }
                }
            );
        }

        public async ValueTask<ClientRect> getInputElementClientRect()
        {
            return await EventHorizonBlazorInterop.FuncClass<ClientRect>(
                entity => new ClientRect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInputElementClientRect" }
                }
            );
        }

        public async ValueTask<bool> isDeterministicLockStep()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDeterministicLockStep" }
                }
            );
        }

        public async ValueTask<decimal> getLockstepMaxSteps()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getLockstepMaxSteps" }
                }
            );
        }

        public async ValueTask<decimal> getTimeStep()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTimeStep" }
                }
            );
        }

        public async ValueTask generateMipMapsForCubemap(InternalTexture texture, System.Nullable<bool> unbind = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "generateMipMapsForCubemap" }, texture, unbind
                }
            );
        }

        public async ValueTask setState(bool culling, System.Nullable<decimal> zOffset = null, System.Nullable<bool> force = null, System.Nullable<bool> reverseSide = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setState" }, culling, zOffset, force, reverseSide
                }
            );
        }

        public async ValueTask setZOffset(decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setZOffset" }, value
                }
            );
        }

        public async ValueTask<decimal> getZOffset()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getZOffset" }
                }
            );
        }

        public async ValueTask setDepthBuffer(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthBuffer" }, enable
                }
            );
        }

        public async ValueTask<bool> getDepthWrite()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthWrite" }
                }
            );
        }

        public async ValueTask setDepthWrite(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthWrite" }, enable
                }
            );
        }

        public async ValueTask<bool> getStencilBuffer()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilBuffer" }
                }
            );
        }

        public async ValueTask setStencilBuffer(bool enable)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilBuffer" }, enable
                }
            );
        }

        public async ValueTask<decimal> getStencilMask()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilMask" }
                }
            );
        }

        public async ValueTask setStencilMask(decimal mask)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilMask" }, mask
                }
            );
        }

        public async ValueTask<decimal> getStencilFunction()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunction" }
                }
            );
        }

        public async ValueTask<decimal> getStencilFunctionReference()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunctionReference" }
                }
            );
        }

        public async ValueTask<decimal> getStencilFunctionMask()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilFunctionMask" }
                }
            );
        }

        public async ValueTask setStencilFunction(decimal stencilFunc)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunction" }, stencilFunc
                }
            );
        }

        public async ValueTask setStencilFunctionReference(decimal reference)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunctionReference" }, reference
                }
            );
        }

        public async ValueTask setStencilFunctionMask(decimal mask)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilFunctionMask" }, mask
                }
            );
        }

        public async ValueTask<decimal> getStencilOperationFail()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationFail" }
                }
            );
        }

        public async ValueTask<decimal> getStencilOperationDepthFail()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationDepthFail" }
                }
            );
        }

        public async ValueTask<decimal> getStencilOperationPass()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStencilOperationPass" }
                }
            );
        }

        public async ValueTask setStencilOperationFail(decimal operation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationFail" }, operation
                }
            );
        }

        public async ValueTask setStencilOperationDepthFail(decimal operation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationDepthFail" }, operation
                }
            );
        }

        public async ValueTask setStencilOperationPass(decimal operation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStencilOperationPass" }, operation
                }
            );
        }

        public async ValueTask setDitheringState(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDitheringState" }, value
                }
            );
        }

        public async ValueTask setRasterizerState(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRasterizerState" }, value
                }
            );
        }

        public async ValueTask<decimal> getDepthFunction()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthFunction" }
                }
            );
        }

        public async ValueTask setDepthFunction(decimal depthFunc)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunction" }, depthFunc
                }
            );
        }

        public async ValueTask setDepthFunctionToGreater()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToGreater" }
                }
            );
        }

        public async ValueTask setDepthFunctionToGreaterOrEqual()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToGreaterOrEqual" }
                }
            );
        }

        public async ValueTask setDepthFunctionToLess()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToLess" }
                }
            );
        }

        public async ValueTask setDepthFunctionToLessOrEqual()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthFunctionToLessOrEqual" }
                }
            );
        }

        public async ValueTask cacheStencilState()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cacheStencilState" }
                }
            );
        }

        public async ValueTask restoreStencilState()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreStencilState" }
                }
            );
        }

        public async ValueTask<IViewportLikeCachedEntity> setDirectViewport(decimal x, decimal y, decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.FuncClass<IViewportLikeCachedEntity>(
                entity => new IViewportLikeCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectViewport" }, x, y, width, height
                }
            );
        }

        public async ValueTask scissorClear(decimal x, decimal y, decimal width, decimal height, IColor4Like clearColor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scissorClear" }, x, y, width, height, clearColor
                }
            );
        }

        public async ValueTask enableScissor(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableScissor" }, x, y, width, height
                }
            );
        }

        public async ValueTask disableScissor()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableScissor" }
                }
            );
        }

        public async ValueTask<Observable<IDisplayChangedEventArgsCachedEntity>> initWebVR()
        {
            return await EventHorizonBlazorInterop.FuncClass<Observable<IDisplayChangedEventArgsCachedEntity>>(
                entity => new Observable<IDisplayChangedEventArgsCachedEntity>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "initWebVR" }
                }
            );
        }

        public async ValueTask disableVR()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableVR" }
                }
            );
        }

        public async ValueTask<bool> isVRPresenting()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVRPresenting" }
                }
            );
        }

        public async ValueTask<string> getVertexShaderSource(WebGLProgram program)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getVertexShaderSource" }, program
                }
            );
        }

        public async ValueTask<string> getFragmentShaderSource(WebGLProgram program)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getFragmentShaderSource" }, program
                }
            );
        }

        public async ValueTask setDepthStencilTexture(decimal channel, WebGLUniformLocation uniform, RenderTargetTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthStencilTexture" }, channel, uniform, texture
                }
            );
        }

        public async ValueTask setTextureFromPostProcess(decimal channel, PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcess" }, channel, postProcess
                }
            );
        }

        public async ValueTask setTextureFromPostProcessOutput(decimal channel, PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcessOutput" }, channel, postProcess
                }
            );
        }

        public async ValueTask switchFullscreen(bool requestPointerLock)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchFullscreen" }, requestPointerLock
                }
            );
        }

        public async ValueTask enterFullscreen(bool requestPointerLock)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enterFullscreen" }, requestPointerLock
                }
            );
        }

        public async ValueTask exitFullscreen()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "exitFullscreen" }
                }
            );
        }

        public async ValueTask enterPointerlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enterPointerlock" }
                }
            );
        }

        public async ValueTask exitPointerlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "exitPointerlock" }
                }
            );
        }

        public async ValueTask beginFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public async ValueTask endFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endFrame" }
                }
            );
        }

        public async ValueTask resize()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }

        public async ValueTask<bool> setSize(decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public async ValueTask<WebGLProgramCachedEntity> createShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, string defines = null, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createShaderProgram" }, pipelineContext, vertexCode, fragmentCode, defines, context, transformFeedbackVaryings
                }
            );
        }

        public async ValueTask<decimal> getFps()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFps" }
                }
            );
        }

        public async ValueTask<decimal> getDeltaTime()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDeltaTime" }
                }
            );
        }

        public async ValueTask<decimal> updateRenderTargetTextureSampleCount(InternalTexture texture, decimal samples)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "updateRenderTargetTextureSampleCount" }, texture, samples
                }
            );
        }

        public async ValueTask updateTextureComparisonFunction(InternalTexture texture, decimal comparisonFunction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureComparisonFunction" }, texture, comparisonFunction
                }
            );
        }

        public async ValueTask<DataBuffer> createInstancesBuffer(decimal capacity)
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createInstancesBuffer" }, capacity
                }
            );
        }

        public async ValueTask deleteInstancesBuffer(WebGLBuffer buffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteInstancesBuffer" }, buffer
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask displayLoadingUI()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "displayLoadingUI" }
                }
            );
        }

        public async ValueTask hideLoadingUI()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "hideLoadingUI" }
                }
            );
        }
        #endregion
    }
}