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

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public decimal value
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "value"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "value", value);
            }
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
