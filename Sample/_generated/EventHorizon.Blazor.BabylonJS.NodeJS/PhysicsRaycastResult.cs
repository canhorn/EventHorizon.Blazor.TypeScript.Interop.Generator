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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsRaycastResult>))]
    public class PhysicsRaycastResult : CastingResult
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public decimal hitDistance
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "hitDistance"); }
        }

        private Vector3 __hitNormalWorld;
        public Vector3 hitNormalWorld
        {
            get
            {
                if (__hitNormalWorld == null)
                {
                    __hitNormalWorld = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "hitNormalWorld",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __hitNormalWorld;
            }
        }

        private Vector3 __hitPointWorld;
        public Vector3 hitPointWorld
        {
            get
            {
                if (__hitPointWorld == null)
                {
                    __hitPointWorld = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "hitPointWorld",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __hitPointWorld;
            }
        }

        private Vector3 __rayFromWorld;
        public Vector3 rayFromWorld
        {
            get
            {
                if (__rayFromWorld == null)
                {
                    __rayFromWorld = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "rayFromWorld",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rayFromWorld;
            }
        }

        private Vector3 __rayToWorld;
        public Vector3 rayToWorld
        {
            get
            {
                if (__rayToWorld == null)
                {
                    __rayToWorld = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "rayToWorld",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rayToWorld;
            }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PhysicsRaycastResult()
            : base() { }

        public PhysicsRaycastResult(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void setHitDistance(decimal distance)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHitDistance" }, distance }
            );
        }

        public void calculateHitDistance()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "calculateHitDistance" } }
            );
        }

        public void reset(Vector3 from = null, Vector3 to = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" }, from, to }
            );
        }
        #endregion
    }
}
