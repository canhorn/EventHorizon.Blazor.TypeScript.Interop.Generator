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

    [JsonConverter(typeof(CachedEntityConverter<MaterialBRDFDefines>))]
    public class MaterialBRDFDefines : MaterialDefines
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

        public async ValueTask<bool> get_BRDF_V_HEIGHT_CORRELATED()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "BRDF_V_HEIGHT_CORRELATED"
            );
        }

        public ValueTask set_BRDF_V_HEIGHT_CORRELATED(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "BRDF_V_HEIGHT_CORRELATED", value);
        }

        public async ValueTask<bool> get_MS_BRDF_ENERGY_CONSERVATION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "MS_BRDF_ENERGY_CONSERVATION"
            );
        }

        public ValueTask set_MS_BRDF_ENERGY_CONSERVATION(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "MS_BRDF_ENERGY_CONSERVATION",
                value
            );
        }

        public async ValueTask<bool> get_SPHERICAL_HARMONICS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SPHERICAL_HARMONICS");
        }

        public ValueTask set_SPHERICAL_HARMONICS(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SPHERICAL_HARMONICS", value);
        }

        public async ValueTask<bool> get_SPECULAR_GLOSSINESS_ENERGY_CONSERVATION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SPECULAR_GLOSSINESS_ENERGY_CONSERVATION"
            );
        }

        public ValueTask set_SPECULAR_GLOSSINESS_ENERGY_CONSERVATION(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SPECULAR_GLOSSINESS_ENERGY_CONSERVATION",
                value
            );
        }
        #endregion

        #region Constructor
        public MaterialBRDFDefines()
            : base() { }

        public MaterialBRDFDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialBRDFDefines> NewMaterialBRDFDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialBRDFDefines" },
                externalProperties
            );

            return new MaterialBRDFDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
