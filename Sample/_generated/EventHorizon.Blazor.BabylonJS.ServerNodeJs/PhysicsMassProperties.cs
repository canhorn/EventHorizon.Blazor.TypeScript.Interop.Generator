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

    public interface PhysicsMassProperties : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsMassPropertiesCachedEntity>))]
    public class PhysicsMassPropertiesCachedEntity : CachedEntityObject, PhysicsMassProperties
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
        private Vector3 __centerOfMass;

        public async ValueTask<Vector3> get_centerOfMass()
        {
            if (__centerOfMass == null)
            {
                __centerOfMass = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "centerOfMass",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __centerOfMass;
        }

        public ValueTask set_centerOfMass(Vector3 value)
        {
            __centerOfMass = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "centerOfMass", value);
        }

        public async ValueTask<decimal> get_mass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass");
        }

        public ValueTask set_mass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
        }

        private Vector3 __inertia;

        public async ValueTask<Vector3> get_inertia()
        {
            if (__inertia == null)
            {
                __inertia = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "inertia",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __inertia;
        }

        public ValueTask set_inertia(Vector3 value)
        {
            __inertia = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "inertia", value);
        }

        private Quaternion __inertiaOrientation;

        public async ValueTask<Quaternion> get_inertiaOrientation()
        {
            if (__inertiaOrientation == null)
            {
                __inertiaOrientation = await EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "inertiaOrientation",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __inertiaOrientation;
        }

        public ValueTask set_inertiaOrientation(Quaternion value)
        {
            __inertiaOrientation = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "inertiaOrientation", value);
        }
        #endregion

        #region Constructor
        public PhysicsMassPropertiesCachedEntity()
            : base() { }

        public PhysicsMassPropertiesCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
