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
        
        public async ValueTask<decimal> get_collisionMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
        }
        public ValueTask set_collisionMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
        }

        private Vector3 __slidePlaneNormal;
        public async ValueTask<Vector3> get_slidePlaneNormal()
        {
            if(__slidePlaneNormal == null)
            {
                __slidePlaneNormal = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_collisionFound()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionFound"
                );
        }
        public ValueTask set_collisionFound(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionFound",
                    value
                );
        }

        private Vector3 __intersectionPoint;
        public async ValueTask<Vector3> get_intersectionPoint()
        {
            if(__intersectionPoint == null)
            {
                __intersectionPoint = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_intersectionPoint(Vector3 value)
        {
__intersectionPoint = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionPoint",
                    value
                );
        }

        private AbstractMesh __collidedMesh;
        public async ValueTask<AbstractMesh> get_collidedMesh()
        {
            if(__collidedMesh == null)
            {
                __collidedMesh = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
        public ValueTask set_collidedMesh(AbstractMesh value)
        {
__collidedMesh = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collidedMesh",
                    value
                );
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