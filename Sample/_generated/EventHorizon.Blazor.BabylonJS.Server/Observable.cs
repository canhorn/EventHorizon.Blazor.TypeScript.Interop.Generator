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
        
        public async ValueTask<Observer<T>[]> get_observers()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Observer<T>>(
                    this.___guid,
                    "observers",
                    (entity) =>
                    {
                        return new Observer<T>() { ___guid = entity.___guid };
                    }
                );
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

        public static async ValueTask<Observable<T>> NewObservable(
            ActionCallback<Observer<T>> onObserverAdded = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Observable" },
                onObserverAdded
            );

            return new Observable<T>(entity);
        }
        #endregion

        #region Methods
        #region add TODO: Get Comments as metadata identification
        private bool _isAddEnabled = false;
        private readonly IDictionary<string, Func<T, EventState, Task>> _addActionMap = new Dictionary<string, Func<T, EventState, Task>>();

        public async ValueTask<string> add(
            Func<T, EventState, Task> callback
        )
        {
            await SetupAddLoop();

            var handle = Guid.NewGuid().ToString();
            _addActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupAddLoop()
        {
            if (_isAddEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> addOnce(
            Func<T, EventState, Task> callback
        )
        {
            await SetupAddOnceLoop();

            var handle = Guid.NewGuid().ToString();
            _addOnceActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupAddOnceLoop()
        {
            if (_isAddOnceEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<bool> remove(Observer<T> observer)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "remove" }, observer
                }
            );
        }

        #region removeCallback TODO: Get Comments as metadata identification
        private bool _isRemoveCallbackEnabled = false;
        private readonly IDictionary<string, Func<T, EventState, Task>> _removeCallbackActionMap = new Dictionary<string, Func<T, EventState, Task>>();

        public async ValueTask<string> removeCallback(
            Func<T, EventState, Task> callback
        )
        {
            await SetupRemoveCallbackLoop();

            var handle = Guid.NewGuid().ToString();
            _removeCallbackActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupRemoveCallbackLoop()
        {
            if (_isRemoveCallbackEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask makeObserverTopPriority(Observer<T> observer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "makeObserverTopPriority" }, observer
                }
            );
        }

        public async ValueTask makeObserverBottomPriority(Observer<T> observer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "makeObserverBottomPriority" }, observer
                }
            );
        }

        public async ValueTask<bool> notifyObservers(T eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null, object userInfo = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "notifyObservers" }, eventData, mask, target, currentTarget, userInfo
                }
            );
        }

        public async ValueTask<T> notifyObserversWithPromise(T eventData, System.Nullable<decimal> mask = null, object target = null, object currentTarget = null, object userInfo = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "notifyObserversWithPromise" }, eventData, mask, target, currentTarget, userInfo
                }
            );
        }

        public async ValueTask notifyObserver(Observer<T> observer, T eventData, System.Nullable<decimal> mask = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "notifyObserver" }, observer, eventData, mask
                }
            );
        }

        public async ValueTask<bool> hasObservers()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasObservers" }
                }
            );
        }

        public async ValueTask clear()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public async ValueTask<Observable<T>> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Observable<T>>(
                entity => new Observable<T>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<bool> hasSpecificMask(System.Nullable<decimal> mask = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificMask" }, mask
                }
            );
        }
        #endregion
    }
}