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

    [JsonConverter(typeof(CachedEntityConverter<MaterialDetailMapDefines>))]
    public class MaterialDetailMapDefines : MaterialDefines
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

        public bool DETAIL
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "DETAIL"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "DETAIL", value);
            }
        }

        public decimal DETAILDIRECTUV
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "DETAILDIRECTUV"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "DETAILDIRECTUV", value);
            }
        }

        public decimal DETAIL_NORMALBLENDMETHOD
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DETAIL_NORMALBLENDMETHOD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "DETAIL_NORMALBLENDMETHOD", value);
            }
        }
        #endregion

        #region Constructor
        public MaterialDetailMapDefines()
            : base() { }

        public MaterialDetailMapDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialDetailMapDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialDetailMapDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
