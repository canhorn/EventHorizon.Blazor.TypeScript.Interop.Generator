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
        public Vector3 mainPivot
        {
            get
            {
                if (__mainPivot == null)
                {
                    __mainPivot = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __mainPivot = null;
                EventHorizonBlazorInterop.Set(this.___guid, "mainPivot", value);
            }
        }

        private Vector3 __connectedPivot;
        public Vector3 connectedPivot
        {
            get
            {
                if (__connectedPivot == null)
                {
                    __connectedPivot = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __connectedPivot = null;
                EventHorizonBlazorInterop.Set(this.___guid, "connectedPivot", value);
            }
        }

        private Vector3 __mainAxis;
        public Vector3 mainAxis
        {
            get
            {
                if (__mainAxis == null)
                {
                    __mainAxis = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __mainAxis = null;
                EventHorizonBlazorInterop.Set(this.___guid, "mainAxis", value);
            }
        }

        private Vector3 __connectedAxis;
        public Vector3 connectedAxis
        {
            get
            {
                if (__connectedAxis == null)
                {
                    __connectedAxis = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __connectedAxis = null;
                EventHorizonBlazorInterop.Set(this.___guid, "connectedAxis", value);
            }
        }

        public bool collision
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "collision"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "collision", value);
            }
        }

        public CachedEntity nativeParams
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "nativeParams",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "nativeParams", value);
            }
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
