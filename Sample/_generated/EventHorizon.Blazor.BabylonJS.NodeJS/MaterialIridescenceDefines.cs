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

    [JsonConverter(typeof(CachedEntityConverter<MaterialIridescenceDefines>))]
    public class MaterialIridescenceDefines : MaterialDefines
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

        public bool IRIDESCENCE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "IRIDESCENCE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE", value);
            }
        }

        public bool IRIDESCENCE_TEXTURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "IRIDESCENCE_TEXTURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE_TEXTURE", value);
            }
        }

        public decimal IRIDESCENCE_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "IRIDESCENCE_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE_TEXTUREDIRECTUV", value);
            }
        }

        public bool IRIDESCENCE_THICKNESS_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IRIDESCENCE_THICKNESS_TEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE_THICKNESS_TEXTURE", value);
            }
        }

        public decimal IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV",
                    value
                );
            }
        }
        #endregion

        #region Constructor
        public MaterialIridescenceDefines()
            : base() { }

        public MaterialIridescenceDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialIridescenceDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialIridescenceDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
