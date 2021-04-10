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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FramingBehavior>))]
    public class FramingBehavior : CachedEntityObject, Behavior<ArcRotateCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static ExponentialEase __EasingFunction;
        public static async ValueTask<ExponentialEase> get_EasingFunction()
        {
            if(__EasingFunction == null)
            {
                __EasingFunction = await EventHorizonBlazorInterop.GetClass<ExponentialEase>(
                    "BABYLON",
                    "FramingBehavior.EasingFunction",
                    (entity) =>
                    {
                        return new ExponentialEase() { ___guid = entity.___guid };
                    }
                );
            }
            return __EasingFunction;
        }
        public static ValueTask set_EasingFunction(ExponentialEase value)
        {
__EasingFunction = null;
                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.EasingFunction",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_EasingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "FramingBehavior.EasingMode"
                );
        }
        public static ValueTask set_EasingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.EasingMode",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_IgnoreBoundsSizeMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "FramingBehavior.IgnoreBoundsSizeMode"
                );
        }
        public static ValueTask set_IgnoreBoundsSizeMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.IgnoreBoundsSizeMode",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_FitFrustumSidesMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "FramingBehavior.FitFrustumSidesMode"
                );
        }
        public static ValueTask set_FitFrustumSidesMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.FitFrustumSidesMode",
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

        
        public async ValueTask<decimal> get_mode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mode"
                );
        }
        public ValueTask set_mode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radiusScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusScale"
                );
        }
        public ValueTask set_radiusScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_positionScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "positionScale"
                );
        }
        public ValueTask set_positionScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positionScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_defaultElevation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultElevation"
                );
        }
        public ValueTask set_defaultElevation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultElevation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_elevationReturnTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elevationReturnTime"
                );
        }
        public ValueTask set_elevationReturnTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elevationReturnTime",
                    value
                );
        }

        
        public async ValueTask<decimal> get_elevationReturnWaitTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elevationReturnWaitTime"
                );
        }
        public ValueTask set_elevationReturnWaitTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elevationReturnWaitTime",
                    value
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

        
        public async ValueTask<decimal> get_framingTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framingTime"
                );
        }
        public ValueTask set_framingTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framingTime",
                    value
                );
        }

        
        public async ValueTask<bool> get_isUserIsMoving()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUserIsMoving"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_autoCorrectCameraLimitsAndSensibility()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoCorrectCameraLimitsAndSensibility"
                );
        }
        public ValueTask set_autoCorrectCameraLimitsAndSensibility(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoCorrectCameraLimitsAndSensibility",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public FramingBehavior() : base() { }

        public FramingBehavior(
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

        public async ValueTask zoomOnMesh(AbstractMesh mesh, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "zoomOnMesh" }, mesh, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public async ValueTask zoomOnMeshHierarchy(AbstractMesh mesh, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "zoomOnMeshHierarchy" }, mesh, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public async ValueTask zoomOnMeshesHierarchy(AbstractMesh[] meshes, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "zoomOnMeshesHierarchy" }, meshes, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public async ValueTask zoomOnBoundingInfo(Vector3 minimumWorld, Vector3 maximumWorld, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "zoomOnBoundingInfo" }, minimumWorld, maximumWorld, focusOnOriginXZ, onAnimationEnd
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