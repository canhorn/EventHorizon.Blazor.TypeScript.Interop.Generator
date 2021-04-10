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

    
    
    [JsonConverter(typeof(CachedEntityConverter<KeyboardInfo>))]
    public class KeyboardInfo : CachedEntityObject
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
        
        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
        }
        public ValueTask set_type(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
        }

        private KeyboardEvent __event;
        public async ValueTask<KeyboardEvent> get_event()
        {
            if(__event == null)
            {
                __event = await EventHorizonBlazorInterop.GetClass<KeyboardEvent>(
                    this.___guid,
                    "event",
                    (entity) =>
                    {
                        return new KeyboardEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __event;
        }
        public ValueTask set_event(KeyboardEvent value)
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
        public KeyboardInfo() : base() { } 

        public KeyboardInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<KeyboardInfo> NewKeyboardInfo(
            decimal type, KeyboardEvent @event
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "KeyboardInfo" },
                type, @event
            );

            return new KeyboardInfo(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}