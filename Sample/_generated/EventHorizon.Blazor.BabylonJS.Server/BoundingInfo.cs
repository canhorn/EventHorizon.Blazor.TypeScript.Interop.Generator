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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BoundingInfo>))]
    public class BoundingInfo : CachedEntityObject, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
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

        
        public async ValueTask<bool> get_isLocked()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLocked"
                );
        }
        public ValueTask set_isLocked(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isLocked",
                    value
                );
        }

        
        public async ValueTask<decimal> get_diagonalLength()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "diagonalLength"
                );
        }
        #endregion

        #region Properties
        private BoundingBox __boundingBox;
        public async ValueTask<BoundingBox> get_boundingBox()
        {
            if(__boundingBox == null)
            {
                __boundingBox = await EventHorizonBlazorInterop.GetClass<BoundingBox>(
                    this.___guid,
                    "boundingBox",
                    (entity) =>
                    {
                        return new BoundingBox() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingBox;
        }

        private BoundingSphere __boundingSphere;
        public async ValueTask<BoundingSphere> get_boundingSphere()
        {
            if(__boundingSphere == null)
            {
                __boundingSphere = await EventHorizonBlazorInterop.GetClass<BoundingSphere>(
                    this.___guid,
                    "boundingSphere",
                    (entity) =>
                    {
                        return new BoundingSphere() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingSphere;
        }
        #endregion
        
        #region Constructor
        public BoundingInfo() : base() { }

        public BoundingInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<BoundingInfo> NewBoundingInfo(
            Vector3 minimum, Vector3 maximum, Matrix worldMatrix = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BoundingInfo" },
                minimum, maximum, worldMatrix
            );

            return new BoundingInfo(entity);
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

        public async ValueTask update(Matrix world)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, world
                }
            );
        }

        public async ValueTask<BoundingInfo> centerOn(Vector3 center, Vector3 extend)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "centerOn" }, center, extend
                }
            );
        }

        public async ValueTask<BoundingInfo> scale(decimal factor)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, factor
                }
            );
        }

        public async ValueTask<bool> isInFrustum(Plane[] frustumPlanes, System.Nullable<decimal> strategy = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes, strategy
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

        public async ValueTask<bool> intersects(BoundingInfo boundingInfo, bool precise)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, boundingInfo, precise
                }
            );
        }
        #endregion
    }
}