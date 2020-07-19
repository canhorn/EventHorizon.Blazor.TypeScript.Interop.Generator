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
    public class StandardMaterial : PushMaterial
    {
        #region Static Accessors
        
        public static bool DiffuseTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled",
                    value
                );
            }
        }

        
        public static bool AmbientTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.AmbientTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.AmbientTextureEnabled",
                    value
                );
            }
        }

        
        public static bool OpacityTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.OpacityTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.OpacityTextureEnabled",
                    value
                );
            }
        }

        
        public static bool ReflectionTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ReflectionTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.ReflectionTextureEnabled",
                    value
                );
            }
        }

        
        public static bool EmissiveTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.EmissiveTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.EmissiveTextureEnabled",
                    value
                );
            }
        }

        
        public static bool SpecularTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.SpecularTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.SpecularTextureEnabled",
                    value
                );
            }
        }

        
        public static bool BumpTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.BumpTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.BumpTextureEnabled",
                    value
                );
            }
        }

        
        public static bool LightmapTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.LightmapTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.LightmapTextureEnabled",
                    value
                );
            }
        }

        
        public static bool RefractionTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.RefractionTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.RefractionTextureEnabled",
                    value
                );
            }
        }

        
        public static bool ColorGradingTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ColorGradingTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.ColorGradingTextureEnabled",
                    value
                );
            }
        }

        
        public static bool FresnelEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.FresnelEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "StandardMaterial.FresnelEnabled",
                    value
                );
            }
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static StandardMaterial Parse(object source, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<StandardMaterial>(
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
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInteropt.GetClass<ImageProcessingConfiguration>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
            }
        }

        
        public bool cameraColorCurvesEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "cameraColorCurvesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraColorCurvesEnabled",
                    value
                );
            }
        }

        
        public bool cameraColorGradingEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "cameraColorGradingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraColorGradingEnabled",
                    value
                );
            }
        }

        
        public bool cameraToneMappingEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "cameraToneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraToneMappingEnabled",
                    value
                );
            }
        }

        
        public decimal cameraExposure
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cameraExposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraExposure",
                    value
                );
            }
        }

        
        public decimal cameraContrast
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cameraContrast"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraContrast",
                    value
                );
            }
        }

        private BaseTexture __cameraColorGradingTexture;
        public BaseTexture cameraColorGradingTexture
        {
            get
            {
            if(__cameraColorGradingTexture == null)
            {
                __cameraColorGradingTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__cameraColorGradingTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraColorGradingTexture",
                    value
                );
            }
        }

        private ColorCurves __cameraColorCurves;
        public ColorCurves cameraColorCurves
        {
            get
            {
            if(__cameraColorCurves == null)
            {
                __cameraColorCurves = EventHorizonBlazorInteropt.GetClass<ColorCurves>(
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
            set
            {
__cameraColorCurves = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraColorCurves",
                    value
                );
            }
        }

        
        public bool hasRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
            }
        }

        
        public bool useLogarithmicDepth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useLogarithmicDepth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useLogarithmicDepth",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private BaseTexture __diffuseTexture;
        public BaseTexture diffuseTexture
        {
            get
            {
            if(__diffuseTexture == null)
            {
                __diffuseTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__diffuseTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "diffuseTexture",
                    value
                );
            }
        }

        private BaseTexture __ambientTexture;
        public BaseTexture ambientTexture
        {
            get
            {
            if(__ambientTexture == null)
            {
                __ambientTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__ambientTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ambientTexture",
                    value
                );
            }
        }

        private BaseTexture __opacityTexture;
        public BaseTexture opacityTexture
        {
            get
            {
            if(__opacityTexture == null)
            {
                __opacityTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__opacityTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "opacityTexture",
                    value
                );
            }
        }

        private BaseTexture __reflectionTexture;
        public BaseTexture reflectionTexture
        {
            get
            {
            if(__reflectionTexture == null)
            {
                __reflectionTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__reflectionTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reflectionTexture",
                    value
                );
            }
        }

        private BaseTexture __emissiveTexture;
        public BaseTexture emissiveTexture
        {
            get
            {
            if(__emissiveTexture == null)
            {
                __emissiveTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__emissiveTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emissiveTexture",
                    value
                );
            }
        }

        private BaseTexture __specularTexture;
        public BaseTexture specularTexture
        {
            get
            {
            if(__specularTexture == null)
            {
                __specularTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__specularTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "specularTexture",
                    value
                );
            }
        }

        private BaseTexture __bumpTexture;
        public BaseTexture bumpTexture
        {
            get
            {
            if(__bumpTexture == null)
            {
                __bumpTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__bumpTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "bumpTexture",
                    value
                );
            }
        }

        private BaseTexture __lightmapTexture;
        public BaseTexture lightmapTexture
        {
            get
            {
            if(__lightmapTexture == null)
            {
                __lightmapTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__lightmapTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lightmapTexture",
                    value
                );
            }
        }

        private BaseTexture __refractionTexture;
        public BaseTexture refractionTexture
        {
            get
            {
            if(__refractionTexture == null)
            {
                __refractionTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
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
            set
            {
__refractionTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "refractionTexture",
                    value
                );
            }
        }

        private Color3 __ambientColor;
        public Color3 ambientColor
        {
            get
            {
            if(__ambientColor == null)
            {
                __ambientColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
            set
            {
__ambientColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ambientColor",
                    value
                );
            }
        }

        private Color3 __diffuseColor;
        public Color3 diffuseColor
        {
            get
            {
            if(__diffuseColor == null)
            {
                __diffuseColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
            set
            {
__diffuseColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "diffuseColor",
                    value
                );
            }
        }

        private Color3 __specularColor;
        public Color3 specularColor
        {
            get
            {
            if(__specularColor == null)
            {
                __specularColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
            set
            {
__specularColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "specularColor",
                    value
                );
            }
        }

        private Color3 __emissiveColor;
        public Color3 emissiveColor
        {
            get
            {
            if(__emissiveColor == null)
            {
                __emissiveColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
            set
            {
__emissiveColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emissiveColor",
                    value
                );
            }
        }

        
        public decimal specularPower
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "specularPower"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "specularPower",
                    value
                );
            }
        }

        
        public bool useAlphaFromDiffuseTexture
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useAlphaFromDiffuseTexture"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useAlphaFromDiffuseTexture",
                    value
                );
            }
        }

        
        public bool useEmissiveAsIllumination
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useEmissiveAsIllumination"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useEmissiveAsIllumination",
                    value
                );
            }
        }

        
        public bool linkEmissiveWithDiffuse
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "linkEmissiveWithDiffuse"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linkEmissiveWithDiffuse",
                    value
                );
            }
        }

        
        public bool useSpecularOverAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useSpecularOverAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useSpecularOverAlpha",
                    value
                );
            }
        }

        
        public bool useReflectionOverAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useReflectionOverAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useReflectionOverAlpha",
                    value
                );
            }
        }

        
        public bool disableLighting
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableLighting"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableLighting",
                    value
                );
            }
        }

        
        public bool useObjectSpaceNormalMap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useObjectSpaceNormalMap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useObjectSpaceNormalMap",
                    value
                );
            }
        }

        
        public bool useParallax
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useParallax"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useParallax",
                    value
                );
            }
        }

        
        public bool useParallaxOcclusion
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useParallaxOcclusion"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useParallaxOcclusion",
                    value
                );
            }
        }

        
        public decimal parallaxScaleBias
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "parallaxScaleBias"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "parallaxScaleBias",
                    value
                );
            }
        }

        
        public decimal roughness
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "roughness"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "roughness",
                    value
                );
            }
        }

        
        public decimal indexOfRefraction
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "indexOfRefraction"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "indexOfRefraction",
                    value
                );
            }
        }

        
        public bool invertRefractionY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertRefractionY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertRefractionY",
                    value
                );
            }
        }

        
        public decimal alphaCutOff
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alphaCutOff"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alphaCutOff",
                    value
                );
            }
        }

        
        public bool useLightmapAsShadowmap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useLightmapAsShadowmap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useLightmapAsShadowmap",
                    value
                );
            }
        }

        private FresnelParameters __diffuseFresnelParameters;
        public FresnelParameters diffuseFresnelParameters
        {
            get
            {
            if(__diffuseFresnelParameters == null)
            {
                __diffuseFresnelParameters = EventHorizonBlazorInteropt.GetClass<FresnelParameters>(
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
            set
            {
__diffuseFresnelParameters = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "diffuseFresnelParameters",
                    value
                );
            }
        }

        private FresnelParameters __opacityFresnelParameters;
        public FresnelParameters opacityFresnelParameters
        {
            get
            {
            if(__opacityFresnelParameters == null)
            {
                __opacityFresnelParameters = EventHorizonBlazorInteropt.GetClass<FresnelParameters>(
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
            set
            {
__opacityFresnelParameters = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "opacityFresnelParameters",
                    value
                );
            }
        }

        private FresnelParameters __reflectionFresnelParameters;
        public FresnelParameters reflectionFresnelParameters
        {
            get
            {
            if(__reflectionFresnelParameters == null)
            {
                __reflectionFresnelParameters = EventHorizonBlazorInteropt.GetClass<FresnelParameters>(
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
            set
            {
__reflectionFresnelParameters = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reflectionFresnelParameters",
                    value
                );
            }
        }

        private FresnelParameters __refractionFresnelParameters;
        public FresnelParameters refractionFresnelParameters
        {
            get
            {
            if(__refractionFresnelParameters == null)
            {
                __refractionFresnelParameters = EventHorizonBlazorInteropt.GetClass<FresnelParameters>(
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
            set
            {
__refractionFresnelParameters = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "refractionFresnelParameters",
                    value
                );
            }
        }

        private FresnelParameters __emissiveFresnelParameters;
        public FresnelParameters emissiveFresnelParameters
        {
            get
            {
            if(__emissiveFresnelParameters == null)
            {
                __emissiveFresnelParameters = EventHorizonBlazorInteropt.GetClass<FresnelParameters>(
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
            set
            {
__emissiveFresnelParameters = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emissiveFresnelParameters",
                    value
                );
            }
        }

        
        public bool useReflectionFresnelFromSpecular
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useReflectionFresnelFromSpecular"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useReflectionFresnelFromSpecular",
                    value
                );
            }
        }

        
        public bool useGlossinessFromSpecularMapAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useGlossinessFromSpecularMapAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useGlossinessFromSpecularMapAlpha",
                    value
                );
            }
        }

        
        public decimal maxSimultaneousLights
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
            }
        }

        
        public bool invertNormalMapX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertNormalMapX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertNormalMapX",
                    value
                );
            }
        }

        
        public bool invertNormalMapY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertNormalMapY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertNormalMapY",
                    value
                );
            }
        }

        
        public bool twoSidedLighting
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "twoSidedLighting"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "twoSidedLighting",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public StandardMaterial() : base() { }

        public StandardMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public StandardMaterial(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "StandardMaterial" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region customShaderNameResolve TODO: Get Comments as metadata identification
        private bool _isCustomShaderNameResolveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customShaderNameResolveActionMap = new Dictionary<string, Func<Task>>();

        public string customShaderNameResolve(
            Func<Task> callback
        )
        {
            SetupCustomShaderNameResolveLoop();

            var handle = Guid.NewGuid().ToString();
            _customShaderNameResolveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCustomShaderNameResolveLoop()
        {
            if (_isCustomShaderNameResolveEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "customShaderNameResolve",
                "CallCustomShaderNameResolveActions",
                _invokableReference
            );
            _isCustomShaderNameResolveEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomShaderNameResolveActions()
        {
            foreach (var action in _customShaderNameResolveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public BaseTexture getAlphaTestTexture()
        {
            return EventHorizonBlazorInteropt.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public void buildUniformLayout()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "buildUniformLayout" }
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public IAnimatableCachedEntity[] getAnimatables()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures
                }
            );
        }

        public StandardMaterial clone(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<StandardMaterial>(
                entity => new StandardMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
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