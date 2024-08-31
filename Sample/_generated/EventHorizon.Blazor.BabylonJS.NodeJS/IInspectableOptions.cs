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

        public string label
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "label"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "label", value);
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

        public bool selected
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "selected"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "selected", value);
            }
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
