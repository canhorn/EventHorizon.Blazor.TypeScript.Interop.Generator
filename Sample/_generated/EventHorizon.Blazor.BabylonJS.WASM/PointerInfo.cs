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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointerInfo>))]
    public class PointerInfo : PointerInfoBase
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
        private PickingInfo __pickInfo;
        public PickingInfo pickInfo
        {
            get
            {
            if(__pickInfo == null)
            {
                __pickInfo = EventHorizonBlazorInterop.GetClass<PickingInfo>(
                    this.___guid,
                    "pickInfo",
                    (entity) =>
                    {
                        return new PickingInfo() { ___guid = entity.___guid };
                    }
                );
            }
            return __pickInfo;
            }
            set
            {
__pickInfo = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickInfo",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PointerInfo() : base() { }

        public PointerInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PointerInfo(
            decimal type, PointerEvent @event, PickingInfo pickInfo
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfo" },
                type, @event, pickInfo
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}