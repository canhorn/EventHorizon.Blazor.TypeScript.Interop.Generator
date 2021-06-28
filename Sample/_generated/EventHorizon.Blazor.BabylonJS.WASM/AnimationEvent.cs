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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationEvent>))]
    public class AnimationEvent : CachedEntityObject
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
        
        public decimal frame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public bool onlyOnce
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "onlyOnce"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onlyOnce",
                    value
                );
            }
        }

        
        public bool isDone
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDone"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isDone",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationEvent() : base() { }

        public AnimationEvent(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationEvent(
            decimal frame, ActionCallback<decimal> action, System.Nullable<bool> onlyOnce = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationEvent" },
                frame, action, onlyOnce
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region action TODO: Get Comments as metadata identification
        private bool _isActionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _actionActionMap = new Dictionary<string, Func<Task>>();

        public string action(
            Func<Task> callback
        )
        {
            SetupActionLoop();

            var handle = Guid.NewGuid().ToString();
            _actionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool action_Remove(
            string handle
        )
        {
            return _actionActionMap.Remove(
                handle
            );
        }

        private void SetupActionLoop()
        {
            if (_isActionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "action",
                "CallActionActions",
                _invokableReference
            );
            _isActionEnabled = true;
        }

        [JSInvokable]
        public async Task CallActionActions()
        {
            foreach (var action in _actionActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}