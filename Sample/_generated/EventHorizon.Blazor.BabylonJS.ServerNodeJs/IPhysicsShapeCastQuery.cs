/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<PhysicsShape> get_shape()
        {
            if (__shape == null)
            {
                __shape = await EventHorizonBlazorInterop.GetClass<PhysicsShape>(
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

        public ValueTask set_shape(PhysicsShape value)
        {
            __shape = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
        }

        private Quaternion __rotation;

        public async ValueTask<Quaternion> get_rotation()
        {
            if (__rotation == null)
            {
                __rotation = await EventHorizonBlazorInterop.GetClass<Quaternion>(
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

        public ValueTask set_rotation(Quaternion value)
        {
            __rotation = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
        }

        private Vector3 __startPosition;

        public async ValueTask<Vector3> get_startPosition()
        {
            if (__startPosition == null)
            {
                __startPosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        public ValueTask set_startPosition(Vector3 value)
        {
            __startPosition = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "startPosition", value);
        }

        private Vector3 __endPosition;

        public async ValueTask<Vector3> get_endPosition()
        {
            if (__endPosition == null)
            {
                __endPosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        public ValueTask set_endPosition(Vector3 value)
        {
            __endPosition = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "endPosition", value);
        }

        public async ValueTask<bool> get_shouldHitTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "shouldHitTriggers");
        }

        public ValueTask set_shouldHitTriggers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shouldHitTriggers", value);
        }

        private PhysicsBody __ignoreBody;

        public async ValueTask<PhysicsBody> get_ignoreBody()
        {
            if (__ignoreBody == null)
            {
                __ignoreBody = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
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

        public ValueTask set_ignoreBody(PhysicsBody value)
        {
            __ignoreBody = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "ignoreBody", value);
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
