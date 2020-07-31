/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    public interface IAudioEngine : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IAudioEngineCachedEntity>))]
    public class IAudioEngineCachedEntity : CachedEntityObject, IAudioEngine
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
        
        public bool canUseWebAudio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canUseWebAudio"
                );
            }
        }

        private AudioContext __audioContext;
        public AudioContext audioContext
        {
            get
            {
            if(__audioContext == null)
            {
                __audioContext = EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "audioContext",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __audioContext;
            }
        }

        private GainNode __masterGain;
        public GainNode masterGain
        {
            get
            {
            if(__masterGain == null)
            {
                __masterGain = EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "masterGain",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __masterGain;
            }
        }

        
        public bool isMP3supported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMP3supported"
                );
            }
        }

        
        public bool isOGGsupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOGGsupported"
                );
            }
        }

        
        public bool WarnedWebAudioUnsupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "WarnedWebAudioUnsupported"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "WarnedWebAudioUnsupported",
                    value
                );
            }
        }

        
        public bool useCustomUnlockedButton
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCustomUnlockedButton"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCustomUnlockedButton",
                    value
                );
            }
        }

        
        public bool unlocked
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "unlocked"
                );
            }
        }

        private Observable<AudioEngine> __onAudioUnlockedObservable;
        public Observable<AudioEngine> onAudioUnlockedObservable
        {
            get
            {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = EventHorizonBlazorInterop.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioUnlockedObservable;
            }
            set
            {
__onAudioUnlockedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    value
                );
            }
        }

        private Observable<AudioEngine> __onAudioLockedObservable;
        public Observable<AudioEngine> onAudioLockedObservable
        {
            get
            {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = EventHorizonBlazorInterop.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioLockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioLockedObservable;
            }
            set
            {
__onAudioLockedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioLockedObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IAudioEngineCachedEntity() : base() { }

        public IAudioEngineCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void @lock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@lock" }
                }
            );
        }

        public void @unlock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@unlock" }
                }
            );
        }
        #endregion
    }
}