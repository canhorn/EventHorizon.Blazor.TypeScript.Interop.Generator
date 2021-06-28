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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ImageProcessingConfiguration>))]
    public class ImageProcessingConfiguration : CachedEntityObject
    {
        #region Static Accessors
        
        public static decimal VIGNETTEMODE_MULTIPLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.VIGNETTEMODE_MULTIPLY"
                );
            }
        }

        
        public static decimal VIGNETTEMODE_OPAQUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.VIGNETTEMODE_OPAQUE"
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal TONEMAPPING_STANDARD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.TONEMAPPING_STANDARD"
                );
            }
        }

        
        public static decimal TONEMAPPING_ACES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.TONEMAPPING_ACES"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void PrepareUniforms(string[] uniforms, IImageProcessingConfigurationDefines defines)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareUniforms" }, uniforms, defines
                }
            );
        }

        public static void PrepareSamplers(string[] samplersList, IImageProcessingConfigurationDefines defines)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareSamplers" }, samplersList, defines
                }
            );
        }

        public static ImageProcessingConfiguration Parse(object source)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "Parse" }, source
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool colorCurvesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorCurvesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorCurvesEnabled",
                    value
                );
            }
        }

        private BaseTexture __colorGradingTexture;
        public BaseTexture colorGradingTexture
        {
            get
            {
            if(__colorGradingTexture == null)
            {
                __colorGradingTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "colorGradingTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorGradingTexture;
            }
            set
            {
__colorGradingTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingTexture",
                    value
                );
            }
        }

        
        public bool colorGradingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingEnabled",
                    value
                );
            }
        }

        
        public bool colorGradingWithGreenDepth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingWithGreenDepth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingWithGreenDepth",
                    value
                );
            }
        }

        
        public bool colorGradingBGR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingBGR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingBGR",
                    value
                );
            }
        }

        
        public decimal exposure
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exposure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exposure",
                    value
                );
            }
        }

        
        public bool toneMappingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "toneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingEnabled",
                    value
                );
            }
        }

        
        public decimal toneMappingType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toneMappingType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingType",
                    value
                );
            }
        }

        
        public decimal contrast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "contrast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contrast",
                    value
                );
            }
        }

        
        public decimal vignetteBlendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteBlendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteBlendMode",
                    value
                );
            }
        }

        
        public bool vignetteEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vignetteEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteEnabled",
                    value
                );
            }
        }

        
        public bool applyByPostProcess
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyByPostProcess"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyByPostProcess",
                    value
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private ColorCurves __colorCurves;
        public ColorCurves colorCurves
        {
            get
            {
            if(__colorCurves == null)
            {
                __colorCurves = EventHorizonBlazorInterop.GetClass<ColorCurves>(
                    this.___guid,
                    "colorCurves",
                    (entity) =>
                    {
                        return new ColorCurves() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorCurves;
            }
            set
            {
__colorCurves = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorCurves",
                    value
                );
            }
        }

        
        public decimal vignetteStretch
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteStretch"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteStretch",
                    value
                );
            }
        }

        
        public decimal vignetteCentreX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCentreX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCentreX",
                    value
                );
            }
        }

        
        public decimal vignetteCentreY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCentreY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCentreY",
                    value
                );
            }
        }

        
        public decimal vignetteWeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteWeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteWeight",
                    value
                );
            }
        }

        private Color4 __vignetteColor;
        public Color4 vignetteColor
        {
            get
            {
            if(__vignetteColor == null)
            {
                __vignetteColor = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "vignetteColor",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __vignetteColor;
            }
            set
            {
__vignetteColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteColor",
                    value
                );
            }
        }

        
        public decimal vignetteCameraFov
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCameraFov"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCameraFov",
                    value
                );
            }
        }

        private Observable<ImageProcessingConfiguration> __onUpdateParameters;
        public Observable<ImageProcessingConfiguration> onUpdateParameters
        {
            get
            {
            if(__onUpdateParameters == null)
            {
                __onUpdateParameters = EventHorizonBlazorInterop.GetClass<Observable<ImageProcessingConfiguration>>(
                    this.___guid,
                    "onUpdateParameters",
                    (entity) =>
                    {
                        return new Observable<ImageProcessingConfiguration>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onUpdateParameters;
            }
            set
            {
__onUpdateParameters = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onUpdateParameters",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ImageProcessingConfiguration() : base() { }

        public ImageProcessingConfiguration(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void prepareDefines(IImageProcessingConfigurationDefines defines, System.Nullable<bool> forPostProcess = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, forPostProcess
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void bind(Effect effect, System.Nullable<decimal> overrideAspectRatio = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, effect, overrideAspectRatio
                }
            );
        }

        public ImageProcessingConfiguration clone()
        {
            return EventHorizonBlazorInterop.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}