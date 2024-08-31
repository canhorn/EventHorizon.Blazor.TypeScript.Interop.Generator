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

    public interface ITextMetrics : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ITextMetricsCachedEntity>))]
    public class ITextMetricsCachedEntity : CachedEntityObject, ITextMetrics
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

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
        }

        public decimal actualBoundingBoxLeft
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxLeft"
                );
            }
        }

        public decimal actualBoundingBoxRight
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxRight"
                );
            }
        }

        public decimal actualBoundingBoxAscent
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxAscent"
                );
            }
        }

        public decimal actualBoundingBoxDescent
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "actualBoundingBoxDescent"
                );
            }
        }
        #endregion

        #region Constructor
        public ITextMetricsCachedEntity()
            : base() { }

        public ITextMetricsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
