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

    public interface IPerfCustomEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPerfCustomEventCachedEntity>))]
    public class IPerfCustomEventCachedEntity : CachedEntityObject, IPerfCustomEvent
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

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<decimal> get_value()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "value");
        }

        public ValueTask set_value(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "value", value);
        }
        #endregion

        #region Constructor
        public IPerfCustomEventCachedEntity()
            : base() { }

        public IPerfCustomEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
