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
        
        public decimal amplitude
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "amplitude"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "amplitude",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public BackEase() : base() { }

        public BackEase(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BackEase(
            System.Nullable<decimal> amplitude = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BackEase" },
                amplitude
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