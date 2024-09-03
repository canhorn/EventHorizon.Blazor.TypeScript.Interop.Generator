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

    [JsonConverter(typeof(CachedEntityConverter<ShapeCastResult>))]
    public class ShapeCastResult : CastingResult
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<decimal> get_hitFraction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "hitFraction");
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ShapeCastResult()
            : base() { }

        public ShapeCastResult(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask setHitFraction(decimal fraction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setHitFraction" }, fraction }
            );
        }
        #endregion
    }
}
