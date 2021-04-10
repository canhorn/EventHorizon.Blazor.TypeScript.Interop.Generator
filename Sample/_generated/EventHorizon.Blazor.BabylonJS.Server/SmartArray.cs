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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SmartArray<CachedEntity>>))]
    public class SmartArray<T> : CachedEntityObject, ISmartArrayLike<T> where T : CachedEntity, new()
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
        public SmartArray() : base() { }

        public SmartArray(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<SmartArray<T>> NewSmartArray(
            decimal capacity
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SmartArray" },
                capacity
            );

            return new SmartArray<T>(entity);
        }
        #endregion

        #region Methods
        public async ValueTask push(T value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "push" }, value
                }
            );
        }

        public async ValueTask forEach(ActionCallback<T> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forEach" }, func
                }
            );
        }

        public async ValueTask sort(ActionCallback<T, T> compareFn)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sort" }, compareFn
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask concat(object array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "concat" }, array
                }
            );
        }

        public async ValueTask<decimal> indexOf(T value)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "indexOf" }, value
                }
            );
        }

        public async ValueTask<bool> contains(T value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, value
                }
            );
        }
        #endregion
    }
}