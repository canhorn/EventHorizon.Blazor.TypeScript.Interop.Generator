/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<CameraInputsManager<CachedEntity>>))]
    public class CameraInputsManager<TCamera> : CachedEntityObject where TCamera : CachedEntity, new()
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private CameraInputsMapCachedEntity<TCamera> __attached;
        public CameraInputsMapCachedEntity<TCamera> attached
        {
            get
            {
            if(__attached == null)
            {
                __attached = EventHorizonBlazorInterop.GetClass<CameraInputsMapCachedEntity<TCamera>>(
                    this.___guid,
                    "attached",
                    (entity) =>
                    {
                        return new CameraInputsMapCachedEntity<TCamera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __attached;
            }
            set
            {
__attached = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attached",
                    value
                );
            }
        }

        
        public CachedEntity attachedElement
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "attachedElement"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachedElement",
                    value
                );
            }
        }

        
        public bool noPreventDefault
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noPreventDefault",
                    value
                );
            }
        }

        private TCamera __camera;
        public TCamera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<TCamera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new TCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CameraInputsManager() : base() { } 

        public CameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public CameraInputsManager(
            TCamera camera
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "CameraInputsManager" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region checkInputs TODO: Get Comments as metadata identification
        private bool _isCheckInputsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _checkInputsActionMap = new Dictionary<string, Func<Task>>();

        public string checkInputs(
            Func<Task> callback
        )
        {
            SetupCheckInputsLoop();

            var handle = Guid.NewGuid().ToString();
            _checkInputsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCheckInputsLoop()
        {
            if (_isCheckInputsEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "checkInputs",
                "CallCheckInputsActions",
                _invokableReference
            );
            _isCheckInputsEnabled = true;
        }

        [JSInvokable]
        public async Task CallCheckInputsActions()
        {
            foreach (var action in _checkInputsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void add(ICameraInputCachedEntity<TCamera> input)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "add" }, input
                }
            );
        }

        public void remove(ICameraInputCachedEntity<TCamera> inputToRemove)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "remove" }, inputToRemove
                }
            );
        }

        public void removeByType(string inputType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeByType" }, inputType
                }
            );
        }

        public void attachInput(ICameraInputCachedEntity<TCamera> input)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachInput" }, input
                }
            );
        }

        public void attachElement(object element, System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachElement" }, element, noPreventDefault
                }
            );
        }

        public void detachElement(object element, System.Nullable<bool> disconnect = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachElement" }, element, disconnect
                }
            );
        }

        public void rebuildInputCheck()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuildInputCheck" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void serialize(object serializedCamera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializedCamera
                }
            );
        }

        public void parse(object parsedCamera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "parse" }, parsedCamera
                }
            );
        }
        #endregion
    }
}