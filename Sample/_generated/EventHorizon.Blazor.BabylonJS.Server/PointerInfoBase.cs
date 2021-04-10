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
        
        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
        }
        public ValueTask set_type(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
        }

        private PointerEvent __event;
        public async ValueTask<PointerEvent> get_event()
        {
            if(__event == null)
            {
                __event = await EventHorizonBlazorInterop.GetClass<PointerEvent>(
                    this.___guid,
                    "event",
                    (entity) =>
                    {
                        return new PointerEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __event;
        }
        public ValueTask set_event(PointerEvent value)
        {
__event = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "event",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PointerInfoBase() : base() { } 

        public PointerInfoBase(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PointerInfoBase> NewPointerInfoBase(
            decimal type, PointerEvent @event
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfoBase" },
                type, @event
            );

            return new PointerInfoBase(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}