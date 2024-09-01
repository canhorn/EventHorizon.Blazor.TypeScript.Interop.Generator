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

        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width");
        }

        public async ValueTask<decimal> get_actualBoundingBoxLeft()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "actualBoundingBoxLeft"
            );
        }

        public async ValueTask<decimal> get_actualBoundingBoxRight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "actualBoundingBoxRight"
            );
        }

        public async ValueTask<decimal> get_actualBoundingBoxAscent()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "actualBoundingBoxAscent"
            );
        }

        public async ValueTask<decimal> get_actualBoundingBoxDescent()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "actualBoundingBoxDescent"
            );
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
