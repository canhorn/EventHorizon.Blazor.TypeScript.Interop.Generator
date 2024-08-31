/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<decimal> get_maxTexturesImageUnits()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxTexturesImageUnits"
            );
        }

        public ValueTask set_maxTexturesImageUnits(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxTexturesImageUnits", value);
        }

        public async ValueTask<decimal> get_maxVertexTextureImageUnits()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxVertexTextureImageUnits"
            );
        }

        public ValueTask set_maxVertexTextureImageUnits(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxVertexTextureImageUnits", value);
        }

        public async ValueTask<decimal> get_maxCombinedTexturesImageUnits()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxCombinedTexturesImageUnits"
            );
        }

        public ValueTask set_maxCombinedTexturesImageUnits(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "maxCombinedTexturesImageUnits",
                value
            );
        }

        public async ValueTask<decimal> get_maxTextureSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxTextureSize");
        }

        public ValueTask set_maxTextureSize(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxTextureSize", value);
        }

        public async ValueTask<decimal> get_maxSamples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxSamples");
        }

        public ValueTask set_maxSamples(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxSamples", value);
        }

        public async ValueTask<decimal> get_maxCubemapTextureSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxCubemapTextureSize"
            );
        }

        public ValueTask set_maxCubemapTextureSize(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxCubemapTextureSize", value);
        }

        public async ValueTask<decimal> get_maxRenderTextureSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxRenderTextureSize"
            );
        }

        public ValueTask set_maxRenderTextureSize(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxRenderTextureSize", value);
        }

        public async ValueTask<decimal> get_maxVertexAttribs()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxVertexAttribs");
        }

        public ValueTask set_maxVertexAttribs(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxVertexAttribs", value);
        }

        public async ValueTask<decimal> get_maxVaryingVectors()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxVaryingVectors");
        }

        public ValueTask set_maxVaryingVectors(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxVaryingVectors", value);
        }

        public async ValueTask<decimal> get_maxVertexUniformVectors()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxVertexUniformVectors"
            );
        }

        public ValueTask set_maxVertexUniformVectors(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxVertexUniformVectors", value);
        }

        public async ValueTask<decimal> get_maxFragmentUniformVectors()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "maxFragmentUniformVectors"
            );
        }

        public ValueTask set_maxFragmentUniformVectors(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxFragmentUniformVectors", value);
        }

        public async ValueTask<bool> get_standardDerivatives()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "standardDerivatives");
        }

        public ValueTask set_standardDerivatives(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "standardDerivatives", value);
        }

        private WEBGL_compressed_texture_s3tc __s3tc;

        public async ValueTask<WEBGL_compressed_texture_s3tc> get_s3tc()
        {
            if (__s3tc == null)
            {
                __s3tc = await EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_s3tc>(
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

        public ValueTask set_s3tc(WEBGL_compressed_texture_s3tc value)
        {
            __s3tc = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "s3tc", value);
        }

        private WEBGL_compressed_texture_s3tc_srgb __s3tc_srgb;

        public async ValueTask<WEBGL_compressed_texture_s3tc_srgb> get_s3tc_srgb()
        {
            if (__s3tc_srgb == null)
            {
                __s3tc_srgb =
                    await EventHorizonBlazorInterop.GetClass<WEBGL_compressed_texture_s3tc_srgb>(
                        this.___guid,
                        "s3tc_srgb",
                        (entity) =>
                        {
                            return new WEBGL_compressed_texture_s3tc_srgb()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __s3tc_srgb;
        }

        public ValueTask set_s3tc_srgb(WEBGL_compressed_texture_s3tc_srgb value)
        {
            __s3tc_srgb = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "s3tc_srgb", value);
        }

        public async ValueTask<CachedEntity> get_pvrtc()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "pvrtc",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_pvrtc(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pvrtc", value);
        }

        public async ValueTask<CachedEntity> get_etc1()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "etc1",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_etc1(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "etc1", value);
        }

        public async ValueTask<CachedEntity> get_etc2()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "etc2",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_etc2(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "etc2", value);
        }

        public async ValueTask<CachedEntity> get_astc()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "astc",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_astc(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "astc", value);
        }

        public async ValueTask<CachedEntity> get_bptc()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "bptc",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_bptc(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "bptc", value);
        }

        public async ValueTask<bool> get_textureFloat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "textureFloat");
        }

        public ValueTask set_textureFloat(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureFloat", value);
        }

        public async ValueTask<bool> get_vertexArrayObject()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "vertexArrayObject");
        }

        public ValueTask set_vertexArrayObject(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "vertexArrayObject", value);
        }

        private EXT_texture_filter_anisotropic __textureAnisotropicFilterExtension;

        public async ValueTask<EXT_texture_filter_anisotropic> get_textureAnisotropicFilterExtension()
        {
            if (__textureAnisotropicFilterExtension == null)
            {
                __textureAnisotropicFilterExtension =
                    await EventHorizonBlazorInterop.GetClass<EXT_texture_filter_anisotropic>(
                        this.___guid,
                        "textureAnisotropicFilterExtension",
                        (entity) =>
                        {
                            return new EXT_texture_filter_anisotropic()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __textureAnisotropicFilterExtension;
        }

        public ValueTask set_textureAnisotropicFilterExtension(EXT_texture_filter_anisotropic value)
        {
            __textureAnisotropicFilterExtension = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "textureAnisotropicFilterExtension",
                value
            );
        }

        public async ValueTask<decimal> get_maxAnisotropy()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxAnisotropy");
        }

        public ValueTask set_maxAnisotropy(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxAnisotropy", value);
        }

        public async ValueTask<bool> get_instancedArrays()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "instancedArrays");
        }

        public ValueTask set_instancedArrays(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "instancedArrays", value);
        }

        public async ValueTask<bool> get_uintIndices()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "uintIndices");
        }

        public ValueTask set_uintIndices(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uintIndices", value);
        }

        public async ValueTask<bool> get_highPrecisionShaderSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "highPrecisionShaderSupported"
            );
        }

        public ValueTask set_highPrecisionShaderSupported(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "highPrecisionShaderSupported",
                value
            );
        }

        public async ValueTask<bool> get_fragmentDepthSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "fragmentDepthSupported"
            );
        }

        public ValueTask set_fragmentDepthSupported(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fragmentDepthSupported", value);
        }

        public async ValueTask<bool> get_textureFloatLinearFiltering()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "textureFloatLinearFiltering"
            );
        }

        public ValueTask set_textureFloatLinearFiltering(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "textureFloatLinearFiltering",
                value
            );
        }

        public async ValueTask<bool> get_textureFloatRender()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "textureFloatRender");
        }

        public ValueTask set_textureFloatRender(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureFloatRender", value);
        }

        public async ValueTask<bool> get_textureHalfFloat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "textureHalfFloat");
        }

        public ValueTask set_textureHalfFloat(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureHalfFloat", value);
        }

        public async ValueTask<bool> get_textureHalfFloatLinearFiltering()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "textureHalfFloatLinearFiltering"
            );
        }

        public ValueTask set_textureHalfFloatLinearFiltering(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "textureHalfFloatLinearFiltering",
                value
            );
        }

        public async ValueTask<bool> get_textureHalfFloatRender()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "textureHalfFloatRender"
            );
        }

        public ValueTask set_textureHalfFloatRender(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureHalfFloatRender", value);
        }

        public async ValueTask<bool> get_textureLOD()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "textureLOD");
        }

        public ValueTask set_textureLOD(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureLOD", value);
        }

        public async ValueTask<bool> get_texelFetch()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "texelFetch");
        }

        public ValueTask set_texelFetch(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "texelFetch", value);
        }

        public async ValueTask<bool> get_drawBuffersExtension()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "drawBuffersExtension");
        }

        public ValueTask set_drawBuffersExtension(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "drawBuffersExtension", value);
        }

        public async ValueTask<bool> get_depthTextureExtension()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "depthTextureExtension");
        }

        public ValueTask set_depthTextureExtension(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "depthTextureExtension", value);
        }

        public async ValueTask<bool> get_colorBufferFloat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "colorBufferFloat");
        }

        public ValueTask set_colorBufferFloat(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "colorBufferFloat", value);
        }

        public async ValueTask<bool> get_colorBufferHalfFloat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "colorBufferHalfFloat");
        }

        public ValueTask set_colorBufferHalfFloat(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "colorBufferHalfFloat", value);
        }

        private EXT_disjoint_timer_queryCachedEntity __timerQuery;

        public async ValueTask<EXT_disjoint_timer_queryCachedEntity> get_timerQuery()
        {
            if (__timerQuery == null)
            {
                __timerQuery =
                    await EventHorizonBlazorInterop.GetClass<EXT_disjoint_timer_queryCachedEntity>(
                        this.___guid,
                        "timerQuery",
                        (entity) =>
                        {
                            return new EXT_disjoint_timer_queryCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __timerQuery;
        }

        public ValueTask set_timerQuery(EXT_disjoint_timer_queryCachedEntity value)
        {
            __timerQuery = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "timerQuery", value);
        }

        public async ValueTask<bool> get_canUseTimestampForTimerQuery()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "canUseTimestampForTimerQuery"
            );
        }

        public ValueTask set_canUseTimestampForTimerQuery(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "canUseTimestampForTimerQuery",
                value
            );
        }

        public async ValueTask<bool> get_supportOcclusionQuery()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportOcclusionQuery");
        }

        public ValueTask set_supportOcclusionQuery(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "supportOcclusionQuery", value);
        }

        public async ValueTask<CachedEntity> get_multiview()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "multiview",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_multiview(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "multiview", value);
        }

        public async ValueTask<CachedEntity> get_oculusMultiview()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "oculusMultiview",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_oculusMultiview(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "oculusMultiview", value);
        }

        public async ValueTask<CachedEntity> get_parallelShaderCompile()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "parallelShaderCompile",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_parallelShaderCompile(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "parallelShaderCompile", value);
        }

        public async ValueTask<decimal> get_maxMSAASamples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxMSAASamples");
        }

        public ValueTask set_maxMSAASamples(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxMSAASamples", value);
        }

        public async ValueTask<bool> get_blendMinMax()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "blendMinMax");
        }

        public ValueTask set_blendMinMax(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "blendMinMax", value);
        }

        public async ValueTask<bool> get_canUseGLInstanceID()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "canUseGLInstanceID");
        }

        public ValueTask set_canUseGLInstanceID(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "canUseGLInstanceID", value);
        }

        public async ValueTask<bool> get_canUseGLVertexID()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "canUseGLVertexID");
        }

        public ValueTask set_canUseGLVertexID(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "canUseGLVertexID", value);
        }

        public async ValueTask<bool> get_supportComputeShaders()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportComputeShaders");
        }

        public ValueTask set_supportComputeShaders(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "supportComputeShaders", value);
        }

        public async ValueTask<bool> get_supportSRGBBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportSRGBBuffers");
        }

        public ValueTask set_supportSRGBBuffers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "supportSRGBBuffers", value);
        }

        public async ValueTask<bool> get_supportTransformFeedbacks()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "supportTransformFeedbacks"
            );
        }

        public ValueTask set_supportTransformFeedbacks(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "supportTransformFeedbacks", value);
        }

        public async ValueTask<bool> get_textureMaxLevel()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "textureMaxLevel");
        }

        public ValueTask set_textureMaxLevel(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureMaxLevel", value);
        }

        public async ValueTask<decimal> get_texture2DArrayMaxLayerCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "texture2DArrayMaxLayerCount"
            );
        }

        public ValueTask set_texture2DArrayMaxLayerCount(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "texture2DArrayMaxLayerCount",
                value
            );
        }

        public async ValueTask<bool> get_disableMorphTargetTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "disableMorphTargetTexture"
            );
        }

        public ValueTask set_disableMorphTargetTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableMorphTargetTexture", value);
        }

        public async ValueTask<bool> get_supportFloatTexturesResolve()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "supportFloatTexturesResolve"
            );
        }

        public ValueTask set_supportFloatTexturesResolve(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "supportFloatTexturesResolve",
                value
            );
        }

        public async ValueTask<bool> get_rg11b10ufColorRenderable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "rg11b10ufColorRenderable"
            );
        }

        public ValueTask set_rg11b10ufColorRenderable(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "rg11b10ufColorRenderable", value);
        }
        #endregion

        #region Constructor
        public EngineCapabilitiesCachedEntity()
            : base() { }

        public EngineCapabilitiesCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
