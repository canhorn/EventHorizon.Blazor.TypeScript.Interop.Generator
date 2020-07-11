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
    public class CameraInputsManager : CachedEntityObject
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
        private CameraInputsMap __attached;
        public CameraInputsMap attached
        {
            get
            {
            if(__attached == null)
            {
                __attached = EventHorizonBlazorInteropt.GetClass<CameraInputsMap>(
                    this.___guid,
                    "attached",
                    (entity) =>
                    {
                        return new CameraInputsMapCachedEntity(entity);
                    }
                );
            }
            return __attached;
            }
            set
            {
__attached = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "attachedElement"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "noPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "noPreventDefault",
                    value
                );
            }
        }

        
        public CachedEntity camera
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "camera"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            CachedEntity camera
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
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
            EventHorizonBlazorInteropt.FuncCallback(
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

        public void add(ICameraInput input)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "add" }, input
                }
            );
        }

        public void remove(ICameraInput inputToRemove)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "remove" }, inputToRemove
                }
            );
        }

        public void removeByType(string inputType)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeByType" }, inputType
                }
            );
        }

        public void attachInput(ICameraInput input)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachInput" }, input
                }
            );
        }

        public void attachElement(CachedEntity element, System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachElement" }, element, noPreventDefault
                }
            );
        }

        public void detachElement(CachedEntity element, System.Nullable<bool> disconnect = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachElement" }, element, disconnect
                }
            );
        }

        public void rebuildInputCheck()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuildInputCheck" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void serialize(CachedEntity serializedCamera)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializedCamera
                }
            );
        }

        public void parse(CachedEntity parsedCamera)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "parse" }, parsedCamera
                }
            );
        }
        #endregion
    }
}