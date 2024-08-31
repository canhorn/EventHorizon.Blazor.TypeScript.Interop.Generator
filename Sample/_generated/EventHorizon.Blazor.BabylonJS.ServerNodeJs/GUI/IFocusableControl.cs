/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IFocusableControl : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IFocusableControlCachedEntity>))]
    public class IFocusableControlCachedEntity : CachedEntityObject, IFocusableControl
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

        public async ValueTask<decimal> get_tabIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tabIndex");
        }

        public ValueTask set_tabIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "tabIndex", value);
        }

        public async ValueTask<string> get_focusBorderColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "focusBorderColor");
        }

        public ValueTask set_focusBorderColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "focusBorderColor", value);
        }
        #endregion

        #region Constructor
        public IFocusableControlCachedEntity()
            : base() { }

        public IFocusableControlCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask onFocus()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onFocus" } }
            );
        }

        public async ValueTask onBlur()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onBlur" } }
            );
        }

        public async ValueTask processKeyboard(IKeyboardEvent evt)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "processKeyboard" }, evt }
            );
        }

        public async ValueTask<Control[]> keepsFocusWith()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "keepsFocusWith" } }
            );
        }

        public async ValueTask focus()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "focus" } }
            );
        }

        public async ValueTask blur()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "blur" } }
            );
        }
        #endregion
    }
}
