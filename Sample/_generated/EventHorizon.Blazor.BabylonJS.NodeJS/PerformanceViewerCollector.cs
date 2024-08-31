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

    [JsonConverter(typeof(CachedEntityConverter<PerformanceViewerCollector>))]
    public class PerformanceViewerCollector : CachedEntityObject
    {
        #region Static Accessors

        public static decimal SliceDataOffset
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PerformanceViewerCollector.SliceDataOffset"
                );
            }
        }

        public static decimal NumberOfPointsOffset
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PerformanceViewerCollector.NumberOfPointsOffset"
                );
            }
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool hasLoadedData
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasLoadedData"); }
        }

        public bool isStarted
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStarted"); }
        }
        #endregion

        #region Properties
        private IPerfDatasetsCachedEntity __datasets;
        public IPerfDatasetsCachedEntity datasets
        {
            get
            {
                if (__datasets == null)
                {
                    __datasets = EventHorizonBlazorInterop.GetClass<IPerfDatasetsCachedEntity>(
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
        }

        private Observable<decimal[]> __datasetObservable;
        public Observable<decimal[]> datasetObservable
        {
            get
            {
                if (__datasetObservable == null)
                {
                    __datasetObservable = EventHorizonBlazorInterop.GetClass<Observable<decimal[]>>(
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
        }

        private Observable<CachedEntity> __metadataObservable;
        public Observable<CachedEntity> metadataObservable
        {
            get
            {
                if (__metadataObservable == null)
                {
                    __metadataObservable = EventHorizonBlazorInterop.GetClass<
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

        public PerformanceViewerCollector(
            Scene _scene,
            IPerformanceViewerStrategyParameter[] _enabledStrategyCallbacks = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PerformanceViewerCollector" },
                _scene,
                _enabledStrategyCallbacks
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public IPerfCustomEventCachedEntity registerEvent(
            string name,
            System.Nullable<bool> forceUpdate = null,
            string category = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IPerfCustomEventCachedEntity>(
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

        public void sendEvent(IPerfCustomEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sendEvent" }, @event }
            );
        }

        public void addCollectionStrategies(IPerformanceViewerStrategyParameter[] strategyCallbacks)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCollectionStrategies" },
                    strategyCallbacks
                }
            );
        }

        public void getCurrentSlice()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getCurrentSlice" } }
            );
        }

        public void updateMetadata<T>(string id, T prop, T value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMetadata" }, id, prop, value }
            );
        }

        public void clear(System.Nullable<bool> preserveStringEventsRestore = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clear" }, preserveStringEventsRestore }
            );
        }

        public bool loadFromFileData(string data, System.Nullable<bool> keepDatasetMeta = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "loadFromFileData" },
                    data,
                    keepDatasetMeta
                }
            );
        }

        public void exportDataToCsv()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "exportDataToCsv" } }
            );
        }

        public void start(System.Nullable<bool> shouldPreserve = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "start" }, shouldPreserve }
            );
        }

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stop" } }
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
