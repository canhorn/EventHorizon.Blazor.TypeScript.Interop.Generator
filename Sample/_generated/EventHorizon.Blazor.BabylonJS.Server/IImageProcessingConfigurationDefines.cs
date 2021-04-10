/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        
        public async ValueTask<bool> get_IMAGEPROCESSING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSING"
                );
        }
        public ValueTask set_IMAGEPROCESSING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSING",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTE"
                );
        }
        public ValueTask set_VIGNETTE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTE",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTEBLENDMODEMULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY"
                );
        }
        public ValueTask set_VIGNETTEBLENDMODEMULTIPLY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEMULTIPLY",
                    value
                );
        }

        
        public async ValueTask<bool> get_VIGNETTEBLENDMODEOPAQUE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE"
                );
        }
        public ValueTask set_VIGNETTEBLENDMODEOPAQUE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VIGNETTEBLENDMODEOPAQUE",
                    value
                );
        }

        
        public async ValueTask<bool> get_TONEMAPPING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING"
                );
        }
        public ValueTask set_TONEMAPPING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING",
                    value
                );
        }

        
        public async ValueTask<bool> get_TONEMAPPING_ACES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "TONEMAPPING_ACES"
                );
        }
        public ValueTask set_TONEMAPPING_ACES(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TONEMAPPING_ACES",
                    value
                );
        }

        
        public async ValueTask<bool> get_CONTRAST()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "CONTRAST"
                );
        }
        public ValueTask set_CONTRAST(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CONTRAST",
                    value
                );
        }

        
        public async ValueTask<bool> get_EXPOSURE()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "EXPOSURE"
                );
        }
        public ValueTask set_EXPOSURE(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "EXPOSURE",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORCURVES()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORCURVES"
                );
        }
        public ValueTask set_COLORCURVES(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORCURVES",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORGRADING()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING"
                );
        }
        public ValueTask set_COLORGRADING(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING",
                    value
                );
        }

        
        public async ValueTask<bool> get_COLORGRADING3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "COLORGRADING3D"
                );
        }
        public ValueTask set_COLORGRADING3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "COLORGRADING3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_SAMPLER3DGREENDEPTH()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH"
                );
        }
        public ValueTask set_SAMPLER3DGREENDEPTH(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DGREENDEPTH",
                    value
                );
        }

        
        public async ValueTask<bool> get_SAMPLER3DBGRMAP()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SAMPLER3DBGRMAP"
                );
        }
        public ValueTask set_SAMPLER3DBGRMAP(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SAMPLER3DBGRMAP",
                    value
                );
        }

        
        public async ValueTask<bool> get_IMAGEPROCESSINGPOSTPROCESS()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS"
                );
        }
        public ValueTask set_IMAGEPROCESSINGPOSTPROCESS(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "IMAGEPROCESSINGPOSTPROCESS",
                    value
                );
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