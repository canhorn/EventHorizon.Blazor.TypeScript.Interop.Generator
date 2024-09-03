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

        public decimal mass
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
            }
        }

        public decimal friction
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
            }
        }

        public decimal restitution
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
            }
        }

        public decimal radius
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "radius"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "radius", value);
            }
        }

        private Vector3 __pointA;
        public Vector3 pointA
        {
            get
            {
                if (__pointA == null)
                {
                    __pointA = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __pointA = null;
                EventHorizonBlazorInterop.Set(this.___guid, "pointA", value);
            }
        }

        private Vector3 __pointB;
        public Vector3 pointB
        {
            get
            {
                if (__pointB == null)
                {
                    __pointB = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __pointB = null;
                EventHorizonBlazorInterop.Set(this.___guid, "pointB", value);
            }
        }

        private Vector3 __extents;
        public Vector3 extents
        {
            get
            {
                if (__extents == null)
                {
                    __extents = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __extents = null;
                EventHorizonBlazorInterop.Set(this.___guid, "extents", value);
            }
        }

        private Quaternion __rotation;
        public Quaternion rotation
        {
            get
            {
                if (__rotation == null)
                {
                    __rotation = EventHorizonBlazorInterop.GetClass<Quaternion>(
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
            set
            {
                __rotation = null;
                EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
            }
        }

        private Vector3 __center;
        public Vector3 center
        {
            get
            {
                if (__center == null)
                {
                    __center = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __center = null;
                EventHorizonBlazorInterop.Set(this.___guid, "center", value);
            }
        }

        private Mesh __mesh;
        public Mesh mesh
        {
            get
            {
                if (__mesh == null)
                {
                    __mesh = EventHorizonBlazorInterop.GetClass<Mesh>(
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
            set
            {
                __mesh = null;
                EventHorizonBlazorInterop.Set(this.___guid, "mesh", value);
            }
        }

        public bool startAsleep
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "startAsleep"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "startAsleep", value);
            }
        }

        public bool isTriggerShape
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTriggerShape"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isTriggerShape", value);
            }
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
