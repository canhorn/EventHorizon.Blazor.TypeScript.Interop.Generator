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

    public interface PhysicsConstraintParameters : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsConstraintParametersCachedEntity>))]
    public class PhysicsConstraintParametersCachedEntity
        : CachedEntityObject,
            PhysicsConstraintParameters
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
        private Vector3 __pivotA;

        public async ValueTask<Vector3> get_pivotA()
        {
            if (__pivotA == null)
            {
                __pivotA = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "pivotA",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __pivotA;
        }

        public ValueTask set_pivotA(Vector3 value)
        {
            __pivotA = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "pivotA", value);
        }

        private Vector3 __pivotB;

        public async ValueTask<Vector3> get_pivotB()
        {
            if (__pivotB == null)
            {
                __pivotB = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "pivotB",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __pivotB;
        }

        public ValueTask set_pivotB(Vector3 value)
        {
            __pivotB = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "pivotB", value);
        }

        private Vector3 __axisA;

        public async ValueTask<Vector3> get_axisA()
        {
            if (__axisA == null)
            {
                __axisA = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "axisA",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __axisA;
        }

        public ValueTask set_axisA(Vector3 value)
        {
            __axisA = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "axisA", value);
        }

        private Vector3 __axisB;

        public async ValueTask<Vector3> get_axisB()
        {
            if (__axisB == null)
            {
                __axisB = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "axisB",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __axisB;
        }

        public ValueTask set_axisB(Vector3 value)
        {
            __axisB = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "axisB", value);
        }

        private Vector3 __perpAxisA;

        public async ValueTask<Vector3> get_perpAxisA()
        {
            if (__perpAxisA == null)
            {
                __perpAxisA = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "perpAxisA",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __perpAxisA;
        }

        public ValueTask set_perpAxisA(Vector3 value)
        {
            __perpAxisA = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "perpAxisA", value);
        }

        private Vector3 __perpAxisB;

        public async ValueTask<Vector3> get_perpAxisB()
        {
            if (__perpAxisB == null)
            {
                __perpAxisB = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "perpAxisB",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __perpAxisB;
        }

        public ValueTask set_perpAxisB(Vector3 value)
        {
            __perpAxisB = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "perpAxisB", value);
        }

        public async ValueTask<decimal> get_maxDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxDistance");
        }

        public ValueTask set_maxDistance(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxDistance", value);
        }

        public async ValueTask<bool> get_collision()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "collision");
        }

        public ValueTask set_collision(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "collision", value);
        }
        #endregion

        #region Constructor
        public PhysicsConstraintParametersCachedEntity()
            : base() { }

        public PhysicsConstraintParametersCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
