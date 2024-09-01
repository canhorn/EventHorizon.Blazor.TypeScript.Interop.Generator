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

    public interface IAudioEngineOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IAudioEngineOptionsCachedEntity>))]
    public class IAudioEngineOptionsCachedEntity : CachedEntityObject, IAudioEngineOptions
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
        private AudioContext __audioContext;
        public AudioContext audioContext
        {
            get
            {
                if (__audioContext == null)
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
            set
            {
                __audioContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "audioContext", value);
            }
        }

        private AudioDestinationNode __audioDestination;
        public AudioDestinationNode audioDestination
        {
            get
            {
                if (__audioDestination == null)
                {
                    __audioDestination = EventHorizonBlazorInterop.GetClass<AudioDestinationNode>(
                        this.___guid,
                        "audioDestination",
                        (entity) =>
                        {
                            return new AudioDestinationNode() { ___guid = entity.___guid };
                        }
                    );
                }
                return __audioDestination;
            }
            set
            {
                __audioDestination = null;
                EventHorizonBlazorInterop.Set(this.___guid, "audioDestination", value);
            }
        }
        #endregion

        #region Constructor
        public IAudioEngineOptionsCachedEntity()
            : base() { }

        public IAudioEngineOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
