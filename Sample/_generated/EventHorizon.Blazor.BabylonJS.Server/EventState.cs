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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EventState>))]
    public class EventState : CachedEntityObject
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
        
        public async ValueTask<bool> get_skipNextObservers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipNextObservers"
                );
        }
        public ValueTask set_skipNextObservers(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipNextObservers",
                    value
                );
        }

        
        public async ValueTask<decimal> get_mask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mask"
                );
        }
        public ValueTask set_mask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_target()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_target(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_currentTarget()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "currentTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_currentTarget(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentTarget",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_lastReturnValue()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "lastReturnValue",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_lastReturnValue(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lastReturnValue",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_userInfo()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "userInfo",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_userInfo(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "userInfo",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public EventState() : base() { } 

        public EventState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<EventState> NewEventState(
            decimal mask, System.Nullable<bool> skipNextObservers = null, object target = null, object currentTarget = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "EventState" },
                mask, skipNextObservers, target, currentTarget
            );

            return new EventState(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<EventState> initalize(decimal mask, System.Nullable<bool> skipNextObservers = null, object target = null, object currentTarget = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<EventState>(
                entity => new EventState() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "initalize" }, mask, skipNextObservers, target, currentTarget
                }
            );
        }
        #endregion
    }
}