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

    [JsonConverter(typeof(CachedEntityConverter<MaterialSubSurfaceDefines>))]
    public class MaterialSubSurfaceDefines : MaterialDefines
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

        public async ValueTask<bool> get_SUBSURFACE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SUBSURFACE");
        }

        public ValueTask set_SUBSURFACE(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SUBSURFACE", value);
        }

        public async ValueTask<bool> get_SS_REFRACTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_REFRACTION");
        }

        public ValueTask set_SS_REFRACTION(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTION", value);
        }

        public async ValueTask<bool> get_SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS"
            );
        }

        public ValueTask set_SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS",
                value
            );
        }

        public async ValueTask<bool> get_SS_TRANSLUCENCY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_TRANSLUCENCY");
        }

        public ValueTask set_SS_TRANSLUCENCY(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_TRANSLUCENCY", value);
        }

        public async ValueTask<bool> get_SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS"
            );
        }

        public ValueTask set_SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS",
                value
            );
        }

        public async ValueTask<bool> get_SS_SCATTERING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_SCATTERING");
        }

        public ValueTask set_SS_SCATTERING(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_SCATTERING", value);
        }

        public async ValueTask<bool> get_SS_DISPERSION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_DISPERSION");
        }

        public ValueTask set_SS_DISPERSION(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_DISPERSION", value);
        }

        public async ValueTask<bool> get_SS_THICKNESSANDMASK_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_THICKNESSANDMASK_TEXTURE"
            );
        }

        public ValueTask set_SS_THICKNESSANDMASK_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_THICKNESSANDMASK_TEXTURE",
                value
            );
        }

        public async ValueTask<decimal> get_SS_THICKNESSANDMASK_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SS_THICKNESSANDMASK_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_SS_THICKNESSANDMASK_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_THICKNESSANDMASK_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_SS_HAS_THICKNESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_HAS_THICKNESS");
        }

        public ValueTask set_SS_HAS_THICKNESS(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_HAS_THICKNESS", value);
        }

        public async ValueTask<bool> get_SS_REFRACTIONINTENSITY_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_REFRACTIONINTENSITY_TEXTURE"
            );
        }

        public ValueTask set_SS_REFRACTIONINTENSITY_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_REFRACTIONINTENSITY_TEXTURE",
                value
            );
        }

        public async ValueTask<decimal> get_SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_SS_TRANSLUCENCYINTENSITY_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_TRANSLUCENCYINTENSITY_TEXTURE"
            );
        }

        public ValueTask set_SS_TRANSLUCENCYINTENSITY_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_TRANSLUCENCYINTENSITY_TEXTURE",
                value
            );
        }

        public async ValueTask<decimal> get_SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_SS_TRANSLUCENCYCOLOR_TEXTURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_TRANSLUCENCYCOLOR_TEXTURE"
            );
        }

        public ValueTask set_SS_TRANSLUCENCYCOLOR_TEXTURE(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_TRANSLUCENCYCOLOR_TEXTURE",
                value
            );
        }

        public async ValueTask<decimal> get_SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV"
            );
        }

        public ValueTask set_SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV",
                value
            );
        }

        public async ValueTask<bool> get_SS_REFRACTIONMAP_3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_REFRACTIONMAP_3D");
        }

        public ValueTask set_SS_REFRACTIONMAP_3D(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTIONMAP_3D", value);
        }

        public async ValueTask<bool> get_SS_REFRACTIONMAP_OPPOSITEZ()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_REFRACTIONMAP_OPPOSITEZ"
            );
        }

        public ValueTask set_SS_REFRACTIONMAP_OPPOSITEZ(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTIONMAP_OPPOSITEZ", value);
        }

        public async ValueTask<bool> get_SS_LODINREFRACTIONALPHA()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_LODINREFRACTIONALPHA"
            );
        }

        public ValueTask set_SS_LODINREFRACTIONALPHA(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_LODINREFRACTIONALPHA", value);
        }

        public async ValueTask<bool> get_SS_GAMMAREFRACTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_GAMMAREFRACTION");
        }

        public ValueTask set_SS_GAMMAREFRACTION(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_GAMMAREFRACTION", value);
        }

        public async ValueTask<bool> get_SS_RGBDREFRACTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_RGBDREFRACTION");
        }

        public ValueTask set_SS_RGBDREFRACTION(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_RGBDREFRACTION", value);
        }

        public async ValueTask<bool> get_SS_LINEARSPECULARREFRACTION()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_LINEARSPECULARREFRACTION"
            );
        }

        public ValueTask set_SS_LINEARSPECULARREFRACTION(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_LINEARSPECULARREFRACTION",
                value
            );
        }

        public async ValueTask<bool> get_SS_LINKREFRACTIONTOTRANSPARENCY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_LINKREFRACTIONTOTRANSPARENCY"
            );
        }

        public ValueTask set_SS_LINKREFRACTIONTOTRANSPARENCY(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_LINKREFRACTIONTOTRANSPARENCY",
                value
            );
        }

        public async ValueTask<bool> get_SS_ALBEDOFORREFRACTIONTINT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_ALBEDOFORREFRACTIONTINT"
            );
        }

        public ValueTask set_SS_ALBEDOFORREFRACTIONTINT(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_ALBEDOFORREFRACTIONTINT", value);
        }

        public async ValueTask<bool> get_SS_ALBEDOFORTRANSLUCENCYTINT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_ALBEDOFORTRANSLUCENCYTINT"
            );
        }

        public ValueTask set_SS_ALBEDOFORTRANSLUCENCYTINT(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_ALBEDOFORTRANSLUCENCYTINT",
                value
            );
        }

        public async ValueTask<bool> get_SS_USE_LOCAL_REFRACTIONMAP_CUBIC()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_USE_LOCAL_REFRACTIONMAP_CUBIC"
            );
        }

        public ValueTask set_SS_USE_LOCAL_REFRACTIONMAP_CUBIC(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "SS_USE_LOCAL_REFRACTIONMAP_CUBIC",
                value
            );
        }

        public async ValueTask<bool> get_SS_USE_THICKNESS_AS_DEPTH()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "SS_USE_THICKNESS_AS_DEPTH"
            );
        }

        public ValueTask set_SS_USE_THICKNESS_AS_DEPTH(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_USE_THICKNESS_AS_DEPTH", value);
        }

        public async ValueTask<bool> get_SS_USE_GLTF_TEXTURES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_USE_GLTF_TEXTURES");
        }

        public ValueTask set_SS_USE_GLTF_TEXTURES(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "SS_USE_GLTF_TEXTURES", value);
        }
        #endregion

        #region Constructor
        public MaterialSubSurfaceDefines()
            : base() { }

        public MaterialSubSurfaceDefines(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MaterialSubSurfaceDefines> NewMaterialSubSurfaceDefines(
            object externalProperties = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialSubSurfaceDefines" },
                externalProperties
            );

            return new MaterialSubSurfaceDefines(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
