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

        public bool generateMipMaps
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateMipMaps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateMipMaps", value);
            }
        }

        public bool doNotChangeAspectRatio
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotChangeAspectRatio");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "doNotChangeAspectRatio", value);
            }
        }

        public decimal type
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        public bool isCube
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCube"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isCube", value);
            }
        }

        public decimal samplingMode
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samplingMode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samplingMode", value);
            }
        }

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

        public bool isMulti
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isMulti", value);
            }
        }

        public decimal format
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "format"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "format", value);
            }
        }

        public bool delayAllocation
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "delayAllocation"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "delayAllocation", value);
            }
        }

        public decimal samples
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
            }
        }

        public decimal creationFlags
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "creationFlags"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "creationFlags", value);
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

        public bool useSRGBBuffer
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useSRGBBuffer"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useSRGBBuffer", value);
            }
        }

        public bool gammaSpace
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "gammaSpace"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "gammaSpace", value);
            }
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
