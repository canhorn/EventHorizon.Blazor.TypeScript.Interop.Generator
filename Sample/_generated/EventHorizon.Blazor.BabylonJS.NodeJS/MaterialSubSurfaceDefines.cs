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

        public bool SUBSURFACE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SUBSURFACE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SUBSURFACE", value);
            }
        }

        public bool SS_REFRACTION
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_REFRACTION"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTION", value);
            }
        }

        public bool SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_REFRACTION_USE_INTENSITY_FROM_THICKNESS",
                    value
                );
            }
        }

        public bool SS_TRANSLUCENCY
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_TRANSLUCENCY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_TRANSLUCENCY", value);
            }
        }

        public bool SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_TRANSLUCENCY_USE_INTENSITY_FROM_THICKNESS",
                    value
                );
            }
        }

        public bool SS_SCATTERING
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_SCATTERING"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_SCATTERING", value);
            }
        }

        public bool SS_DISPERSION
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_DISPERSION"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_DISPERSION", value);
            }
        }

        public bool SS_THICKNESSANDMASK_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_THICKNESSANDMASK_TEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_THICKNESSANDMASK_TEXTURE", value);
            }
        }

        public decimal SS_THICKNESSANDMASK_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SS_THICKNESSANDMASK_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_THICKNESSANDMASK_TEXTUREDIRECTUV",
                    value
                );
            }
        }

        public bool SS_HAS_THICKNESS
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_HAS_THICKNESS"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_HAS_THICKNESS", value);
            }
        }

        public bool SS_REFRACTIONINTENSITY_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_REFRACTIONINTENSITY_TEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_REFRACTIONINTENSITY_TEXTURE",
                    value
                );
            }
        }

        public decimal SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_REFRACTIONINTENSITY_TEXTUREDIRECTUV",
                    value
                );
            }
        }

        public bool SS_TRANSLUCENCYINTENSITY_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_TRANSLUCENCYINTENSITY_TEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_TRANSLUCENCYINTENSITY_TEXTURE",
                    value
                );
            }
        }

        public decimal SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_TRANSLUCENCYINTENSITY_TEXTUREDIRECTUV",
                    value
                );
            }
        }

        public bool SS_TRANSLUCENCYCOLOR_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_TRANSLUCENCYCOLOR_TEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_TRANSLUCENCYCOLOR_TEXTURE", value);
            }
        }

        public decimal SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_TRANSLUCENCYCOLOR_TEXTUREDIRECTUV",
                    value
                );
            }
        }

        public bool SS_REFRACTIONMAP_3D
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_REFRACTIONMAP_3D"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTIONMAP_3D", value);
            }
        }

        public bool SS_REFRACTIONMAP_OPPOSITEZ
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_REFRACTIONMAP_OPPOSITEZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_REFRACTIONMAP_OPPOSITEZ", value);
            }
        }

        public bool SS_LODINREFRACTIONALPHA
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_LODINREFRACTIONALPHA");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_LODINREFRACTIONALPHA", value);
            }
        }

        public bool SS_GAMMAREFRACTION
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_GAMMAREFRACTION"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_GAMMAREFRACTION", value);
            }
        }

        public bool SS_RGBDREFRACTION
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_RGBDREFRACTION"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_RGBDREFRACTION", value);
            }
        }

        public bool SS_LINEARSPECULARREFRACTION
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_LINEARSPECULARREFRACTION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_LINEARSPECULARREFRACTION", value);
            }
        }

        public bool SS_LINKREFRACTIONTOTRANSPARENCY
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_LINKREFRACTIONTOTRANSPARENCY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_LINKREFRACTIONTOTRANSPARENCY",
                    value
                );
            }
        }

        public bool SS_ALBEDOFORREFRACTIONTINT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_ALBEDOFORREFRACTIONTINT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_ALBEDOFORREFRACTIONTINT", value);
            }
        }

        public bool SS_ALBEDOFORTRANSLUCENCYTINT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_ALBEDOFORTRANSLUCENCYTINT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_ALBEDOFORTRANSLUCENCYTINT", value);
            }
        }

        public bool SS_USE_LOCAL_REFRACTIONMAP_CUBIC
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_USE_LOCAL_REFRACTIONMAP_CUBIC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SS_USE_LOCAL_REFRACTIONMAP_CUBIC",
                    value
                );
            }
        }

        public bool SS_USE_THICKNESS_AS_DEPTH
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SS_USE_THICKNESS_AS_DEPTH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_USE_THICKNESS_AS_DEPTH", value);
            }
        }

        public bool SS_USE_GLTF_TEXTURES
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SS_USE_GLTF_TEXTURES");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SS_USE_GLTF_TEXTURES", value);
            }
        }
        #endregion

        #region Constructor
        public MaterialSubSurfaceDefines()
            : base() { }

        public MaterialSubSurfaceDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialSubSurfaceDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialSubSurfaceDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
