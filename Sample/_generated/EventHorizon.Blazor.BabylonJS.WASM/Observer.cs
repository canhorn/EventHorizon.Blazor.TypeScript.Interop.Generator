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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Observer<CachedEntity>>))]
    public class Observer<T> : CachedEntityObject where T : CachedEntity, new()
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
        
        public decimal mask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mask",
                    value
                );
            }
        }

        
        public CachedEntity scope
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "scope",
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
                    "scope",
                    value
                );
            }
        }

        
        public bool unregisterOnNextCall
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "unregisterOnNextCall"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "unregisterOnNextCall",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Observer() : base() { }

        public Observer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Observer(
            ActionCallback<T, EventState> callback, decimal mask, object scope = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Observer" },
                callback, mask, scope
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region callback TODO: Get Comments as metadata identification
        private bool _isCallbackEnabled = false;
        private readonly IDictionary<string, Func<Task>> _callbackActionMap = new Dictionary<string, Func<Task>>();

        public string callback(
            Func<Task> callback
        )
        {
            SetupCallbackLoop();

            var handle = Guid.NewGuid().ToString();
            _callbackActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool callback_Remove(
            string handle
        )
        {
            return _callbackActionMap.Remove(
                handle
            );
        }

        private void SetupCallbackLoop()
        {
            if (_isCallbackEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "callback",
                "CallCallbackActions",
                _invokableReference
            );
            _isCallbackEnabled = true;
        }

        [JSInvokable]
        public async Task CallCallbackActions()
        {
            foreach (var action in _callbackActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}