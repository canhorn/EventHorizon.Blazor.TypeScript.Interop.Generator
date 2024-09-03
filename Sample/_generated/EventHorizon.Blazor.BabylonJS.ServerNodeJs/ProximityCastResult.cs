/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<decimal> get_hitDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "hitDistance");
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
        public async ValueTask setHitDistance(decimal distance)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHitDistance" }, distance }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
