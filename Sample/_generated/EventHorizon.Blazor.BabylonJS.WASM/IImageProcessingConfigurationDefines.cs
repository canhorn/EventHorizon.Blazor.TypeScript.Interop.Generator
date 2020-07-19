/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IImageProcessingConfigurationDefines : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IImageProcessingConfigurationDefinesCachedEntity : CachedEntityObject, IImageProcessingConfigurationDefines
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
        
        public bool IMAGEPROCESSING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSING"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "VIGNETTE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "TONEMAPPING"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "TONEMAPPING_ACES"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "CONTRAST"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "EXPOSURE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "COLORCURVES"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "COLORGRADING"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "COLORGRADING3D"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "SAMPLER3DBGRMAP"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IImageProcessingConfigurationDefinesCachedEntity() : base() { }

        public IImageProcessingConfigurationDefinesCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}