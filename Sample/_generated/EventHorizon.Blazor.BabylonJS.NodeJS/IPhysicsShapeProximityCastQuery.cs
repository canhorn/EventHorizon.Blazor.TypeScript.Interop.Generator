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

    public interface IPhysicsShapeProximityCastQuery : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsShapeProximityCastQueryCachedEntity>))]
    public class IPhysicsShapeProximityCastQueryCachedEntity
        : CachedEntityObject,
            IPhysicsShapeProximityCastQuery
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
        private PhysicsShape __shape;
        public PhysicsShape shape
        {
            get
            {
                if (__shape == null)
                {
                    __shape = EventHorizonBlazorInterop.GetClass<PhysicsShape>(
                        this.___guid,
                        "shape",
                        (entity) =>
                        {
                            return new PhysicsShape() { ___guid = entity.___guid };
                        }
                    );
                }
                return __shape;
            }
            set
            {
                __shape = null;
                EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
            }
        }

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

        private Quaternion __rotation;
        public Quaternion rotation
        {
            get
            {
                if (__rotation == null)
                {
                    __rotation = EventHorizonBlazorInterop.GetClass<Quaternion>(
                        this.___guid,
                        "rotation",
                        (entity) =>
                        {
                            return new Quaternion() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rotation;
            }
            set
            {
                __rotation = null;
                EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
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
        public IPhysicsShapeProximityCastQueryCachedEntity()
            : base() { }

        public IPhysicsShapeProximityCastQueryCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
