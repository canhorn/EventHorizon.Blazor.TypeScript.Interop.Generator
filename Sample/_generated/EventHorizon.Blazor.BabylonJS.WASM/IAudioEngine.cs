/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IAudioEngine { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IAudioEngineCachedEntity : CachedEntityObject, IDisposable, IAudioEngine
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
            return EventHorizonBlazorInteropt.Get<bool>(
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
                __audioContext = EventHorizonBlazorInteropt.GetClass<AudioContext>(
                    this.___guid,
                    "audioContext",
                    (entity) =>
                    {
                        return new AudioContext(entity);
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
                __masterGain = EventHorizonBlazorInteropt.GetClass<GainNode>(
                    this.___guid,
                    "masterGain",
                    (entity) =>
                    {
                        return new GainNode(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isMP3supported"
                );
            }
        }

        
        public bool isOGGsupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isOGGsupported"
                );
            }
        }

        
        public bool WarnedWebAudioUnsupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "WarnedWebAudioUnsupported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useCustomUnlockedButton"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "unlocked"
                );
            }
        }

        private Observable __onAudioUnlockedObservable;
        public Observable onAudioUnlockedObservable
        {
            get
            {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAudioUnlockedObservable;
            }
            set
            {
__onAudioUnlockedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    value
                );
            }
        }

        private Observable __onAudioLockedObservable;
        public Observable onAudioLockedObservable
        {
            get
            {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAudioLockedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAudioLockedObservable;
            }
            set
            {
__onAudioLockedObservable = null;
                EventHorizonBlazorInteropt.Set(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@lock" }
                }
            );
        }

        public void @unlock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@unlock" }
                }
            );
        }
        #endregion
    }
}