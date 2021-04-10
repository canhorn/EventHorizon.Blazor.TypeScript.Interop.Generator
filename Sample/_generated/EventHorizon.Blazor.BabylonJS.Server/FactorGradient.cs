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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FactorGradient>))]
    public class FactorGradient : CachedEntityObject, IValueGradient
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
        
        public async ValueTask<decimal> get_gradient()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
        }
        public ValueTask set_gradient(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradient",
                    value
                );
        }

        
        public async ValueTask<decimal> get_factor1()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "factor1"
                );
        }
        public ValueTask set_factor1(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "factor1",
                    value
                );
        }

        
        public async ValueTask<decimal> get_factor2()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "factor2"
                );
        }
        public ValueTask set_factor2(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "factor2",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public FactorGradient() : base() { }

        public FactorGradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<FactorGradient> NewFactorGradient(
            decimal gradient, decimal factor1, System.Nullable<decimal> factor2 = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FactorGradient" },
                gradient, factor1, factor2
            );

            return new FactorGradient(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> getFactor()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFactor" }
                }
            );
        }
        #endregion
    }
}