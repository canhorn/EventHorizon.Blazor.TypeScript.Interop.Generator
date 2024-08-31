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

    public interface IQuaternionLike : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IQuaternionLikeCachedEntity>))]
    public class IQuaternionLikeCachedEntity : CachedEntityObject, IQuaternionLike
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

        public async ValueTask<decimal> get_w()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "w");
        }

        public ValueTask set_w(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "w", value);
        }
        #endregion

        #region Constructor
        public IQuaternionLikeCachedEntity()
            : base() { }

        public IQuaternionLikeCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
