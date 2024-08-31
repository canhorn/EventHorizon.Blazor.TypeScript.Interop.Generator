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

    public interface IPerformanceViewerStrategyParameter : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPerformanceViewerStrategyParameterCachedEntity>))]
    public class IPerformanceViewerStrategyParameterCachedEntity
        : CachedEntityObject,
            IPerformanceViewerStrategyParameter
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

        public ActionResultCallback<
            ActionResultCallback<Scene, IPerfViewerCollectionStrategyCachedEntity>
        > strategyCallback
        {
            get
            {
                return EventHorizonBlazorInterop.Get<
                    ActionResultCallback<
                        ActionResultCallback<Scene, IPerfViewerCollectionStrategyCachedEntity>
                    >
                >(this.___guid, "strategyCallback");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "strategyCallback", value);
            }
        }

        public string category
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "category"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "category", value);
            }
        }

        public bool hidden
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hidden"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "hidden", value);
            }
        }
        #endregion

        #region Constructor
        public IPerformanceViewerStrategyParameterCachedEntity()
            : base() { }

        public IPerformanceViewerStrategyParameterCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
