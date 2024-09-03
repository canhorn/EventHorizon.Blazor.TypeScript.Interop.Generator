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

    public interface IPhysicsCollisionEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsCollisionEventCachedEntity>))]
    public class IPhysicsCollisionEventCachedEntity : CachedEntityObject, IPhysicsCollisionEvent
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
        private Vector3 __point;

        public async ValueTask<Vector3> get_point()
        {
            if (__point == null)
            {
                __point = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "point",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __point;
        }

        public ValueTask set_point(Vector3 value)
        {
            __point = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "point", value);
        }

        public async ValueTask<decimal> get_distance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "distance");
        }

        public ValueTask set_distance(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "distance", value);
        }

        public async ValueTask<decimal> get_impulse()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "impulse");
        }

        public ValueTask set_impulse(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "impulse", value);
        }

        private Vector3 __normal;

        public async ValueTask<Vector3> get_normal()
        {
            if (__normal == null)
            {
                __normal = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
        }

        public ValueTask set_normal(Vector3 value)
        {
            __normal = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "normal", value);
        }
        #endregion

        #region Constructor
        public IPhysicsCollisionEventCachedEntity()
            : base() { }

        public IPhysicsCollisionEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
