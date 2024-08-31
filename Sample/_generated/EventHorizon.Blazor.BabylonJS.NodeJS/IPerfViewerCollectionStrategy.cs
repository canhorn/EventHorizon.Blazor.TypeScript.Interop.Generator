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

        public string id
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "id"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "id", value);
            }
        }
        #endregion

        #region Constructor
        public IPerfViewerCollectionStrategyCachedEntity()
            : base() { }

        public IPerfViewerCollectionStrategyCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public decimal getData()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getData" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
