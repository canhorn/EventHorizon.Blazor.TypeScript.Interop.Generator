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

    [JsonConverter(typeof(CachedEntityConverter<MaterialClearCoatDefines>))]
    public class MaterialClearCoatDefines : MaterialDefines
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

        public async ValueTask<bool> get_CLEARCOAT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT");
        }

        public ValueTask set_CLEARCOAT(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_DEFAULTIOR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT_DEFAULTIOR");
        }

        public ValueTask set_CLEARCOAT_DEFAULTIOR(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_DEFAULTIOR", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT_TEXTURE");
        }

        public ValueTask set_CLEARCOAT_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_TEXTURE", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_TEXTURE_ROUGHNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "CLEARCOAT_TEXTURE_ROUGHNESS"
            );
        }

        public ValueTask set_CLEARCOAT_TEXTURE_ROUGHNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "CLEARCOAT_TEXTURE_ROUGHNESS",
                value
            );
        }

        public async ValueTask<decimal> get_CLEARCOAT_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "CLEARCOAT_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_CLEARCOAT_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_TEXTUREDIRECTUV", value);
        }

        public async ValueTask<decimal> get_CLEARCOAT_TEXTURE_ROUGHNESSDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "CLEARCOAT_TEXTURE_ROUGHNESSDIRECTUV"
            );
        }

        public ValueTask set_CLEARCOAT_TEXTURE_ROUGHNESSDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "CLEARCOAT_TEXTURE_ROUGHNESSDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_CLEARCOAT_BUMP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT_BUMP");
        }

        public ValueTask set_CLEARCOAT_BUMP(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_BUMP", value);
        }

        public async ValueTask<decimal> get_CLEARCOAT_BUMPDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "CLEARCOAT_BUMPDIRECTUV"
            );
        }

        public ValueTask set_CLEARCOAT_BUMPDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_BUMPDIRECTUV", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_USE_ROUGHNESS_FROM_MAINTEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "CLEARCOAT_USE_ROUGHNESS_FROM_MAINTEXTURE"
            );
        }

        public ValueTask set_CLEARCOAT_USE_ROUGHNESS_FROM_MAINTEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "CLEARCOAT_USE_ROUGHNESS_FROM_MAINTEXTURE",
                value
            );
        }

        public async ValueTask<bool> get_CLEARCOAT_REMAP_F0()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT_REMAP_F0");
        }

        public ValueTask set_CLEARCOAT_REMAP_F0(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_REMAP_F0", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_TINT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "CLEARCOAT_TINT");
        }

        public ValueTask set_CLEARCOAT_TINT(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_TINT", value);
        }

        public async ValueTask<bool> get_CLEARCOAT_TINT_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "CLEARCOAT_TINT_TEXTURE"
            );
        }

        public ValueTask set_CLEARCOAT_TINT_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "CLEARCOAT_TINT_TEXTURE", value);
        }

        public async ValueTask<decimal> get_CLEARCOAT_TINT_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "CLEARCOAT_TINT_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_CLEARCOAT_TINT_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "CLEARCOAT_TINT_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_CLEARCOAT_TINT_GAMMATEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "CLEARCOAT_TINT_GAMMATEXTURE"
            );
        }

        public ValueTask set_CLEARCOAT_TINT_GAMMATEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "CLEARCOAT_TINT_GAMMATEXTURE",
                value
            );
        }
        #endregion

        #region Constructor
        public MaterialClearCoatDefines()
            : base() { }

        public MaterialClearCoatDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialClearCoatDefines> NewMaterialClearCoatDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialClearCoatDefines" },
                externalProperties
            );

            return new MaterialClearCoatDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
