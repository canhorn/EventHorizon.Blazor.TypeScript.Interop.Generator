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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AutoRotationBehavior>))]
    public class AutoRotationBehavior : CachedEntityObject, Behavior<ArcRotateCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }

        
        public async ValueTask<bool> get_zoomStopsAnimation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "zoomStopsAnimation"
                );
        }
        public ValueTask set_zoomStopsAnimation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomStopsAnimation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_idleRotationSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationSpeed"
                );
        }
        public ValueTask set_idleRotationSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_idleRotationWaitTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationWaitTime"
                );
        }
        public ValueTask set_idleRotationWaitTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationWaitTime",
                    value
                );
        }

        
        public async ValueTask<decimal> get_idleRotationSpinupTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationSpinupTime"
                );
        }
        public ValueTask set_idleRotationSpinupTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationSpinupTime",
                    value
                );
        }

        
        public async ValueTask<bool> get_rotationInProgress()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotationInProgress"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public AutoRotationBehavior() : base() { }

        public AutoRotationBehavior(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask init()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public async ValueTask attach(ArcRotateCamera camera)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attach" }, camera
                }
            );
        }

        public async ValueTask detach()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }
        #endregion
    }
}