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

    [JsonConverter(typeof(CachedEntityConverter<MaterialAnisotropicDefines>))]
    public class MaterialAnisotropicDefines : MaterialDefines
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

        public bool ANISOTROPIC
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC", value);
            }
        }

        public bool ANISOTROPIC_TEXTURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC_TEXTURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC_TEXTURE", value);
            }
        }

        public decimal ANISOTROPIC_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANISOTROPIC_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC_TEXTUREDIRECTUV", value);
            }
        }

        public bool ANISOTROPIC_LEGACY
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC_LEGACY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC_LEGACY", value);
            }
        }

        public bool MAINUV1
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MAINUV1"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MAINUV1", value);
            }
        }
        #endregion

        #region Constructor
        public MaterialAnisotropicDefines()
            : base() { }

        public MaterialAnisotropicDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialAnisotropicDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialAnisotropicDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
