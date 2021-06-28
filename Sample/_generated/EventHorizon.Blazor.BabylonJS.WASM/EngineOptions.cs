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
        
        public decimal limitDeviceRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "limitDeviceRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "limitDeviceRatio",
                    value
                );
            }
        }

        
        public bool autoEnableWebVR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoEnableWebVR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoEnableWebVR",
                    value
                );
            }
        }

        
        public bool disableWebGL2Support
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableWebGL2Support"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableWebGL2Support",
                    value
                );
            }
        }

        
        public bool audioEngine
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "audioEngine"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audioEngine",
                    value
                );
            }
        }

        
        public bool deterministicLockstep
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "deterministicLockstep"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deterministicLockstep",
                    value
                );
            }
        }

        
        public decimal lockstepMaxSteps
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lockstepMaxSteps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockstepMaxSteps",
                    value
                );
            }
        }

        
        public decimal timeStep
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeStep"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeStep",
                    value
                );
            }
        }

        
        public bool doNotHandleContextLost
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotHandleContextLost"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleContextLost",
                    value
                );
            }
        }

        
        public bool doNotHandleTouchAction
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotHandleTouchAction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleTouchAction",
                    value
                );
            }
        }

        
        public bool useHighPrecisionFloats
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useHighPrecisionFloats"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useHighPrecisionFloats",
                    value
                );
            }
        }

        
        public bool xrCompatible
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "xrCompatible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xrCompatible",
                    value
                );
            }
        }

        
        public bool useHighPrecisionMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useHighPrecisionMatrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useHighPrecisionMatrix",
                    value
                );
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "failIfMajorPerformanceCaveat",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EngineOptionsCachedEntity() : base() { }

        public EngineOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}