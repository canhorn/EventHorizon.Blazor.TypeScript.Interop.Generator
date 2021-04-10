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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FreeCamera>))]
    public class FreeCamera : TargetCamera
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_angularSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibility"
                );
        }
        public ValueTask set_angularSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibility",
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

        
        public async ValueTask<decimal[]> get_keysUpward()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysUpward"
                );
        }
        public ValueTask set_keysUpward(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysUpward",
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

        
        public async ValueTask<decimal[]> get_keysDownward()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysDownward"
                );
        }
        public ValueTask set_keysDownward(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysDownward",
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

        
        public async ValueTask<decimal> get_collisionMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
        }
        public ValueTask set_collisionMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
        }
        #endregion

        #region Properties
        private Vector3 __ellipsoid;
        public async ValueTask<Vector3> get_ellipsoid()
        {
            if(__ellipsoid == null)
            {
                __ellipsoid = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoid",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ellipsoid;
        }
        public ValueTask set_ellipsoid(Vector3 value)
        {
__ellipsoid = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoid",
                    value
                );
        }

        private Vector3 __ellipsoidOffset;
        public async ValueTask<Vector3> get_ellipsoidOffset()
        {
            if(__ellipsoidOffset == null)
            {
                __ellipsoidOffset = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoidOffset",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ellipsoidOffset;
        }
        public ValueTask set_ellipsoidOffset(Vector3 value)
        {
__ellipsoidOffset = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoidOffset",
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

        
        public async ValueTask<bool> get_applyGravity()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyGravity"
                );
        }
        public ValueTask set_applyGravity(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyGravity",
                    value
                );
        }

        private FreeCameraInputsManager __inputs;
        public async ValueTask<FreeCameraInputsManager> get_inputs()
        {
            if(__inputs == null)
            {
                __inputs = await EventHorizonBlazorInterop.GetClass<FreeCameraInputsManager>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new FreeCameraInputsManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputs;
        }
        public ValueTask set_inputs(FreeCameraInputsManager value)
        {
__inputs = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public FreeCamera() : base() { }

        public FreeCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<FreeCamera> NewFreeCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FreeCamera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );

            return new FreeCamera(entity);
        }
        #endregion

        #region Methods
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