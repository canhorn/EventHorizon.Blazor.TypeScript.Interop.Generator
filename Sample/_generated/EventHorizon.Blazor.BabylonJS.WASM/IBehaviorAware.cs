/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IBehaviorAware { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IBehaviorAwareCachedEntity : CachedEntityObject, IBehaviorAware
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
        public CachedEntity addBehavior(Behavior behavior)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addBehavior" }, behavior
                }
            );
        }

        public CachedEntity removeBehavior(Behavior behavior)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeBehavior" }, behavior
                }
            );
        }

        public Behavior getBehaviorByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Behavior>(
                entity => new BehaviorCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBehaviorByName" }, name
                }
            );
        }
        #endregion
    }
}