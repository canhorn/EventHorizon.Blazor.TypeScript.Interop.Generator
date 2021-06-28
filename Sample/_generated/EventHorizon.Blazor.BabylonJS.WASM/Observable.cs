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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Observable<CachedEntity>>))]
    public class Observable<T> : CachedEntityObject where T : CachedEntity, new()
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public Observer<T>[] observers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Observer<T>>(
                    this.___guid,
                    "observers",
                    (entity) =>
                    {
                        return new Observer<T>() { ___guid = entity.___guid };
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

        public Observable(
            ActionCallback<Observer<T>> onObserverAdded = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Observable" },
                onObserverAdded
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region add TODO: Get Comments as metadata identification
        private bool _isAddEnabled = false;
        private readonly IDictionary<string, Func<T, EventState, Task>> _addActionMap = new Dictionary<string, Func<T, EventState, Task>>();

        public string add(
            Func<T, EventState, Task> callback
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

        public bool add_Remove(
            string handle
        )
        {
            return _addActionMap.Remove(
                handle
            );
        }

        private void SetupAddLoop()
        {
            if (_isAddEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "add",
                "CallAddActions",
                _invokableReference
            );
            _isAddEnabled = true;
        }

        [JSInvokable]
        public async Task CallAddActions(T eventData, EventState eventState)
        {
            foreach (var action in _addActionMap.Values)
            {
                await action(eventData, eventState);
            }
        }
        #endregion

        #region addOnce TODO: Get Comments as metadata identification
        private bool _isAddOnceEnabled = false;
        private readonly IDictionary<string, Func<T, EventState, Task>> _addOnceActionMap = new Dictionary<string, Func<T, EventState, Task>>();

        public string addOnce(
            Func<T, EventState, Task> callback
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

        public bool addOnce_Remove(
            string handle
        )
        {
            return _addOnceActionMap.Remove(
                handle
            );
        }

        private void SetupAddOnceLoop()
        {
            if (_isAddOnceEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "addOnce",
                "CallAddOnceActions",
                _invokableReference
            );
            _isAddOnceEnabled = true;
        }

        [JSInvokable]
        public async Task CallAddOnceActions(T eventData, EventState eventState)
        {
            foreach (var action in _addOnceActionMap.Values)
            {
                await action(eventData, eventState);
            }
        }
        #endregion

        public bool remove(Observer<T> observer)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "remove" }, observer
                }
            );
        }

        #region removeCallback TODO: Get Comments as metadata identification
        private bool _isRemoveCallbackEnabled = false;
        private readonly IDictionary<string, Func<T, EventState, Task>> _removeCallbackActionMap = new Dictionary<string, Func<T, EventState, Task>>();

        public string removeCallback(
            Func<T, EventState, Task> callback
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

        public bool removeCallback_Remove(
            string handle
        )
        {
            return _removeCallbackActionMap.Remove(
                handle
            );
        }

        private void SetupRemoveCallbackLoop()
        {
            if (_isRemoveCallbackEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "removeCallback",
                "CallRemoveCallbackActions",
                _invokableReference
            );
            _isRemoveCallbackEnabled = true;
        }

        [JSInvokable]
        public async Task CallRemoveCallbackActions(T eventData, EventState eventState)
        {
            foreach (var action in _removeCallbackActionMap.Values)
            {
                await action(eventData, eventState);
            }
        }
        #endregion

        public void makeObserverTopPriority(Observer<T> observer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "makeObserverTopPriority" }, observer
                }
            );
        }

        public void makeObserverBottomPriority(Observer<T> observer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "makeObserverBottomPriority" }, observer
                }
            );
        }

        public bool notifyObservers(T eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null, object userInfo = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "notifyObservers" }, eventData, mask, target, currentTarget, userInfo
                }
            );
        }

        public ValueTask<T> notifyObserversWithPromise(T eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null, object userInfo = null)
        {
            return EventHorizonBlazorInterop.TaskClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "notifyObserversWithPromise" }, eventData, mask, target, currentTarget, userInfo
                }
            );
        }

        public void notifyObserver(Observer<T> observer, T eventData, System.Nullable<decimal> mask = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "notifyObserver" }, observer, eventData, mask
                }
            );
        }

        public bool hasObservers()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasObservers" }
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

        public Observable<T> clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Observable<T>>(
                entity => new Observable<T>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool hasSpecificMask(System.Nullable<decimal> mask = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasSpecificMask" }, mask
                }
            );
        }
        #endregion
    }
}