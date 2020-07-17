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
            get
            {
            return EventHorizonBlazorInteropt.Get<int>(
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

        private MouseWheelEvent __event;
        public MouseWheelEvent @event
        {
            get
            {
            if(__event == null)
            {
                __event = EventHorizonBlazorInteropt.GetClass<MouseWheelEvent>(
                    this.___guid,
                    "event",
                    (entity) =>
                    {
                        return new MouseWheelEvent(entity);
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
        public PointerInfoBase() : base() { } 

        public PointerInfoBase(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PointerInfoBase(
            decimal type, object @event
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "PointerInfoBase" },
                type, @event
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}