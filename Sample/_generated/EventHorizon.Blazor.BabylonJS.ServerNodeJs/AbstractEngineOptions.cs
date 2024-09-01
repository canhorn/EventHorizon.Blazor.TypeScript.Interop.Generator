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

    public interface AbstractEngineOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<AbstractEngineOptionsCachedEntity>))]
    public class AbstractEngineOptionsCachedEntity : CachedEntityObject, AbstractEngineOptions
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

        public async ValueTask<decimal> get_limitDeviceRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "limitDeviceRatio");
        }

        public ValueTask set_limitDeviceRatio(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "limitDeviceRatio", value);
        }

        public async ValueTask<bool> get_audioEngine()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "audioEngine");
        }

        public ValueTask set_audioEngine(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "audioEngine", value);
        }

        private IAudioEngineOptionsCachedEntity __audioEngineOptions;

        public async ValueTask<IAudioEngineOptionsCachedEntity> get_audioEngineOptions()
        {
            if (__audioEngineOptions == null)
            {
                __audioEngineOptions =
                    await EventHorizonBlazorInterop.GetClass<IAudioEngineOptionsCachedEntity>(
                        this.___guid,
                        "audioEngineOptions",
                        (entity) =>
                        {
                            return new IAudioEngineOptionsCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __audioEngineOptions;
        }

        public ValueTask set_audioEngineOptions(IAudioEngineOptionsCachedEntity value)
        {
            __audioEngineOptions = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "audioEngineOptions", value);
        }

        public async ValueTask<bool> get_deterministicLockstep()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "deterministicLockstep");
        }

        public ValueTask set_deterministicLockstep(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "deterministicLockstep", value);
        }

        public async ValueTask<decimal> get_lockstepMaxSteps()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "lockstepMaxSteps");
        }

        public ValueTask set_lockstepMaxSteps(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "lockstepMaxSteps", value);
        }

        public async ValueTask<decimal> get_timeStep()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "timeStep");
        }

        public ValueTask set_timeStep(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "timeStep", value);
        }

        public async ValueTask<bool> get_doNotHandleContextLost()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "doNotHandleContextLost"
            );
        }

        public ValueTask set_doNotHandleContextLost(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleContextLost", value);
        }

        public async ValueTask<bool> get_doNotHandleTouchAction()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "doNotHandleTouchAction"
            );
        }

        public ValueTask set_doNotHandleTouchAction(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleTouchAction", value);
        }

        public async ValueTask<bool> get_useHighPrecisionMatrix()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useHighPrecisionMatrix"
            );
        }

        public ValueTask set_useHighPrecisionMatrix(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useHighPrecisionMatrix", value);
        }

        public async ValueTask<bool> get_adaptToDeviceRatio()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptToDeviceRatio");
        }

        public ValueTask set_adaptToDeviceRatio(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "adaptToDeviceRatio", value);
        }

        public async ValueTask<bool> get_antialias()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "antialias");
        }

        public ValueTask set_antialias(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "antialias", value);
        }

        public async ValueTask<bool> get_stencil()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "stencil");
        }

        public ValueTask set_stencil(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencil", value);
        }

        public async ValueTask<bool> get_premultipliedAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "premultipliedAlpha");
        }

        public ValueTask set_premultipliedAlpha(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "premultipliedAlpha", value);
        }

        public async ValueTask<bool> get_useExactSrgbConversions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useExactSrgbConversions"
            );
        }

        public ValueTask set_useExactSrgbConversions(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useExactSrgbConversions", value);
        }
        #endregion

        #region Constructor
        public AbstractEngineOptionsCachedEntity()
            : base() { }

        public AbstractEngineOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
