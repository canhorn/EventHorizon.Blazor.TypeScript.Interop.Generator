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
        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private KeyboardEvent __event;
        public KeyboardEvent @event
        {
            get
            {
            if(__event == null)
            {
                __event = EventHorizonBlazorInteropt.GetClass<KeyboardEvent>(
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
            set
            {
__event = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "event",
                    value
                );
            }
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

        public KeyboardInfo(
            decimal type, KeyboardEvent @event
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "KeyboardInfo" },
                type, @event
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}