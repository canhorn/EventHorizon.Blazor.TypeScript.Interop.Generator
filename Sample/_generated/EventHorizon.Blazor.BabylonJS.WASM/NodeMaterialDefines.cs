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
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "NORMAL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NORMAL",
                    value
                );
            }
        }

        
        public bool TANGENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TANGENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TANGENT",
                    value
                );
            }
        }

        
        public bool UV1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "UV1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UV1",
                    value
                );
            }
        }

        
        public decimal NUM_BONE_INFLUENCERS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_BONE_INFLUENCERS",
                    value
                );
            }
        }

        
        public decimal BonesPerMesh
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BonesPerMesh"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BonesPerMesh",
                    value
                );
            }
        }

        
        public bool BONETEXTURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "BONETEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BONETEXTURE",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_NORMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_NORMAL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_NORMAL",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_TANGENT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_TANGENT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_TANGENT",
                    value
                );
            }
        }

        
        public bool MORPHTARGETS_UV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "MORPHTARGETS_UV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MORPHTARGETS_UV",
                    value
                );
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "NUM_MORPH_INFLUENCERS",
                    value
                );
            }
        }

        
        public bool IMAGEPROCESSING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSING",
                    value
                );
            }
        }

        
        public bool VIGNETTE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTE",
                    value
                );
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY",
                    value
                );
            }
        }

        
        public bool VIGNETTEBLENDMODEOPAQUE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE",
                    value
                );
            }
        }

        
        public bool TONEMAPPING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING",
                    value
                );
            }
        }

        
        public bool TONEMAPPING_ACES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING_ACES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING_ACES",
                    value
                );
            }
        }

        
        public bool CONTRAST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CONTRAST"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTRAST",
                    value
                );
            }
        }

        
        public bool EXPOSURE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EXPOSURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EXPOSURE",
                    value
                );
            }
        }

        
        public bool COLORCURVES
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORCURVES"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORCURVES",
                    value
                );
            }
        }

        
        public bool COLORGRADING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING",
                    value
                );
            }
        }

        
        public bool COLORGRADING3D
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING3D"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING3D",
                    value
                );
            }
        }

        
        public bool SAMPLER3DGREENDEPTH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH",
                    value
                );
            }
        }

        
        public bool SAMPLER3DBGRMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DBGRMAP"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DBGRMAP",
                    value
                );
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS",
                    value
                );
            }
        }

        
        public decimal BUMPDIRECTUV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BUMPDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BUMPDIRECTUV",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeMaterialDefines() : base() { }

        public NodeMaterialDefines(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void setValue(string name, object value, System.Nullable<bool> markAsUnprocessedIfDirty = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" }, name, value, markAsUnprocessedIfDirty
                }
            );
        }
        #endregion
    }
}