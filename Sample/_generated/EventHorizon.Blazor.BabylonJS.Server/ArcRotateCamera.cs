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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ArcRotateCamera>))]
    public class ArcRotateCamera : TargetCamera
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Vector3 __target;
        public async ValueTask<Vector3> get_target()
        {
            if(__target == null)
            {
                __target = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
        }
        public ValueTask set_target(Vector3 value)
        {
__target = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }

        private Vector3 __position;
        public async ValueTask<Vector3> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }
        public ValueTask set_position(Vector3 value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
        }

        private Vector3 __upVector;
        public async ValueTask<Vector3> get_upVector()
        {
            if(__upVector == null)
            {
                __upVector = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "upVector",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __upVector;
        }
        public ValueTask set_upVector(Vector3 value)
        {
__upVector = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upVector",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angularSensibilityX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibilityX"
                );
        }
        public ValueTask set_angularSensibilityX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibilityX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angularSensibilityY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibilityY"
                );
        }
        public ValueTask set_angularSensibilityY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibilityY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pinchPrecision()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchPrecision"
                );
        }
        public ValueTask set_pinchPrecision(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchPrecision",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pinchDeltaPercentage()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchDeltaPercentage"
                );
        }
        public ValueTask set_pinchDeltaPercentage(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchDeltaPercentage",
                    value
                );
        }

        
        public async ValueTask<bool> get_useNaturalPinchZoom()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useNaturalPinchZoom"
                );
        }
        public ValueTask set_useNaturalPinchZoom(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useNaturalPinchZoom",
                    value
                );
        }

        
        public async ValueTask<decimal> get_panningSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningSensibility"
                );
        }
        public ValueTask set_panningSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningSensibility",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_keysUp()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysUp"
                );
        }
        public ValueTask set_keysUp(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysUp",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_keysDown()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysDown"
                );
        }
        public ValueTask set_keysDown(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysDown",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_keysLeft()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysLeft"
                );
        }
        public ValueTask set_keysLeft(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysLeft",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_keysRight()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysRight"
                );
        }
        public ValueTask set_keysRight(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysRight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wheelPrecision()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wheelPrecision"
                );
        }
        public ValueTask set_wheelPrecision(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wheelPrecision",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wheelDeltaPercentage()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wheelDeltaPercentage"
                );
        }
        public ValueTask set_wheelDeltaPercentage(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wheelDeltaPercentage",
                    value
                );
        }

        private BouncingBehavior __bouncingBehavior;
        public async ValueTask<BouncingBehavior> get_bouncingBehavior()
        {
            if(__bouncingBehavior == null)
            {
                __bouncingBehavior = await EventHorizonBlazorInterop.GetClass<BouncingBehavior>(
                    this.___guid,
                    "bouncingBehavior",
                    (entity) =>
                    {
                        return new BouncingBehavior() { ___guid = entity.___guid };
                    }
                );
            }
            return __bouncingBehavior;
        }

        
        public async ValueTask<bool> get_useBouncingBehavior()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBouncingBehavior"
                );
        }
        public ValueTask set_useBouncingBehavior(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBouncingBehavior",
                    value
                );
        }

        private FramingBehavior __framingBehavior;
        public async ValueTask<FramingBehavior> get_framingBehavior()
        {
            if(__framingBehavior == null)
            {
                __framingBehavior = await EventHorizonBlazorInterop.GetClass<FramingBehavior>(
                    this.___guid,
                    "framingBehavior",
                    (entity) =>
                    {
                        return new FramingBehavior() { ___guid = entity.___guid };
                    }
                );
            }
            return __framingBehavior;
        }

        
        public async ValueTask<bool> get_useFramingBehavior()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useFramingBehavior"
                );
        }
        public ValueTask set_useFramingBehavior(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useFramingBehavior",
                    value
                );
        }

        private AutoRotationBehavior __autoRotationBehavior;
        public async ValueTask<AutoRotationBehavior> get_autoRotationBehavior()
        {
            if(__autoRotationBehavior == null)
            {
                __autoRotationBehavior = await EventHorizonBlazorInterop.GetClass<AutoRotationBehavior>(
                    this.___guid,
                    "autoRotationBehavior",
                    (entity) =>
                    {
                        return new AutoRotationBehavior() { ___guid = entity.___guid };
                    }
                );
            }
            return __autoRotationBehavior;
        }

        
        public async ValueTask<bool> get_useAutoRotationBehavior()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAutoRotationBehavior"
                );
        }
        public ValueTask set_useAutoRotationBehavior(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAutoRotationBehavior",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_alpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
        }
        public ValueTask set_alpha(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
        }

        
        public async ValueTask<decimal> get_beta()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beta"
                );
        }
        public ValueTask set_beta(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beta",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
        }
        public ValueTask set_radius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertialAlphaOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialAlphaOffset"
                );
        }
        public ValueTask set_inertialAlphaOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialAlphaOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertialBetaOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialBetaOffset"
                );
        }
        public ValueTask set_inertialBetaOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialBetaOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertialRadiusOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialRadiusOffset"
                );
        }
        public ValueTask set_inertialRadiusOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialRadiusOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerAlphaLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerAlphaLimit"
                );
        }
        public ValueTask set_lowerAlphaLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerAlphaLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperAlphaLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperAlphaLimit"
                );
        }
        public ValueTask set_upperAlphaLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperAlphaLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerBetaLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerBetaLimit"
                );
        }
        public ValueTask set_lowerBetaLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerBetaLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperBetaLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperBetaLimit"
                );
        }
        public ValueTask set_upperBetaLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperBetaLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerRadiusLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusLimit"
                );
        }
        public ValueTask set_lowerRadiusLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperRadiusLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusLimit"
                );
        }
        public ValueTask set_upperRadiusLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertialPanningX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialPanningX"
                );
        }
        public ValueTask set_inertialPanningX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialPanningX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertialPanningY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialPanningY"
                );
        }
        public ValueTask set_inertialPanningY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialPanningY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pinchToPanMaxDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchToPanMaxDistance"
                );
        }
        public ValueTask set_pinchToPanMaxDistance(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchToPanMaxDistance",
                    value
                );
        }

        
        public async ValueTask<decimal> get_panningDistanceLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningDistanceLimit"
                );
        }
        public ValueTask set_panningDistanceLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningDistanceLimit",
                    value
                );
        }

        private Vector3 __panningOriginTarget;
        public async ValueTask<Vector3> get_panningOriginTarget()
        {
            if(__panningOriginTarget == null)
            {
                __panningOriginTarget = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "panningOriginTarget",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __panningOriginTarget;
        }
        public ValueTask set_panningOriginTarget(Vector3 value)
        {
__panningOriginTarget = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningOriginTarget",
                    value
                );
        }

        
        public async ValueTask<decimal> get_panningInertia()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningInertia"
                );
        }
        public ValueTask set_panningInertia(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningInertia",
                    value
                );
        }

        
        public async ValueTask<decimal> get_zoomOnFactor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoomOnFactor"
                );
        }
        public ValueTask set_zoomOnFactor(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomOnFactor",
                    value
                );
        }

        private Vector2 __targetScreenOffset;
        public async ValueTask<Vector2> get_targetScreenOffset()
        {
            if(__targetScreenOffset == null)
            {
                __targetScreenOffset = await EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "targetScreenOffset",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __targetScreenOffset;
        }
        public ValueTask set_targetScreenOffset(Vector2 value)
        {
__targetScreenOffset = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetScreenOffset",
                    value
                );
        }

        
        public async ValueTask<bool> get_allowUpsideDown()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowUpsideDown"
                );
        }
        public ValueTask set_allowUpsideDown(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowUpsideDown",
                    value
                );
        }

        
        public async ValueTask<bool> get_useInputToRestoreState()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useInputToRestoreState"
                );
        }
        public ValueTask set_useInputToRestoreState(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useInputToRestoreState",
                    value
                );
        }

        private ArcRotateCameraInputsManager __inputs;
        public async ValueTask<ArcRotateCameraInputsManager> get_inputs()
        {
            if(__inputs == null)
            {
                __inputs = await EventHorizonBlazorInterop.GetClass<ArcRotateCameraInputsManager>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new ArcRotateCameraInputsManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputs;
        }
        public ValueTask set_inputs(ArcRotateCameraInputsManager value)
        {
__inputs = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
        }

        private Vector3 __panningAxis;
        public async ValueTask<Vector3> get_panningAxis()
        {
            if(__panningAxis == null)
            {
                __panningAxis = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "panningAxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __panningAxis;
        }
        public ValueTask set_panningAxis(Vector3 value)
        {
__panningAxis = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningAxis",
                    value
                );
        }

        private Observable<AbstractMesh> __onMeshTargetChangedObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onMeshTargetChangedObservable()
        {
            if(__onMeshTargetChangedObservable == null)
            {
                __onMeshTargetChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onMeshTargetChangedObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMeshTargetChangedObservable;
        }
        public ValueTask set_onMeshTargetChangedObservable(Observable<AbstractMesh> value)
        {
__onMeshTargetChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshTargetChangedObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_checkCollisions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
        }
        public ValueTask set_checkCollisions(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkCollisions",
                    value
                );
        }

        private Vector3 __collisionRadius;
        public async ValueTask<Vector3> get_collisionRadius()
        {
            if(__collisionRadius == null)
            {
                __collisionRadius = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "collisionRadius",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __collisionRadius;
        }
        public ValueTask set_collisionRadius(Vector3 value)
        {
__collisionRadius = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionRadius",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ArcRotateCamera() : base() { }

        public ArcRotateCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ArcRotateCamera> NewArcRotateCamera(
            string name, decimal alpha, decimal beta, decimal radius, Vector3 target, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ArcRotateCamera" },
                name, alpha, beta, radius, target, scene, setActiveOnSceneIfNoneActive
            );

            return new ArcRotateCamera(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setMatUp()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatUp" }
                }
            );
        }

        #region onCollide TODO: Get Comments as metadata identification
        private bool _isOnCollideEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onCollideActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onCollide(
            Func<Task> callback
        )
        {
            await SetupOnCollideLoop();

            var handle = Guid.NewGuid().ToString();
            _onCollideActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnCollideLoop()
        {
            if (_isOnCollideEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onCollide",
                "CallOnCollideActions",
                _invokableReference
            );
            _isOnCollideEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnCollideActions()
        {
            foreach (var action in _onCollideActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<Camera> storeState()
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public async ValueTask attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
                }
            );
        }

        public async ValueTask detachControl()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public async ValueTask rebuildAnglesAndRadius()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuildAnglesAndRadius" }
                }
            );
        }

        public async ValueTask setPosition(Vector3 position)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPosition" }, position
                }
            );
        }

        public async ValueTask setTarget(AbstractMesh target, System.Nullable<bool> toBoundingCenter = null, System.Nullable<bool> allowSamePosition = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTarget" }, target, toBoundingCenter, allowSamePosition
                }
            );
        }

        public async ValueTask zoomOn(AbstractMesh[] meshes = null, System.Nullable<bool> doNotUpdateMaxZ = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "zoomOn" }, meshes, doNotUpdateMaxZ
                }
            );
        }

        public async ValueTask focusOn(AbstractMesh[] meshesOrMinMaxVectorAndDistance, System.Nullable<bool> doNotUpdateMaxZ = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "focusOn" }, meshesOrMinMaxVectorAndDistance, doNotUpdateMaxZ
                }
            );
        }

        public async ValueTask<Camera> createRigCamera(string name, decimal cameraIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}