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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BouncingBehavior>))]
    public class BouncingBehavior : CachedEntityObject, Behavior<ArcRotateCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static BackEase __EasingFunction;
        public static async ValueTask<BackEase> get_EasingFunction()
        {
            if(__EasingFunction == null)
            {
                __EasingFunction = await EventHorizonBlazorInterop.GetClass<BackEase>(
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
        public static ValueTask set_EasingFunction(BackEase value)
        {
__EasingFunction = null;
                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BouncingBehavior.EasingFunction",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_EasingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BouncingBehavior.EasingMode"
                );
        }
        public static ValueTask set_EasingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BouncingBehavior.EasingMode",
                    value
                );
        }
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

        
        public async ValueTask<bool> get_autoTransitionRange()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoTransitionRange"
                );
        }
        public ValueTask set_autoTransitionRange(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoTransitionRange",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_transitionDuration()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transitionDuration"
                );
        }
        public ValueTask set_transitionDuration(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transitionDuration",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerRadiusTransitionRange()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusTransitionRange"
                );
        }
        public ValueTask set_lowerRadiusTransitionRange(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusTransitionRange",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperRadiusTransitionRange()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusTransitionRange"
                );
        }
        public ValueTask set_upperRadiusTransitionRange(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusTransitionRange",
                    value
                );
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

        public async ValueTask stopAllAnimations()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopAllAnimations" }
                }
            );
        }
        #endregion
    }
}