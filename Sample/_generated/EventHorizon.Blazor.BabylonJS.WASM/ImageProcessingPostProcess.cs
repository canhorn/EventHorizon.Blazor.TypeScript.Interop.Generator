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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ImageProcessingPostProcess>))]
    public class ImageProcessingPostProcess : PostProcess
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingConfiguration;
            }
            set
            {
__imageProcessingConfiguration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
            }
        }

        
        public bool isSupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
            }
        }

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

        
        public bool fromLinearSpace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fromLinearSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fromLinearSpace",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public ImageProcessingPostProcess() : base() { }

        public ImageProcessingPostProcess(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ImageProcessingPostProcess(
            string name, decimal options, Camera camera = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, System.Nullable<decimal> textureType = null, ImageProcessingConfiguration imageProcessingConfiguration = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ImageProcessingPostProcess" },
                name, options, camera, samplingMode, engine, reusable, textureType, imageProcessingConfiguration
            );
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

        public void dispose(Camera camera = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, camera
                }
            );
        }
        #endregion
    }
}