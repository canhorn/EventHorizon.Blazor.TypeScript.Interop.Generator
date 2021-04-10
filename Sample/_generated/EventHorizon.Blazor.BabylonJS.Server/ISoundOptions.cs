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

    public interface ISoundOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISoundOptionsCachedEntity>))]
    public class ISoundOptionsCachedEntity : CachedEntityObject, ISoundOptions
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
        
        public async ValueTask<bool> get_autoplay()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoplay"
                );
        }
        public ValueTask set_autoplay(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoplay",
                    value
                );
        }

        
        public async ValueTask<bool> get_loop()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
        }
        public ValueTask set_loop(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
        }

        
        public async ValueTask<decimal> get_volume()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "volume"
                );
        }
        public ValueTask set_volume(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "volume",
                    value
                );
        }

        
        public async ValueTask<bool> get_spatialSound()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spatialSound"
                );
        }
        public ValueTask set_spatialSound(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spatialSound",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxDistance"
                );
        }
        public ValueTask set_maxDistance(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxDistance",
                    value
                );
        }

        
        public async ValueTask<bool> get_useCustomAttenuation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCustomAttenuation"
                );
        }
        public ValueTask set_useCustomAttenuation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCustomAttenuation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_rolloffFactor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rolloffFactor"
                );
        }
        public ValueTask set_rolloffFactor(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rolloffFactor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_refDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refDistance"
                );
        }
        public ValueTask set_refDistance(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refDistance",
                    value
                );
        }

        
        public async ValueTask<string> get_distanceModel()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "distanceModel"
                );
        }
        public ValueTask set_distanceModel(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distanceModel",
                    value
                );
        }

        
        public async ValueTask<decimal> get_playbackRate()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "playbackRate"
                );
        }
        public ValueTask set_playbackRate(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "playbackRate",
                    value
                );
        }

        
        public async ValueTask<bool> get_streaming()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "streaming"
                );
        }
        public ValueTask set_streaming(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "streaming",
                    value
                );
        }

        
        public async ValueTask<decimal> get_length()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
        }
        public ValueTask set_length(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
        }

        
        public async ValueTask<decimal> get_offset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
        }
        public ValueTask set_offset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
        }

        
        public async ValueTask<bool> get_skipCodecCheck()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipCodecCheck"
                );
        }
        public ValueTask set_skipCodecCheck(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipCodecCheck",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ISoundOptionsCachedEntity() : base() { }

        public ISoundOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}