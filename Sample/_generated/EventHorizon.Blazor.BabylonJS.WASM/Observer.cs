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
    public class Observer : CachedEntityObject
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "mask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "scope"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "unregisterOnNextCall"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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

        private void SetupCallbackLoop()
        {
            if (_isCallbackEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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