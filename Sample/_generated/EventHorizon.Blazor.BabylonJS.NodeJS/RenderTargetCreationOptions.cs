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

        public bool generateDepthBuffer
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateDepthBuffer"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateDepthBuffer", value);
            }
        }

        public bool generateStencilBuffer
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateStencilBuffer");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateStencilBuffer", value);
            }
        }

        public bool noColorAttachment
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "noColorAttachment"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "noColorAttachment", value);
            }
        }

        private InternalTexture __colorAttachment;
        public InternalTexture colorAttachment
        {
            get
            {
                if (__colorAttachment == null)
                {
                    __colorAttachment = EventHorizonBlazorInterop.GetClass<InternalTexture>(
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
            set
            {
                __colorAttachment = null;
                EventHorizonBlazorInterop.Set(this.___guid, "colorAttachment", value);
            }
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
