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

    public interface IScreenshotSize : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IScreenshotSizeCachedEntity>))]
    public class IScreenshotSizeCachedEntity : CachedEntityObject, IScreenshotSize
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

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "height", value);
            }
        }

        public decimal precision
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "precision"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "precision", value);
            }
        }

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "width", value);
            }
        }

        public decimal finalWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "finalWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "finalWidth", value);
            }
        }

        public decimal finalHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "finalHeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "finalHeight", value);
            }
        }
        #endregion

        #region Constructor
        public IScreenshotSizeCachedEntity()
            : base() { }

        public IScreenshotSizeCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
