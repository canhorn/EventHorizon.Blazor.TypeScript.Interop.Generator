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

        public bool BRDF_V_HEIGHT_CORRELATED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BRDF_V_HEIGHT_CORRELATED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "BRDF_V_HEIGHT_CORRELATED", value);
            }
        }

        public bool MS_BRDF_ENERGY_CONSERVATION
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MS_BRDF_ENERGY_CONSERVATION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MS_BRDF_ENERGY_CONSERVATION", value);
            }
        }

        public bool SPHERICAL_HARMONICS
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SPHERICAL_HARMONICS"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SPHERICAL_HARMONICS", value);
            }
        }

        public bool SPECULAR_GLOSSINESS_ENERGY_CONSERVATION
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SPECULAR_GLOSSINESS_ENERGY_CONSERVATION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SPECULAR_GLOSSINESS_ENERGY_CONSERVATION",
                    value
                );
            }
        }
        #endregion

        #region Constructor
        public MaterialBRDFDefines()
            : base() { }

        public MaterialBRDFDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialBRDFDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialBRDFDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
