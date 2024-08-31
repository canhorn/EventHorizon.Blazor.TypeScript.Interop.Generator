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

    [JsonConverter(typeof(CachedEntityConverter<MaterialSheenDefines>))]
    public class MaterialSheenDefines : MaterialDefines
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

        public async ValueTask<bool> get_SHEEN()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN");
        }

        public ValueTask set_SHEEN(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN", value);
        }

        public async ValueTask<bool> get_SHEEN_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_TEXTURE");
        }

        public ValueTask set_SHEEN_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTURE", value);
        }

        public async ValueTask<bool> get_SHEEN_GAMMATEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_GAMMATEXTURE");
        }

        public ValueTask set_SHEEN_GAMMATEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_GAMMATEXTURE", value);
        }

        public async ValueTask<bool> get_SHEEN_TEXTURE_ROUGHNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SHEEN_TEXTURE_ROUGHNESS"
            );
        }

        public ValueTask set_SHEEN_TEXTURE_ROUGHNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTURE_ROUGHNESS", value);
        }

        public async ValueTask<decimal> get_SHEEN_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SHEEN_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_SHEEN_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTUREDIRECTUV", value);
        }

        public async ValueTask<decimal> get_SHEEN_TEXTURE_ROUGHNESSDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SHEEN_TEXTURE_ROUGHNESSDIRECTUV"
            );
        }

        public ValueTask set_SHEEN_TEXTURE_ROUGHNESSDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SHEEN_TEXTURE_ROUGHNESSDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_SHEEN_LINKWITHALBEDO()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_LINKWITHALBEDO");
        }

        public ValueTask set_SHEEN_LINKWITHALBEDO(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_LINKWITHALBEDO", value);
        }

        public async ValueTask<bool> get_SHEEN_ROUGHNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_ROUGHNESS");
        }

        public ValueTask set_SHEEN_ROUGHNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_ROUGHNESS", value);
        }

        public async ValueTask<bool> get_SHEEN_ALBEDOSCALING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_ALBEDOSCALING");
        }

        public ValueTask set_SHEEN_ALBEDOSCALING(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_ALBEDOSCALING", value);
        }

        public async ValueTask<bool> get_SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE"
            );
        }

        public ValueTask set_SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE",
                value
            );
        }
        #endregion

        #region Constructor
        public MaterialSheenDefines()
            : base() { }

        public MaterialSheenDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialSheenDefines> NewMaterialSheenDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialSheenDefines" },
                externalProperties
            );

            return new MaterialSheenDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
