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

    public interface IPhysicsPointProximityQuery : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsPointProximityQueryCachedEntity>))]
    public class IPhysicsPointProximityQueryCachedEntity
        : CachedEntityObject,
            IPhysicsPointProximityQuery
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
        private Vector3 __position;
        public Vector3 position
        {
            get
            {
                if (__position == null)
                {
                    __position = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "position",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __position;
            }
            set
            {
                __position = null;
                EventHorizonBlazorInterop.Set(this.___guid, "position", value);
            }
        }

        public decimal maxDistance
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxDistance"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maxDistance", value);
            }
        }

        private IRaycastQueryCachedEntity __collisionFilter;
        public IRaycastQueryCachedEntity collisionFilter
        {
            get
            {
                if (__collisionFilter == null)
                {
                    __collisionFilter =
                        EventHorizonBlazorInterop.GetClass<IRaycastQueryCachedEntity>(
                            this.___guid,
                            "collisionFilter",
                            (entity) =>
                            {
                                return new IRaycastQueryCachedEntity() { ___guid = entity.___guid };
                            }
                        );
                }
                return __collisionFilter;
            }
            set
            {
                __collisionFilter = null;
                EventHorizonBlazorInterop.Set(this.___guid, "collisionFilter", value);
            }
        }

        public bool shouldHitTriggers
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "shouldHitTriggers"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shouldHitTriggers", value);
            }
        }

        private PhysicsBody __ignoreBody;
        public PhysicsBody ignoreBody
        {
            get
            {
                if (__ignoreBody == null)
                {
                    __ignoreBody = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                        this.___guid,
                        "ignoreBody",
                        (entity) =>
                        {
                            return new PhysicsBody() { ___guid = entity.___guid };
                        }
                    );
                }
                return __ignoreBody;
            }
            set
            {
                __ignoreBody = null;
                EventHorizonBlazorInterop.Set(this.___guid, "ignoreBody", value);
            }
        }
        #endregion

        #region Constructor
        public IPhysicsPointProximityQueryCachedEntity()
            : base() { }

        public IPhysicsPointProximityQueryCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
