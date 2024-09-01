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

    [JsonConverter(typeof(CachedEntityConverter<VertexDataMaterialInfo>))]
    public class VertexDataMaterialInfo : CachedEntityObject
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

        public async ValueTask<decimal> get_materialIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "materialIndex");
        }

        public ValueTask set_materialIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "materialIndex", value);
        }

        public async ValueTask<decimal> get_verticesStart()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticesStart");
        }

        public ValueTask set_verticesStart(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "verticesStart", value);
        }

        public async ValueTask<decimal> get_verticesCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticesCount");
        }

        public ValueTask set_verticesCount(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "verticesCount", value);
        }

        public async ValueTask<decimal> get_indexStart()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexStart");
        }

        public ValueTask set_indexStart(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "indexStart", value);
        }

        public async ValueTask<decimal> get_indexCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexCount");
        }

        public ValueTask set_indexCount(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "indexCount", value);
        }
        #endregion

        #region Constructor
        public VertexDataMaterialInfo()
            : base() { }

        public VertexDataMaterialInfo(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
