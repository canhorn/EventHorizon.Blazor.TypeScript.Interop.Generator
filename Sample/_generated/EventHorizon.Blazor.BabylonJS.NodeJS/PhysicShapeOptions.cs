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

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        private PhysicsShapeParametersCachedEntity __parameters;
        public PhysicsShapeParametersCachedEntity parameters
        {
            get
            {
                if (__parameters == null)
                {
                    __parameters =
                        EventHorizonBlazorInterop.GetClass<PhysicsShapeParametersCachedEntity>(
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
            set
            {
                __parameters = null;
                EventHorizonBlazorInterop.Set(this.___guid, "parameters", value);
            }
        }

        public CachedEntity pluginData
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "pluginData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pluginData", value);
            }
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
