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
    public class Observable : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public Observer[] observers
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Observer>(
                    this.___guid,
                    "observers",
                    (entity) =>
                    {
                        return new Observer(entity);
                    }
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Observable() : base() { } 

        public Observable(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        #region add TODO: Get Comments as metadata identification
        private bool _isAddEnabled = false;
        private readonly IDictionary<string, Func<Task>> _addActionMap = new Dictionary<string, Func<Task>>();

        public string add(
            Func<Task> callback
        )
        {
            SetupAddLoop();

            var handle = Guid.NewGuid().ToString();
            _addActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupAddLoop()
        {
            if (_isAddEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "add",
                "CallAddActions",
                _invokableReference
            );
            _isAddEnabled = true;
        }

        [JSInvokable]
        public async Task CallAddActions()
        {
            foreach (var action in _addActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region addOnce TODO: Get Comments as metadata identification
        private bool _isAddOnceEnabled = false;
        private readonly IDictionary<string, Func<Task>> _addOnceActionMap = new Dictionary<string, Func<Task>>();

        public string addOnce(
            Func<Task> callback
        )
        {
            SetupAddOnceLoop();

            var handle = Guid.NewGuid().ToString();
            _addOnceActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupAddOnceLoop()
        {
            if (_isAddOnceEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "addOnce",
                "CallAddOnceActions",
                _invokableReference
            );
            _isAddOnceEnabled = true;
        }

        [JSInvokable]
        public async Task CallAddOnceActions()
        {
            foreach (var action in _addOnceActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public bool remove(Observer observer)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "remove" }, observer
                }
            );
        }

        #region removeCallback TODO: Get Comments as metadata identification
        private bool _isRemoveCallbackEnabled = false;
        private readonly IDictionary<string, Func<Task>> _removeCallbackActionMap = new Dictionary<string, Func<Task>>();

        public string removeCallback(
            Func<Task> callback
        )
        {
            SetupRemoveCallbackLoop();

            var handle = Guid.NewGuid().ToString();
            _removeCallbackActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRemoveCallbackLoop()
        {
            if (_isRemoveCallbackEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "removeCallback",
                "CallRemoveCallbackActions",
                _invokableReference
            );
            _isRemoveCallbackEnabled = true;
        }

        [JSInvokable]
        public async Task CallRemoveCallbackActions()
        {
            foreach (var action in _removeCallbackActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void makeObserverTopPriority(Observer observer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "makeObserverTopPriority" }, observer
                }
            );
        }

        public void makeObserverBottomPriority(Observer observer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "makeObserverBottomPriority" }, observer
                }
            );
        }

        public bool notifyObservers(object eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "notifyObservers" }, eventData, mask, target, currentTarget
                }
            );
        }

        public Task notifyObserversWithPromise(object eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null)
        {
            return EventHorizonBlazorInteropt.Func<Task>(
                new object[] 
                {
                    new string[] { this.___guid, "notifyObserversWithPromise" }, eventData, mask, target, currentTarget
                }
            );
        }

        public void notifyObserver(Observer observer, object eventData, System.Nullable<decimal> mask = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "notifyObserver" }, observer, eventData, mask
                }
            );
        }

        public bool hasObservers()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasObservers" }
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

        public Observable clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Observable>(
                entity => new Observable(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool hasSpecificMask(System.Nullable<decimal> mask = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificMask" }, mask
                }
            );
        }
        #endregion
    }
}