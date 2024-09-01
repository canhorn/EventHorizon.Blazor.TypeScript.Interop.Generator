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

        public async ValueTask<
            ActionResultCallback<
                ActionResultCallback<Scene, IPerfViewerCollectionStrategyCachedEntity>
            >
        > get_strategyCallback()
        {
            return await EventHorizonBlazorInterop.Get<
                ActionResultCallback<
                    ActionResultCallback<Scene, IPerfViewerCollectionStrategyCachedEntity>
                >
            >(this.___guid, "strategyCallback");
        }

        public ValueTask set_strategyCallback(
            ActionResultCallback<
                ActionResultCallback<Scene, IPerfViewerCollectionStrategyCachedEntity>
            > value
        )
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "strategyCallback", value);
        }

        public async ValueTask<string> get_category()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "category");
        }

        public ValueTask set_category(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "category", value);
        }

        public async ValueTask<bool> get_hidden()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "hidden");
        }

        public ValueTask set_hidden(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "hidden", value);
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
