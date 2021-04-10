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
        #endregion

        #region Properties
        private Vector3 __cameraDirection;
        public async ValueTask<Vector3> get_cameraDirection()
        {
            if(__cameraDirection == null)
            {
                __cameraDirection = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_cameraDirection(Vector3 value)
        {
__cameraDirection = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraDirection",
                    value
                );
        }

        private Vector2 __cameraRotation;
        public async ValueTask<Vector2> get_cameraRotation()
        {
            if(__cameraRotation == null)
            {
                __cameraRotation = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        public ValueTask set_cameraRotation(Vector2 value)
        {
__cameraRotation = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraRotation",
                    value
                );
        }

        
        public async ValueTask<bool> get_ignoreParentScaling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreParentScaling"
                );
        }
        public ValueTask set_ignoreParentScaling(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreParentScaling",
                    value
                );
        }

        
        public async ValueTask<bool> get_updateUpVectorFromRotation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "updateUpVectorFromRotation"
                );
        }
        public ValueTask set_updateUpVectorFromRotation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateUpVectorFromRotation",
                    value
                );
        }

        private Vector3 __rotation;
        public async ValueTask<Vector3> get_rotation()
        {
            if(__rotation == null)
            {
                __rotation = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_rotation(Vector3 value)
        {
__rotation = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
        }

        private Quaternion __rotationQuaternion;
        public async ValueTask<Quaternion> get_rotationQuaternion()
        {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = await EventHorizonBlazorInterop.GetClass<Quaternion>(
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
        public ValueTask set_rotationQuaternion(Quaternion value)
        {
__rotationQuaternion = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
        }

        
        public async ValueTask<decimal> get_speed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speed"
                );
        }
        public ValueTask set_speed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speed",
                    value
                );
        }

        
        public async ValueTask<bool> get_noRotationConstraint()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noRotationConstraint"
                );
        }
        public ValueTask set_noRotationConstraint(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noRotationConstraint",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertRotation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertRotation"
                );
        }
        public ValueTask set_invertRotation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertRotation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inverseRotationSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inverseRotationSpeed"
                );
        }
        public ValueTask set_inverseRotationSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverseRotationSpeed",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_lockedTarget()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "lockedTarget",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_lockedTarget(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockedTarget",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public TargetCamera() : base() { }

        public TargetCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<TargetCamera> NewTargetCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TargetCamera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );

            return new TargetCamera(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Vector3> getFrontPosition(decimal distance)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFrontPosition" }, distance
                }
            );
        }

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

        public async ValueTask setTarget(Vector3 target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTarget" }, target
                }
            );
        }

        public async ValueTask<Vector3> getTarget()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTarget" }
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