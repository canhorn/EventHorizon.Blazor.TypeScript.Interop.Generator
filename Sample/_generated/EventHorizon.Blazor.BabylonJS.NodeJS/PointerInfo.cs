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
        private PickingInfo __pickInfo;
        public PickingInfo pickInfo
        {
            get
            {
                if (__pickInfo == null)
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
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PointerInfo()
            : base() { }

        public PointerInfo(ICachedEntity entity)
            : base(entity) { }

        public PointerInfo(
            decimal type,
            IMouseEvent @event,
            PickingInfo pickInfo,
            InputManager inputManager = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfo" },
                type,
                @event,
                pickInfo,
                inputManager
            );
            ___guid = entity.___guid;
        }

        public PointerInfo(decimal type, IMouseEvent @event)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfo" },
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
