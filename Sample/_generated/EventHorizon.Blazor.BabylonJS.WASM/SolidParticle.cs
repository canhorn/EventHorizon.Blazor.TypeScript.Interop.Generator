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
    public class SolidParticle : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Vector3 __scale;
        public Vector3 scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        private Quaternion __quaternion;
        public Quaternion quaternion
        {
            get
            {
            if(__quaternion == null)
            {
                __quaternion = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "quaternion",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __quaternion;
            }
            set
            {
__quaternion = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "quaternion",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal idx
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "idx"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "idx",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        private Color4 __color;
        public Color4 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __rotation;
            }
            set
            {
__rotation = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        private Quaternion __rotationQuaternion;
        public Quaternion rotationQuaternion
        {
            get
            {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "rotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __rotationQuaternion;
            }
            set
            {
__rotationQuaternion = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
            }
        }

        private Vector3 __scaling;
        public Vector3 scaling
        {
            get
            {
            if(__scaling == null)
            {
                __scaling = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "scaling",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __scaling;
            }
            set
            {
__scaling = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scaling",
                    value
                );
            }
        }

        private Vector4 __uvs;
        public Vector4 uvs
        {
            get
            {
            if(__uvs == null)
            {
                __uvs = EventHorizonBlazorInteropt.GetClass<Vector4>(
                    this.___guid,
                    "uvs",
                    (entity) =>
                    {
                        return new Vector4(entity);
                    }
                );
            }
            return __uvs;
            }
            set
            {
__uvs = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        private Vector3 __velocity;
        public Vector3 velocity
        {
            get
            {
            if(__velocity == null)
            {
                __velocity = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "velocity",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __velocity;
            }
            set
            {
__velocity = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "velocity",
                    value
                );
            }
        }

        private Vector3 __pivot;
        public Vector3 pivot
        {
            get
            {
            if(__pivot == null)
            {
                __pivot = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "pivot",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __pivot;
            }
            set
            {
__pivot = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pivot",
                    value
                );
            }
        }

        
        public bool translateFromPivot
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "translateFromPivot"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "translateFromPivot",
                    value
                );
            }
        }

        
        public bool alive
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "alive"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alive",
                    value
                );
            }
        }

        
        public bool isVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
            }
        }

        
        public decimal shapeId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shapeId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shapeId",
                    value
                );
            }
        }

        
        public decimal idxInShape
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "idxInShape"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "idxInShape",
                    value
                );
            }
        }

        
        public decimal parentId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "parentId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "parentId",
                    value
                );
            }
        }

        
        public decimal materialIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "materialIndex",
                    value
                );
            }
        }

        
        public decimal cullingStrategy
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cullingStrategy"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cullingStrategy",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SolidParticle() : base() { } 

        public SolidParticle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SolidParticle(
            decimal particleIndex, decimal particleId, decimal positionIndex, decimal indiceIndex, ModelShape model, decimal shapeId, decimal idxInShape, SolidParticleSystem sps, BoundingInfo modelBoundingInfo = null, System.Nullable<decimal> materialIndex = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "SolidParticle" },
                particleIndex, particleId, positionIndex, indiceIndex, model, shapeId, idxInShape, sps, modelBoundingInfo, materialIndex
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public SolidParticle copyToRef(SolidParticle target)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copyToRef" }, target
                }
            );
        }

        public bool intersectsMesh(object target)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMesh" }, target
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

        public void getRotationMatrix(Matrix m)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getRotationMatrix" }, m
                }
            );
        }
        #endregion
    }
}