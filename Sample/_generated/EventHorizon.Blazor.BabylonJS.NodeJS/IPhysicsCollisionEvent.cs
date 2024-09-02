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

    public interface IPhysicsCollisionEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsCollisionEventCachedEntity>))]
    public class IPhysicsCollisionEventCachedEntity : CachedEntityObject, IPhysicsCollisionEvent
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
        private Vector3 __point;
        public Vector3 point
        {
            get
            {
                if (__point == null)
                {
                    __point = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "point",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __point;
            }
            set
            {
                __point = null;
                EventHorizonBlazorInterop.Set(this.___guid, "point", value);
            }
        }

        public decimal distance
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "distance"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "distance", value);
            }
        }

        public decimal impulse
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "impulse"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "impulse", value);
            }
        }

        private Vector3 __normal;
        public Vector3 normal
        {
            get
            {
                if (__normal == null)
                {
                    __normal = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "normal",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __normal;
            }
            set
            {
                __normal = null;
                EventHorizonBlazorInterop.Set(this.___guid, "normal", value);
            }
        }
        #endregion

        #region Constructor
        public IPhysicsCollisionEventCachedEntity()
            : base() { }

        public IPhysicsCollisionEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
