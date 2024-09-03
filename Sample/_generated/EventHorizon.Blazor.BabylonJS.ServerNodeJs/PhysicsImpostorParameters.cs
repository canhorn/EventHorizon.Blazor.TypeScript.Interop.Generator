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

        public async ValueTask<decimal> get_mass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass");
        }

        public ValueTask set_mass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
        }

        public async ValueTask<decimal> get_friction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction");
        }

        public ValueTask set_friction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
        }

        public async ValueTask<decimal> get_restitution()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution");
        }

        public ValueTask set_restitution(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
        }

        public async ValueTask<CachedEntity> get_nativeOptions()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "nativeOptions",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_nativeOptions(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "nativeOptions", value);
        }

        public async ValueTask<bool> get_ignoreParent()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ignoreParent");
        }

        public ValueTask set_ignoreParent(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ignoreParent", value);
        }

        public async ValueTask<bool> get_disableBidirectionalTransformation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "disableBidirectionalTransformation"
            );
        }

        public ValueTask set_disableBidirectionalTransformation(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "disableBidirectionalTransformation",
                value
            );
        }

        public async ValueTask<decimal> get_pressure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pressure");
        }

        public ValueTask set_pressure(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pressure", value);
        }

        public async ValueTask<decimal> get_stiffness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stiffness");
        }

        public ValueTask set_stiffness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stiffness", value);
        }

        public async ValueTask<decimal> get_velocityIterations()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "velocityIterations");
        }

        public ValueTask set_velocityIterations(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "velocityIterations", value);
        }

        public async ValueTask<decimal> get_positionIterations()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "positionIterations");
        }

        public ValueTask set_positionIterations(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "positionIterations", value);
        }

        public async ValueTask<decimal> get_fixedPoints()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fixedPoints");
        }

        public ValueTask set_fixedPoints(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fixedPoints", value);
        }

        public async ValueTask<decimal> get_margin()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "margin");
        }

        public ValueTask set_margin(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "margin", value);
        }

        public async ValueTask<decimal> get_damping()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "damping");
        }

        public ValueTask set_damping(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "damping", value);
        }

        public async ValueTask<CachedEntity> get_path()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "path",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_path(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "path", value);
        }

        public async ValueTask<CachedEntity> get_shape()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "shape",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_shape(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
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
