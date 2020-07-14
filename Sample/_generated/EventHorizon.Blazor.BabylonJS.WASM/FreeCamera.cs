/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "angularSensibility"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "keysUp"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "keysDown"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "keysLeft"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "keysRight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __ellipsoid = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoid",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __ellipsoid;
            }
            set
            {
__ellipsoid = null;
                EventHorizonBlazorInteropt.Set(
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
                __ellipsoidOffset = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoidOffset",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __ellipsoidOffset;
            }
            set
            {
__ellipsoidOffset = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "applyGravity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __inputs = EventHorizonBlazorInteropt.GetClass<FreeCameraInputsManager>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new FreeCameraInputsManager(entity);
                    }
                );
            }
            return __inputs;
            }
            set
            {
__inputs = null;
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
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

        private void SetupOnCollideLoop()
        {
            if (_isOnCollideEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        public void attachControl(object element, System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, element, noPreventDefault
                }
            );
        }

        public void detachControl(object element)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }, element
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}