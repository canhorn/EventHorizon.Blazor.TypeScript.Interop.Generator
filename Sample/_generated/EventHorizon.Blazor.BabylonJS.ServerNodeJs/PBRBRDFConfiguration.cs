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

    [JsonConverter(typeof(CachedEntityConverter<PBRBRDFConfiguration>))]
    public class PBRBRDFConfiguration : MaterialPluginBase
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<bool> get_DEFAULT_USE_ENERGY_CONSERVATION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_ENERGY_CONSERVATION"
            );
        }

        public static ValueTask set_DEFAULT_USE_ENERGY_CONSERVATION(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_ENERGY_CONSERVATION",
                value
            );
        }

        public static async ValueTask<bool> get_DEFAULT_USE_SMITH_VISIBILITY_HEIGHT_CORRELATED()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SMITH_VISIBILITY_HEIGHT_CORRELATED"
            );
        }

        public static ValueTask set_DEFAULT_USE_SMITH_VISIBILITY_HEIGHT_CORRELATED(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SMITH_VISIBILITY_HEIGHT_CORRELATED",
                value
            );
        }

        public static async ValueTask<bool> get_DEFAULT_USE_SPHERICAL_HARMONICS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SPHERICAL_HARMONICS"
            );
        }

        public static ValueTask set_DEFAULT_USE_SPHERICAL_HARMONICS(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SPHERICAL_HARMONICS",
                value
            );
        }

        public static async ValueTask<bool> get_DEFAULT_USE_SPECULAR_GLOSSINESS_INPUT_ENERGY_CONSERVATION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SPECULAR_GLOSSINESS_INPUT_ENERGY_CONSERVATION"
            );
        }

        public static ValueTask set_DEFAULT_USE_SPECULAR_GLOSSINESS_INPUT_ENERGY_CONSERVATION(
            bool value
        )
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PBRBRDFConfiguration.DEFAULT_USE_SPECULAR_GLOSSINESS_INPUT_ENERGY_CONSERVATION",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<bool> get_useEnergyConservation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useEnergyConservation");
        }

        public ValueTask set_useEnergyConservation(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useEnergyConservation", value);
        }

        public async ValueTask<bool> get_useSmithVisibilityHeightCorrelated()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useSmithVisibilityHeightCorrelated"
            );
        }

        public ValueTask set_useSmithVisibilityHeightCorrelated(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useSmithVisibilityHeightCorrelated",
                value
            );
        }

        public async ValueTask<bool> get_useSphericalHarmonics()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useSphericalHarmonics");
        }

        public ValueTask set_useSphericalHarmonics(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useSphericalHarmonics", value);
        }

        public async ValueTask<bool> get_useSpecularGlossinessInputEnergyConservation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useSpecularGlossinessInputEnergyConservation"
            );
        }

        public ValueTask set_useSpecularGlossinessInputEnergyConservation(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useSpecularGlossinessInputEnergyConservation",
                value
            );
        }
        #endregion

        #region Constructor
        public PBRBRDFConfiguration()
            : base() { }

        public PBRBRDFConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRBRDFConfiguration> NewPBRBRDFConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBRDFConfiguration" },
                material,
                addToPluginList
            );

            return new PBRBRDFConfiguration(entity);
        }

        public static async ValueTask<PBRBRDFConfiguration> NewPBRBRDFConfiguration(
            Material material,
            string name,
            decimal priority,
            object defines = null,
            System.Nullable<bool> addToPluginList = null,
            System.Nullable<bool> enable = null,
            System.Nullable<bool> resolveIncludes = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBRDFConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRBRDFConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask prepareDefines(MaterialBRDFDefines defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepareDefines" }, defines }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
