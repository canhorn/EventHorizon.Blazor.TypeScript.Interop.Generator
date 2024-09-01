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

        public async ValueTask<bool> get_ANISOTROPIC()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC");
        }

        public ValueTask set_ANISOTROPIC(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC", value);
        }

        public async ValueTask<bool> get_ANISOTROPIC_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC_TEXTURE");
        }

        public ValueTask set_ANISOTROPIC_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC_TEXTURE", value);
        }

        public async ValueTask<decimal> get_ANISOTROPIC_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "ANISOTROPIC_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_ANISOTROPIC_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "ANISOTROPIC_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_ANISOTROPIC_LEGACY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "ANISOTROPIC_LEGACY");
        }

        public ValueTask set_ANISOTROPIC_LEGACY(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ANISOTROPIC_LEGACY", value);
        }

        public async ValueTask<bool> get_MAINUV1()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "MAINUV1");
        }

        public ValueTask set_MAINUV1(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "MAINUV1", value);
        }
        #endregion

        #region Constructor
        public MaterialAnisotropicDefines()
            : base() { }

        public MaterialAnisotropicDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialAnisotropicDefines> NewMaterialAnisotropicDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialAnisotropicDefines" },
                externalProperties
            );

            return new MaterialAnisotropicDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
