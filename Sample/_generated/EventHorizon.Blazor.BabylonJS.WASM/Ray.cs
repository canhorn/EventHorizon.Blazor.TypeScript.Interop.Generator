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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Ray>))]
    public class Ray : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Ray Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Ray", "Zero" }
                }
            );
        }

        public static Ray CreateNew(decimal x, decimal y, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Ray", "CreateNew" }, x, y, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public static Ray CreateNewFromTo(Vector3 origin, Vector3 end, Matrix world = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Ray", "CreateNewFromTo" }, origin, end, world
                }
            );
        }

        public static Ray Transform(Ray ray, Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Ray", "Transform" }, ray, matrix
                }
            );
        }

        public static void TransformToRef(Ray ray, Matrix matrix, Ray result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Ray", "TransformToRef" }, ray, matrix, result
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Vector3 __origin;
        public Vector3 origin
        {
            get
            {
            if(__origin == null)
            {
                __origin = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "origin",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __origin;
            }
            set
            {
__origin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "origin",
                    value
                );
            }
        }

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Ray() : base() { }

        public Ray(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Ray(
            Vector3 origin, Vector3 direction, System.Nullable<decimal> length = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Ray" },
                origin, direction, length
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool intersectsBoxMinMax(Vector3 minimum, Vector3 maximum, System.Nullable<decimal> intersectionTreshold = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBoxMinMax" }, minimum, maximum, intersectionTreshold
                }
            );
        }

        public bool intersectsBox(BoundingBox box, System.Nullable<decimal> intersectionTreshold = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsBox" }, box, intersectionTreshold
                }
            );
        }

        public bool intersectsSphere(BoundingSphere sphere, System.Nullable<decimal> intersectionTreshold = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere, intersectionTreshold
                }
            );
        }

        public IntersectionInfo intersectsTriangle(Vector3 vertex0, Vector3 vertex1, Vector3 vertex2)
        {
            return EventHorizonBlazorInterop.FuncClass<IntersectionInfo>(
                entity => new IntersectionInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsTriangle" }, vertex0, vertex1, vertex2
                }
            );
        }

        public decimal intersectsPlane(Plane plane)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsPlane" }, plane
                }
            );
        }

        public Vector3 intersectsAxis(string axis, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsAxis" }, axis, offset
                }
            );
        }

        public PickingInfo intersectsMesh(AbstractMesh mesh, System.Nullable<bool> fastCheck = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsMesh" }, mesh, fastCheck
                }
            );
        }

        public PickingInfo[] intersectsMeshes(AbstractMesh[] meshes, System.Nullable<bool> fastCheck = null, PickingInfo[] results = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsMeshes" }, meshes, fastCheck, results
                }
            );
        }

        public decimal intersectionSegment(Vector3 sega, Vector3 segb, decimal threshold)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "intersectionSegment" }, sega, segb, threshold
                }
            );
        }

        public Ray update(decimal x, decimal y, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "update" }, x, y, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public void unprojectRayToRef(decimal sourceX, decimal sourceY, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unprojectRayToRef" }, sourceX, sourceY, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }
        #endregion
    }
}