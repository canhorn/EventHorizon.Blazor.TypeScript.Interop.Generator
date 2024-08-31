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

    public interface ISortableLight : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ISortableLightCachedEntity>))]
    public class ISortableLightCachedEntity : CachedEntityObject, ISortableLight
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

        public bool shadowEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "shadowEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowEnabled", value);
            }
        }

        public decimal renderPriority
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderPriority"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderPriority", value);
            }
        }
        #endregion

        #region Constructor
        public ISortableLightCachedEntity()
            : base() { }

        public ISortableLightCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
