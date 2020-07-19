/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISmartArrayLike<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
        
        public T[] data
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<T>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
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