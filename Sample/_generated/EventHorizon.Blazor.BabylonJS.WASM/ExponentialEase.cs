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
        
        public decimal exponent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exponent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exponent",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ExponentialEase() : base() { }

        public ExponentialEase(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ExponentialEase(
            System.Nullable<decimal> exponent = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExponentialEase" },
                exponent
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal easeInCore(decimal gradient)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "easeInCore" }, gradient
                }
            );
        }
        #endregion
    }
}