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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BoundingBox>))]
    public class BoundingBox : CachedEntityObject, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<bool> Intersects(BoundingBox box0, BoundingBox box1)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "Intersects" }, box0, box1
                }
            );
        }

        public static async ValueTask<bool> IntersectsSphere(Vector3 minPoint, Vector3 maxPoint, Vector3 sphereCenter, decimal sphereRadius)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "IntersectsSphere" }, minPoint, maxPoint, sphereCenter, sphereRadius
                }
            );
        }

        public static async ValueTask<bool> IsCompletelyInFrustum(Vector3[] boundingVectors, Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "IsCompletelyInFrustum" }, boundingVectors, frustumPlanes
                }
            );
        }

        public static async ValueTask<bool> IsInFrustum(Vector3[] boundingVectors, Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "IsInFrustum" }, boundingVectors, frustumPlanes
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public async ValueTask<Vector3[]> get_vectors()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "vectors",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
        }

        private Vector3 __center;
        public async ValueTask<Vector3> get_center()
        {
            if(__center == null)
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

        private Vector3 __centerWorld;
        public async ValueTask<Vector3> get_centerWorld()
        {
            if(__centerWorld == null)
            {
                __centerWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "centerWorld",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __centerWorld;
        }

        private Vector3 __extendSize;
        public async ValueTask<Vector3> get_extendSize()
        {
            if(__extendSize == null)
            {
                __extendSize = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "extendSize",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __extendSize;
        }

        private Vector3 __extendSizeWorld;
        public async ValueTask<Vector3> get_extendSizeWorld()
        {
            if(__extendSizeWorld == null)
            {
                __extendSizeWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "extendSizeWorld",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __extendSizeWorld;
        }

        
        public async ValueTask<Vector3[]> get_directions()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "directions",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<Vector3[]> get_vectorsWorld()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    this.___guid,
                    "vectorsWorld",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
        }

        private Vector3 __minimumWorld;
        public async ValueTask<Vector3> get_minimumWorld()
        {
            if(__minimumWorld == null)
            {
                __minimumWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "minimumWorld",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __minimumWorld;
        }

        private Vector3 __maximumWorld;
        public async ValueTask<Vector3> get_maximumWorld()
        {
            if(__maximumWorld == null)
            {
                __maximumWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "maximumWorld",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __maximumWorld;
        }

        private Vector3 __minimum;
        public async ValueTask<Vector3> get_minimum()
        {
            if(__minimum == null)
            {
                __minimum = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "minimum",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __minimum;
        }

        private Vector3 __maximum;
        public async ValueTask<Vector3> get_maximum()
        {
            if(__maximum == null)
            {
                __maximum = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "maximum",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __maximum;
        }
        #endregion
        
        #region Constructor
        public BoundingBox() : base() { }

        public BoundingBox(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<BoundingBox> NewBoundingBox(
            Vector3 min, Vector3 max, Matrix worldMatrix = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BoundingBox" },
                min, max, worldMatrix
            );

            return new BoundingBox(entity);
        }
        #endregion

        #region Methods
        public async ValueTask reConstruct(Vector3 min, Vector3 max, Matrix worldMatrix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reConstruct" }, min, max, worldMatrix
                }
            );
        }

        public async ValueTask<BoundingBox> scale(decimal factor)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, factor
                }
            );
        }

        public async ValueTask<Matrix> getWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public async ValueTask<bool> isInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public async ValueTask<bool> isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }

        public async ValueTask<bool> intersectsPoint(Vector3 point)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsPoint" }, point
                }
            );
        }

        public async ValueTask<bool> intersectsSphere(BoundingSphere sphere)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere
                }
            );
        }

        public async ValueTask<bool> intersectsMinMax(Vector3 min, Vector3 max)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMinMax" }, min, max
                }
            );
        }
        #endregion
    }
}