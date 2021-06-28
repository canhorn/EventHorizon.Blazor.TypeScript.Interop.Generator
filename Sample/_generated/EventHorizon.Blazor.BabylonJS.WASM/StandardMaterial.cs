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

    
    
    [JsonConverter(typeof(CachedEntityConverter<StandardMaterial>))]
    public class StandardMaterial : PushMaterial
    {
        #region Static Accessors
        
        public static bool DiffuseTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.DiffuseTextureEnabled",
                    value
                );
            }
        }

        
        public static bool DetailTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.DetailTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "StandardMaterial.DetailTextureEnabled",
                    value
                );
            }
        }

        
        public static bool AmbientTextureEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.AmbientTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.OpacityTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ReflectionTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.EmissiveTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.SpecularTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.BumpTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.LightmapTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.RefractionTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.ColorGradingTextureEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "StandardMaterial.FresnelEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.FuncClass<StandardMaterial>(
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

        
        public bool cameraColorCurvesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorCurvesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorGradingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraToneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraExposure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraContrast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __cameraColorGradingTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __cameraColorCurves = EventHorizonBlazorInterop.GetClass<ColorCurves>(
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorCurves",
                    value
                );
            }
        }

        
        public bool canRenderToMRT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRenderToMRT"
                );
            }
        }

        
        public bool hasRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
            }
        }

        
        public bool useLogarithmicDepth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useLogarithmicDepth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __diffuseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __ambientTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __opacityTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __reflectionTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __emissiveTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __specularTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __bumpTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __lightmapTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __refractionTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
                EventHorizonBlazorInterop.Set(
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
                __ambientColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
                EventHorizonBlazorInterop.Set(
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
                __diffuseColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
                EventHorizonBlazorInterop.Set(
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
                __specularColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
                EventHorizonBlazorInterop.Set(
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
                __emissiveColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "specularPower"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlphaFromDiffuseTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useEmissiveAsIllumination"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linkEmissiveWithDiffuse"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSpecularOverAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReflectionOverAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableLighting"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useObjectSpaceNormalMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useParallax"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useParallaxOcclusion"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "parallaxScaleBias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "roughness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexOfRefraction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertRefractionY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaCutOff"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useLightmapAsShadowmap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __diffuseFresnelParameters = EventHorizonBlazorInterop.GetClass<FresnelParameters>(
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
                EventHorizonBlazorInterop.Set(
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
                __opacityFresnelParameters = EventHorizonBlazorInterop.GetClass<FresnelParameters>(
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
                EventHorizonBlazorInterop.Set(
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
                __reflectionFresnelParameters = EventHorizonBlazorInterop.GetClass<FresnelParameters>(
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
                EventHorizonBlazorInterop.Set(
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
                __refractionFresnelParameters = EventHorizonBlazorInterop.GetClass<FresnelParameters>(
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
                EventHorizonBlazorInterop.Set(
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
                __emissiveFresnelParameters = EventHorizonBlazorInterop.GetClass<FresnelParameters>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useReflectionFresnelFromSpecular"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGlossinessFromSpecularMapAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertNormalMapX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertNormalMapY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "twoSidedLighting"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "twoSidedLighting",
                    value
                );
            }
        }

        private PrePassConfiguration __prePassConfiguration;
        public PrePassConfiguration prePassConfiguration
        {
            get
            {
            if(__prePassConfiguration == null)
            {
                __prePassConfiguration = EventHorizonBlazorInterop.GetClass<PrePassConfiguration>(
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
        }

        private DetailMapConfiguration __detailMap;
        public DetailMapConfiguration detailMap
        {
            get
            {
            if(__detailMap == null)
            {
                __detailMap = EventHorizonBlazorInterop.GetClass<DetailMapConfiguration>(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "StandardMaterial" },
                name, scene
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

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public BaseTexture getAlphaTestTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public void buildUniformLayout()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "buildUniformLayout" }
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public IAnimatableCachedEntity[] getAnimatables()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures
                }
            );
        }

        public StandardMaterial clone(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<StandardMaterial>(
                entity => new StandardMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name
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