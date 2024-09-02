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

    public interface PhysicShapeOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicShapeOptionsCachedEntity>))]
    public class PhysicShapeOptionsCachedEntity : CachedEntityObject, PhysicShapeOptions
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

        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "type");
        }

        public ValueTask set_type(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        private PhysicsShapeParametersCachedEntity __parameters;

        public async ValueTask<PhysicsShapeParametersCachedEntity> get_parameters()
        {
            if (__parameters == null)
            {
                __parameters =
                    await EventHorizonBlazorInterop.GetClass<PhysicsShapeParametersCachedEntity>(
                        this.___guid,
                        "parameters",
                        (entity) =>
                        {
                            return new PhysicsShapeParametersCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __parameters;
        }

        public ValueTask set_parameters(PhysicsShapeParametersCachedEntity value)
        {
            __parameters = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "parameters", value);
        }

        public async ValueTask<CachedEntity> get_pluginData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "pluginData",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_pluginData(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pluginData", value);
        }
        #endregion

        #region Constructor
        public PhysicShapeOptionsCachedEntity()
            : base() { }

        public PhysicShapeOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
