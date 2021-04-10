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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ImageProcessingConfiguration>))]
    public class ImageProcessingConfiguration : CachedEntityObject
    {
        #region Static Accessors
        
        public static async ValueTask<decimal> get_VIGNETTEMODE_MULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.VIGNETTEMODE_MULTIPLY"
                );
        }

        
        public static async ValueTask<decimal> get_VIGNETTEMODE_OPAQUE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.VIGNETTEMODE_OPAQUE"
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_TONEMAPPING_STANDARD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.TONEMAPPING_STANDARD"
                );
        }

        
        public static async ValueTask<decimal> get_TONEMAPPING_ACES()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ImageProcessingConfiguration.TONEMAPPING_ACES"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask PrepareUniforms(string[] uniforms, IImageProcessingConfigurationDefines defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareUniforms" }, uniforms, defines
                }
            );
        }

        public static async ValueTask PrepareSamplers(string[] samplersList, IImageProcessingConfigurationDefines defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "PrepareSamplers" }, samplersList, defines
                }
            );
        }

        public static async ValueTask<ImageProcessingConfiguration> Parse(object source)
        {
            return await EventHorizonBlazorInterop.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ImageProcessingConfiguration", "Parse" }, source
                }
            );
        }
        #endregion

        #region Accessors
        
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

        
        public async ValueTask<bool> get_colorGradingWithGreenDepth()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingWithGreenDepth"
                );
        }
        public ValueTask set_colorGradingWithGreenDepth(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingWithGreenDepth",
                    value
                );
        }

        
        public async ValueTask<bool> get_colorGradingBGR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorGradingBGR"
                );
        }
        public ValueTask set_colorGradingBGR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorGradingBGR",
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

        
        public async ValueTask<bool> get_applyByPostProcess()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyByPostProcess"
                );
        }
        public ValueTask set_applyByPostProcess(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyByPostProcess",
                    value
                );
        }

        
        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
        }
        public ValueTask set_isEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
        }
        #endregion

        #region Properties
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

        private Observable<ImageProcessingConfiguration> __onUpdateParameters;
        public async ValueTask<Observable<ImageProcessingConfiguration>> get_onUpdateParameters()
        {
            if(__onUpdateParameters == null)
            {
                __onUpdateParameters = await EventHorizonBlazorInterop.GetClass<Observable<ImageProcessingConfiguration>>(
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
        public ValueTask set_onUpdateParameters(Observable<ImageProcessingConfiguration> value)
        {
__onUpdateParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onUpdateParameters",
                    value
                );
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
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask prepareDefines(IImageProcessingConfigurationDefines defines, System.Nullable<bool> forPostProcess = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, forPostProcess
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask bind(Effect effect, System.Nullable<decimal> overrideAspectRatio = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, effect, overrideAspectRatio
                }
            );
        }

        public async ValueTask<ImageProcessingConfiguration> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<ImageProcessingConfiguration>(
                entity => new ImageProcessingConfiguration() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}