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

    public interface ISmartArrayLike<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISmartArrayLikeCachedEntity<CachedEntity>>))]
    public class ISmartArrayLikeCachedEntity<T> : CachedEntityObject, ISmartArrayLike<T> where T : CachedEntity, new()
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
        
        public async ValueTask<T[]> get_data()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<T>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_data(T[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
        }

        
        public async ValueTask<decimal> get_length()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
        }
        public ValueTask set_length(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ISmartArrayLikeCachedEntity() : base() { }

        public ISmartArrayLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}