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

    public interface IObliqueParams : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IObliqueParamsCachedEntity>))]
    public class IObliqueParamsCachedEntity : CachedEntityObject, IObliqueParams
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

        public async ValueTask<decimal> get_angle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "angle");
        }

        public ValueTask set_angle(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "angle", value);
        }

        public async ValueTask<decimal> get_length()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "length");
        }

        public ValueTask set_length(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "length", value);
        }

        public async ValueTask<decimal> get_offset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offset");
        }

        public ValueTask set_offset(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "offset", value);
        }
        #endregion

        #region Constructor
        public IObliqueParamsCachedEntity()
            : base() { }

        public IObliqueParamsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
