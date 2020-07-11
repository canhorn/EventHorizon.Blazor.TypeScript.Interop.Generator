/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IFocusableControl { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "onFocus" }
                }
            );
        }

        public void onBlur()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "onBlur" }
                }
            );
        }

        public void processKeyboard(KeyboardEvent evt)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "processKeyboard" }, evt
                }
            );
        }

        public Control[] keepsFocusWith()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Control>(
                entity => new Control(entity),
                new object[]
                {
                    new string[] { this.___guid, "keepsFocusWith" }
                }
            );
        }
        #endregion
    }
}