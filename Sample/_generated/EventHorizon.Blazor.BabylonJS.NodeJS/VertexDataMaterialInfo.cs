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

        public decimal materialIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "materialIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "materialIndex", value);
            }
        }

        public decimal verticesStart
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticesStart"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "verticesStart", value);
            }
        }

        public decimal verticesCount
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticesCount"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "verticesCount", value);
            }
        }

        public decimal indexStart
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexStart"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "indexStart", value);
            }
        }

        public decimal indexCount
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexCount"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "indexCount", value);
            }
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
