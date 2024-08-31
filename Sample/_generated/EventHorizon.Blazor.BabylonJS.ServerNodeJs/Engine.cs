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

    [JsonConverter(typeof(CachedEntityConverter<Engine>))]
    public class Engine : ThinEngine
    {
        #region Static Accessors

        public static async ValueTask<string> get_NpmPackage()
        {
            return await EventHorizonBlazorInterop.Get<string>("BABYLON", "Engine.NpmPackage");
        }

        public static async ValueTask<string> get_Version()
        {
            return await EventHorizonBlazorInterop.Get<string>("BABYLON", "Engine.Version");
        }

        public static async ValueTask<AbstractEngine[]> get_Instances()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractEngine>(
                "BABYLON",
                "Engine.Instances",
                (entity) =>
                {
                    return new AbstractEngine() { ___guid = entity.___guid };
                }
            );
        }

        private static AbstractEngine __LastCreatedEngine;

        public static async ValueTask<AbstractEngine> get_LastCreatedEngine()
        {
            if (__LastCreatedEngine == null)
            {
                __LastCreatedEngine = await EventHorizonBlazorInterop.GetClass<AbstractEngine>(
                    "BABYLON",
                    "Engine.LastCreatedEngine",
                    (entity) =>
                    {
                        return new AbstractEngine() { ___guid = entity.___guid };
                    }
                );
            }
            return __LastCreatedEngine;
        }

        private static Scene __LastCreatedScene;

        public static async ValueTask<Scene> get_LastCreatedScene()
        {
            if (__LastCreatedScene == null)
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
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_DISABLE");
        }

        public static async ValueTask<decimal> get_ALPHA_ADD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_ADD");
        }

        public static async ValueTask<decimal> get_ALPHA_COMBINE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_COMBINE");
        }

        public static async ValueTask<decimal> get_ALPHA_SUBTRACT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_SUBTRACT");
        }

        public static async ValueTask<decimal> get_ALPHA_MULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_MULTIPLY");
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
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_ONEONE");
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
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.NEVER");
        }

        public static async ValueTask<decimal> get_ALWAYS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALWAYS");
        }

        public static async ValueTask<decimal> get_LESS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.LESS");
        }

        public static async ValueTask<decimal> get_EQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.EQUAL");
        }

        public static async ValueTask<decimal> get_LEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.LEQUAL");
        }

        public static async ValueTask<decimal> get_GREATER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.GREATER");
        }

        public static async ValueTask<decimal> get_GEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.GEQUAL");
        }

        public static async ValueTask<decimal> get_NOTEQUAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.NOTEQUAL");
        }

        public static async ValueTask<decimal> get_KEEP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.KEEP");
        }

        public static async ValueTask<decimal> get_REPLACE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.REPLACE");
        }

        public static async ValueTask<decimal> get_INCR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INCR");
        }

        public static async ValueTask<decimal> get_DECR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.DECR");
        }

        public static async ValueTask<decimal> get_INVERT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INVERT");
        }

        public static async ValueTask<decimal> get_INCR_WRAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INCR_WRAP");
        }

        public static async ValueTask<decimal> get_DECR_WRAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.DECR_WRAP");
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
        #endregion

        #region Static Methods
        public static async ValueTask MarkAllMaterialsAsDirty(
            decimal flag,
            ActionResultCallback<Material, bool> predicate = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Engine", "MarkAllMaterialsAsDirty" },
                    flag,
                    predicate
                }
            );
        }

        public static async ValueTask<ILoadingScreenCachedEntity> DefaultLoadingScreenFactory(
            HTMLCanvasElement canvas
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ILoadingScreenCachedEntity>(
                entity => new ILoadingScreenCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Engine", "DefaultLoadingScreenFactory" },
                    canvas
                }
            );
        }
        #endregion

        #region Accessors
        private PerformanceMonitor __performanceMonitor;

        public async ValueTask<PerformanceMonitor> get_performanceMonitor()
        {
            if (__performanceMonitor == null)
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
        #endregion

        #region Properties
        private ICustomAnimationFrameRequesterCachedEntity __customAnimationFrameRequester;

        public async ValueTask<ICustomAnimationFrameRequesterCachedEntity> get_customAnimationFrameRequester()
        {
            if (__customAnimationFrameRequester == null)
            {
                __customAnimationFrameRequester =
                    await EventHorizonBlazorInterop.GetClass<ICustomAnimationFrameRequesterCachedEntity>(
                        this.___guid,
                        "customAnimationFrameRequester",
                        (entity) =>
                        {
                            return new ICustomAnimationFrameRequesterCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __customAnimationFrameRequester;
        }

        public ValueTask set_customAnimationFrameRequester(
            ICustomAnimationFrameRequesterCachedEntity value
        )
        {
            __customAnimationFrameRequester = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "customAnimationFrameRequester",
                value
            );
        }
        #endregion

        #region Constructor
        public Engine()
            : base() { }

        public Engine(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Engine> NewEngine(
            HTMLCanvasElement canvasOrContext,
            System.Nullable<bool> antialias = null,
            EngineOptions options = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Engine" },
                canvasOrContext,
                antialias,
                options,
                adaptToDeviceRatio
            );

            return new Engine(entity);
        }

        public static async ValueTask<Engine> NewEngine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Engine" },
                antialias,
                options,
                adaptToDeviceRatio
            );

            return new Engine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal[]> resizeImageBitmap(
            HTMLImageElement image,
            decimal bufferWidth,
            decimal bufferHeight
        )
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "resizeImageBitmap" },
                    image,
                    bufferWidth,
                    bufferHeight
                }
            );
        }

        public async ValueTask switchFullscreen(bool requestPointerLock)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "switchFullscreen" },
                    requestPointerLock
                }
            );
        }

        public async ValueTask enterFullscreen(bool requestPointerLock)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enterFullscreen" },
                    requestPointerLock
                }
            );
        }

        public async ValueTask exitFullscreen()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exitFullscreen" } }
            );
        }

        public async ValueTask setDitheringState(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDitheringState" }, value }
            );
        }

        public async ValueTask setRasterizerState(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setRasterizerState" }, value }
            );
        }

        public async ValueTask<IViewportLikeCachedEntity> setDirectViewport(
            decimal x,
            decimal y,
            decimal width,
            decimal height
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IViewportLikeCachedEntity>(
                entity => new IViewportLikeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDirectViewport" },
                    x,
                    y,
                    width,
                    height
                }
            );
        }

        public async ValueTask scissorClear(
            decimal x,
            decimal y,
            decimal width,
            decimal height,
            IColor4Like clearColor
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scissorClear" },
                    x,
                    y,
                    width,
                    height,
                    clearColor
                }
            );
        }

        public async ValueTask enableScissor(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableScissor" }, x, y, width, height }
            );
        }

        public async ValueTask disableScissor()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disableScissor" } }
            );
        }

        public async ValueTask<string> getVertexShaderSource(WebGLProgram program)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getVertexShaderSource" }, program }
            );
        }

        public async ValueTask<string> getFragmentShaderSource(WebGLProgram program)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getFragmentShaderSource" }, program }
            );
        }

        public async ValueTask<CachedEntity> getFontOffset(string font)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getFontOffset" }, font }
            );
        }

        public async ValueTask enterPointerlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enterPointerlock" } }
            );
        }

        public async ValueTask exitPointerlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exitPointerlock" } }
            );
        }

        public async ValueTask beginFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginFrame" } }
            );
        }

        public async ValueTask<WebGLProgramCachedEntity> createShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            string defines = null,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
                entity => new WebGLProgramCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createShaderProgram" },
                    pipelineContext,
                    vertexCode,
                    fragmentCode,
                    defines,
                    context,
                    transformFeedbackVaryings
                }
            );
        }

        public async ValueTask<InternalTexture> wrapWebGLTexture(
            WebGLTexture texture,
            System.Nullable<bool> hasMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "wrapWebGLTexture" },
                    texture,
                    hasMipMaps,
                    samplingMode,
                    width,
                    height
                }
            );
        }

        public async ValueTask updateTextureComparisonFunction(
            InternalTexture texture,
            decimal comparisonFunction
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureComparisonFunction" },
                    texture,
                    comparisonFunction
                }
            );
        }

        public async ValueTask<DataBuffer> createInstancesBuffer(decimal capacity)
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createInstancesBuffer" }, capacity }
            );
        }

        public async ValueTask deleteInstancesBuffer(WebGLBuffer buffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "deleteInstancesBuffer" }, buffer }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
