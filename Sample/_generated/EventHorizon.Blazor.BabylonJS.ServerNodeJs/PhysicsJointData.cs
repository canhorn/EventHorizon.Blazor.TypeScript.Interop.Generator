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

    public interface PhysicsJointData : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsJointDataCachedEntity>))]
    public class PhysicsJointDataCachedEntity : CachedEntityObject, PhysicsJointData
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
        private Vector3 __mainPivot;

        public async ValueTask<Vector3> get_mainPivot()
        {
            if (__mainPivot == null)
            {
                __mainPivot = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "mainPivot",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __mainPivot;
        }

        public ValueTask set_mainPivot(Vector3 value)
        {
            __mainPivot = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "mainPivot", value);
        }

        private Vector3 __connectedPivot;

        public async ValueTask<Vector3> get_connectedPivot()
        {
            if (__connectedPivot == null)
            {
                __connectedPivot = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "connectedPivot",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __connectedPivot;
        }

        public ValueTask set_connectedPivot(Vector3 value)
        {
            __connectedPivot = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "connectedPivot", value);
        }

        private Vector3 __mainAxis;

        public async ValueTask<Vector3> get_mainAxis()
        {
            if (__mainAxis == null)
            {
                __mainAxis = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "mainAxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __mainAxis;
        }

        public ValueTask set_mainAxis(Vector3 value)
        {
            __mainAxis = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "mainAxis", value);
        }

        private Vector3 __connectedAxis;

        public async ValueTask<Vector3> get_connectedAxis()
        {
            if (__connectedAxis == null)
            {
                __connectedAxis = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "connectedAxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __connectedAxis;
        }

        public ValueTask set_connectedAxis(Vector3 value)
        {
            __connectedAxis = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "connectedAxis", value);
        }

        public async ValueTask<bool> get_collision()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "collision");
        }

        public ValueTask set_collision(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "collision", value);
        }

        public async ValueTask<CachedEntity> get_nativeParams()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "nativeParams",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_nativeParams(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "nativeParams", value);
        }
        #endregion

        #region Constructor
        public PhysicsJointDataCachedEntity()
            : base() { }

        public PhysicsJointDataCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
