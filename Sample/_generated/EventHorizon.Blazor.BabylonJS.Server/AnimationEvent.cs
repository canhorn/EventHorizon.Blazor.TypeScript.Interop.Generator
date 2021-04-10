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
        
        public async ValueTask<decimal> get_frame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frame"
                );
        }
        public ValueTask set_frame(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
        }

        
        public async ValueTask<bool> get_onlyOnce()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "onlyOnce"
                );
        }
        public ValueTask set_onlyOnce(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onlyOnce",
                    value
                );
        }

        
        public async ValueTask<bool> get_isDone()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDone"
                );
        }
        public ValueTask set_isDone(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isDone",
                    value
                );
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

        public static async ValueTask<AnimationEvent> NewAnimationEvent(
            decimal frame, ActionCallback<decimal> action, System.Nullable<bool> onlyOnce = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationEvent" },
                frame, action, onlyOnce
            );

            return new AnimationEvent(entity);
        }
        #endregion

        #region Methods
        #region action TODO: Get Comments as metadata identification
        private bool _isActionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _actionActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> action(
            Func<Task> callback
        )
        {
            await SetupActionLoop();

            var handle = Guid.NewGuid().ToString();
            _actionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupActionLoop()
        {
            if (_isActionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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