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

    [JsonConverter(typeof(CachedEntityConverter<PerformanceViewerCollector>))]
    public class PerformanceViewerCollector : CachedEntityObject
    {
        #region Static Accessors

        public static async ValueTask<decimal> get_SliceDataOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PerformanceViewerCollector.SliceDataOffset"
            );
        }

        public static async ValueTask<decimal> get_NumberOfPointsOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PerformanceViewerCollector.NumberOfPointsOffset"
            );
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_hasLoadedData()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasLoadedData");
        }

        public async ValueTask<bool> get_isStarted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStarted");
        }
        #endregion

        #region Properties
        private IPerfDatasetsCachedEntity __datasets;

        public async ValueTask<IPerfDatasetsCachedEntity> get_datasets()
        {
            if (__datasets == null)
            {
                __datasets = await EventHorizonBlazorInterop.GetClass<IPerfDatasetsCachedEntity>(
                    this.___guid,
                    "datasets",
                    (entity) =>
                    {
                        return new IPerfDatasetsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __datasets;
        }

        private Observable<decimal[]> __datasetObservable;

        public async ValueTask<Observable<decimal[]>> get_datasetObservable()
        {
            if (__datasetObservable == null)
            {
                __datasetObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<decimal[]>
                >(
                    this.___guid,
                    "datasetObservable",
                    (entity) =>
                    {
                        return new Observable<decimal[]>() { ___guid = entity.___guid };
                    }
                );
            }
            return __datasetObservable;
        }

        private Observable<CachedEntity> __metadataObservable;

        public async ValueTask<Observable<CachedEntity>> get_metadataObservable()
        {
            if (__metadataObservable == null)
            {
                __metadataObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<CachedEntity>
                >(
                    this.___guid,
                    "metadataObservable",
                    (entity) =>
                    {
                        return new Observable<CachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __metadataObservable;
        }
        #endregion

        #region Constructor
        public PerformanceViewerCollector()
            : base() { }

        public PerformanceViewerCollector(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PerformanceViewerCollector> NewPerformanceViewerCollector(
            Scene _scene,
            IPerformanceViewerStrategyParameter[] _enabledStrategyCallbacks = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PerformanceViewerCollector" },
                _scene,
                _enabledStrategyCallbacks
            );

            return new PerformanceViewerCollector(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<IPerfCustomEventCachedEntity> registerEvent(
            string name,
            System.Nullable<bool> forceUpdate = null,
            string category = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IPerfCustomEventCachedEntity>(
                entity => new IPerfCustomEventCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerEvent" },
                    name,
                    forceUpdate,
                    category
                }
            );
        }

        public async ValueTask sendEvent(IPerfCustomEvent @event)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sendEvent" }, @event }
            );
        }

        public async ValueTask addCollectionStrategies(
            IPerformanceViewerStrategyParameter[] strategyCallbacks
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCollectionStrategies" },
                    strategyCallbacks
                }
            );
        }

        public async ValueTask getCurrentSlice()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getCurrentSlice" } }
            );
        }

        public async ValueTask updateMetadata<T>(string id, T prop, T value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMetadata" }, id, prop, value }
            );
        }

        public async ValueTask clear(System.Nullable<bool> preserveStringEventsRestore = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clear" }, preserveStringEventsRestore }
            );
        }

        public async ValueTask<bool> loadFromFileData(
            string data,
            System.Nullable<bool> keepDatasetMeta = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "loadFromFileData" },
                    data,
                    keepDatasetMeta
                }
            );
        }

        public async ValueTask exportDataToCsv()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exportDataToCsv" } }
            );
        }

        public async ValueTask start(System.Nullable<bool> shouldPreserve = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "start" }, shouldPreserve }
            );
        }

        public async ValueTask stop()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stop" } }
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
