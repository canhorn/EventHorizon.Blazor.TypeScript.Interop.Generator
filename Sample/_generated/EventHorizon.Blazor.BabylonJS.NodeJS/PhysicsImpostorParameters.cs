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

    public interface PhysicsImpostorParameters : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsImpostorParametersCachedEntity>))]
    public class PhysicsImpostorParametersCachedEntity
        : CachedEntityObject,
            PhysicsImpostorParameters
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

        public decimal mass
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
            }
        }

        public decimal friction
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
            }
        }

        public decimal restitution
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
            }
        }

        public CachedEntity nativeOptions
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "nativeOptions",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "nativeOptions", value);
            }
        }

        public bool ignoreParent
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ignoreParent"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ignoreParent", value);
            }
        }

        public bool disableBidirectionalTransformation
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableBidirectionalTransformation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableBidirectionalTransformation",
                    value
                );
            }
        }

        public decimal pressure
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pressure"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pressure", value);
            }
        }

        public decimal stiffness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stiffness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stiffness", value);
            }
        }

        public decimal velocityIterations
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "velocityIterations");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "velocityIterations", value);
            }
        }

        public decimal positionIterations
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "positionIterations");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "positionIterations", value);
            }
        }

        public decimal fixedPoints
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fixedPoints"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fixedPoints", value);
            }
        }

        public decimal margin
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "margin"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "margin", value);
            }
        }

        public decimal damping
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "damping"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "damping", value);
            }
        }

        public CachedEntity path
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "path",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "path", value);
            }
        }

        public CachedEntity shape
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "shape",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
            }
        }
        #endregion

        #region Constructor
        public PhysicsImpostorParametersCachedEntity()
            : base() { }

        public PhysicsImpostorParametersCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
