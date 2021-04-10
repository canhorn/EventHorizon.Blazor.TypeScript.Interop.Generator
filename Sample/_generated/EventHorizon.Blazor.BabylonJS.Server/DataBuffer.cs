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

    
    
    [JsonConverter(typeof(CachedEntityConverter<DataBuffer>))]
    public class DataBuffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<CachedEntity> get_underlyingResource()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "underlyingResource"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_references()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "references"
                );
        }
        public ValueTask set_references(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "references",
                    value
                );
        }

        
        public async ValueTask<decimal> get_capacity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "capacity"
                );
        }
        public ValueTask set_capacity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "capacity",
                    value
                );
        }

        
        public async ValueTask<bool> get_is32Bits()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is32Bits"
                );
        }
        public ValueTask set_is32Bits(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "is32Bits",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public DataBuffer() : base() { } 

        public DataBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}