/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    public interface IDisplayChangedEventArgs : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IDisplayChangedEventArgsCachedEntity>))]
    public class IDisplayChangedEventArgsCachedEntity : CachedEntityObject, IDisplayChangedEventArgs
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
        
        public async ValueTask<CachedEntity> get_vrDisplay()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "vrDisplay"
                );
        }
        public ValueTask set_vrDisplay(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vrDisplay",
                    value
                );
        }

        
        public async ValueTask<bool> get_vrSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "vrSupported"
                );
        }
        public ValueTask set_vrSupported(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vrSupported",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IDisplayChangedEventArgsCachedEntity() : base() { }

        public IDisplayChangedEventArgsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}