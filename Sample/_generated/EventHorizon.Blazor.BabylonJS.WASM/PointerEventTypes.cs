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
    public class PointerEventTypes : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal POINTERDOWN
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERDOWN"
                );
            }
        }

        
        public static decimal POINTERUP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERUP"
                );
            }
        }

        
        public static decimal POINTERMOVE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERMOVE"
                );
            }
        }

        
        public static decimal POINTERWHEEL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERWHEEL"
                );
            }
        }

        
        public static decimal POINTERPICK
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERPICK"
                );
            }
        }

        
        public static decimal POINTERTAP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERTAP"
                );
            }
        }

        
        public static decimal POINTERDOUBLETAP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "PointerEventTypes.POINTERDOUBLETAP"
                );
            }
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