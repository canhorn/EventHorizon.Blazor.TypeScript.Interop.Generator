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

        
        public bool isLocked
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLocked"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isLocked",
                    value
                );
            }
        }

        
        public decimal diagonalLength
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "diagonalLength"
                );
            }
        }
        #endregion

        #region Properties
        private BoundingBox __boundingBox;
        public BoundingBox boundingBox
        {
            get
            {
            if(__boundingBox == null)
            {
                __boundingBox = EventHorizonBlazorInteropt.GetClass<BoundingBox>(
                    this.___guid,
                    "boundingBox",
                    (entity) =>
                    {
                        return new BoundingBox(entity);
                    }
                );
            }
            return __boundingBox;
            }
        }

        private BoundingSphere __boundingSphere;
        public BoundingSphere boundingSphere
        {
            get
            {
            if(__boundingSphere == null)
            {
                __boundingSphere = EventHorizonBlazorInteropt.GetClass<BoundingSphere>(
                    this.___guid,
                    "boundingSphere",
                    (entity) =>
                    {
                        return new BoundingSphere(entity);
                    }
                );
            }
            return __boundingSphere;
            }
        }
        #endregion
        
        #region Constructor
        public BoundingInfo() : base() { }

        public BoundingInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BoundingInfo(
            Vector3 minimum, Vector3 maximum, Matrix worldMatrix = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "BoundingInfo" },
                minimum, maximum, worldMatrix
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

        public void update(Matrix world)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, world
                }
            );
        }

        public BoundingInfo centerOn(Vector3 center, Vector3 extend)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoundingInfo>(
                entity => new BoundingInfo(entity),
                new object[] 
                {
                    new string[] { this.___guid, "centerOn" }, center, extend
                }
            );
        }

        public BoundingInfo scale(decimal factor)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoundingInfo>(
                entity => new BoundingInfo(entity),
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, factor
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes, System.Nullable<decimal> strategy = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes, strategy
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

        public bool intersects(BoundingInfo boundingInfo, bool precise)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, boundingInfo, precise
                }
            );
        }
        #endregion
    }
}