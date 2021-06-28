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
        public Vector3 target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Vector3 __upVector;
        public Vector3 upVector
        {
            get
            {
            if(__upVector == null)
            {
                __upVector = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__upVector = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upVector",
                    value
                );
            }
        }

        
        public decimal angularSensibilityX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibilityX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibilityX",
                    value
                );
            }
        }

        
        public decimal angularSensibilityY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibilityY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibilityY",
                    value
                );
            }
        }

        
        public decimal pinchPrecision
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchPrecision"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchPrecision",
                    value
                );
            }
        }

        
        public decimal pinchDeltaPercentage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchDeltaPercentage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchDeltaPercentage",
                    value
                );
            }
        }

        
        public bool useNaturalPinchZoom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useNaturalPinchZoom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useNaturalPinchZoom",
                    value
                );
            }
        }

        
        public decimal panningSensibility
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningSensibility"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningSensibility",
                    value
                );
            }
        }

        
        public decimal[] keysUp
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysUp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysUp",
                    value
                );
            }
        }

        
        public decimal[] keysDown
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysDown",
                    value
                );
            }
        }

        
        public decimal[] keysLeft
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysLeft",
                    value
                );
            }
        }

        
        public decimal[] keysRight
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysRight",
                    value
                );
            }
        }

        
        public decimal wheelPrecision
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wheelPrecision"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wheelPrecision",
                    value
                );
            }
        }

        
        public decimal wheelDeltaPercentage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wheelDeltaPercentage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wheelDeltaPercentage",
                    value
                );
            }
        }

        private BouncingBehavior __bouncingBehavior;
        public BouncingBehavior bouncingBehavior
        {
            get
            {
            if(__bouncingBehavior == null)
            {
                __bouncingBehavior = EventHorizonBlazorInterop.GetClass<BouncingBehavior>(
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
        }

        
        public bool useBouncingBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBouncingBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBouncingBehavior",
                    value
                );
            }
        }

        private FramingBehavior __framingBehavior;
        public FramingBehavior framingBehavior
        {
            get
            {
            if(__framingBehavior == null)
            {
                __framingBehavior = EventHorizonBlazorInterop.GetClass<FramingBehavior>(
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
        }

        
        public bool useFramingBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useFramingBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useFramingBehavior",
                    value
                );
            }
        }

        private AutoRotationBehavior __autoRotationBehavior;
        public AutoRotationBehavior autoRotationBehavior
        {
            get
            {
            if(__autoRotationBehavior == null)
            {
                __autoRotationBehavior = EventHorizonBlazorInterop.GetClass<AutoRotationBehavior>(
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
        }

        
        public bool useAutoRotationBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAutoRotationBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAutoRotationBehavior",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public decimal beta
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beta"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beta",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal inertialAlphaOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialAlphaOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialAlphaOffset",
                    value
                );
            }
        }

        
        public decimal inertialBetaOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialBetaOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialBetaOffset",
                    value
                );
            }
        }

        
        public decimal inertialRadiusOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialRadiusOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialRadiusOffset",
                    value
                );
            }
        }

        
        public decimal lowerAlphaLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerAlphaLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerAlphaLimit",
                    value
                );
            }
        }

        
        public decimal upperAlphaLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperAlphaLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperAlphaLimit",
                    value
                );
            }
        }

        
        public decimal lowerBetaLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerBetaLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerBetaLimit",
                    value
                );
            }
        }

        
        public decimal upperBetaLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperBetaLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperBetaLimit",
                    value
                );
            }
        }

        
        public decimal lowerRadiusLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusLimit",
                    value
                );
            }
        }

        
        public decimal upperRadiusLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusLimit",
                    value
                );
            }
        }

        
        public decimal inertialPanningX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialPanningX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialPanningX",
                    value
                );
            }
        }

        
        public decimal inertialPanningY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertialPanningY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertialPanningY",
                    value
                );
            }
        }

        
        public decimal pinchToPanMaxDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pinchToPanMaxDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pinchToPanMaxDistance",
                    value
                );
            }
        }

        
        public decimal panningDistanceLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningDistanceLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningDistanceLimit",
                    value
                );
            }
        }

        private Vector3 __panningOriginTarget;
        public Vector3 panningOriginTarget
        {
            get
            {
            if(__panningOriginTarget == null)
            {
                __panningOriginTarget = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__panningOriginTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningOriginTarget",
                    value
                );
            }
        }

        
        public decimal panningInertia
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "panningInertia"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningInertia",
                    value
                );
            }
        }

        
        public decimal zoomOnFactor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zoomOnFactor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zoomOnFactor",
                    value
                );
            }
        }

        private Vector2 __targetScreenOffset;
        public Vector2 targetScreenOffset
        {
            get
            {
            if(__targetScreenOffset == null)
            {
                __targetScreenOffset = EventHorizonBlazorInterop.GetClass<Vector2>(
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
            set
            {
__targetScreenOffset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetScreenOffset",
                    value
                );
            }
        }

        
        public bool allowUpsideDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowUpsideDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowUpsideDown",
                    value
                );
            }
        }

        
        public bool useInputToRestoreState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useInputToRestoreState"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useInputToRestoreState",
                    value
                );
            }
        }

        private ArcRotateCameraInputsManager __inputs;
        public ArcRotateCameraInputsManager inputs
        {
            get
            {
            if(__inputs == null)
            {
                __inputs = EventHorizonBlazorInterop.GetClass<ArcRotateCameraInputsManager>(
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
            set
            {
__inputs = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
            }
        }

        private Vector3 __panningAxis;
        public Vector3 panningAxis
        {
            get
            {
            if(__panningAxis == null)
            {
                __panningAxis = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__panningAxis = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "panningAxis",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onMeshTargetChangedObservable;
        public Observable<AbstractMesh> onMeshTargetChangedObservable
        {
            get
            {
            if(__onMeshTargetChangedObservable == null)
            {
                __onMeshTargetChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
            set
            {
__onMeshTargetChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshTargetChangedObservable",
                    value
                );
            }
        }

        
        public bool checkCollisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkCollisions",
                    value
                );
            }
        }

        private Vector3 __collisionRadius;
        public Vector3 collisionRadius
        {
            get
            {
            if(__collisionRadius == null)
            {
                __collisionRadius = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__collisionRadius = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionRadius",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ArcRotateCamera() : base() { }

        public ArcRotateCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ArcRotateCamera(
            string name, decimal alpha, decimal beta, decimal radius, Vector3 target, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ArcRotateCamera" },
                name, alpha, beta, radius, target, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setMatUp()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMatUp" }
                }
            );
        }

        #region onCollide TODO: Get Comments as metadata identification
        private bool _isOnCollideEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onCollideActionMap = new Dictionary<string, Func<Task>>();

        public string onCollide(
            Func<Task> callback
        )
        {
            SetupOnCollideLoop();

            var handle = Guid.NewGuid().ToString();
            _onCollideActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onCollide_Remove(
            string handle
        )
        {
            return _onCollideActionMap.Remove(
                handle
            );
        }

        private void SetupOnCollideLoop()
        {
            if (_isOnCollideEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public Camera storeState()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public void attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
                }
            );
        }

        public void detachControl()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public void rebuildAnglesAndRadius()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rebuildAnglesAndRadius" }
                }
            );
        }

        public void setPosition(Vector3 position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, position
                }
            );
        }

        public void setTarget(AbstractMesh target, System.Nullable<bool> toBoundingCenter = null, System.Nullable<bool> allowSamePosition = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTarget" }, target, toBoundingCenter, allowSamePosition
                }
            );
        }

        public void zoomOn(AbstractMesh[] meshes = null, System.Nullable<bool> doNotUpdateMaxZ = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "zoomOn" }, meshes, doNotUpdateMaxZ
                }
            );
        }

        public void focusOn(AbstractMesh[] meshesOrMinMaxVectorAndDistance, System.Nullable<bool> doNotUpdateMaxZ = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "focusOn" }, meshesOrMinMaxVectorAndDistance, doNotUpdateMaxZ
                }
            );
        }

        public Camera createRigCamera(string name, decimal cameraIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}