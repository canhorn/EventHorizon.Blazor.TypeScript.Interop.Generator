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

        private Observable<IAudioEngineCachedEntity> __onAudioUnlockedObservable;
        public Observable<IAudioEngineCachedEntity> onAudioUnlockedObservable
        {
            get
            {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = EventHorizonBlazorInterop.GetClass<Observable<IAudioEngineCachedEntity>>(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    (entity) =>
                    {
                        return new Observable<IAudioEngineCachedEntity>() { ___guid = entity.___guid };
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

        private Observable<IAudioEngineCachedEntity> __onAudioLockedObservable;
        public Observable<IAudioEngineCachedEntity> onAudioLockedObservable
        {
            get
            {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = EventHorizonBlazorInterop.GetClass<Observable<IAudioEngineCachedEntity>>(
                    this.___guid,
                    "onAudioLockedObservable",
                    (entity) =>
                    {
                        return new Observable<IAudioEngineCachedEntity>() { ___guid = entity.___guid };
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

        public decimal getGlobalVolume()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getGlobalVolume" }
                }
            );
        }

        public void setGlobalVolume(decimal newVolume)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setGlobalVolume" }, newVolume
                }
            );
        }

        public void connectToAnalyser(Analyser analyser)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "connectToAnalyser" }, analyser
                }
            );
        }
        #endregion
    }
}