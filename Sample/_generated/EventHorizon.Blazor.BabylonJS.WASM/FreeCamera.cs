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
        
        public decimal angularSensibility
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSensibility"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSensibility",
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

        
        public decimal[] keysUpward
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysUpward"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysUpward",
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

        
        public decimal[] keysDownward
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "keysDownward"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "keysDownward",
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

        
        public decimal collisionMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Vector3 __ellipsoid;
        public Vector3 ellipsoid
        {
            get
            {
            if(__ellipsoid == null)
            {
                __ellipsoid = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__ellipsoid = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoid",
                    value
                );
            }
        }

        private Vector3 __ellipsoidOffset;
        public Vector3 ellipsoidOffset
        {
            get
            {
            if(__ellipsoidOffset == null)
            {
                __ellipsoidOffset = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__ellipsoidOffset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoidOffset",
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

        
        public bool applyGravity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyGravity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyGravity",
                    value
                );
            }
        }

        private FreeCameraInputsManager __inputs;
        public FreeCameraInputsManager inputs
        {
            get
            {
            if(__inputs == null)
            {
                __inputs = EventHorizonBlazorInterop.GetClass<FreeCameraInputsManager>(
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
        #endregion
        
        #region Constructor
        public FreeCamera() : base() { }

        public FreeCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FreeCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FreeCamera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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