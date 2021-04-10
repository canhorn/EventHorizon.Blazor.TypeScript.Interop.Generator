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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointerEventTypes>))]
    public class PointerEventTypes : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_POINTERDOWN()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERDOWN"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERUP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERUP"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERMOVE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERMOVE"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERWHEEL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERWHEEL"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERPICK()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERPICK"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERTAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERTAP"
                );
        }

        
        public static async ValueTask<decimal> get_POINTERDOUBLETAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERDOUBLETAP"
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public PointerEventTypes() : base() { } 

        public PointerEventTypes(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}