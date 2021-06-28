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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FramingBehavior>))]
    public class FramingBehavior : CachedEntityObject, Behavior<ArcRotateCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static ExponentialEase __EasingFunction;
        public static ExponentialEase EasingFunction
        {
            get
            {
            if(__EasingFunction == null)
            {
                __EasingFunction = EventHorizonBlazorInterop.GetClass<ExponentialEase>(
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
            set
            {
__EasingFunction = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.EasingFunction",
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
                    "FramingBehavior.EasingMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.EasingMode",
                    value
                );
            }
        }

        
        public static decimal IgnoreBoundsSizeMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "FramingBehavior.IgnoreBoundsSizeMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.IgnoreBoundsSizeMode",
                    value
                );
            }
        }

        
        public static decimal FitFrustumSidesMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "FramingBehavior.FitFrustumSidesMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "FramingBehavior.FitFrustumSidesMode",
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

        
        public decimal mode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mode",
                    value
                );
            }
        }

        
        public decimal radiusScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusScale",
                    value
                );
            }
        }

        
        public decimal positionScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "positionScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positionScale",
                    value
                );
            }
        }

        
        public decimal defaultElevation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultElevation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultElevation",
                    value
                );
            }
        }

        
        public decimal elevationReturnTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elevationReturnTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elevationReturnTime",
                    value
                );
            }
        }

        
        public decimal elevationReturnWaitTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "elevationReturnWaitTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "elevationReturnWaitTime",
                    value
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

        
        public decimal framingTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framingTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framingTime",
                    value
                );
            }
        }

        
        public bool isUserIsMoving
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUserIsMoving"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool autoCorrectCameraLimitsAndSensibility
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoCorrectCameraLimitsAndSensibility"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoCorrectCameraLimitsAndSensibility",
                    value
                );
            }
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

        public void zoomOnMesh(AbstractMesh mesh, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "zoomOnMesh" }, mesh, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public void zoomOnMeshHierarchy(AbstractMesh mesh, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "zoomOnMeshHierarchy" }, mesh, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public void zoomOnMeshesHierarchy(AbstractMesh[] meshes, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "zoomOnMeshesHierarchy" }, meshes, focusOnOriginXZ, onAnimationEnd
                }
            );
        }

        public void zoomOnBoundingInfo(Vector3 minimumWorld, Vector3 maximumWorld, System.Nullable<bool> focusOnOriginXZ = null, ActionCallback onAnimationEnd = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "zoomOnBoundingInfo" }, minimumWorld, maximumWorld, focusOnOriginXZ, onAnimationEnd
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