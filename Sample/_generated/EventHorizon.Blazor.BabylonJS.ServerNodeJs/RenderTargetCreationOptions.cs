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

    public interface RenderTargetCreationOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<RenderTargetCreationOptionsCachedEntity>))]
    public class RenderTargetCreationOptionsCachedEntity
        : CachedEntityObject,
            RenderTargetCreationOptions
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
        #endregion

        #region Constructor
        public RenderTargetCreationOptionsCachedEntity()
            : base() { }

        public RenderTargetCreationOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
