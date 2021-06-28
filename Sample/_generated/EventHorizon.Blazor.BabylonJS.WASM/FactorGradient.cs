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
        
        public decimal gradient
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradient",
                    value
                );
            }
        }

        
        public decimal factor1
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "factor1"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "factor1",
                    value
                );
            }
        }

        
        public decimal factor2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "factor2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "factor2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FactorGradient() : base() { }

        public FactorGradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FactorGradient(
            decimal gradient, decimal factor1, System.Nullable<decimal> factor2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FactorGradient" },
                gradient, factor1, factor2
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getFactor()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFactor" }
                }
            );
        }
        #endregion
    }
}