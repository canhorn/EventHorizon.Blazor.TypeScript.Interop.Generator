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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ExponentialEase>))]
    public class ExponentialEase : EasingFunction, IEasingFunction
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
        
        public async ValueTask<decimal> get_exponent()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exponent"
                );
        }
        public ValueTask set_exponent(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exponent",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ExponentialEase() : base() { }

        public ExponentialEase(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ExponentialEase> NewExponentialEase(
            System.Nullable<decimal> exponent = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExponentialEase" },
                exponent
            );

            return new ExponentialEase(entity);
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