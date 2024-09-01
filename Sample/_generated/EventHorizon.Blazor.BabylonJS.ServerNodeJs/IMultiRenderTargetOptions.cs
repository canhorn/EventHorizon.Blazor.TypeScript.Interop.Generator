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

    public interface IMultiRenderTargetOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMultiRenderTargetOptionsCachedEntity>))]
    public class IMultiRenderTargetOptionsCachedEntity
        : CachedEntityObject,
            IMultiRenderTargetOptions
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

        public async ValueTask<bool> get_generateMipMaps()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateMipMaps");
        }

        public ValueTask set_generateMipMaps(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "generateMipMaps", value);
        }

        public async ValueTask<decimal[]> get_types()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "types");
        }

        public ValueTask set_types(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "types", value);
        }

        public async ValueTask<decimal[]> get_samplingModes()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "samplingModes");
        }

        public ValueTask set_samplingModes(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samplingModes", value);
        }

        public async ValueTask<bool[]> get_useSRGBBuffers()
        {
            return await EventHorizonBlazorInterop.GetArray<bool>(this.___guid, "useSRGBBuffers");
        }

        public ValueTask set_useSRGBBuffers(bool[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useSRGBBuffers", value);
        }

        public async ValueTask<bool> get_generateDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateDepthBuffer");
        }

        public ValueTask set_generateDepthBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "generateDepthBuffer", value);
        }

        public async ValueTask<bool> get_generateStencilBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateStencilBuffer");
        }

        public ValueTask set_generateStencilBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "generateStencilBuffer", value);
        }

        public async ValueTask<bool> get_generateDepthTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateDepthTexture");
        }

        public ValueTask set_generateDepthTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "generateDepthTexture", value);
        }

        public async ValueTask<decimal[]> get_formats()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "formats");
        }

        public ValueTask set_formats(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "formats", value);
        }

        public async ValueTask<decimal> get_depthTextureFormat()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "depthTextureFormat");
        }

        public ValueTask set_depthTextureFormat(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "depthTextureFormat", value);
        }

        public async ValueTask<decimal> get_textureCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "textureCount");
        }

        public ValueTask set_textureCount(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "textureCount", value);
        }

        public async ValueTask<bool> get_doNotChangeAspectRatio()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "doNotChangeAspectRatio"
            );
        }

        public ValueTask set_doNotChangeAspectRatio(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "doNotChangeAspectRatio", value);
        }

        public async ValueTask<decimal> get_defaultType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "defaultType");
        }

        public ValueTask set_defaultType(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "defaultType", value);
        }

        public async ValueTask<bool> get_drawOnlyOnFirstAttachmentByDefault()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "drawOnlyOnFirstAttachmentByDefault"
            );
        }

        public ValueTask set_drawOnlyOnFirstAttachmentByDefault(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "drawOnlyOnFirstAttachmentByDefault",
                value
            );
        }

        public async ValueTask<decimal[]> get_targetTypes()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "targetTypes");
        }

        public ValueTask set_targetTypes(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "targetTypes", value);
        }

        public async ValueTask<decimal[]> get_faceIndex()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "faceIndex");
        }

        public ValueTask set_faceIndex(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "faceIndex", value);
        }

        public async ValueTask<decimal[]> get_layerIndex()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerIndex");
        }

        public ValueTask set_layerIndex(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "layerIndex", value);
        }

        public async ValueTask<decimal[]> get_layerCounts()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerCounts");
        }

        public ValueTask set_layerCounts(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "layerCounts", value);
        }

        public async ValueTask<string[]> get_labels()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(this.___guid, "labels");
        }

        public ValueTask set_labels(string[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "labels", value);
        }

        public async ValueTask<string> get_label()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "label");
        }

        public ValueTask set_label(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "label", value);
        }
        #endregion

        #region Constructor
        public IMultiRenderTargetOptionsCachedEntity()
            : base() { }

        public IMultiRenderTargetOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
