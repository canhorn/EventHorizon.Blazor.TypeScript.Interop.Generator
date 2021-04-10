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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BackEase>))]
    public class BackEase : EasingFunction, IEasingFunction
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
        
        public async ValueTask<decimal> get_amplitude()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "amplitude"
                );
        }
        public ValueTask set_amplitude(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "amplitude",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public BackEase() : base() { }

        public BackEase(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<BackEase> NewBackEase(
            System.Nullable<decimal> amplitude = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BackEase" },
                amplitude
            );

            return new BackEase(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> easeInCore(decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "easeInCore" }, gradient
                }
            );
        }
        #endregion
    }
}