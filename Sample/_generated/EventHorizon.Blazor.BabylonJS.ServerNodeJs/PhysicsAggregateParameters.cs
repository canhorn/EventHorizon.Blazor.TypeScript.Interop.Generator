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

    public interface PhysicsAggregateParameters : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsAggregateParametersCachedEntity>))]
    public class PhysicsAggregateParametersCachedEntity
        : CachedEntityObject,
            PhysicsAggregateParameters
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

        public async ValueTask<decimal> get_mass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass");
        }

        public ValueTask set_mass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
        }

        public async ValueTask<decimal> get_friction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction");
        }

        public ValueTask set_friction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
        }

        public async ValueTask<decimal> get_restitution()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution");
        }

        public ValueTask set_restitution(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
        }

        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "radius");
        }

        public ValueTask set_radius(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "radius", value);
        }

        private Vector3 __pointA;

        public async ValueTask<Vector3> get_pointA()
        {
            if (__pointA == null)
            {
                __pointA = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "pointA",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointA;
        }

        public ValueTask set_pointA(Vector3 value)
        {
            __pointA = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "pointA", value);
        }

        private Vector3 __pointB;

        public async ValueTask<Vector3> get_pointB()
        {
            if (__pointB == null)
            {
                __pointB = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "pointB",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __pointB;
        }

        public ValueTask set_pointB(Vector3 value)
        {
            __pointB = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "pointB", value);
        }

        private Vector3 __extents;

        public async ValueTask<Vector3> get_extents()
        {
            if (__extents == null)
            {
                __extents = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "extents",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __extents;
        }

        public ValueTask set_extents(Vector3 value)
        {
            __extents = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "extents", value);
        }

        private Quaternion __rotation;

        public async ValueTask<Quaternion> get_rotation()
        {
            if (__rotation == null)
            {
                __rotation = await EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotation;
        }

        public ValueTask set_rotation(Quaternion value)
        {
            __rotation = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
        }

        private Vector3 __center;

        public async ValueTask<Vector3> get_center()
        {
            if (__center == null)
            {
                __center = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "center",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __center;
        }

        public ValueTask set_center(Vector3 value)
        {
            __center = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "center", value);
        }

        private Mesh __mesh;

        public async ValueTask<Mesh> get_mesh()
        {
            if (__mesh == null)
            {
                __mesh = await EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "mesh",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __mesh;
        }

        public ValueTask set_mesh(Mesh value)
        {
            __mesh = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "mesh", value);
        }

        public async ValueTask<bool> get_startAsleep()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "startAsleep");
        }

        public ValueTask set_startAsleep(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "startAsleep", value);
        }

        public async ValueTask<bool> get_isTriggerShape()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTriggerShape");
        }

        public ValueTask set_isTriggerShape(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isTriggerShape", value);
        }
        #endregion

        #region Constructor
        public PhysicsAggregateParametersCachedEntity()
            : base() { }

        public PhysicsAggregateParametersCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
