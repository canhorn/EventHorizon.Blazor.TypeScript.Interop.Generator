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

    public interface EngineCapabilities : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<EngineCapabilitiesCachedEntity>))]
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxTexturesImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVertexTextureImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxCombinedTexturesImageUnits"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSamples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxCubemapTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxRenderTextureSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVertexAttribs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVaryingVectors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxVertexUniformVectors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxFragmentUniformVectors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "standardDerivatives"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __s3tc = EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_s3tc>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "pvrtc",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "etc1",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "etc2",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "astc",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "astc",
                    value
                );
            }
        }

        
        public CachedEntity bptc
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "bptc",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bptc",
                    value
                );
            }
        }

        
        public bool textureFloat
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureFloat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vertexArrayObject"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __textureAnisotropicFilterExtension = EventHorizonBlazorInterop.GetClass<EXT_texture_filter_anisotropic>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAnisotropy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "instancedArrays"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "uintIndices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "highPrecisionShaderSupported"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fragmentDepthSupported"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureFloatLinearFiltering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureFloatRender"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureHalfFloat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureHalfFloatLinearFiltering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureHalfFloatRender"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "textureLOD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawBuffersExtension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthTextureExtension"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "colorBufferFloat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __timerQuery = EventHorizonBlazorInterop.GetClass<EXT_disjoint_timer_queryCachedEntity>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canUseTimestampForTimerQuery"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "multiview",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "oculusMultiview",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parallelShaderCompile",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxMSAASamples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "blendMinMax"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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