/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
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

        #endregion
        
        #region Constructor
        public IFocusableControlCachedEntity() : base() { }

        public IFocusableControlCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void onFocus()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onFocus" }
                }
            );
        }

        public void onBlur()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "onBlur" }
                }
            );
        }

        public void processKeyboard(KeyboardEvent evt)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processKeyboard" }, evt
                }
            );
        }

        public Control[] keepsFocusWith()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "keepsFocusWith" }
                }
            );
        }
        #endregion
    }
}