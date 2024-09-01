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

        public string[] ids
        {
            get { return EventHorizonBlazorInterop.GetArray<string>(this.___guid, "ids"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ids", value);
            }
        }

        private DynamicFloat32Array __data;
        public DynamicFloat32Array data
        {
            get
            {
                if (__data == null)
                {
                    __data = EventHorizonBlazorInterop.GetClass<DynamicFloat32Array>(
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
            set
            {
                __data = null;
                EventHorizonBlazorInterop.Set(this.___guid, "data", value);
            }
        }

        private DynamicFloat32Array __startingIndices;
        public DynamicFloat32Array startingIndices
        {
            get
            {
                if (__startingIndices == null)
                {
                    __startingIndices = EventHorizonBlazorInterop.GetClass<DynamicFloat32Array>(
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
            set
            {
                __startingIndices = null;
                EventHorizonBlazorInterop.Set(this.___guid, "startingIndices", value);
            }
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
