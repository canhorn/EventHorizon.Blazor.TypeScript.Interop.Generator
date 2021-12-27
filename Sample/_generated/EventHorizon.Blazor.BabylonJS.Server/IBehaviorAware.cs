/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IBehaviorAware<T> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IBehaviorAwareCachedEntity<CachedEntity>>))]
    public class IBehaviorAwareCachedEntity<T> : CachedEntityObject, IBehaviorAware<T> where T : CachedEntity, new()
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
        public IBehaviorAwareCachedEntity() : base() { }

        public IBehaviorAwareCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<T> addBehavior(Behavior<T> behavior)
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addBehavior" }, behavior
                }
            );
        }

        public async ValueTask<T> removeBehavior(Behavior<T> behavior)
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeBehavior" }, behavior
                }
            );
        }

        public async ValueTask<BehaviorCachedEntity<T>> getBehaviorByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<BehaviorCachedEntity<T>>(
                entity => new BehaviorCachedEntity<T>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBehaviorByName" }, name
                }
            );
        }
        #endregion
    }
}