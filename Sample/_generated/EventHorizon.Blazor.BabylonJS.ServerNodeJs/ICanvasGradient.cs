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

    public interface ICanvasGradient : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ICanvasGradientCachedEntity>))]
    public class ICanvasGradientCachedEntity : CachedEntityObject, ICanvasGradient
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

        #endregion

        #region Constructor
        public ICanvasGradientCachedEntity()
            : base() { }

        public ICanvasGradientCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask addColorStop(decimal offset, string color)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColorStop" }, offset, color }
            );
        }
        #endregion
    }
}
