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

    [JsonConverter(typeof(CachedEntityConverter<PointerInfoBase>))]
    public class PointerInfoBase : CachedEntityObject
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

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        private IMouseEventCachedEntity __event;
        public IMouseEventCachedEntity @event
        {
            get
            {
                if (__event == null)
                {
                    __event = EventHorizonBlazorInterop.GetClass<IMouseEventCachedEntity>(
                        this.___guid,
                        "event",
                        (entity) =>
                        {
                            return new IMouseEventCachedEntity() { ___guid = entity.___guid };
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
        #endregion

        #region Constructor
        public PointerInfoBase()
            : base() { }

        public PointerInfoBase(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PointerInfoBase(decimal type, IMouseEvent @event)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfoBase" },
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
