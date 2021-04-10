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
        
        public async ValueTask<decimal> get_limitDeviceRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "limitDeviceRatio"
                );
        }
        public ValueTask set_limitDeviceRatio(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "limitDeviceRatio",
                    value
                );
        }

        
        public async ValueTask<bool> get_autoEnableWebVR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoEnableWebVR"
                );
        }
        public ValueTask set_autoEnableWebVR(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoEnableWebVR",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableWebGL2Support()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableWebGL2Support"
                );
        }
        public ValueTask set_disableWebGL2Support(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableWebGL2Support",
                    value
                );
        }

        
        public async ValueTask<bool> get_audioEngine()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "audioEngine"
                );
        }
        public ValueTask set_audioEngine(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "audioEngine",
                    value
                );
        }

        
        public async ValueTask<bool> get_deterministicLockstep()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "deterministicLockstep"
                );
        }
        public ValueTask set_deterministicLockstep(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "deterministicLockstep",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lockstepMaxSteps()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lockstepMaxSteps"
                );
        }
        public ValueTask set_lockstepMaxSteps(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockstepMaxSteps",
                    value
                );
        }

        
        public async ValueTask<decimal> get_timeStep()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "timeStep"
                );
        }
        public ValueTask set_timeStep(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "timeStep",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleContextLost",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleTouchAction",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useHighPrecisionFloats",
                    value
                );
        }

        
        public async ValueTask<bool> get_xrCompatible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "xrCompatible"
                );
        }
        public ValueTask set_xrCompatible(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xrCompatible",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useHighPrecisionMatrix",
                    value
                );
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