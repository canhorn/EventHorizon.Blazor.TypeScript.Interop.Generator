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

    public interface IPerfDatasets : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPerfDatasetsCachedEntity>))]
    public class IPerfDatasetsCachedEntity : CachedEntityObject, IPerfDatasets
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

        public async ValueTask<string[]> get_ids()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(this.___guid, "ids");
        }

        public ValueTask set_ids(string[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "ids", value);
        }

        private DynamicFloat32Array __data;

        public async ValueTask<DynamicFloat32Array> get_data()
        {
            if (__data == null)
            {
                __data = await EventHorizonBlazorInterop.GetClass<DynamicFloat32Array>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new DynamicFloat32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __data;
        }

        public ValueTask set_data(DynamicFloat32Array value)
        {
            __data = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "data", value);
        }

        private DynamicFloat32Array __startingIndices;

        public async ValueTask<DynamicFloat32Array> get_startingIndices()
        {
            if (__startingIndices == null)
            {
                __startingIndices = await EventHorizonBlazorInterop.GetClass<DynamicFloat32Array>(
                    this.___guid,
                    "startingIndices",
                    (entity) =>
                    {
                        return new DynamicFloat32Array() { ___guid = entity.___guid };
                    }
                );
            }
            return __startingIndices;
        }

        public ValueTask set_startingIndices(DynamicFloat32Array value)
        {
            __startingIndices = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "startingIndices", value);
        }
        #endregion

        #region Constructor
        public IPerfDatasetsCachedEntity()
            : base() { }

        public IPerfDatasetsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
