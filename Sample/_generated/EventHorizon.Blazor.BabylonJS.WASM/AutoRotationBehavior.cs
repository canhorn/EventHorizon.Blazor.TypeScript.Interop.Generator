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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
        }

        
        public bool zoomStopsAnimation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "zoomStopsAnimation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomStopsAnimation",
                    value
                );
            }
        }

        
        public decimal idleRotationSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationSpeed",
                    value
                );
            }
        }

        
        public decimal idleRotationWaitTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationWaitTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationWaitTime",
                    value
                );
            }
        }

        
        public decimal idleRotationSpinupTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "idleRotationSpinupTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "idleRotationSpinupTime",
                    value
                );
            }
        }

        
        public bool rotationInProgress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "rotationInProgress"
                );
            }
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
        public void init()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }
                }
            );
        }

        public void attach(ArcRotateCamera camera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attach" }, camera
                }
            );
        }

        public void detach()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }
        #endregion
    }
}