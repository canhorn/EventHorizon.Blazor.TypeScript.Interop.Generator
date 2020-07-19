/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface EngineOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "limitDeviceRatio"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoEnableWebVR"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableWebGL2Support"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "audioEngine"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "deterministicLockstep"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "lockstepMaxSteps"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "timeStep"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotHandleContextLost"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotHandleTouchAction"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useHighPrecisionFloats"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useHighPrecisionFloats",
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