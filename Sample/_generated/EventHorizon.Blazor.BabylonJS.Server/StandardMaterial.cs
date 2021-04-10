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

    
    
    [JsonConverter(typeof(CachedEntityConverter<StandardMaterial>))]
    public class StandardMaterial : PushMaterial
    {
        #region Static Accessors
        
        public static async ValueTask<bool> get_DiffuseTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled"
                );
        }
        public static ValueTask set_DiffuseTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_DetailTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.DetailTextureEnabled"
                );
        }
        public static ValueTask set_DetailTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.DetailTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_AmbientTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.AmbientTextureEnabled"
                );
        }
        public static ValueTask set_AmbientTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.AmbientTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_OpacityTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.OpacityTextureEnabled"
                );
        }
        public static ValueTask set_OpacityTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.OpacityTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_ReflectionTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ReflectionTextureEnabled"
                );
        }
        public static ValueTask set_ReflectionTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.ReflectionTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_EmissiveTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.EmissiveTextureEnabled"
                );
        }
        public static ValueTask set_EmissiveTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.EmissiveTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_SpecularTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.SpecularTextureEnabled"
                );
        }
        public static ValueTask set_SpecularTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.SpecularTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_BumpTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.BumpTextureEnabled"
                );
        }
        public static ValueTask set_BumpTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.BumpTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_LightmapTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.LightmapTextureEnabled"
                );
        }
        public static ValueTask set_LightmapTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.LightmapTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_RefractionTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.RefractionTextureEnabled"
                );
        }
        public static ValueTask set_RefractionTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.RefractionTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_ColorGradingTextureEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ColorGradingTextureEnabled"
                );
        }
        public static ValueTask set_ColorGradingTextureEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.ColorGradingTextureEnabled",
                    value
                );
        }

        
        public static async ValueTask<bool> get_FresnelEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.FresnelEnabled"
                );
        }
        public static ValueTask set_FresnelEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.FresnelEnabled",
                    value
                );
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<StandardMaterial> Parse(object source, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<StandardMaterial>(
                entity => new StandardMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "StandardMaterial", "Parse" }, source, scene, rootUrl
                }
            );
        }
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

        
        public async ValueTask<bool> get_cameraColorCurvesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorCurvesEnabled"
                );
        }
        public ValueTask set_cameraColorCurvesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorCurvesEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_cameraColorGradingEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorGradingEnabled"
                );
        }
        public ValueTask set_cameraColorGradingEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorGradingEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_cameraToneMappingEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraToneMappingEnabled"
                );
        }
        public ValueTask set_cameraToneMappingEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraToneMappingEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cameraExposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraExposure"
                );
        }
        public ValueTask set_cameraExposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraExposure",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cameraContrast()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraContrast"
                );
        }
        public ValueTask set_cameraContrast(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraContrast",
                    value
                );
        }

        private BaseTexture __cameraColorGradingTexture;
        public async ValueTask<BaseTexture> get_cameraColorGradingTexture()
        {
            if(__cameraColorGradingTexture == null)
            {
                __cameraColorGradingTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "cameraColorGradingTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraColorGradingTexture;
        }
        public ValueTask set_cameraColorGradingTexture(BaseTexture value)
        {
__cameraColorGradingTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorGradingTexture",
                    value
                );
        }

        private ColorCurves __cameraColorCurves;
        public async ValueTask<ColorCurves> get_cameraColorCurves()
        {
            if(__cameraColorCurves == null)
            {
                __cameraColorCurves = await EventHorizonBlazorInterop.GetClass<ColorCurves>(
                    this.___guid,
                    "cameraColorCurves",
                    (entity) =>
                    {
                        return new ColorCurves() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraColorCurves;
        }
        public ValueTask set_cameraColorCurves(ColorCurves value)
        {
__cameraColorCurves = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorCurves",
                    value
                );
        }

        
        public async ValueTask<bool> get_canRenderToMRT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRenderToMRT"
                );
        }

        
        public async ValueTask<bool> get_hasRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
        }

        
        public async ValueTask<bool> get_useLogarithmicDepth()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useLogarithmicDepth"
                );
        }
        public ValueTask set_useLogarithmicDepth(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useLogarithmicDepth",
                    value
                );
        }
        #endregion

        #region Properties
        private BaseTexture __diffuseTexture;
        public async ValueTask<BaseTexture> get_diffuseTexture()
        {
            if(__diffuseTexture == null)
            {
                __diffuseTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "diffuseTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffuseTexture;
        }
        public ValueTask set_diffuseTexture(BaseTexture value)
        {
__diffuseTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseTexture",
                    value
                );
        }

        private BaseTexture __ambientTexture;
        public async ValueTask<BaseTexture> get_ambientTexture()
        {
            if(__ambientTexture == null)
            {
                __ambientTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "ambientTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __ambientTexture;
        }
        public ValueTask set_ambientTexture(BaseTexture value)
        {
__ambientTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ambientTexture",
                    value
                );
        }

        private BaseTexture __opacityTexture;
        public async ValueTask<BaseTexture> get_opacityTexture()
        {
            if(__opacityTexture == null)
            {
                __opacityTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "opacityTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __opacityTexture;
        }
        public ValueTask set_opacityTexture(BaseTexture value)
        {
__opacityTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacityTexture",
                    value
                );
        }

        private BaseTexture __reflectionTexture;
        public async ValueTask<BaseTexture> get_reflectionTexture()
        {
            if(__reflectionTexture == null)
            {
                __reflectionTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "reflectionTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __reflectionTexture;
        }
        public ValueTask set_reflectionTexture(BaseTexture value)
        {
__reflectionTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionTexture",
                    value
                );
        }

        private BaseTexture __emissiveTexture;
        public async ValueTask<BaseTexture> get_emissiveTexture()
        {
            if(__emissiveTexture == null)
            {
                __emissiveTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "emissiveTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __emissiveTexture;
        }
        public ValueTask set_emissiveTexture(BaseTexture value)
        {
__emissiveTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissiveTexture",
                    value
                );
        }

        private BaseTexture __specularTexture;
        public async ValueTask<BaseTexture> get_specularTexture()
        {
            if(__specularTexture == null)
            {
                __specularTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "specularTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularTexture;
        }
        public ValueTask set_specularTexture(BaseTexture value)
        {
__specularTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularTexture",
                    value
                );
        }

        private BaseTexture __bumpTexture;
        public async ValueTask<BaseTexture> get_bumpTexture()
        {
            if(__bumpTexture == null)
            {
                __bumpTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "bumpTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __bumpTexture;
        }
        public ValueTask set_bumpTexture(BaseTexture value)
        {
__bumpTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bumpTexture",
                    value
                );
        }

        private BaseTexture __lightmapTexture;
        public async ValueTask<BaseTexture> get_lightmapTexture()
        {
            if(__lightmapTexture == null)
            {
                __lightmapTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "lightmapTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __lightmapTexture;
        }
        public ValueTask set_lightmapTexture(BaseTexture value)
        {
__lightmapTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightmapTexture",
                    value
                );
        }

        private BaseTexture __refractionTexture;
        public async ValueTask<BaseTexture> get_refractionTexture()
        {
            if(__refractionTexture == null)
            {
                __refractionTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "refractionTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __refractionTexture;
        }
        public ValueTask set_refractionTexture(BaseTexture value)
        {
__refractionTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refractionTexture",
                    value
                );
        }

        private Color3 __ambientColor;
        public async ValueTask<Color3> get_ambientColor()
        {
            if(__ambientColor == null)
            {
                __ambientColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "ambientColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ambientColor;
        }
        public ValueTask set_ambientColor(Color3 value)
        {
__ambientColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ambientColor",
                    value
                );
        }

        private Color3 __diffuseColor;
        public async ValueTask<Color3> get_diffuseColor()
        {
            if(__diffuseColor == null)
            {
                __diffuseColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "diffuseColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffuseColor;
        }
        public ValueTask set_diffuseColor(Color3 value)
        {
__diffuseColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseColor",
                    value
                );
        }

        private Color3 __specularColor;
        public async ValueTask<Color3> get_specularColor()
        {
            if(__specularColor == null)
            {
                __specularColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "specularColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __specularColor;
        }
        public ValueTask set_specularColor(Color3 value)
        {
__specularColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularColor",
                    value
                );
        }

        private Color3 __emissiveColor;
        public async ValueTask<Color3> get_emissiveColor()
        {
            if(__emissiveColor == null)
            {
                __emissiveColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "emissiveColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __emissiveColor;
        }
        public ValueTask set_emissiveColor(Color3 value)
        {
__emissiveColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissiveColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_specularPower()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "specularPower"
                );
        }
        public ValueTask set_specularPower(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specularPower",
                    value
                );
        }

        
        public async ValueTask<bool> get_useAlphaFromDiffuseTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlphaFromDiffuseTexture"
                );
        }
        public ValueTask set_useAlphaFromDiffuseTexture(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAlphaFromDiffuseTexture",
                    value
                );
        }

        
        public async ValueTask<bool> get_useEmissiveAsIllumination()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useEmissiveAsIllumination"
                );
        }
        public ValueTask set_useEmissiveAsIllumination(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useEmissiveAsIllumination",
                    value
                );
        }

        
        public async ValueTask<bool> get_linkEmissiveWithDiffuse()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linkEmissiveWithDiffuse"
                );
        }
        public ValueTask set_linkEmissiveWithDiffuse(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkEmissiveWithDiffuse",
                    value
                );
        }

        
        public async ValueTask<bool> get_useSpecularOverAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSpecularOverAlpha"
                );
        }
        public ValueTask set_useSpecularOverAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useSpecularOverAlpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_useReflectionOverAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReflectionOverAlpha"
                );
        }
        public ValueTask set_useReflectionOverAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useReflectionOverAlpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableLighting()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableLighting"
                );
        }
        public ValueTask set_disableLighting(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableLighting",
                    value
                );
        }

        
        public async ValueTask<bool> get_useObjectSpaceNormalMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useObjectSpaceNormalMap"
                );
        }
        public ValueTask set_useObjectSpaceNormalMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useObjectSpaceNormalMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useParallax()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useParallax"
                );
        }
        public ValueTask set_useParallax(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useParallax",
                    value
                );
        }

        
        public async ValueTask<bool> get_useParallaxOcclusion()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useParallaxOcclusion"
                );
        }
        public ValueTask set_useParallaxOcclusion(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useParallaxOcclusion",
                    value
                );
        }

        
        public async ValueTask<decimal> get_parallaxScaleBias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "parallaxScaleBias"
                );
        }
        public ValueTask set_parallaxScaleBias(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "parallaxScaleBias",
                    value
                );
        }

        
        public async ValueTask<decimal> get_roughness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "roughness"
                );
        }
        public ValueTask set_roughness(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roughness",
                    value
                );
        }

        
        public async ValueTask<decimal> get_indexOfRefraction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexOfRefraction"
                );
        }
        public ValueTask set_indexOfRefraction(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexOfRefraction",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertRefractionY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertRefractionY"
                );
        }
        public ValueTask set_invertRefractionY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertRefractionY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_alphaCutOff()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaCutOff"
                );
        }
        public ValueTask set_alphaCutOff(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaCutOff",
                    value
                );
        }

        
        public async ValueTask<bool> get_useLightmapAsShadowmap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useLightmapAsShadowmap"
                );
        }
        public ValueTask set_useLightmapAsShadowmap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useLightmapAsShadowmap",
                    value
                );
        }

        private FresnelParameters __diffuseFresnelParameters;
        public async ValueTask<FresnelParameters> get_diffuseFresnelParameters()
        {
            if(__diffuseFresnelParameters == null)
            {
                __diffuseFresnelParameters = await EventHorizonBlazorInterop.GetClass<FresnelParameters>(
                    this.___guid,
                    "diffuseFresnelParameters",
                    (entity) =>
                    {
                        return new FresnelParameters() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffuseFresnelParameters;
        }
        public ValueTask set_diffuseFresnelParameters(FresnelParameters value)
        {
__diffuseFresnelParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseFresnelParameters",
                    value
                );
        }

        private FresnelParameters __opacityFresnelParameters;
        public async ValueTask<FresnelParameters> get_opacityFresnelParameters()
        {
            if(__opacityFresnelParameters == null)
            {
                __opacityFresnelParameters = await EventHorizonBlazorInterop.GetClass<FresnelParameters>(
                    this.___guid,
                    "opacityFresnelParameters",
                    (entity) =>
                    {
                        return new FresnelParameters() { ___guid = entity.___guid };
                    }
                );
            }
            return __opacityFresnelParameters;
        }
        public ValueTask set_opacityFresnelParameters(FresnelParameters value)
        {
__opacityFresnelParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacityFresnelParameters",
                    value
                );
        }

        private FresnelParameters __reflectionFresnelParameters;
        public async ValueTask<FresnelParameters> get_reflectionFresnelParameters()
        {
            if(__reflectionFresnelParameters == null)
            {
                __reflectionFresnelParameters = await EventHorizonBlazorInterop.GetClass<FresnelParameters>(
                    this.___guid,
                    "reflectionFresnelParameters",
                    (entity) =>
                    {
                        return new FresnelParameters() { ___guid = entity.___guid };
                    }
                );
            }
            return __reflectionFresnelParameters;
        }
        public ValueTask set_reflectionFresnelParameters(FresnelParameters value)
        {
__reflectionFresnelParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionFresnelParameters",
                    value
                );
        }

        private FresnelParameters __refractionFresnelParameters;
        public async ValueTask<FresnelParameters> get_refractionFresnelParameters()
        {
            if(__refractionFresnelParameters == null)
            {
                __refractionFresnelParameters = await EventHorizonBlazorInterop.GetClass<FresnelParameters>(
                    this.___guid,
                    "refractionFresnelParameters",
                    (entity) =>
                    {
                        return new FresnelParameters() { ___guid = entity.___guid };
                    }
                );
            }
            return __refractionFresnelParameters;
        }
        public ValueTask set_refractionFresnelParameters(FresnelParameters value)
        {
__refractionFresnelParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refractionFresnelParameters",
                    value
                );
        }

        private FresnelParameters __emissiveFresnelParameters;
        public async ValueTask<FresnelParameters> get_emissiveFresnelParameters()
        {
            if(__emissiveFresnelParameters == null)
            {
                __emissiveFresnelParameters = await EventHorizonBlazorInterop.GetClass<FresnelParameters>(
                    this.___guid,
                    "emissiveFresnelParameters",
                    (entity) =>
                    {
                        return new FresnelParameters() { ___guid = entity.___guid };
                    }
                );
            }
            return __emissiveFresnelParameters;
        }
        public ValueTask set_emissiveFresnelParameters(FresnelParameters value)
        {
__emissiveFresnelParameters = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emissiveFresnelParameters",
                    value
                );
        }

        
        public async ValueTask<bool> get_useReflectionFresnelFromSpecular()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReflectionFresnelFromSpecular"
                );
        }
        public ValueTask set_useReflectionFresnelFromSpecular(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useReflectionFresnelFromSpecular",
                    value
                );
        }

        
        public async ValueTask<bool> get_useGlossinessFromSpecularMapAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGlossinessFromSpecularMapAlpha"
                );
        }
        public ValueTask set_useGlossinessFromSpecularMapAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useGlossinessFromSpecularMapAlpha",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxSimultaneousLights()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
        }
        public ValueTask set_maxSimultaneousLights(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertNormalMapX()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertNormalMapX"
                );
        }
        public ValueTask set_invertNormalMapX(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertNormalMapX",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertNormalMapY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertNormalMapY"
                );
        }
        public ValueTask set_invertNormalMapY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertNormalMapY",
                    value
                );
        }

        
        public async ValueTask<bool> get_twoSidedLighting()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "twoSidedLighting"
                );
        }
        public ValueTask set_twoSidedLighting(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "twoSidedLighting",
                    value
                );
        }

        private PrePassConfiguration __prePassConfiguration;
        public async ValueTask<PrePassConfiguration> get_prePassConfiguration()
        {
            if(__prePassConfiguration == null)
            {
                __prePassConfiguration = await EventHorizonBlazorInterop.GetClass<PrePassConfiguration>(
                    this.___guid,
                    "prePassConfiguration",
                    (entity) =>
                    {
                        return new PrePassConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __prePassConfiguration;
        }

        private DetailMapConfiguration __detailMap;
        public async ValueTask<DetailMapConfiguration> get_detailMap()
        {
            if(__detailMap == null)
            {
                __detailMap = await EventHorizonBlazorInterop.GetClass<DetailMapConfiguration>(
                    this.___guid,
                    "detailMap",
                    (entity) =>
                    {
                        return new DetailMapConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __detailMap;
        }
        #endregion
        
        #region Constructor
        public StandardMaterial() : base() { }

        public StandardMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<StandardMaterial> NewStandardMaterial(
            string name, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "StandardMaterial" },
                name, scene
            );

            return new StandardMaterial(entity);
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

        public async ValueTask<bool> needAlphaBlending()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public async ValueTask<bool> needAlphaTesting()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public async ValueTask<BaseTexture> getAlphaTestTexture()
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public async ValueTask buildUniformLayout()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "buildUniformLayout" }
                }
            );
        }

        public async ValueTask unbind()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public async ValueTask bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public async ValueTask<IAnimatableCachedEntity[]> getAnimatables()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public async ValueTask<BaseTexture[]> getActiveTextures()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures
                }
            );
        }

        public async ValueTask<StandardMaterial> clone(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<StandardMaterial>(
                entity => new StandardMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
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