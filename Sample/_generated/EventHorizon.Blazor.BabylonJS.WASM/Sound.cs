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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Sound>))]
    public class Sound : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Sound Parse(object parsedSound, Scene scene, string rootUrl, Sound sourceSound = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Sound>(
                entity => new Sound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Sound", "Parse" }, parsedSound, scene, rootUrl, sourceSound
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal currentTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentTime"
                );
            }
        }

        
        public decimal directionalConeInnerAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "directionalConeInnerAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "directionalConeInnerAngle",
                    value
                );
            }
        }

        
        public decimal directionalConeOuterAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "directionalConeOuterAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "directionalConeOuterAngle",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public bool autoplay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoplay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoplay",
                    value
                );
            }
        }

        
        public bool loop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loop",
                    value
                );
            }
        }

        
        public bool useCustomAttenuation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCustomAttenuation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCustomAttenuation",
                    value
                );
            }
        }

        
        public decimal soundTrackId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "soundTrackId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "soundTrackId",
                    value
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPlaying",
                    value
                );
            }
        }

        
        public bool isPaused
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPaused"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPaused",
                    value
                );
            }
        }

        
        public bool spatialSound
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spatialSound"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spatialSound",
                    value
                );
            }
        }

        
        public decimal refDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refDistance",
                    value
                );
            }
        }

        
        public decimal rolloffFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rolloffFactor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rolloffFactor",
                    value
                );
            }
        }

        
        public decimal maxDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxDistance",
                    value
                );
            }
        }

        
        public string distanceModel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "distanceModel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distanceModel",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        private Observable<Sound> __onEndedObservable;
        public Observable<Sound> onEndedObservable
        {
            get
            {
            if(__onEndedObservable == null)
            {
                __onEndedObservable = EventHorizonBlazorInterop.GetClass<Observable<Sound>>(
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
            set
            {
__onEndedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onEndedObservable",
                    value
                );
            }
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

        public Sound(
            string name, object urlOrArrayBuffer, Scene scene, ActionCallback readyToPlayCallback = null, ISoundOptions options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Sound" },
                name, urlOrArrayBuffer, scene, readyToPlayCallback, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onended TODO: Get Comments as metadata identification
        private bool _isOnendedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onendedActionMap = new Dictionary<string, Func<Task>>();

        public string onended(
            Func<Task> callback
        )
        {
            SetupOnendedLoop();

            var handle = Guid.NewGuid().ToString();
            _onendedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onended_Remove(
            string handle
        )
        {
            return _onendedActionMap.Remove(
                handle
            );
        }

        private void SetupOnendedLoop()
        {
            if (_isOnendedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void setAudioBuffer(AudioBuffer audioBuffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAudioBuffer" }, audioBuffer
                }
            );
        }

        public void updateOptions(ISoundOptions options)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateOptions" }, options
                }
            );
        }

        public void switchPanningModelToHRTF()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "switchPanningModelToHRTF" }
                }
            );
        }

        public void switchPanningModelToEqualPower()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "switchPanningModelToEqualPower" }
                }
            );
        }

        public void connectToSoundTrackAudioNode(AudioNode soundTrackAudioNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "connectToSoundTrackAudioNode" }, soundTrackAudioNode
                }
            );
        }

        public void setDirectionalCone(decimal coneInnerAngle, decimal coneOuterAngle, decimal coneOuterGain)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDirectionalCone" }, coneInnerAngle, coneOuterAngle, coneOuterGain
                }
            );
        }

        public void setPosition(Vector3 newPosition)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, newPosition
                }
            );
        }

        public void setLocalDirectionToMesh(Vector3 newLocalDirection)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLocalDirectionToMesh" }, newLocalDirection
                }
            );
        }

        public void updateDistanceFromListener()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDistanceFromListener" }
                }
            );
        }

        #region setAttenuationFunction TODO: Get Comments as metadata identification
        private bool _isSetAttenuationFunctionEnabled = false;
        private readonly IDictionary<string, Func<decimal, decimal, decimal, decimal, decimal, Task>> _setAttenuationFunctionActionMap = new Dictionary<string, Func<decimal, decimal, decimal, decimal, decimal, Task>>();

        public string setAttenuationFunction(
            Func<decimal, decimal, decimal, decimal, decimal, Task> callback
        )
        {
            SetupSetAttenuationFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _setAttenuationFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool setAttenuationFunction_Remove(
            string handle
        )
        {
            return _setAttenuationFunctionActionMap.Remove(
                handle
            );
        }

        private void SetupSetAttenuationFunctionLoop()
        {
            if (_isSetAttenuationFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public void play(System.Nullable<decimal> time = null, System.Nullable<decimal> offset = null, System.Nullable<decimal> length = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "play" }, time, offset, length
                }
            );
        }

        public void stop(System.Nullable<decimal> time = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }, time
                }
            );
        }

        public void pause()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public void setVolume(decimal newVolume, System.Nullable<decimal> time = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVolume" }, newVolume, time
                }
            );
        }

        public void setPlaybackRate(decimal newPlaybackRate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPlaybackRate" }, newPlaybackRate
                }
            );
        }

        public decimal getVolume()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVolume" }
                }
            );
        }

        public void attachToMesh(TransformNode transformNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachToMesh" }, transformNode
                }
            );
        }

        public void detachFromMesh()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachFromMesh" }
                }
            );
        }

        public Sound clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Sound>(
                entity => new Sound() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public AudioBuffer getAudioBuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioBuffer>(
                entity => new AudioBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAudioBuffer" }
                }
            );
        }

        public AudioBufferSourceNode getSoundSource()
        {
            return EventHorizonBlazorInterop.FuncClass<AudioBufferSourceNode>(
                entity => new AudioBufferSourceNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSoundSource" }
                }
            );
        }

        public GainNode getSoundGain()
        {
            return EventHorizonBlazorInterop.FuncClass<GainNode>(
                entity => new GainNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSoundGain" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}