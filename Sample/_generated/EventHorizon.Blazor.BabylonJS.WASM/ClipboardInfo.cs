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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ClipboardInfo>))]
    public class ClipboardInfo : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static decimal GetTypeFromCharacter(decimal keyCode)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "ClipboardInfo", "GetTypeFromCharacter" }, keyCode
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        private ClipboardEvent __event;
        public ClipboardEvent @event
        {
            get
            {
            if(__event == null)
            {
                __event = EventHorizonBlazorInterop.GetClass<ClipboardEvent>(
                    this.___guid,
                    "event",
                    (entity) =>
                    {
                        return new ClipboardEvent() { ___guid = entity.___guid };
                    }
                );
            }
            return __event;
            }
            set
            {
__event = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "event",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ClipboardInfo() : base() { }

        public ClipboardInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ClipboardInfo(
            decimal type, ClipboardEvent @event
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ClipboardInfo" },
                type, @event
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}