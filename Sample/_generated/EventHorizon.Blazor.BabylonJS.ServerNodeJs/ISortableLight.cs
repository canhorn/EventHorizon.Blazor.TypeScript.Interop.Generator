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

        public async ValueTask<bool> get_shadowEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "shadowEnabled");
        }

        public ValueTask set_shadowEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowEnabled", value);
        }

        public async ValueTask<decimal> get_renderPriority()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderPriority");
        }

        public ValueTask set_renderPriority(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderPriority", value);
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
