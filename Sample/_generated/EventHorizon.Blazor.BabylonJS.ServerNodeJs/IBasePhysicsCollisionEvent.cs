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

    public interface IBasePhysicsCollisionEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IBasePhysicsCollisionEventCachedEntity>))]
    public class IBasePhysicsCollisionEventCachedEntity
        : CachedEntityObject,
            IBasePhysicsCollisionEvent
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
        private PhysicsBody __collider;

        public async ValueTask<PhysicsBody> get_collider()
        {
            if (__collider == null)
            {
                __collider = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    this.___guid,
                    "collider",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __collider;
        }

        public ValueTask set_collider(PhysicsBody value)
        {
            __collider = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "collider", value);
        }

        private PhysicsBody __collidedAgainst;

        public async ValueTask<PhysicsBody> get_collidedAgainst()
        {
            if (__collidedAgainst == null)
            {
                __collidedAgainst = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    this.___guid,
                    "collidedAgainst",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __collidedAgainst;
        }

        public ValueTask set_collidedAgainst(PhysicsBody value)
        {
            __collidedAgainst = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "collidedAgainst", value);
        }

        public async ValueTask<decimal> get_colliderIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "colliderIndex");
        }

        public ValueTask set_colliderIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "colliderIndex", value);
        }

        public async ValueTask<decimal> get_collidedAgainstIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "collidedAgainstIndex"
            );
        }

        public ValueTask set_collidedAgainstIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "collidedAgainstIndex", value);
        }

        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "type");
        }

        public ValueTask set_type(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }
        #endregion

        #region Constructor
        public IBasePhysicsCollisionEventCachedEntity()
            : base() { }

        public IBasePhysicsCollisionEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
