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
    public class ImageProcessingConfiguration : CachedEntityObject
    {
        #region Static Accessors
        
        public static decimal VIGNETTEMODE_MULTIPLY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.VIGNETTEMODE_MULTIPLY"
                );
            }
        }

        
        public static decimal VIGNETTEMODE_OPAQUE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ImageProcessingConfiguration.TONEMAPPING_STANDARD"
                );
            }
        }

        
        public static decimal TONEMAPPING_ACES
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ImageProcessingConfiguration.TONEMAPPING_ACES"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void PrepareUniforms(string[] uniforms, IImageProcessingConfigurationDefines defines)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareUniforms" }, uniforms, defines
                }
            );
        }

        public static void PrepareSamplers(string[] samplersList, IImageProcessingConfigurationDefines defines)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareSamplers" }, samplersList, defines
                }
            );
        }

        public static ImageProcessingConfiguration Parse(CachedEntity source)
        {
            return EventHorizonBlazorInteropt.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration(entity),
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "colorCurvesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __colorGradingTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "colorGradingTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __colorGradingTexture;
            }
            set
            {
__colorGradingTexture = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "colorGradingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "colorGradingWithGreenDepth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "colorGradingBGR"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "exposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "toneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "toneMappingType"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "contrast"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteBlendMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "vignetteEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "applyByPostProcess"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __colorCurves = EventHorizonBlazorInteropt.GetClass<ColorCurves>(
                    this.___guid,
                    "colorCurves",
                    (entity) =>
                    {
                        return new ColorCurves(entity);
                    }
                );
            }
            return __colorCurves;
            }
            set
            {
__colorCurves = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteStretch"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteCentreX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteCentreY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteWeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __vignetteColor = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "vignetteColor",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __vignetteColor;
            }
            set
            {
__vignetteColor = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vignetteCameraFov"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vignetteCameraFov",
                    value
                );
            }
        }

        private Observable __onUpdateParameters;
        public Observable onUpdateParameters
        {
            get
            {
            if(__onUpdateParameters == null)
            {
                __onUpdateParameters = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onUpdateParameters",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onUpdateParameters;
            }
            set
            {
__onUpdateParameters = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void prepareDefines(IImageProcessingConfigurationDefines defines, System.Nullable<bool> forPostProcess = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, forPostProcess
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void bind(Effect effect, System.Nullable<decimal> overrideAspectRatio = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, effect, overrideAspectRatio
                }
            );
        }

        public ImageProcessingConfiguration clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}