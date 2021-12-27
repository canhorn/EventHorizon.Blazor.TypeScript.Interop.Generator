/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ClipboardInfo>))]
    public class ClipboardInfo : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<decimal> GetTypeFromCharacter(decimal keyCode)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
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

        private ClipboardEvent __event;
        public async ValueTask<ClipboardEvent> get_event()
        {
            if(__event == null)
            {
                __event = await EventHorizonBlazorInterop.GetClass<ClipboardEvent>(
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
        public ValueTask set_event(ClipboardEvent value)
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
        public ClipboardInfo() : base() { } 

        public ClipboardInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<ClipboardInfo> NewClipboardInfo(
            decimal type, ClipboardEvent @event
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ClipboardInfo" },
                type, @event
            );

            return new ClipboardInfo(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}