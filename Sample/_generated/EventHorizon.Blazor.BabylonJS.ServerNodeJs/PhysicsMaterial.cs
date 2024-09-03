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

        public async ValueTask<decimal> get_friction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction");
        }

        public ValueTask set_friction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
        }

        public async ValueTask<decimal> get_staticFriction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "staticFriction");
        }

        public ValueTask set_staticFriction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "staticFriction", value);
        }

        public async ValueTask<decimal> get_restitution()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution");
        }

        public ValueTask set_restitution(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
        }

        public async ValueTask<int> get_frictionCombine()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "frictionCombine");
        }

        public ValueTask set_frictionCombine(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "frictionCombine", value);
        }

        public async ValueTask<int> get_restitutionCombine()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "restitutionCombine");
        }

        public ValueTask set_restitutionCombine(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "restitutionCombine", value);
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
