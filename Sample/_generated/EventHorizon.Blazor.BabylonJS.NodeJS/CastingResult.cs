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
        public Vector3 hitPoint
        {
            get
            {
                if (__hitPoint == null)
                {
                    __hitPoint = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private Vector3 __hitNormal;
        public Vector3 hitNormal
        {
            get
            {
                if (__hitNormal == null)
                {
                    __hitNormal = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        public bool hasHit
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasHit"); }
        }

        public decimal triangleIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "triangleIndex"); }
        }
        #endregion

        #region Properties
        private PhysicsBody __body;
        public PhysicsBody body
        {
            get
            {
                if (__body == null)
                {
                    __body = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
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
            set
            {
                __body = null;
                EventHorizonBlazorInterop.Set(this.___guid, "body", value);
            }
        }

        public decimal bodyIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "bodyIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "bodyIndex", value);
            }
        }

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
        public void setHitData(
            IXYZ hitNormal,
            IXYZ hitPoint,
            System.Nullable<decimal> triangleIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setHitData" },
                    hitNormal,
                    hitPoint,
                    triangleIndex
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
