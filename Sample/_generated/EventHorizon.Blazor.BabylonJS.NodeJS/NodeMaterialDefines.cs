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

    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialDefines>))]
    public class NodeMaterialDefines : MaterialDefines, IImageProcessingConfigurationDefines
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

        public bool NORMAL
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "NORMAL"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "NORMAL", value);
            }
        }

        public bool TANGENT
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "TANGENT"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "TANGENT", value);
            }
        }

        public bool VERTEXCOLOR_NME
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "VERTEXCOLOR_NME"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "VERTEXCOLOR_NME", value);
            }
        }

        public bool UV1
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV1"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV1", value);
            }
        }

        public bool UV2
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV2"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV2", value);
            }
        }

        public bool UV3
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV3"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV3", value);
            }
        }

        public bool UV4
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV4"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV4", value);
            }
        }

        public bool UV5
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV5"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV5", value);
            }
        }

        public bool UV6
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "UV6"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "UV6", value);
            }
        }

        public bool PREPASS
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "PREPASS"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS", value);
            }
        }

        public bool PREPASS_NORMAL
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "PREPASS_NORMAL"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_NORMAL", value);
            }
        }

        public decimal PREPASS_NORMAL_INDEX
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "PREPASS_NORMAL_INDEX");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_NORMAL_INDEX", value);
            }
        }

        public bool PREPASS_POSITION
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "PREPASS_POSITION"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_POSITION", value);
            }
        }

        public decimal PREPASS_POSITION_INDEX
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "PREPASS_POSITION_INDEX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_POSITION_INDEX", value);
            }
        }

        public bool PREPASS_DEPTH
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "PREPASS_DEPTH"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_DEPTH", value);
            }
        }

        public decimal PREPASS_DEPTH_INDEX
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "PREPASS_DEPTH_INDEX");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "PREPASS_DEPTH_INDEX", value);
            }
        }

        public decimal SCENE_MRT_COUNT
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "SCENE_MRT_COUNT"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SCENE_MRT_COUNT", value);
            }
        }

        public decimal NUM_BONE_INFLUENCERS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "NUM_BONE_INFLUENCERS");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "NUM_BONE_INFLUENCERS", value);
            }
        }

        public decimal BonesPerMesh
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "BonesPerMesh"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "BonesPerMesh", value);
            }
        }

        public bool BONETEXTURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "BONETEXTURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "BONETEXTURE", value);
            }
        }

        public bool MORPHTARGETS
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MORPHTARGETS"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MORPHTARGETS", value);
            }
        }

        public bool MORPHTARGETS_NORMAL
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MORPHTARGETS_NORMAL"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MORPHTARGETS_NORMAL", value);
            }
        }

        public bool MORPHTARGETS_TANGENT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MORPHTARGETS_TANGENT");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MORPHTARGETS_TANGENT", value);
            }
        }

        public bool MORPHTARGETS_UV
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MORPHTARGETS_UV"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MORPHTARGETS_UV", value);
            }
        }

        public decimal NUM_MORPH_INFLUENCERS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "NUM_MORPH_INFLUENCERS", value);
            }
        }

        public bool MORPHTARGETS_TEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "MORPHTARGETS_TEXTURE");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "MORPHTARGETS_TEXTURE", value);
            }
        }

        public bool IMAGEPROCESSING
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "IMAGEPROCESSING"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IMAGEPROCESSING", value);
            }
        }

        public bool VIGNETTE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "VIGNETTE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "VIGNETTE", value);
            }
        }

        public bool VIGNETTEBLENDMODEMULTIPLY
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "VIGNETTEBLENDMODEMULTIPLY", value);
            }
        }

        public bool VIGNETTEBLENDMODEOPAQUE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "VIGNETTEBLENDMODEOPAQUE");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "VIGNETTEBLENDMODEOPAQUE", value);
            }
        }

        public decimal TONEMAPPING
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "TONEMAPPING"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "TONEMAPPING", value);
            }
        }

        public bool CONTRAST
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "CONTRAST"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "CONTRAST", value);
            }
        }

        public bool EXPOSURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "EXPOSURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "EXPOSURE", value);
            }
        }

        public bool COLORCURVES
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "COLORCURVES"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "COLORCURVES", value);
            }
        }

        public bool COLORGRADING
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "COLORGRADING"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "COLORGRADING", value);
            }
        }

        public bool COLORGRADING3D
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "COLORGRADING3D"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "COLORGRADING3D", value);
            }
        }

        public bool SAMPLER3DGREENDEPTH
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SAMPLER3DGREENDEPTH"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SAMPLER3DGREENDEPTH", value);
            }
        }

        public bool SAMPLER3DBGRMAP
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SAMPLER3DBGRMAP"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SAMPLER3DBGRMAP", value);
            }
        }

        public bool DITHER
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "DITHER"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "DITHER", value);
            }
        }

        public bool IMAGEPROCESSINGPOSTPROCESS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "IMAGEPROCESSINGPOSTPROCESS", value);
            }
        }

        public bool SKIPFINALCOLORCLAMP
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SKIPFINALCOLORCLAMP"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SKIPFINALCOLORCLAMP", value);
            }
        }

        public decimal BUMPDIRECTUV
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "BUMPDIRECTUV"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "BUMPDIRECTUV", value);
            }
        }

        public bool CAMERA_ORTHOGRAPHIC
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "CAMERA_ORTHOGRAPHIC"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "CAMERA_ORTHOGRAPHIC", value);
            }
        }

        public bool CAMERA_PERSPECTIVE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "CAMERA_PERSPECTIVE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "CAMERA_PERSPECTIVE", value);
            }
        }
        #endregion

        #region Constructor
        public NodeMaterialDefines()
            : base() { }

        public NodeMaterialDefines(ICachedEntity entity)
            : base(entity) { }

        public NodeMaterialDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterialDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setValue(
            string name,
            object value,
            System.Nullable<bool> markAsUnprocessedIfDirty = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" },
                    name,
                    value,
                    markAsUnprocessedIfDirty
                }
            );
        }
        #endregion
    }
}
