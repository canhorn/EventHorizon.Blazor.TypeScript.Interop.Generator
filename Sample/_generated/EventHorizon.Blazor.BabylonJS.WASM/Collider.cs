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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Collider>))]
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __slidePlaneNormal = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionFound"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __intersectionPoint = EventHorizonBlazorInterop.GetClass<Vector3>(
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
                EventHorizonBlazorInterop.Set(
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
                __collidedMesh = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
                EventHorizonBlazorInterop.Set(
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