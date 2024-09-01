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

    public interface IPerfViewerCollectionStrategy : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPerfViewerCollectionStrategyCachedEntity>))]
    public class IPerfViewerCollectionStrategyCachedEntity
        : CachedEntityObject,
            IPerfViewerCollectionStrategy
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

        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "id");
        }

        public ValueTask set_id(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "id", value);
        }
        #endregion

        #region Constructor
        public IPerfViewerCollectionStrategyCachedEntity()
            : base() { }

        public IPerfViewerCollectionStrategyCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<decimal> getData()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getData" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
