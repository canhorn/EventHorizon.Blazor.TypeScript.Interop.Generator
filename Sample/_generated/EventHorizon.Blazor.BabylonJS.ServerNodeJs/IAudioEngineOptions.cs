/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<AudioContext> get_audioContext()
        {
            if (__audioContext == null)
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

        public ValueTask set_audioContext(AudioContext value)
        {
            __audioContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "audioContext", value);
        }

        private AudioDestinationNode __audioDestination;

        public async ValueTask<AudioDestinationNode> get_audioDestination()
        {
            if (__audioDestination == null)
            {
                __audioDestination = await EventHorizonBlazorInterop.GetClass<AudioDestinationNode>(
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

        public ValueTask set_audioDestination(AudioDestinationNode value)
        {
            __audioDestination = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "audioDestination", value);
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
