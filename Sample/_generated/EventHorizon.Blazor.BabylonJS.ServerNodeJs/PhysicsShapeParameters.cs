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

        public async ValueTask<bool> get_includeChildMeshes()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "includeChildMeshes");
        }

        public ValueTask set_includeChildMeshes(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "includeChildMeshes", value);
        }

        public async ValueTask<decimal> get_heightFieldSizeX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightFieldSizeX");
        }

        public ValueTask set_heightFieldSizeX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "heightFieldSizeX", value);
        }

        public async ValueTask<decimal> get_heightFieldSizeZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightFieldSizeZ");
        }

        public ValueTask set_heightFieldSizeZ(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "heightFieldSizeZ", value);
        }

        public async ValueTask<decimal> get_numHeightFieldSamplesX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "numHeightFieldSamplesX"
            );
        }

        public ValueTask set_numHeightFieldSamplesX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "numHeightFieldSamplesX", value);
        }

        public async ValueTask<decimal> get_numHeightFieldSamplesZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "numHeightFieldSamplesZ"
            );
        }

        public ValueTask set_numHeightFieldSamplesZ(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "numHeightFieldSamplesZ", value);
        }

        public async ValueTask<decimal[]> get_heightFieldData()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                this.___guid,
                "heightFieldData"
            );
        }

        public ValueTask set_heightFieldData(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "heightFieldData", value);
        }

        private GroundMesh __groundMesh;

        public async ValueTask<GroundMesh> get_groundMesh()
        {
            if (__groundMesh == null)
            {
                __groundMesh = await EventHorizonBlazorInterop.GetClass<GroundMesh>(
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

        public ValueTask set_groundMesh(GroundMesh value)
        {
            __groundMesh = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "groundMesh", value);
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
