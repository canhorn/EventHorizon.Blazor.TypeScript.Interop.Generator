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

        public async ValueTask<bool> get_IRIDESCENCE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "IRIDESCENCE");
        }

        public ValueTask set_IRIDESCENCE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE", value);
        }

        public async ValueTask<bool> get_IRIDESCENCE_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "IRIDESCENCE_TEXTURE");
        }

        public ValueTask set_IRIDESCENCE_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "IRIDESCENCE_TEXTURE", value);
        }

        public async ValueTask<decimal> get_IRIDESCENCE_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "IRIDESCENCE_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_IRIDESCENCE_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "IRIDESCENCE_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_IRIDESCENCE_THICKNESS_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "IRIDESCENCE_THICKNESS_TEXTURE"
            );
        }

        public ValueTask set_IRIDESCENCE_THICKNESS_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "IRIDESCENCE_THICKNESS_TEXTURE",
                value
            );
        }

        public async ValueTask<decimal> get_IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "IRIDESCENCE_THICKNESS_TEXTUREDIRECTUV",
                value
            );
        }
        #endregion

        #region Constructor
        public MaterialIridescenceDefines()
            : base() { }

        public MaterialIridescenceDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialIridescenceDefines> NewMaterialIridescenceDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialIridescenceDefines" },
                externalProperties
            );

            return new MaterialIridescenceDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
