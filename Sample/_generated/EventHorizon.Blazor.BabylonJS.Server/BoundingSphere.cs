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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BoundingSphere>))]
    public class BoundingSphere : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<bool> Intersects(BoundingSphere sphere0, BoundingSphere sphere1)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
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

        
        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
        }
        public ValueTask set_radius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
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

        
        public async ValueTask<decimal> get_radiusWorld()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusWorld"
                );
        }
        public ValueTask set_radiusWorld(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusWorld",
                    value
                );
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
        public BoundingSphere() : base() { } 

        public BoundingSphere(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<BoundingSphere> NewBoundingSphere(
            Vector3 min, Vector3 max, Matrix worldMatrix = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BoundingSphere" },
                min, max, worldMatrix
            );

            return new BoundingSphere(entity);
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

        public async ValueTask<BoundingSphere> scale(decimal factor)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingSphere>(
                entity => new BoundingSphere() { ___guid = entity.___guid },
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

        public async ValueTask<bool> isCenterInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCenterInFrustum" }, frustumPlanes
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
        #endregion
    }
}