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

    public interface PhysicsMaterial : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsMaterialCachedEntity>))]
    public class PhysicsMaterialCachedEntity : CachedEntityObject, PhysicsMaterial
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

        public decimal friction
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
            }
        }

        public decimal staticFriction
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "staticFriction"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "staticFriction", value);
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

        public int frictionCombine
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "frictionCombine"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "frictionCombine", value);
            }
        }

        public int restitutionCombine
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "restitutionCombine"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "restitutionCombine", value);
            }
        }
        #endregion

        #region Constructor
        public PhysicsMaterialCachedEntity()
            : base() { }

        public PhysicsMaterialCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
