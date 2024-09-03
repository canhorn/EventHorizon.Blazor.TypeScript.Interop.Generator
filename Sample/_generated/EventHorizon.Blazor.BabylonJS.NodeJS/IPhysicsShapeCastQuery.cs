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

    public interface IPhysicsShapeCastQuery : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsShapeCastQueryCachedEntity>))]
    public class IPhysicsShapeCastQueryCachedEntity : CachedEntityObject, IPhysicsShapeCastQuery
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

        private Vector3 __startPosition;
        public Vector3 startPosition
        {
            get
            {
                if (__startPosition == null)
                {
                    __startPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "startPosition",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __startPosition;
            }
            set
            {
                __startPosition = null;
                EventHorizonBlazorInterop.Set(this.___guid, "startPosition", value);
            }
        }

        private Vector3 __endPosition;
        public Vector3 endPosition
        {
            get
            {
                if (__endPosition == null)
                {
                    __endPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "endPosition",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __endPosition;
            }
            set
            {
                __endPosition = null;
                EventHorizonBlazorInterop.Set(this.___guid, "endPosition", value);
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
        public IPhysicsShapeCastQueryCachedEntity()
            : base() { }

        public IPhysicsShapeCastQueryCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
