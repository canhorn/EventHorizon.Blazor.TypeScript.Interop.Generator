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

    public interface IMouseEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMouseEventCachedEntity>))]
    public class IMouseEventCachedEntity : CachedEntityObject, IMouseEvent
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

        public async ValueTask<int> get_inputIndex()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "inputIndex");
        }

        public ValueTask set_inputIndex(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "inputIndex", value);
        }

        public async ValueTask<bool> get_altKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "altKey");
        }

        public ValueTask set_altKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "altKey", value);
        }

        public async ValueTask<decimal> get_button()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "button");
        }

        public ValueTask set_button(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "button", value);
        }

        public async ValueTask<decimal> get_buttons()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "buttons");
        }

        public ValueTask set_buttons(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "buttons", value);
        }

        public async ValueTask<decimal> get_clientX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "clientX");
        }

        public ValueTask set_clientX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clientX", value);
        }

        public async ValueTask<decimal> get_clientY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "clientY");
        }

        public ValueTask set_clientY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clientY", value);
        }

        public async ValueTask<bool> get_ctrlKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ctrlKey");
        }

        public ValueTask set_ctrlKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ctrlKey", value);
        }

        public async ValueTask<decimal> get_detail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "detail");
        }

        public ValueTask set_detail(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "detail", value);
        }

        public async ValueTask<bool> get_metaKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "metaKey");
        }

        public ValueTask set_metaKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "metaKey", value);
        }

        public async ValueTask<decimal> get_movementX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "movementX");
        }

        public ValueTask set_movementX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "movementX", value);
        }

        public async ValueTask<decimal> get_movementY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "movementY");
        }

        public ValueTask set_movementY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "movementY", value);
        }

        public async ValueTask<decimal> get_mozMovementX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mozMovementX");
        }

        public ValueTask set_mozMovementX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mozMovementX", value);
        }

        public async ValueTask<decimal> get_mozMovementY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mozMovementY");
        }

        public ValueTask set_mozMovementY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mozMovementY", value);
        }

        public async ValueTask<decimal> get_msMovementX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "msMovementX");
        }

        public ValueTask set_msMovementX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "msMovementX", value);
        }

        public async ValueTask<decimal> get_msMovementY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "msMovementY");
        }

        public ValueTask set_msMovementY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "msMovementY", value);
        }

        public async ValueTask<decimal> get_offsetX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offsetX");
        }

        public ValueTask set_offsetX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "offsetX", value);
        }

        public async ValueTask<decimal> get_offsetY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offsetY");
        }

        public ValueTask set_offsetY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "offsetY", value);
        }

        public async ValueTask<decimal> get_pageX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pageX");
        }

        public ValueTask set_pageX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pageX", value);
        }

        public async ValueTask<decimal> get_pageY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pageY");
        }

        public ValueTask set_pageY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pageY", value);
        }

        public async ValueTask<bool> get_shiftKey()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "shiftKey");
        }

        public ValueTask set_shiftKey(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shiftKey", value);
        }

        public async ValueTask<decimal> get_webkitMovementX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webkitMovementX");
        }

        public ValueTask set_webkitMovementX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "webkitMovementX", value);
        }

        public async ValueTask<decimal> get_webkitMovementY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webkitMovementY");
        }

        public ValueTask set_webkitMovementY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "webkitMovementY", value);
        }

        public async ValueTask<decimal> get_x()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "x");
        }

        public ValueTask set_x(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "x", value);
        }

        public async ValueTask<decimal> get_y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "y");
        }

        public ValueTask set_y(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "y", value);
        }
        #endregion

        #region Constructor
        public IMouseEventCachedEntity()
            : base() { }

        public IMouseEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
