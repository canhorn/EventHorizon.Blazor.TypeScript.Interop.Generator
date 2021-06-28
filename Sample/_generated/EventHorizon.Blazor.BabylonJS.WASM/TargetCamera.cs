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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TargetCamera>))]
    public class TargetCamera : Camera
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
        #endregion

        #region Properties
        private Vector3 __cameraDirection;
        public Vector3 cameraDirection
        {
            get
            {
            if(__cameraDirection == null)
            {
                __cameraDirection = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "cameraDirection",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraDirection;
            }
            set
            {
__cameraDirection = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraDirection",
                    value
                );
            }
        }

        private Vector2 __cameraRotation;
        public Vector2 cameraRotation
        {
            get
            {
            if(__cameraRotation == null)
            {
                __cameraRotation = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "cameraRotation",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraRotation;
            }
            set
            {
__cameraRotation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraRotation",
                    value
                );
            }
        }

        
        public bool ignoreParentScaling
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreParentScaling"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreParentScaling",
                    value
                );
            }
        }

        
        public bool updateUpVectorFromRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "updateUpVectorFromRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateUpVectorFromRotation",
                    value
                );
            }
        }

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotation;
            }
            set
            {
__rotation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        private Quaternion __rotationQuaternion;
        public Quaternion rotationQuaternion
        {
            get
            {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "rotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotationQuaternion;
            }
            set
            {
__rotationQuaternion = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
            }
        }

        
        public decimal speed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speed",
                    value
                );
            }
        }

        
        public bool noRotationConstraint
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noRotationConstraint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noRotationConstraint",
                    value
                );
            }
        }

        
        public bool invertRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertRotation",
                    value
                );
            }
        }

        
        public decimal inverseRotationSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inverseRotationSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverseRotationSpeed",
                    value
                );
            }
        }

        
        public CachedEntity lockedTarget
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "lockedTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockedTarget",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TargetCamera() : base() { }

        public TargetCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TargetCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TargetCamera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vector3 getFrontPosition(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFrontPosition" }, distance
                }
            );
        }

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

        public void setTarget(Vector3 target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTarget" }, target
                }
            );
        }

        public Vector3 getTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTarget" }
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