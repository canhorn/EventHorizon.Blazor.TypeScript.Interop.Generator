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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EasingFunction>))]
    public class EasingFunction : CachedEntityObject, IEasingFunction
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_EASINGMODE_EASEIN()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEIN"
                );
        }

        
        public static async ValueTask<decimal> get_EASINGMODE_EASEOUT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEOUT"
                );
        }

        
        public static async ValueTask<decimal> get_EASINGMODE_EASEINOUT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "EasingFunction.EASINGMODE_EASEINOUT"
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
        public EasingFunction() : base() { }

        public EasingFunction(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask setEasingMode(decimal easingMode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEasingMode" }, easingMode
                }
            );
        }

        public async ValueTask<decimal> getEasingMode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getEasingMode" }
                }
            );
        }

        public async ValueTask<decimal> easeInCore(decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "easeInCore" }, gradient
                }
            );
        }

        public async ValueTask<decimal> ease(decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "ease" }, gradient
                }
            );
        }
        #endregion
    }
}