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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Sound>))]
    public class Sound : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Sound> Parse(object parsedSound, Scene scene, string rootUrl, Sound sourceSound = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Sound>(
                entity => new Sound() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Sound", "Parse" }, parsedSound, scene, rootUrl, sourceSound
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_currentTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentTime"
                );
        }

        
        public async ValueTask<decimal> get_directionalConeInnerAngle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "directionalConeInnerAngle"
                );
        }
        public ValueTask set_directionalConeInnerAngle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "directionalConeInnerAngle",
                    value
                );
        }

        
        public async ValueTask<decimal> get_directionalConeOuterAngle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "directionalConeOuterAngle"
                );
        }
        public ValueTask set_directionalConeOuterAngle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "directionalConeOuterAngle",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
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

        
        public async ValueTask<decimal> get_soundTrackId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "soundTrackId"
                );
        }
        public ValueTask set_soundTrackId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "soundTrackId",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPlaying()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
                );
        }
        public ValueTask set_isPlaying(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPlaying",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPaused()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPaused"
                );
        }
        public ValueTask set_isPaused(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPaused",
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

        
        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_metadata(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
        }

        private Observable<Sound> __onEndedObservable;
        public async ValueTask<Observable<Sound>> get_onEndedObservable()
        {
            if(__onEndedObservable == null)
            {
                __onEndedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Sound>>(
                    this.___guid,
                    "onEndedObservable",
                    (entity) =>
                    {
                        return new Observable<Sound>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEndedObservable;
        }
        public ValueTask set_onEndedObservable(Observable<Sound> value)
        {
__onEndedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onEndedObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Sound() : base() { } 

        public Sound(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Sound> NewSound(
            string name, object urlOrArrayBuffer, Scene scene, ActionCallback readyToPlayCallback = null, ISoundOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Sound" },
                name, urlOrArrayBuffer, scene, readyToPlayCallback, options
            );

            return new Sound(entity);
        }
        #endregion

        #region Methods
        #region onended TODO: Get Comments as metadata identification
        private bool _isOnendedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onendedActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onended(
            Func<Task> callback
        )
        {
            await SetupOnendedLoop();

            var handle = Guid.NewGuid().ToString();
            _onendedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnendedLoop()
        {
            if (_isOnendedEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onended",
                "CallOnendedActions",
                _invokableReference
            );
            _isOnendedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnendedActions()
        {
            foreach (var action in _onendedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask setAudioBuffer(AudioBuffer audioBuffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAudioBuffer" }, audioBuffer
                }
            );
        }

        public async ValueTask updateOptions(ISoundOptions options)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateOptions" }, options
                }
            );
        }

        public async ValueTask switchPanningModelToHRTF()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchPanningModelToHRTF" }
                }
            );
        }

        public async ValueTask switchPanningModelToEqualPower()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchPanningModelToEqualPower" }
                }
            );
        }

        public async ValueTask connectToSoundTrackAudioNode(AudioNode soundTrackAudioNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectToSoundTrackAudioNode" }, soundTrackAudioNode
                }
            );
        }

        public async ValueTask setDirectionalCone(decimal coneInnerAngle, decimal coneOuterAngle, decimal coneOuterGain)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDirectionalCone" }, coneInnerAngle, coneOuterAngle, coneOuterGain
                }
            );
        }

        public async ValueTask setPosition(Vector3 newPosition)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPosition" }, newPosition
                }
            );
        }

        public async ValueTask setLocalDirectionToMesh(Vector3 newLocalDirection)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setLocalDirectionToMesh" }, newLocalDirection
                }
            );
        }

        public async ValueTask updateDistanceFromListener()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDistanceFromListener" }
                }
            );
        }

        #region setAttenuationFunction TODO: Get Comments as metadata identification
        private bool _isSetAttenuationFunctionEnabled = false;
        private readonly IDictionary<string, Func<decimal, decimal, decimal, decimal, decimal, Task>> _setAttenuationFunctionActionMap = new Dictionary<string, Func<decimal, decimal, decimal, decimal, decimal, Task>>();

        public async ValueTask<string> setAttenuationFunction(
            Func<decimal, decimal, decimal, decimal, decimal, Task> callback
        )
        {
            await SetupSetAttenuationFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _setAttenuationFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupSetAttenuationFunctionLoop()
        {
            if (_isSetAttenuationFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "setAttenuationFunction",
                "CallSetAttenuationFunctionActions",
                _invokableReference
            );
            _isSetAttenuationFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallSetAttenuationFunctionActions(decimal currentVolume, decimal currentDistance, decimal maxDistance, decimal refDistance, decimal rolloffFactor)
        {
            foreach (var action in _setAttenuationFunctionActionMap.Values)
            {
                await action(currentVolume, currentDistance, maxDistance, refDistance, rolloffFactor);
            }
        }
        #endregion

        public async ValueTask play(System.Nullable<decimal> time = null, System.Nullable<decimal> offset = null, System.Nullable<decimal> length = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "play" }, time, offset, length
                }
            );
        }

        public async ValueTask stop(System.Nullable<decimal> time = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }, time
                }
            );
        }

        public async ValueTask pause()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public async ValueTask setVolume(decimal newVolume, System.Nullable<decimal> time = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVolume" }, newVolume, time
                }
            );
        }

        public async ValueTask setPlaybackRate(decimal newPlaybackRate)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPlaybackRate" }, newPlaybackRate
                }
            );
        }

        public async ValueTask<decimal> getVolume()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getVolume" }
                }
            );
        }

        public async ValueTask attachToMesh(TransformNode transformNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachToMesh" }, transformNode
                }
            );
        }

        public async ValueTask detachFromMesh()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachFromMesh" }
                }
            );
        }

        public async ValueTask<Sound> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Sound>(
                entity => new Sound() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<AudioBuffer> getAudioBuffer()
        {
            return await EventHorizonBlazorInterop.FuncClass<AudioBuffer>(
                entity => new AudioBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAudioBuffer" }
                }
            );
        }

        public async ValueTask<AudioBufferSourceNode> getSoundSource()
        {
            return await EventHorizonBlazorInterop.FuncClass<AudioBufferSourceNode>(
                entity => new AudioBufferSourceNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSoundSource" }
                }
            );
        }

        public async ValueTask<GainNode> getSoundGain()
        {
            return await EventHorizonBlazorInterop.FuncClass<GainNode>(
                entity => new GainNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSoundGain" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}