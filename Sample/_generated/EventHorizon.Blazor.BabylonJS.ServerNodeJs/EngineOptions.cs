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

    public interface EngineOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<EngineOptionsCachedEntity>))]
    public class EngineOptionsCachedEntity : CachedEntityObject, EngineOptions
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

        public async ValueTask<bool> get_disableWebGL2Support()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableWebGL2Support");
        }

        public ValueTask set_disableWebGL2Support(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableWebGL2Support", value);
        }

        public async ValueTask<bool> get_useHighPrecisionFloats()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useHighPrecisionFloats"
            );
        }

        public ValueTask set_useHighPrecisionFloats(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useHighPrecisionFloats", value);
        }

        public async ValueTask<bool> get_xrCompatible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "xrCompatible");
        }

        public ValueTask set_xrCompatible(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "xrCompatible", value);
        }

        public async ValueTask<bool> get_failIfMajorPerformanceCaveat()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "failIfMajorPerformanceCaveat"
            );
        }

        public ValueTask set_failIfMajorPerformanceCaveat(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "failIfMajorPerformanceCaveat",
                value
            );
        }

        public async ValueTask<bool> get_forceSRGBBufferSupportState()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "forceSRGBBufferSupportState"
            );
        }

        public ValueTask set_forceSRGBBufferSupportState(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "forceSRGBBufferSupportState",
                value
            );
        }

        public async ValueTask<bool> get_loseContextOnDispose()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "loseContextOnDispose");
        }

        public ValueTask set_loseContextOnDispose(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "loseContextOnDispose", value);
        }
        #endregion

        #region Constructor
        public EngineOptionsCachedEntity()
            : base() { }

        public EngineOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
