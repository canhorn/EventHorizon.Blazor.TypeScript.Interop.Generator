/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<StandardMaterialDefines>))]
    public class StandardMaterialDefines : MaterialDefines, IImageProcessingConfigurationDefines
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public bool MAINUV1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MAINUV1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAINUV1",
                    value
                );
            }
        }

        
        public bool MAINUV2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MAINUV2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAINUV2",
                    value
                );
            }
        }

        
        public bool DIFFUSE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DIFFUSE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSE",
                    value
                );
            }
        }

        
        public decimal DIFFUSEDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DIFFUSEDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSEDIRECTUV",
                    value
                );
            }
        }

        
        public bool AMBIENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "AMBIENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "AMBIENT",
                    value
                );
            }
        }

        
        public decimal AMBIENTDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "AMBIENTDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "AMBIENTDIRECTUV",
                    value
                );
            }
        }

        
        public bool OPACITY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITY",
                    value
                );
            }
        }

        
        public decimal OPACITYDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "OPACITYDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYDIRECTUV",
                    value
                );
            }
        }

        
        public bool OPACITYRGB
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITYRGB"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYRGB",
                    value
                );
            }
        }

        
        public bool REFLECTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTION",
                    value
                );
            }
        }

        
        public bool EMISSIVE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVE",
                    value
                );
            }
        }

        
        public decimal EMISSIVEDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "EMISSIVEDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEDIRECTUV",
                    value
                );
            }
        }

        
        public bool SPECULAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULAR",
                    value
                );
            }
        }

        
        public decimal SPECULARDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SPECULARDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULARDIRECTUV",
                    value
                );
            }
        }

        
        public bool BUMP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BUMP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BUMP",
                    value
                );
            }
        }

        
        public decimal BUMPDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUMPDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BUMPDIRECTUV",
                    value
                );
            }
        }

        
        public bool PARALLAX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PARALLAX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PARALLAX",
                    value
                );
            }
        }

        
        public bool PARALLAXOCCLUSION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PARALLAXOCCLUSION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PARALLAXOCCLUSION",
                    value
                );
            }
        }

        
        public bool SPECULAROVERALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULAROVERALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULAROVERALPHA",
                    value
                );
            }
        }

        
        public bool CLIPPLANE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE",
                    value
                );
            }
        }

        
        public bool CLIPPLANE2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE2",
                    value
                );
            }
        }

        
        public bool CLIPPLANE3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE3"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE3",
                    value
                );
            }
        }

        
        public bool CLIPPLANE4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE4"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE4",
                    value
                );
            }
        }

        
        public bool CLIPPLANE5
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE5"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE5",
                    value
                );
            }
        }

        
        public bool CLIPPLANE6
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CLIPPLANE6"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CLIPPLANE6",
                    value
                );
            }
        }

        
        public bool ALPHATEST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ALPHATEST"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ALPHATEST",
                    value
                );
            }
        }

        
        public bool DEPTHPREPASS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DEPTHPREPASS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEPTHPREPASS",
                    value
                );
            }
        }

        
        public bool ALPHAFROMDIFFUSE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ALPHAFROMDIFFUSE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ALPHAFROMDIFFUSE",
                    value
                );
            }
        }

        
        public bool POINTSIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "POINTSIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "POINTSIZE",
                    value
                );
            }
        }

        
        public bool FOG
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "FOG"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FOG",
                    value
                );
            }
        }

        
        public bool SPECULARTERM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULARTERM"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULARTERM",
                    value
                );
            }
        }

        
        public bool DIFFUSEFRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DIFFUSEFRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DIFFUSEFRESNEL",
                    value
                );
            }
        }

        
        public bool OPACITYFRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OPACITYFRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OPACITYFRESNEL",
                    value
                );
            }
        }

        
        public bool REFLECTIONFRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONFRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONFRESNEL",
                    value
                );
            }
        }

        
        public bool REFRACTIONFRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTIONFRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTIONFRESNEL",
                    value
                );
            }
        }

        
        public bool EMISSIVEFRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVEFRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEFRESNEL",
                    value
                );
            }
        }

        
        public bool FRESNEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "FRESNEL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FRESNEL",
                    value
                );
            }
        }

        
        public bool NORMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "NORMAL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NORMAL",
                    value
                );
            }
        }

        
        public bool UV1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "UV1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UV1",
                    value
                );
            }
        }

        
        public bool UV2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "UV2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UV2",
                    value
                );
            }
        }

        
        public bool VERTEXCOLOR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VERTEXCOLOR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VERTEXCOLOR",
                    value
                );
            }
        }

        
        public bool VERTEXALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VERTEXALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VERTEXALPHA",
                    value
                );
            }
        }

        
        public decimal NUM_BONE_INFLUENCERS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS",
                    value
                );
            }
        }

        
        public decimal BonesPerMesh
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BonesPerMesh"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BonesPerMesh",
                    value
                );
            }
        }

        
        public bool BONETEXTURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BONETEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BONETEXTURE",
                    value
                );
            }
        }

        
        public bool INSTANCES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "INSTANCES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "INSTANCES",
                    value
                );
            }
        }

        
        public bool GLOSSINESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "GLOSSINESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GLOSSINESS",
                    value
                );
            }
        }

        
        public bool ROUGHNESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ROUGHNESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ROUGHNESS",
                    value
                );
            }
        }

        
        public bool EMISSIVEASILLUMINATION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EMISSIVEASILLUMINATION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EMISSIVEASILLUMINATION",
                    value
                );
            }
        }

        
        public bool LINKEMISSIVEWITHDIFFUSE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LINKEMISSIVEWITHDIFFUSE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LINKEMISSIVEWITHDIFFUSE",
                    value
                );
            }
        }

        
        public bool REFLECTIONFRESNELFROMSPECULAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONFRESNELFROMSPECULAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONFRESNELFROMSPECULAR",
                    value
                );
            }
        }

        
        public bool LIGHTMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LIGHTMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LIGHTMAP",
                    value
                );
            }
        }

        
        public decimal LIGHTMAPDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LIGHTMAPDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LIGHTMAPDIRECTUV",
                    value
                );
            }
        }

        
        public bool OBJECTSPACE_NORMALMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "OBJECTSPACE_NORMALMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "OBJECTSPACE_NORMALMAP",
                    value
                );
            }
        }

        
        public bool USELIGHTMAPASSHADOWMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "USELIGHTMAPASSHADOWMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "USELIGHTMAPASSHADOWMAP",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_3D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_3D"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_3D",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_SPHERICAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_SPHERICAL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_SPHERICAL",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_PLANAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_PLANAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_PLANAR",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_CUBIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_CUBIC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_CUBIC",
                    value
                );
            }
        }

        
        public bool USE_LOCAL_REFLECTIONMAP_CUBIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "USE_LOCAL_REFLECTIONMAP_CUBIC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "USE_LOCAL_REFLECTIONMAP_CUBIC",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_PROJECTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_PROJECTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_PROJECTION",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_SKYBOX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_SKYBOX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_SKYBOX",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_EXPLICIT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EXPLICIT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EXPLICIT",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_EQUIRECTANGULAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_EQUIRECTANGULAR_FIXED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR_FIXED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_EQUIRECTANGULAR_FIXED",
                    value
                );
            }
        }

        
        public bool REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONMAP_MIRROREDEQUIRECTANGULAR_FIXED",
                    value
                );
            }
        }

        
        public bool INVERTCUBICMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "INVERTCUBICMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "INVERTCUBICMAP",
                    value
                );
            }
        }

        
        public bool LOGARITHMICDEPTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "LOGARITHMICDEPTH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "LOGARITHMICDEPTH",
                    value
                );
            }
        }

        
        public bool REFRACTION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTION",
                    value
                );
            }
        }

        
        public bool REFRACTIONMAP_3D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFRACTIONMAP_3D"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFRACTIONMAP_3D",
                    value
                );
            }
        }

        
        public bool REFLECTIONOVERALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "REFLECTIONOVERALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "REFLECTIONOVERALPHA",
                    value
                );
            }
        }

        
        public bool TWOSIDEDLIGHTING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TWOSIDEDLIGHTING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TWOSIDEDLIGHTING",
                    value
                );
            }
        }

        
        public bool SHADOWFLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SHADOWFLOAT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SHADOWFLOAT",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_NORMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_NORMAL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_NORMAL",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_TANGENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_TANGENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_TANGENT",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_UV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_UV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_UV",
                    value
                );
            }
        }

        
        public decimal NUM_MORPH_INFLUENCERS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS",
                    value
                );
            }
        }

        
        public bool NONUNIFORMSCALING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "NONUNIFORMSCALING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NONUNIFORMSCALING",
                    value
                );
            }
        }

        
        public bool PREMULTIPLYALPHA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "PREMULTIPLYALPHA"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PREMULTIPLYALPHA",
                    value
                );
            }
        }

        
        public bool IMAGEPROCESSING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSING",
                    value
                );
            }
        }

        
        public bool VIGNETTE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTE",
                    value
                );
            }
        }

        
        public bool VIGNETTEBLENDMODEMULTIPLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY",
                    value
                );
            }
        }

        
        public bool VIGNETTEBLENDMODEOPAQUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE",
                    value
                );
            }
        }

        
        public bool TONEMAPPING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING",
                    value
                );
            }
        }

        
        public bool TONEMAPPING_ACES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING_ACES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING_ACES",
                    value
                );
            }
        }

        
        public bool CONTRAST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CONTRAST"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTRAST",
                    value
                );
            }
        }

        
        public bool COLORCURVES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORCURVES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORCURVES",
                    value
                );
            }
        }

        
        public bool COLORGRADING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING",
                    value
                );
            }
        }

        
        public bool COLORGRADING3D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING3D"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING3D",
                    value
                );
            }
        }

        
        public bool SAMPLER3DGREENDEPTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH",
                    value
                );
            }
        }

        
        public bool SAMPLER3DBGRMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DBGRMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DBGRMAP",
                    value
                );
            }
        }

        
        public bool IMAGEPROCESSINGPOSTPROCESS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS",
                    value
                );
            }
        }

        
        public bool MULTIVIEW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MULTIVIEW"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MULTIVIEW",
                    value
                );
            }
        }

        
        public bool IS_REFLECTION_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IS_REFLECTION_LINEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IS_REFLECTION_LINEAR",
                    value
                );
            }
        }

        
        public bool IS_REFRACTION_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IS_REFRACTION_LINEAR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IS_REFRACTION_LINEAR",
                    value
                );
            }
        }

        
        public bool EXPOSURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EXPOSURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EXPOSURE",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public StandardMaterialDefines() : base() { }

        public StandardMaterialDefines(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void setReflectionMode(string modeToEnable)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setReflectionMode" }, modeToEnable
                }
            );
        }
        #endregion
    }
}