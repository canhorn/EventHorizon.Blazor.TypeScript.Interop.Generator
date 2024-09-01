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

        public decimal limitDeviceRatio
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "limitDeviceRatio"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "limitDeviceRatio", value);
            }
        }

        public bool audioEngine
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "audioEngine"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "audioEngine", value);
            }
        }

        private IAudioEngineOptionsCachedEntity __audioEngineOptions;
        public IAudioEngineOptionsCachedEntity audioEngineOptions
        {
            get
            {
                if (__audioEngineOptions == null)
                {
                    __audioEngineOptions =
                        EventHorizonBlazorInterop.GetClass<IAudioEngineOptionsCachedEntity>(
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
            set
            {
                __audioEngineOptions = null;
                EventHorizonBlazorInterop.Set(this.___guid, "audioEngineOptions", value);
            }
        }

        public bool deterministicLockstep
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "deterministicLockstep");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "deterministicLockstep", value);
            }
        }

        public decimal lockstepMaxSteps
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "lockstepMaxSteps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "lockstepMaxSteps", value);
            }
        }

        public decimal timeStep
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "timeStep"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "timeStep", value);
            }
        }

        public bool doNotHandleContextLost
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotHandleContextLost");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleContextLost", value);
            }
        }

        public bool doNotHandleTouchAction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotHandleTouchAction");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "doNotHandleTouchAction", value);
            }
        }

        public bool useHighPrecisionMatrix
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useHighPrecisionMatrix");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useHighPrecisionMatrix", value);
            }
        }

        public bool adaptToDeviceRatio
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptToDeviceRatio"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "adaptToDeviceRatio", value);
            }
        }

        public bool antialias
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "antialias"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "antialias", value);
            }
        }

        public bool stencil
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "stencil"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencil", value);
            }
        }

        public bool premultipliedAlpha
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "premultipliedAlpha"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "premultipliedAlpha", value);
            }
        }

        public bool useExactSrgbConversions
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useExactSrgbConversions");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useExactSrgbConversions", value);
            }
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
