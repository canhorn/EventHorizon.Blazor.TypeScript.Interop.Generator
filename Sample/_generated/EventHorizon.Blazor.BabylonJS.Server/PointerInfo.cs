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
        public async ValueTask<PickingInfo> get_pickInfo()
        {
            if(__pickInfo == null)
            {
                __pickInfo = await EventHorizonBlazorInterop.GetClass<PickingInfo>(
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
        public ValueTask set_pickInfo(PickingInfo value)
        {
__pickInfo = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickInfo",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PointerInfo() : base() { }

        public PointerInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<PointerInfo> NewPointerInfo(
            decimal type, PointerEvent @event, PickingInfo pickInfo
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfo" },
                type, @event, pickInfo
            );

            return new PointerInfo(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}