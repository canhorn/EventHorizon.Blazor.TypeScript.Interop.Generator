/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Ray>))]
    public class Ray : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Ray> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Ray", "Zero" }
                }
            );
        }

        public static async ValueTask<Ray> CreateNew(decimal x, decimal y, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Ray", "CreateNew" }, x, y, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public static async ValueTask<Ray> CreateNewFromTo(Vector3 origin, Vector3 end, Matrix world = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Ray", "CreateNewFromTo" }, origin, end, world
                }
            );
        }

        public static async ValueTask<Ray> Transform(Ray ray, Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Ray", "Transform" }, ray, matrix
                }
            );
        }

        public static async ValueTask TransformToRef(Ray ray, Matrix matrix, Ray result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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
        public async ValueTask<Vector3> get_origin()
        {
            if(__origin == null)
            {
                __origin = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_origin(Vector3 value)
        {
__origin = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "origin",
                    value
                );
        }

        private Vector3 __direction;
        public async ValueTask<Vector3> get_direction()
        {
            if(__direction == null)
            {
                __direction = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_direction(Vector3 value)
        {
__direction = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
        }

        
        public async ValueTask<decimal> get_length()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
        }
        public ValueTask set_length(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
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

        public static async ValueTask<Ray> NewRay(
            Vector3 origin, Vector3 direction, System.Nullable<decimal> length = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Ray" },
                origin, direction, length
            );

            return new Ray(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> intersectsBoxMinMax(Vector3 minimum, Vector3 maximum, System.Nullable<decimal> intersectionTreshold = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsBoxMinMax" }, minimum, maximum, intersectionTreshold
                }
            );
        }

        public async ValueTask<bool> intersectsBox(BoundingBox box, System.Nullable<decimal> intersectionTreshold = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsBox" }, box, intersectionTreshold
                }
            );
        }

        public async ValueTask<bool> intersectsSphere(BoundingSphere sphere, System.Nullable<decimal> intersectionTreshold = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere, intersectionTreshold
                }
            );
        }

        public async ValueTask<IntersectionInfo> intersectsTriangle(Vector3 vertex0, Vector3 vertex1, Vector3 vertex2)
        {
            return await EventHorizonBlazorInterop.FuncClass<IntersectionInfo>(
                entity => new IntersectionInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersectsTriangle" }, vertex0, vertex1, vertex2
                }
            );
        }

        public async ValueTask<decimal> intersectsPlane(Plane plane)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsPlane" }, plane
                }
            );
        }

        public async ValueTask<Vector3> intersectsAxis(string axis, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersectsAxis" }, axis, offset
                }
            );
        }

        public async ValueTask<PickingInfo> intersectsMesh(AbstractMesh mesh, System.Nullable<bool> fastCheck = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMesh" }, mesh, fastCheck
                }
            );
        }

        public async ValueTask<PickingInfo[]> intersectsMeshes(AbstractMesh[] meshes, System.Nullable<bool> fastCheck = null, PickingInfo[] results = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersectsMeshes" }, meshes, fastCheck, results
                }
            );
        }

        public async ValueTask<decimal> intersectionSegment(Vector3 sega, Vector3 segb, decimal threshold)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectionSegment" }, sega, segb, threshold
                }
            );
        }

        public async ValueTask<Ray> update(decimal x, decimal y, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "update" }, x, y, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public async ValueTask unprojectRayToRef(decimal sourceX, decimal sourceY, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unprojectRayToRef" }, sourceX, sourceY, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }
        #endregion
    }
}