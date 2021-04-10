/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        public async ValueTask onFocus()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "onFocus" }
                }
            );
        }

        public async ValueTask onBlur()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "onBlur" }
                }
            );
        }

        public async ValueTask processKeyboard(KeyboardEvent evt)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "processKeyboard" }, evt
                }
            );
        }

        public async ValueTask<Control[]> keepsFocusWith()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
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