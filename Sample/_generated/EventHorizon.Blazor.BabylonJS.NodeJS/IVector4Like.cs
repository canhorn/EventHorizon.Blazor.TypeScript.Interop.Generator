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

    public interface IVector4Like : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IVector4LikeCachedEntity>))]
    public class IVector4LikeCachedEntity : CachedEntityObject, IVector4Like
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

        public decimal w
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "w"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "w", value);
            }
        }
        #endregion

        #region Constructor
        public IVector4LikeCachedEntity()
            : base() { }

        public IVector4LikeCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
