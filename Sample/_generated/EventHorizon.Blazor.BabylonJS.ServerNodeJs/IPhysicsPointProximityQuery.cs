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

    public interface IPhysicsPointProximityQuery : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsPointProximityQueryCachedEntity>))]
    public class IPhysicsPointProximityQueryCachedEntity
        : CachedEntityObject,
            IPhysicsPointProximityQuery
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
        private Vector3 __position;

        public async ValueTask<Vector3> get_position()
        {
            if (__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }

        public ValueTask set_position(Vector3 value)
        {
            __position = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "position", value);
        }

        public async ValueTask<decimal> get_maxDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxDistance");
        }

        public ValueTask set_maxDistance(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxDistance", value);
        }

        private IRaycastQueryCachedEntity __collisionFilter;

        public async ValueTask<IRaycastQueryCachedEntity> get_collisionFilter()
        {
            if (__collisionFilter == null)
            {
                __collisionFilter =
                    await EventHorizonBlazorInterop.GetClass<IRaycastQueryCachedEntity>(
                        this.___guid,
                        "collisionFilter",
                        (entity) =>
                        {
                            return new IRaycastQueryCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __collisionFilter;
        }

        public ValueTask set_collisionFilter(IRaycastQueryCachedEntity value)
        {
            __collisionFilter = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "collisionFilter", value);
        }

        public async ValueTask<bool> get_shouldHitTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "shouldHitTriggers");
        }

        public ValueTask set_shouldHitTriggers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shouldHitTriggers", value);
        }

        private PhysicsBody __ignoreBody;

        public async ValueTask<PhysicsBody> get_ignoreBody()
        {
            if (__ignoreBody == null)
            {
                __ignoreBody = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    this.___guid,
                    "ignoreBody",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __ignoreBody;
        }

        public ValueTask set_ignoreBody(PhysicsBody value)
        {
            __ignoreBody = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "ignoreBody", value);
        }
        #endregion

        #region Constructor
        public IPhysicsPointProximityQueryCachedEntity()
            : base() { }

        public IPhysicsPointProximityQueryCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
