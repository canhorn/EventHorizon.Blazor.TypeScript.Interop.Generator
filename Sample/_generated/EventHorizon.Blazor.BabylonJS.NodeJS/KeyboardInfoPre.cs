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

    [JsonConverter(typeof(CachedEntityConverter<KeyboardInfoPre>))]
    public class KeyboardInfoPre : KeyboardInfo
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool skipOnPointerObservable
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "skipOnPointerObservable");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "skipOnPointerObservable", value);
            }
        }
        #endregion

        #region Properties

        public decimal type
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        private IKeyboardEventCachedEntity __event;
        public IKeyboardEventCachedEntity @event
        {
            get
            {
                if (__event == null)
                {
                    __event = EventHorizonBlazorInterop.GetClass<IKeyboardEventCachedEntity>(
                        this.___guid,
                        "event",
                        (entity) =>
                        {
                            return new IKeyboardEventCachedEntity() { ___guid = entity.___guid };
                        }
                    );
                }
                return __event;
            }
            set
            {
                __event = null;
                EventHorizonBlazorInterop.Set(this.___guid, "event", value);
            }
        }

        public bool skipOnKeyboardObservable
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipOnKeyboardObservable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "skipOnKeyboardObservable", value);
            }
        }
        #endregion

        #region Constructor
        public KeyboardInfoPre()
            : base() { }

        public KeyboardInfoPre(ICachedEntity entity)
            : base(entity) { }

        public KeyboardInfoPre(decimal type, IKeyboardEvent @event)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "KeyboardInfoPre" },
                type,
                @event
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
