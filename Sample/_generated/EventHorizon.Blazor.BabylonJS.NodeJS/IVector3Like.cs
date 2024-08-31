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

    public interface IVector3Like : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IVector3LikeCachedEntity>))]
    public class IVector3LikeCachedEntity : CachedEntityObject, IVector3Like
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

        public decimal z
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "z"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "z", value);
            }
        }
        #endregion

        #region Constructor
        public IVector3LikeCachedEntity()
            : base() { }

        public IVector3LikeCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
