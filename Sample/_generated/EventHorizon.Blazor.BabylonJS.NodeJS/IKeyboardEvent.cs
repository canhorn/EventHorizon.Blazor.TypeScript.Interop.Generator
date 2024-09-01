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

    public interface IKeyboardEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IKeyboardEventCachedEntity>))]
    public class IKeyboardEventCachedEntity : CachedEntityObject, IKeyboardEvent
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

        public bool altKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "altKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "altKey", value);
            }
        }

        public decimal charCode
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "charCode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "charCode", value);
            }
        }

        public string code
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "code"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "code", value);
            }
        }

        public bool ctrlKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ctrlKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ctrlKey", value);
            }
        }

        public string key
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "key"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "key", value);
            }
        }

        public decimal keyCode
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "keyCode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "keyCode", value);
            }
        }

        public bool metaKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "metaKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "metaKey", value);
            }
        }

        public bool shiftKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "shiftKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shiftKey", value);
            }
        }
        #endregion

        #region Constructor
        public IKeyboardEventCachedEntity()
            : base() { }

        public IKeyboardEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
