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
    public class Collider : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal collisionMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
            }
        }

        private Vector3 __slidePlaneNormal;
        public Vector3 slidePlaneNormal
        {
            get
            {
            if(__slidePlaneNormal == null)
            {
                __slidePlaneNormal = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "slidePlaneNormal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __slidePlaneNormal;
            }
        }
        #endregion

        #region Properties
        
        public bool collisionFound
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "collisionFound"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "collisionFound",
                    value
                );
            }
        }

        private Vector3 __intersectionPoint;
        public Vector3 intersectionPoint
        {
            get
            {
            if(__intersectionPoint == null)
            {
                __intersectionPoint = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "intersectionPoint",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __intersectionPoint;
            }
            set
            {
__intersectionPoint = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "intersectionPoint",
                    value
                );
            }
        }

        private AbstractMesh __collidedMesh;
        public AbstractMesh collidedMesh
        {
            get
            {
            if(__collidedMesh == null)
            {
                __collidedMesh = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    "collidedMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __collidedMesh;
            }
            set
            {
__collidedMesh = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "collidedMesh",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Collider() : base() { } 

        public Collider(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}