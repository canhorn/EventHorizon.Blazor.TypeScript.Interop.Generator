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

    public interface PhysicsShapeParameters : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsShapeParametersCachedEntity>))]
    public class PhysicsShapeParametersCachedEntity : CachedEntityObject, PhysicsShapeParameters
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

        public bool includeChildMeshes
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "includeChildMeshes"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "includeChildMeshes", value);
            }
        }

        public decimal heightFieldSizeX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightFieldSizeX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "heightFieldSizeX", value);
            }
        }

        public decimal heightFieldSizeZ
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightFieldSizeZ"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "heightFieldSizeZ", value);
            }
        }

        public decimal numHeightFieldSamplesX
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numHeightFieldSamplesX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "numHeightFieldSamplesX", value);
            }
        }

        public decimal numHeightFieldSamplesZ
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numHeightFieldSamplesZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "numHeightFieldSamplesZ", value);
            }
        }

        public decimal[] heightFieldData
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "heightFieldData");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "heightFieldData", value);
            }
        }

        private GroundMesh __groundMesh;
        public GroundMesh groundMesh
        {
            get
            {
                if (__groundMesh == null)
                {
                    __groundMesh = EventHorizonBlazorInterop.GetClass<GroundMesh>(
                        this.___guid,
                        "groundMesh",
                        (entity) =>
                        {
                            return new GroundMesh() { ___guid = entity.___guid };
                        }
                    );
                }
                return __groundMesh;
            }
            set
            {
                __groundMesh = null;
                EventHorizonBlazorInterop.Set(this.___guid, "groundMesh", value);
            }
        }
        #endregion

        #region Constructor
        public PhysicsShapeParametersCachedEntity()
            : base() { }

        public PhysicsShapeParametersCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
