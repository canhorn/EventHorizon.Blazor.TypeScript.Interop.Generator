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
    public class BoundingSphere : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static bool Intersects(BoundingSphere sphere0, BoundingSphere sphere1)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "BoundingSphere", "Intersects" }, sphere0, sphere1
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
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

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "radius",
                    value
                );
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

        
        public decimal radiusWorld
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "radiusWorld"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "radiusWorld",
                    value
                );
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
        public BoundingSphere() : base() { } 

        public BoundingSphere(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BoundingSphere(
            Vector3 min, Vector3 max, Matrix worldMatrix = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "BoundingSphere" },
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

        public BoundingSphere scale(decimal factor)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoundingSphere>(
                entity => new BoundingSphere(entity),
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

        public bool isCenterInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCenterInFrustum" }, frustumPlanes
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
        #endregion
    }
}