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

    public interface IBasePhysicsCollisionEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IBasePhysicsCollisionEventCachedEntity>))]
    public class IBasePhysicsCollisionEventCachedEntity
        : CachedEntityObject,
            IBasePhysicsCollisionEvent
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private PhysicsBody __collider;
        public PhysicsBody collider
        {
            get
            {
                if (__collider == null)
                {
                    __collider = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                        this.___guid,
                        "collider",
                        (entity) =>
                        {
                            return new PhysicsBody() { ___guid = entity.___guid };
                        }
                    );
                }
                return __collider;
            }
            set
            {
                __collider = null;
                EventHorizonBlazorInterop.Set(this.___guid, "collider", value);
            }
        }

        private PhysicsBody __collidedAgainst;
        public PhysicsBody collidedAgainst
        {
            get
            {
                if (__collidedAgainst == null)
                {
                    __collidedAgainst = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                        this.___guid,
                        "collidedAgainst",
                        (entity) =>
                        {
                            return new PhysicsBody() { ___guid = entity.___guid };
                        }
                    );
                }
                return __collidedAgainst;
            }
            set
            {
                __collidedAgainst = null;
                EventHorizonBlazorInterop.Set(this.___guid, "collidedAgainst", value);
            }
        }

        public decimal colliderIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "colliderIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "colliderIndex", value);
            }
        }

        public decimal collidedAgainstIndex
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "collidedAgainstIndex");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "collidedAgainstIndex", value);
            }
        }

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }
        #endregion

        #region Constructor
        public IBasePhysicsCollisionEventCachedEntity()
            : base() { }

        public IBasePhysicsCollisionEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
