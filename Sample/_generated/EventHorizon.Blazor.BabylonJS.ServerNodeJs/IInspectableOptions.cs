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

    public interface IInspectableOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IInspectableOptionsCachedEntity>))]
    public class IInspectableOptionsCachedEntity : CachedEntityObject, IInspectableOptions
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

        public async ValueTask<string> get_label()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "label");
        }

        public ValueTask set_label(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "label", value);
        }

        public async ValueTask<decimal> get_value()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "value");
        }

        public ValueTask set_value(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "value", value);
        }

        public async ValueTask<bool> get_selected()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "selected");
        }

        public ValueTask set_selected(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "selected", value);
        }
        #endregion

        #region Constructor
        public IInspectableOptionsCachedEntity()
            : base() { }

        public IInspectableOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
