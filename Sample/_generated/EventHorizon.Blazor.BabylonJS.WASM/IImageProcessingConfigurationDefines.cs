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

    public interface IImageProcessingConfigurationDefines : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IImageProcessingConfigurationDefinesCachedEntity>))]
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