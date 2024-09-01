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

        public bool disableWebGL2Support
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableWebGL2Support");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableWebGL2Support", value);
            }
        }

        public bool useHighPrecisionFloats
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useHighPrecisionFloats");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useHighPrecisionFloats", value);
            }
        }

        public bool xrCompatible
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "xrCompatible"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "xrCompatible", value);
            }
        }

        public bool failIfMajorPerformanceCaveat
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "failIfMajorPerformanceCaveat"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "failIfMajorPerformanceCaveat", value);
            }
        }

        public bool forceSRGBBufferSupportState
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceSRGBBufferSupportState"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "forceSRGBBufferSupportState", value);
            }
        }

        public bool loseContextOnDispose
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "loseContextOnDispose");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "loseContextOnDispose", value);
            }
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
