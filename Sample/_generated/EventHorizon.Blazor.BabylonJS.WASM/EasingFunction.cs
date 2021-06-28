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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EasingFunction>))]
    public class EasingFunction : CachedEntityObject, IEasingFunction
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal EASINGMODE_EASEIN
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEIN"
                );
            }
        }

        
        public static decimal EASINGMODE_EASEOUT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEOUT"
                );
            }
        }

        
        public static decimal EASINGMODE_EASEINOUT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEINOUT"
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
        public EasingFunction() : base() { }

        public EasingFunction(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void setEasingMode(decimal easingMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEasingMode" }, easingMode
                }
            );
        }

        public decimal getEasingMode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getEasingMode" }
                }
            );
        }

        public decimal easeInCore(decimal gradient)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "easeInCore" }, gradient
                }
            );
        }

        public decimal ease(decimal gradient)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "ease" }, gradient
                }
            );
        }
        #endregion
    }
}