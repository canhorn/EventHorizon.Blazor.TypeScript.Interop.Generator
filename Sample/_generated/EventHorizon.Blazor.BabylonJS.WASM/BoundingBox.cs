/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class BoundingBox : CachedEntityObject, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static bool Intersects(BoundingBox box0, BoundingBox box1)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "Intersects" }, box0, box1
                }
            );
        }

        public static bool IntersectsSphere(Vector3 minPoint, Vector3 maxPoint, Vector3 sphereCenter, decimal sphereRadius)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "IntersectsSphere" }, minPoint, maxPoint, sphereCenter, sphereRadius
                }
            );
        }

        public static bool IsCompletelyInFrustum(Vector3[] boundingVectors, Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingBox", "IsCompletelyInFrustum" }, boundingVectors, frustumPlanes
                }
            );
        }

        public static bool IsInFrustum(Vector3[] boundingVectors, Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
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
        
        public Vector3[] vectors
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector3>(
                    this.___guid,
                    "vectors",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
        }

        private Vector3 __center;
        public Vector3 center
        {
            get
            {
            if(__center == null)
            {
                __center = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "center",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __center;
            }
        }

        private Vector3 __centerWorld;
        public Vector3 centerWorld
        {
            get
            {
            if(__centerWorld == null)
            {
                __centerWorld = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "centerWorld",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __centerWorld;
            }
        }

        private Vector3 __extendSize;
        public Vector3 extendSize
        {
            get
            {
            if(__extendSize == null)
            {
                __extendSize = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "extendSize",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __extendSize;
            }
        }

        private Vector3 __extendSizeWorld;
        public Vector3 extendSizeWorld
        {
            get
            {
            if(__extendSizeWorld == null)
            {
                __extendSizeWorld = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "extendSizeWorld",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __extendSizeWorld;
            }
        }

        
        public Vector3[] directions
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector3>(
                    this.___guid,
                    "directions",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
        }

        
        public Vector3[] vectorsWorld
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector3>(
                    this.___guid,
                    "vectorsWorld",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
        }

        private Vector3 __minimumWorld;
        public Vector3 minimumWorld
        {
            get
            {
            if(__minimumWorld == null)
            {
                __minimumWorld = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "minimumWorld",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __minimumWorld;
            }
        }

        private Vector3 __maximumWorld;
        public Vector3 maximumWorld
        {
            get
            {
            if(__maximumWorld == null)
            {
                __maximumWorld = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "maximumWorld",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __maximumWorld;
            }
        }

        private Vector3 __minimum;
        public Vector3 minimum
        {
            get
            {
            if(__minimum == null)
            {
                __minimum = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "minimum",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __minimum;
            }
        }

        private Vector3 __maximum;
        public Vector3 maximum
        {
            get
            {
            if(__maximum == null)
            {
                __maximum = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "maximum",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __maximum;
            }
        }
        #endregion
        
        #region Constructor
        public BoundingBox() : base() { }

        public BoundingBox(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BoundingBox(
            Vector3 min, Vector3 max, Matrix worldMatrix = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "BoundingBox" },
                min, max, worldMatrix
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void reConstruct(Vector3 min, Vector3 max, Matrix worldMatrix = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reConstruct" }, min, max, worldMatrix
                }
            );
        }

        public BoundingBox scale(decimal factor)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoundingBox>(
                entity => new BoundingBox(entity),
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, factor
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public bool isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }

        public bool intersectsPoint(Vector3 point)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsPoint" }, point
                }
            );
        }

        public bool intersectsSphere(BoundingSphere sphere)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsSphere" }, sphere
                }
            );
        }

        public bool intersectsMinMax(Vector3 min, Vector3 max)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMinMax" }, min, max
                }
            );
        }
        #endregion
    }
}