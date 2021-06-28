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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BouncingBehavior>))]
    public class BouncingBehavior : CachedEntityObject, Behavior<ArcRotateCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static BackEase __EasingFunction;
        public static BackEase EasingFunction
        {
            get
            {
            if(__EasingFunction == null)
            {
                __EasingFunction = EventHorizonBlazorInterop.GetClass<BackEase>(
                    "BABYLON",
                    "BouncingBehavior.EasingFunction",
                    (entity) =>
                    {
                        return new BackEase() { ___guid = entity.___guid };
                    }
                );
            }
            return __EasingFunction;
            }
            set
            {
__EasingFunction = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BouncingBehavior.EasingFunction",
                    value
                );
            }
        }

        
        public static decimal EasingMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BouncingBehavior.EasingMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BouncingBehavior.EasingMode",
                    value
                );
            }
        }
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

        
        public bool autoTransitionRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoTransitionRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoTransitionRange",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal transitionDuration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transitionDuration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transitionDuration",
                    value
                );
            }
        }

        
        public decimal lowerRadiusTransitionRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusTransitionRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusTransitionRange",
                    value
                );
            }
        }

        
        public decimal upperRadiusTransitionRange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusTransitionRange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusTransitionRange",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public BouncingBehavior() : base() { }

        public BouncingBehavior(
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

        public void stopAllAnimations()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopAllAnimations" }
                }
            );
        }
        #endregion
    }
}