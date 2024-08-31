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

    public interface RenderTargetTextureOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<RenderTargetTextureOptionsCachedEntity>))]
    public class RenderTargetTextureOptionsCachedEntity
        : CachedEntityObject,
            RenderTargetTextureOptions
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

        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type");
        }

        public ValueTask set_type(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        public async ValueTask<bool> get_isCube()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCube");
        }

        public ValueTask set_isCube(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isCube", value);
        }

        public async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samplingMode");
        }

        public ValueTask set_samplingMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samplingMode", value);
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

        public async ValueTask<bool> get_isMulti()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti");
        }

        public ValueTask set_isMulti(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isMulti", value);
        }

        public async ValueTask<decimal> get_format()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "format");
        }

        public ValueTask set_format(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "format", value);
        }

        public async ValueTask<bool> get_delayAllocation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "delayAllocation");
        }

        public ValueTask set_delayAllocation(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "delayAllocation", value);
        }

        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples");
        }

        public ValueTask set_samples(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
        }

        public async ValueTask<decimal> get_creationFlags()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "creationFlags");
        }

        public ValueTask set_creationFlags(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "creationFlags", value);
        }

        public async ValueTask<bool> get_noColorAttachment()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "noColorAttachment");
        }

        public ValueTask set_noColorAttachment(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "noColorAttachment", value);
        }

        private InternalTexture __colorAttachment;

        public async ValueTask<InternalTexture> get_colorAttachment()
        {
            if (__colorAttachment == null)
            {
                __colorAttachment = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
                    this.___guid,
                    "colorAttachment",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorAttachment;
        }

        public ValueTask set_colorAttachment(InternalTexture value)
        {
            __colorAttachment = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "colorAttachment", value);
        }

        public async ValueTask<bool> get_useSRGBBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useSRGBBuffer");
        }

        public ValueTask set_useSRGBBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useSRGBBuffer", value);
        }

        public async ValueTask<bool> get_gammaSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "gammaSpace");
        }

        public ValueTask set_gammaSpace(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "gammaSpace", value);
        }
        #endregion

        #region Constructor
        public RenderTargetTextureOptionsCachedEntity()
            : base() { }

        public RenderTargetTextureOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
