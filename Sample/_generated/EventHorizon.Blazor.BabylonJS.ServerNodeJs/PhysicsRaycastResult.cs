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

        public async ValueTask<decimal> get_hitDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "hitDistance");
        }

        private Vector3 __hitNormalWorld;

        public async ValueTask<Vector3> get_hitNormalWorld()
        {
            if (__hitNormalWorld == null)
            {
                __hitNormalWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __hitPointWorld;

        public async ValueTask<Vector3> get_hitPointWorld()
        {
            if (__hitPointWorld == null)
            {
                __hitPointWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __rayFromWorld;

        public async ValueTask<Vector3> get_rayFromWorld()
        {
            if (__rayFromWorld == null)
            {
                __rayFromWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __rayToWorld;

        public async ValueTask<Vector3> get_rayToWorld()
        {
            if (__rayToWorld == null)
            {
                __rayToWorld = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public async ValueTask setHitDistance(decimal distance)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHitDistance" }, distance }
            );
        }

        public async ValueTask calculateHitDistance()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "calculateHitDistance" } }
            );
        }

        public async ValueTask reset(Vector3 from = null, Vector3 to = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" }, from, to }
            );
        }
        #endregion
    }
}
