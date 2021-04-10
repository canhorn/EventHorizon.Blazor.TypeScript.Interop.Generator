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

        
        public async ValueTask<bool> get_skipOnPointerObservable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipOnPointerObservable"
                );
        }
        public ValueTask set_skipOnPointerObservable(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipOnPointerObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public KeyboardInfoPre() : base() { }

        public KeyboardInfoPre(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<KeyboardInfoPre> NewKeyboardInfoPre(
            decimal type, KeyboardEvent @event
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "KeyboardInfoPre" },
                type, @event
            );

            return new KeyboardInfoPre(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}