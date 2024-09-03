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

    [JsonConverter(typeof(CachedEntityConverter<ProximityCastResult>))]
    public class ProximityCastResult : CastingResult
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public decimal hitDistance
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "hitDistance"); }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ProximityCastResult()
            : base() { }

        public ProximityCastResult(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void setHitDistance(decimal distance)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHitDistance" }, distance }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
