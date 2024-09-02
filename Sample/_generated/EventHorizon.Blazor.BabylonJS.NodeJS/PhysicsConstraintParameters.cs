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
        public Vector3 pivotA
        {
            get
            {
                if (__pivotA == null)
                {
                    __pivotA = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __pivotA = null;
                EventHorizonBlazorInterop.Set(this.___guid, "pivotA", value);
            }
        }

        private Vector3 __pivotB;
        public Vector3 pivotB
        {
            get
            {
                if (__pivotB == null)
                {
                    __pivotB = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __pivotB = null;
                EventHorizonBlazorInterop.Set(this.___guid, "pivotB", value);
            }
        }

        private Vector3 __axisA;
        public Vector3 axisA
        {
            get
            {
                if (__axisA == null)
                {
                    __axisA = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __axisA = null;
                EventHorizonBlazorInterop.Set(this.___guid, "axisA", value);
            }
        }

        private Vector3 __axisB;
        public Vector3 axisB
        {
            get
            {
                if (__axisB == null)
                {
                    __axisB = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __axisB = null;
                EventHorizonBlazorInterop.Set(this.___guid, "axisB", value);
            }
        }

        private Vector3 __perpAxisA;
        public Vector3 perpAxisA
        {
            get
            {
                if (__perpAxisA == null)
                {
                    __perpAxisA = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __perpAxisA = null;
                EventHorizonBlazorInterop.Set(this.___guid, "perpAxisA", value);
            }
        }

        private Vector3 __perpAxisB;
        public Vector3 perpAxisB
        {
            get
            {
                if (__perpAxisB == null)
                {
                    __perpAxisB = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __perpAxisB = null;
                EventHorizonBlazorInterop.Set(this.___guid, "perpAxisB", value);
            }
        }

        public decimal maxDistance
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxDistance"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maxDistance", value);
            }
        }

        public bool collision
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "collision"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "collision", value);
            }
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
