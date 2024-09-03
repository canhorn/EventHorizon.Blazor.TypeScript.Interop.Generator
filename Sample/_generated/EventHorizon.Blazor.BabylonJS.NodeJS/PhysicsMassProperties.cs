/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
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
        public Vector3 centerOfMass
        {
            get
            {
                if (__centerOfMass == null)
                {
                    __centerOfMass = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __centerOfMass = null;
                EventHorizonBlazorInterop.Set(this.___guid, "centerOfMass", value);
            }
        }

        public decimal mass
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
            }
        }

        private Vector3 __inertia;
        public Vector3 inertia
        {
            get
            {
                if (__inertia == null)
                {
                    __inertia = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __inertia = null;
                EventHorizonBlazorInterop.Set(this.___guid, "inertia", value);
            }
        }

        private Quaternion __inertiaOrientation;
        public Quaternion inertiaOrientation
        {
            get
            {
                if (__inertiaOrientation == null)
                {
                    __inertiaOrientation = EventHorizonBlazorInterop.GetClass<Quaternion>(
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
            set
            {
                __inertiaOrientation = null;
                EventHorizonBlazorInterop.Set(this.___guid, "inertiaOrientation", value);
            }
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
