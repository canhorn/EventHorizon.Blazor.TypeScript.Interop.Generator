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

    [JsonConverter(typeof(CachedEntityConverter<Engine>))]
    public class Engine : ThinEngine
    {
        #region Static Accessors

        public static string NpmPackage
        {
            get { return EventHorizonBlazorInterop.Get<string>("BABYLON", "Engine.NpmPackage"); }
        }

        public static string Version
        {
            get { return EventHorizonBlazorInterop.Get<string>("BABYLON", "Engine.Version"); }
        }

        public static AbstractEngine[] Instances
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<AbstractEngine>(
                    "BABYLON",
                    "Engine.Instances",
                    (entity) =>
                    {
                        return new AbstractEngine() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private static AbstractEngine __LastCreatedEngine;
        public static AbstractEngine LastCreatedEngine
        {
            get
            {
                if (__LastCreatedEngine == null)
                {
                    __LastCreatedEngine = EventHorizonBlazorInterop.GetClass<AbstractEngine>(
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
        }

        private static Scene __LastCreatedScene;
        public static Scene LastCreatedScene
        {
            get
            {
                if (__LastCreatedScene == null)
                {
                    __LastCreatedScene = EventHorizonBlazorInterop.GetClass<Scene>(
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
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_DISABLE");
            }
        }

        public static decimal ALPHA_ADD
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_ADD"); }
        }

        public static decimal ALPHA_COMBINE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_COMBINE");
            }
        }

        public static decimal ALPHA_SUBTRACT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_SUBTRACT");
            }
        }

        public static decimal ALPHA_MULTIPLY
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_MULTIPLY");
            }
        }

        public static decimal ALPHA_MAXIMIZED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_MAXIMIZED");
            }
        }

        public static decimal ALPHA_ONEONE
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_ONEONE"); }
        }

        public static decimal ALPHA_PREMULTIPLIED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED"
                );
            }
        }

        public static decimal ALPHA_PREMULTIPLIED_PORTERDUFF
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_PREMULTIPLIED_PORTERDUFF"
                );
            }
        }

        public static decimal ALPHA_INTERPOLATE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.ALPHA_INTERPOLATE"
                );
            }
        }

        public static decimal ALPHA_SCREENMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALPHA_SCREENMODE");
            }
        }

        public static decimal DELAYLOADSTATE_NONE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NONE"
                );
            }
        }

        public static decimal DELAYLOADSTATE_LOADED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADED"
                );
            }
        }

        public static decimal DELAYLOADSTATE_LOADING
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_LOADING"
                );
            }
        }

        public static decimal DELAYLOADSTATE_NOTLOADED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.DELAYLOADSTATE_NOTLOADED"
                );
            }
        }

        public static decimal NEVER
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.NEVER"); }
        }

        public static decimal ALWAYS
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.ALWAYS"); }
        }

        public static decimal LESS
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.LESS"); }
        }

        public static decimal EQUAL
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.EQUAL"); }
        }

        public static decimal LEQUAL
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.LEQUAL"); }
        }

        public static decimal GREATER
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.GREATER"); }
        }

        public static decimal GEQUAL
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.GEQUAL"); }
        }

        public static decimal NOTEQUAL
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.NOTEQUAL"); }
        }

        public static decimal KEEP
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.KEEP"); }
        }

        public static decimal REPLACE
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.REPLACE"); }
        }

        public static decimal INCR
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INCR"); }
        }

        public static decimal DECR
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.DECR"); }
        }

        public static decimal INVERT
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INVERT"); }
        }

        public static decimal INCR_WRAP
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.INCR_WRAP"); }
        }

        public static decimal DECR_WRAP
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.DECR_WRAP"); }
        }

        public static decimal TEXTURE_CLAMP_ADDRESSMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CLAMP_ADDRESSMODE"
                );
            }
        }

        public static decimal TEXTURE_WRAP_ADDRESSMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_WRAP_ADDRESSMODE"
                );
            }
        }

        public static decimal TEXTURE_MIRROR_ADDRESSMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_MIRROR_ADDRESSMODE"
                );
            }
        }

        public static decimal TEXTUREFORMAT_ALPHA
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_ALPHA"
                );
            }
        }

        public static decimal TEXTUREFORMAT_LUMINANCE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE"
                );
            }
        }

        public static decimal TEXTUREFORMAT_LUMINANCE_ALPHA
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_LUMINANCE_ALPHA"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RGB
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RGBA
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED"
                );
            }
        }

        public static decimal TEXTUREFORMAT_R
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.TEXTUREFORMAT_R");
            }
        }

        public static decimal TEXTUREFORMAT_RG
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.TEXTUREFORMAT_RG");
            }
        }

        public static decimal TEXTUREFORMAT_RED_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RED_INTEGER"
                );
            }
        }

        public static decimal TEXTUREFORMAT_R_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_R_INTEGER"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RG_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RG_INTEGER"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RGB_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGB_INTEGER"
                );
            }
        }

        public static decimal TEXTUREFORMAT_RGBA_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTUREFORMAT_RGBA_INTEGER"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_BYTE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_BYTE"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT"
                );
            }
        }

        public static decimal TEXTURETYPE_FLOAT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT"
                );
            }
        }

        public static decimal TEXTURETYPE_HALF_FLOAT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_HALF_FLOAT"
                );
            }
        }

        public static decimal TEXTURETYPE_BYTE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.TEXTURETYPE_BYTE");
            }
        }

        public static decimal TEXTURETYPE_SHORT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_SHORT"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_SHORT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT"
                );
            }
        }

        public static decimal TEXTURETYPE_INT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.TEXTURETYPE_INT");
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INTEGER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INTEGER"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_SHORT_5_6_5
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_SHORT_5_6_5"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INT_24_8
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_24_8"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV"
                );
            }
        }

        public static decimal TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV"
                );
            }
        }

        public static decimal TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_SAMPLINGMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_SAMPLINGMODE"
                );
            }
        }

        public static decimal TEXTURE_BILINEAR_SAMPLINGMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_BILINEAR_SAMPLINGMODE"
                );
            }
        }

        public static decimal TEXTURE_TRILINEAR_SAMPLINGMODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_TRILINEAR_SAMPLINGMODE"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_NEAREST_MIPLINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPLINEAR"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_LINEAR_MIPNEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPNEAREST"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_LINEAR_MIPLINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR_MIPLINEAR"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_NEAREST_MIPNEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST_MIPNEAREST"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_LINEAR_MIPNEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPNEAREST"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_LINEAR_MIPLINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR_MIPLINEAR"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_LINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_LINEAR"
                );
            }
        }

        public static decimal TEXTURE_NEAREST_NEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_NEAREST_NEAREST"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_NEAREST_MIPNEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPNEAREST"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_NEAREST_MIPLINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST_MIPLINEAR"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_LINEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_LINEAR"
                );
            }
        }

        public static decimal TEXTURE_LINEAR_NEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_LINEAR_NEAREST"
                );
            }
        }

        public static decimal TEXTURE_EXPLICIT_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EXPLICIT_MODE"
                );
            }
        }

        public static decimal TEXTURE_SPHERICAL_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SPHERICAL_MODE"
                );
            }
        }

        public static decimal TEXTURE_PLANAR_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PLANAR_MODE"
                );
            }
        }

        public static decimal TEXTURE_CUBIC_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_CUBIC_MODE"
                );
            }
        }

        public static decimal TEXTURE_PROJECTION_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_PROJECTION_MODE"
                );
            }
        }

        public static decimal TEXTURE_SKYBOX_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_SKYBOX_MODE"
                );
            }
        }

        public static decimal TEXTURE_INVCUBIC_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_INVCUBIC_MODE"
                );
            }
        }

        public static decimal TEXTURE_EQUIRECTANGULAR_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_EQUIRECTANGULAR_MODE"
                );
            }
        }

        public static decimal TEXTURE_FIXED_EQUIRECTANGULAR_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MODE"
                );
            }
        }

        public static decimal TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE"
                );
            }
        }

        public static decimal SCALEMODE_FLOOR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "Engine.SCALEMODE_FLOOR");
            }
        }

        public static decimal SCALEMODE_NEAREST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_NEAREST"
                );
            }
        }

        public static decimal SCALEMODE_CEILING
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Engine.SCALEMODE_CEILING"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void MarkAllMaterialsAsDirty(
            decimal flag,
            ActionResultCallback<Material, bool> predicate = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Engine", "MarkAllMaterialsAsDirty" },
                    flag,
                    predicate
                }
            );
        }

        public static ILoadingScreenCachedEntity DefaultLoadingScreenFactory(
            HTMLCanvasElement canvas
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ILoadingScreenCachedEntity>(
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
        public PerformanceMonitor performanceMonitor
        {
            get
            {
                if (__performanceMonitor == null)
                {
                    __performanceMonitor = EventHorizonBlazorInterop.GetClass<PerformanceMonitor>(
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
        #endregion

        #region Properties
        private ICustomAnimationFrameRequesterCachedEntity __customAnimationFrameRequester;
        public ICustomAnimationFrameRequesterCachedEntity customAnimationFrameRequester
        {
            get
            {
                if (__customAnimationFrameRequester == null)
                {
                    __customAnimationFrameRequester =
                        EventHorizonBlazorInterop.GetClass<ICustomAnimationFrameRequesterCachedEntity>(
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
            set
            {
                __customAnimationFrameRequester = null;
                EventHorizonBlazorInterop.Set(this.___guid, "customAnimationFrameRequester", value);
            }
        }
        #endregion

        #region Constructor
        public Engine()
            : base() { }

        public Engine(ICachedEntity entity)
            : base(entity) { }

        public Engine(
            HTMLCanvasElement canvasOrContext,
            System.Nullable<bool> antialias = null,
            EngineOptions options = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Engine" },
                canvasOrContext,
                antialias,
                options,
                adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }

        public Engine(
            AbstractEngineOptions options,
            System.Nullable<bool> antialias = null,
            System.Nullable<bool> adaptToDeviceRatio = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Engine" },
                antialias,
                options,
                adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal[] resizeImageBitmap(
            HTMLImageElement image,
            decimal bufferWidth,
            decimal bufferHeight
        )
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "resizeImageBitmap" },
                    image,
                    bufferWidth,
                    bufferHeight
                }
            );
        }

        public void switchFullscreen(bool requestPointerLock)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "switchFullscreen" },
                    requestPointerLock
                }
            );
        }

        public void enterFullscreen(bool requestPointerLock)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enterFullscreen" },
                    requestPointerLock
                }
            );
        }

        public void exitFullscreen()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exitFullscreen" } }
            );
        }

        public void setDitheringState(bool value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDitheringState" }, value }
            );
        }

        public void setRasterizerState(bool value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setRasterizerState" }, value }
            );
        }

        public IViewportLikeCachedEntity setDirectViewport(
            decimal x,
            decimal y,
            decimal width,
            decimal height
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IViewportLikeCachedEntity>(
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

        public void scissorClear(
            decimal x,
            decimal y,
            decimal width,
            decimal height,
            IColor4Like clearColor
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void enableScissor(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enableScissor" }, x, y, width, height }
            );
        }

        public void disableScissor()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disableScissor" } }
            );
        }

        public string getVertexShaderSource(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getVertexShaderSource" }, program }
            );
        }

        public string getFragmentShaderSource(WebGLProgram program)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getFragmentShaderSource" }, program }
            );
        }

        public CachedEntity getFontOffset(string font)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getFontOffset" }, font }
            );
        }

        public void enterPointerlock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "enterPointerlock" } }
            );
        }

        public void exitPointerlock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exitPointerlock" } }
            );
        }

        public void beginFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginFrame" } }
            );
        }

        public WebGLProgramCachedEntity createShaderProgram(
            IPipelineContext pipelineContext,
            string vertexCode,
            string fragmentCode,
            string defines = null,
            WebGLRenderingContext context = null,
            string[] transformFeedbackVaryings = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLProgramCachedEntity>(
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

        public InternalTexture wrapWebGLTexture(
            WebGLTexture texture,
            System.Nullable<bool> hasMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public void updateTextureComparisonFunction(
            InternalTexture texture,
            decimal comparisonFunction
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTextureComparisonFunction" },
                    texture,
                    comparisonFunction
                }
            );
        }

        public DataBuffer createInstancesBuffer(decimal capacity)
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createInstancesBuffer" }, capacity }
            );
        }

        public void deleteInstancesBuffer(WebGLBuffer buffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "deleteInstancesBuffer" }, buffer }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
