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

    public interface IMaterialDetailMapDefines : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IMaterialDetailMapDefinesCachedEntity>))]
    public class IMaterialDetailMapDefinesCachedEntity : CachedEntityObject, IMaterialDetailMapDefines
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
        
        public async ValueTask<bool> get_DETAIL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "DETAIL"
                );
        }
        public ValueTask set_DETAIL(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DETAIL",
                    value
                );
        }

        
        public async ValueTask<decimal> get_DETAILDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DETAILDIRECTUV"
                );
        }
        public ValueTask set_DETAILDIRECTUV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DETAILDIRECTUV",
                    value
                );
        }

        
        public async ValueTask<decimal> get_DETAIL_NORMALBLENDMETHOD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DETAIL_NORMALBLENDMETHOD"
                );
        }
        public ValueTask set_DETAIL_NORMALBLENDMETHOD(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DETAIL_NORMALBLENDMETHOD",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IMaterialDetailMapDefinesCachedEntity() : base() { }

        public IMaterialDetailMapDefinesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}