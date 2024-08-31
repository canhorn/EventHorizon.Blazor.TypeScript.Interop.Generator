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

        public async ValueTask<bool> get_altKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "altKey");
        }

        public ValueTask set_altKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "altKey", value);
        }

        public async ValueTask<decimal> get_charCode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "charCode");
        }

        public ValueTask set_charCode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "charCode", value);
        }

        public async ValueTask<string> get_code()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "code");
        }

        public ValueTask set_code(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "code", value);
        }

        public async ValueTask<bool> get_ctrlKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ctrlKey");
        }

        public ValueTask set_ctrlKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ctrlKey", value);
        }

        public async ValueTask<string> get_key()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "key");
        }

        public ValueTask set_key(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "key", value);
        }

        public async ValueTask<decimal> get_keyCode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "keyCode");
        }

        public ValueTask set_keyCode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "keyCode", value);
        }

        public async ValueTask<bool> get_metaKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "metaKey");
        }

        public ValueTask set_metaKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "metaKey", value);
        }

        public async ValueTask<bool> get_shiftKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "shiftKey");
        }

        public ValueTask set_shiftKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shiftKey", value);
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
