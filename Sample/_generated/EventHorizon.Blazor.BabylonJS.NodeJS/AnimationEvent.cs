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
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "frame"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "frame", value);
            }
        }

        public bool onlyOnce
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "onlyOnce"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "onlyOnce", value);
            }
        }

        public bool isDone
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDone"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isDone", value);
            }
        }
        #endregion

        #region Constructor
        public AnimationEvent()
            : base() { }

        public AnimationEvent(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationEvent(
            decimal frame,
            ActionCallback<decimal> action,
            System.Nullable<bool> onlyOnce = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationEvent" },
                frame,
                action,
                onlyOnce
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void action(decimal currentFrame)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "action" }, currentFrame }
            );
        }
        #endregion
    }
}
