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

        public bool generateMipMaps
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateMipMaps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateMipMaps", value);
            }
        }

        public decimal[] types
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "types"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "types", value);
            }
        }

        public decimal[] samplingModes
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "samplingModes");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samplingModes", value);
            }
        }

        public bool[] useSRGBBuffers
        {
            get { return EventHorizonBlazorInterop.GetArray<bool>(this.___guid, "useSRGBBuffers"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useSRGBBuffers", value);
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

        public bool generateDepthTexture
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateDepthTexture");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateDepthTexture", value);
            }
        }

        public decimal[] formats
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "formats"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "formats", value);
            }
        }

        public decimal depthTextureFormat
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "depthTextureFormat");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "depthTextureFormat", value);
            }
        }

        public decimal textureCount
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "textureCount"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "textureCount", value);
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

        public decimal defaultType
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "defaultType"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "defaultType", value);
            }
        }

        public bool drawOnlyOnFirstAttachmentByDefault
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "drawOnlyOnFirstAttachmentByDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "drawOnlyOnFirstAttachmentByDefault",
                    value
                );
            }
        }

        public decimal[] targetTypes
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "targetTypes"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "targetTypes", value);
            }
        }

        public decimal[] faceIndex
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "faceIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "faceIndex", value);
            }
        }

        public decimal[] layerIndex
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "layerIndex", value);
            }
        }

        public decimal[] layerCounts
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerCounts"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "layerCounts", value);
            }
        }

        public string[] labels
        {
            get { return EventHorizonBlazorInterop.GetArray<string>(this.___guid, "labels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "labels", value);
            }
        }

        public string label
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "label"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "label", value);
            }
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
