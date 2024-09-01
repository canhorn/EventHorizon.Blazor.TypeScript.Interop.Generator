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

        public async ValueTask<bool> get_DETAIL()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "DETAIL");
        }

        public ValueTask set_DETAIL(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "DETAIL", value);
        }

        public async ValueTask<decimal> get_DETAILDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "DETAILDIRECTUV");
        }

        public ValueTask set_DETAILDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "DETAILDIRECTUV", value);
        }

        public async ValueTask<decimal> get_DETAIL_NORMALBLENDMETHOD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "DETAIL_NORMALBLENDMETHOD"
            );
        }

        public ValueTask set_DETAIL_NORMALBLENDMETHOD(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "DETAIL_NORMALBLENDMETHOD", value);
        }
        #endregion

        #region Constructor
        public MaterialDetailMapDefines()
            : base() { }

        public MaterialDetailMapDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialDetailMapDefines> NewMaterialDetailMapDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialDetailMapDefines" },
                externalProperties
            );

            return new MaterialDetailMapDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
