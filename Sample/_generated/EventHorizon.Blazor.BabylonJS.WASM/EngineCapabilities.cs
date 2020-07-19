/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface EngineCapabilities : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class EngineCapabilitiesCachedEntity : CachedEntityObject, EngineCapabilities
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
        
        public decimal maxTexturesImageUnits
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxTexturesImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxTexturesImageUnits",
                    value
                );
            }
        }

        
        public decimal maxVertexTextureImageUnits
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxVertexTextureImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxVertexTextureImageUnits",
                    value
                );
            }
        }

        
        public decimal maxCombinedTexturesImageUnits
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxCombinedTexturesImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxCombinedTexturesImageUnits",
                    value
                );
            }
        }

        
        public decimal maxTextureSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxTextureSize",
                    value
                );
            }
        }

        
        public decimal maxSamples
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxSamples"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxSamples",
                    value
                );
            }
        }

        
        public decimal maxCubemapTextureSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxCubemapTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxCubemapTextureSize",
                    value
                );
            }
        }

        
        public decimal maxRenderTextureSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxRenderTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxRenderTextureSize",
                    value
                );
            }
        }

        
        public decimal maxVertexAttribs
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxVertexAttribs"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxVertexAttribs",
                    value
                );
            }
        }

        
        public decimal maxVaryingVectors
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxVaryingVectors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxVaryingVectors",
                    value
                );
            }
        }

        
        public decimal maxVertexUniformVectors
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxVertexUniformVectors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxVertexUniformVectors",
                    value
                );
            }
        }

        
        public decimal maxFragmentUniformVectors
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxFragmentUniformVectors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxFragmentUniformVectors",
                    value
                );
            }
        }

        
        public bool standardDerivatives
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "standardDerivatives"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "standardDerivatives",
                    value
                );
            }
        }

        private WEBGL_compressed_texture_s3tc __s3tc;
        public WEBGL_compressed_texture_s3tc s3tc
        {
            get
            {
            if(__s3tc == null)
            {
                __s3tc = EventHorizonBlazorInteropt.GetClass<WEBGL_compressed_texture_s3tc>(
                    this.___guid,
                    "s3tc",
                    (entity) =>
                    {
                        return new WEBGL_compressed_texture_s3tc() { ___guid = entity.___guid };
                    }
                );
            }
            return __s3tc;
            }
            set
            {
__s3tc = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "s3tc",
                    value
                );
            }
        }

        
        public CachedEntity pvrtc
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "pvrtc"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pvrtc",
                    value
                );
            }
        }

        
        public CachedEntity etc1
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "etc1"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "etc1",
                    value
                );
            }
        }

        
        public CachedEntity etc2
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "etc2"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "etc2",
                    value
                );
            }
        }

        
        public CachedEntity astc
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "astc"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "astc",
                    value
                );
            }
        }

        
        public bool textureFloat
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureFloat"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureFloat",
                    value
                );
            }
        }

        
        public bool vertexArrayObject
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "vertexArrayObject"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vertexArrayObject",
                    value
                );
            }
        }

        private EXT_texture_filter_anisotropic __textureAnisotropicFilterExtension;
        public EXT_texture_filter_anisotropic textureAnisotropicFilterExtension
        {
            get
            {
            if(__textureAnisotropicFilterExtension == null)
            {
                __textureAnisotropicFilterExtension = EventHorizonBlazorInteropt.GetClass<EXT_texture_filter_anisotropic>(
                    this.___guid,
                    "textureAnisotropicFilterExtension",
                    (entity) =>
                    {
                        return new EXT_texture_filter_anisotropic() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureAnisotropicFilterExtension;
            }
            set
            {
__textureAnisotropicFilterExtension = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureAnisotropicFilterExtension",
                    value
                );
            }
        }

        
        public decimal maxAnisotropy
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxAnisotropy"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxAnisotropy",
                    value
                );
            }
        }

        
        public bool instancedArrays
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "instancedArrays"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "instancedArrays",
                    value
                );
            }
        }

        
        public bool uintIndices
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "uintIndices"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uintIndices",
                    value
                );
            }
        }

        
        public bool highPrecisionShaderSupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "highPrecisionShaderSupported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "highPrecisionShaderSupported",
                    value
                );
            }
        }

        
        public bool fragmentDepthSupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "fragmentDepthSupported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fragmentDepthSupported",
                    value
                );
            }
        }

        
        public bool textureFloatLinearFiltering
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureFloatLinearFiltering"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureFloatLinearFiltering",
                    value
                );
            }
        }

        
        public bool textureFloatRender
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureFloatRender"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureFloatRender",
                    value
                );
            }
        }

        
        public bool textureHalfFloat
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureHalfFloat"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureHalfFloat",
                    value
                );
            }
        }

        
        public bool textureHalfFloatLinearFiltering
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureHalfFloatLinearFiltering"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureHalfFloatLinearFiltering",
                    value
                );
            }
        }

        
        public bool textureHalfFloatRender
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureHalfFloatRender"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureHalfFloatRender",
                    value
                );
            }
        }

        
        public bool textureLOD
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "textureLOD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textureLOD",
                    value
                );
            }
        }

        
        public bool drawBuffersExtension
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "drawBuffersExtension"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "drawBuffersExtension",
                    value
                );
            }
        }

        
        public bool depthTextureExtension
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "depthTextureExtension"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depthTextureExtension",
                    value
                );
            }
        }

        
        public bool colorBufferFloat
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "colorBufferFloat"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "colorBufferFloat",
                    value
                );
            }
        }

        private EXT_disjoint_timer_queryCachedEntity __timerQuery;
        public EXT_disjoint_timer_queryCachedEntity timerQuery
        {
            get
            {
            if(__timerQuery == null)
            {
                __timerQuery = EventHorizonBlazorInteropt.GetClass<EXT_disjoint_timer_queryCachedEntity>(
                    this.___guid,
                    "timerQuery",
                    (entity) =>
                    {
                        return new EXT_disjoint_timer_queryCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __timerQuery;
            }
            set
            {
__timerQuery = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "timerQuery",
                    value
                );
            }
        }

        
        public bool canUseTimestampForTimerQuery
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "canUseTimestampForTimerQuery"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "canUseTimestampForTimerQuery",
                    value
                );
            }
        }

        
        public CachedEntity multiview
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "multiview"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "multiview",
                    value
                );
            }
        }

        
        public CachedEntity oculusMultiview
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "oculusMultiview"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "oculusMultiview",
                    value
                );
            }
        }

        
        public CachedEntity parallelShaderCompile
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "parallelShaderCompile"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "parallelShaderCompile",
                    value
                );
            }
        }

        
        public decimal maxMSAASamples
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxMSAASamples"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxMSAASamples",
                    value
                );
            }
        }

        
        public bool blendMinMax
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "blendMinMax"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "blendMinMax",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EngineCapabilitiesCachedEntity() : base() { }

        public EngineCapabilitiesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}