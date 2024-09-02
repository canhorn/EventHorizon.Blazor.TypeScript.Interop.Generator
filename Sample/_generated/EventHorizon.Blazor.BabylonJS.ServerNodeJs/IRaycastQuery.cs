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

    public interface IRaycastQuery : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IRaycastQueryCachedEntity>))]
    public class IRaycastQueryCachedEntity : CachedEntityObject, IRaycastQuery
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

        public async ValueTask<decimal> get_membership()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "membership");
        }

        public ValueTask set_membership(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "membership", value);
        }

        public async ValueTask<decimal> get_collideWith()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "collideWith");
        }

        public ValueTask set_collideWith(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "collideWith", value);
        }
        #endregion

        #region Constructor
        public IRaycastQueryCachedEntity()
            : base() { }

        public IRaycastQueryCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
