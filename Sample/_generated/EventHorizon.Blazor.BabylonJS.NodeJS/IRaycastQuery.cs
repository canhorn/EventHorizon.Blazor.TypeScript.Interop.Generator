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

        public decimal membership
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "membership"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "membership", value);
            }
        }

        public decimal collideWith
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "collideWith"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "collideWith", value);
            }
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
