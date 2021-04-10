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
        
        public async ValueTask<bool> get_canUseWebAudio()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canUseWebAudio"
                );
        }

        private AudioContext __audioContext;
        public async ValueTask<AudioContext> get_audioContext()
        {
            if(__audioContext == null)
            {
                __audioContext = await EventHorizonBlazorInterop.GetClass<AudioContext>(
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

        private GainNode __masterGain;
        public async ValueTask<GainNode> get_masterGain()
        {
            if(__masterGain == null)
            {
                __masterGain = await EventHorizonBlazorInterop.GetClass<GainNode>(
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

        
        public async ValueTask<bool> get_isMP3supported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMP3supported"
                );
        }

        
        public async ValueTask<bool> get_isOGGsupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOGGsupported"
                );
        }

        
        public async ValueTask<bool> get_WarnedWebAudioUnsupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "WarnedWebAudioUnsupported"
                );
        }
        public ValueTask set_WarnedWebAudioUnsupported(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "WarnedWebAudioUnsupported",
                    value
                );
        }

        
        public async ValueTask<bool> get_useCustomUnlockedButton()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCustomUnlockedButton"
                );
        }
        public ValueTask set_useCustomUnlockedButton(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCustomUnlockedButton",
                    value
                );
        }

        
        public async ValueTask<bool> get_unlocked()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "unlocked"
                );
        }

        private Observable<IAudioEngineCachedEntity> __onAudioUnlockedObservable;
        public async ValueTask<Observable<IAudioEngineCachedEntity>> get_onAudioUnlockedObservable()
        {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = await EventHorizonBlazorInterop.GetClass<Observable<IAudioEngineCachedEntity>>(
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
        public ValueTask set_onAudioUnlockedObservable(Observable<IAudioEngineCachedEntity> value)
        {
__onAudioUnlockedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    value
                );
        }

        private Observable<IAudioEngineCachedEntity> __onAudioLockedObservable;
        public async ValueTask<Observable<IAudioEngineCachedEntity>> get_onAudioLockedObservable()
        {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = await EventHorizonBlazorInterop.GetClass<Observable<IAudioEngineCachedEntity>>(
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
        public ValueTask set_onAudioLockedObservable(Observable<IAudioEngineCachedEntity> value)
        {
__onAudioLockedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioLockedObservable",
                    value
                );
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
        public async ValueTask @lock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@lock" }
                }
            );
        }

        public async ValueTask @unlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@unlock" }
                }
            );
        }

        public async ValueTask<decimal> getGlobalVolume()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getGlobalVolume" }
                }
            );
        }

        public async ValueTask setGlobalVolume(decimal newVolume)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setGlobalVolume" }, newVolume
                }
            );
        }

        public async ValueTask connectToAnalyser(Analyser analyser)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectToAnalyser" }, analyser
                }
            );
        }
        #endregion
    }
}