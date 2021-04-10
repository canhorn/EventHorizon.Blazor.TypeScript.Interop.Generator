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
        public async ValueTask<ImageProcessingConfiguration> get_imageProcessingConfiguration()
        {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = await EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
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
        public ValueTask set_imageProcessingConfiguration(ImageProcessingConfiguration value)
        {
__imageProcessingConfiguration = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
        }

        
        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
        }

        private ColorCurves __colorCurves;
        public async ValueTask<ColorCurves> get_colorCurves()
        {
            if(__colorCurves == null)
            {
                __colorCurves = await EventHorizonBlazorInterop.GetClass<ColorCurves>(
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
        public ValueTask set_colorCurves(ColorCurves value)
        {
__colorCurves = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorCurves",
                    value
                );
        }

        
        public async ValueTask<bool> get_colorCurvesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorCurvesEnabled"
                );
        }
        public ValueTask set_colorCurvesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorCurvesEnabled",
                    value
                );
        }

        private BaseTexture __colorGradingTexture;
        public async ValueTask<BaseTexture> get_colorGradingTexture()
        {
            if(__colorGradingTexture == null)
            {
                __colorGradingTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
        public ValueTask set_colorGradingTexture(BaseTexture value)
        {
__colorGradingTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingTexture",
                    value
                );
        }

        
        public async ValueTask<bool> get_colorGradingEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingEnabled"
                );
        }
        public ValueTask set_colorGradingEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_exposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exposure"
                );
        }
        public ValueTask set_exposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exposure",
                    value
                );
        }

        
        public async ValueTask<bool> get_toneMappingEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "toneMappingEnabled"
                );
        }
        public ValueTask set_toneMappingEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_toneMappingType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toneMappingType"
                );
        }
        public ValueTask set_toneMappingType(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingType",
                    value
                );
        }

        
        public async ValueTask<decimal> get_contrast()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "contrast"
                );
        }
        public ValueTask set_contrast(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contrast",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteStretch()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteStretch"
                );
        }
        public ValueTask set_vignetteStretch(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteStretch",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteCentreX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCentreX"
                );
        }
        public ValueTask set_vignetteCentreX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCentreX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteCentreY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCentreY"
                );
        }
        public ValueTask set_vignetteCentreY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCentreY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteWeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteWeight"
                );
        }
        public ValueTask set_vignetteWeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteWeight",
                    value
                );
        }

        private Color4 __vignetteColor;
        public async ValueTask<Color4> get_vignetteColor()
        {
            if(__vignetteColor == null)
            {
                __vignetteColor = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_vignetteColor(Color4 value)
        {
__vignetteColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteCameraFov()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteCameraFov"
                );
        }
        public ValueTask set_vignetteCameraFov(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteCameraFov",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vignetteBlendMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vignetteBlendMode"
                );
        }
        public ValueTask set_vignetteBlendMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteBlendMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_vignetteEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vignetteEnabled"
                );
        }
        public ValueTask set_vignetteEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vignetteEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_fromLinearSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fromLinearSpace"
                );
        }
        public ValueTask set_fromLinearSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fromLinearSpace",
                    value
                );
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

        public static async ValueTask<ImageProcessingPostProcess> NewImageProcessingPostProcess(
            string name, decimal options, Camera camera = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, System.Nullable<decimal> textureType = null, ImageProcessingConfiguration imageProcessingConfiguration = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ImageProcessingPostProcess" },
                name, options, camera, samplingMode, engine, reusable, textureType, imageProcessingConfiguration
            );

            return new ImageProcessingPostProcess(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask dispose(Camera camera = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, camera
                }
            );
        }
        #endregion
    }
}