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

    [JsonConverter(typeof(CachedEntityConverter<CastingResult>))]
    public class CastingResult : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Vector3 __hitPoint;

        public async ValueTask<Vector3> get_hitPoint()
        {
            if (__hitPoint == null)
            {
                __hitPoint = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "hitPoint",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __hitPoint;
        }

        private Vector3 __hitNormal;

        public async ValueTask<Vector3> get_hitNormal()
        {
            if (__hitNormal == null)
            {
                __hitNormal = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "hitNormal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __hitNormal;
        }

        public async ValueTask<bool> get_hasHit()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasHit");
        }

        public async ValueTask<decimal> get_triangleIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "triangleIndex");
        }
        #endregion

        #region Properties
        private PhysicsBody __body;

        public async ValueTask<PhysicsBody> get_body()
        {
            if (__body == null)
            {
                __body = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    this.___guid,
                    "body",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __body;
        }

        public ValueTask set_body(PhysicsBody value)
        {
            __body = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "body", value);
        }

        public async ValueTask<decimal> get_bodyIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "bodyIndex");
        }

        public ValueTask set_bodyIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "bodyIndex", value);
        }

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
        #endregion

        #region Constructor
        public CastingResult()
            : base() { }

        public CastingResult(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods
        public async ValueTask setHitData(
            IXYZ hitNormal,
            IXYZ hitPoint,
            System.Nullable<decimal> triangleIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setHitData" },
                    hitNormal,
                    hitPoint,
                    triangleIndex
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
