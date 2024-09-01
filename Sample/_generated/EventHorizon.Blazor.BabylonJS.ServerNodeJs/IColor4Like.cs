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

    public interface IColor4Like : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IColor4LikeCachedEntity>))]
    public class IColor4LikeCachedEntity : CachedEntityObject, IColor4Like
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

        public async ValueTask<decimal> get_a()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "a");
        }

        public ValueTask set_a(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "a", value);
        }
        #endregion

        #region Constructor
        public IColor4LikeCachedEntity()
            : base() { }

        public IColor4LikeCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
