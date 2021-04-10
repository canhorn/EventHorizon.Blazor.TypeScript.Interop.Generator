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

    public interface HostInformation : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<HostInformationCachedEntity>))]
    public class HostInformationCachedEntity : CachedEntityObject, HostInformation
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
        
        public async ValueTask<bool> get_isMobile()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMobile"
                );
        }
        public ValueTask set_isMobile(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isMobile",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public HostInformationCachedEntity() : base() { }

        public HostInformationCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}