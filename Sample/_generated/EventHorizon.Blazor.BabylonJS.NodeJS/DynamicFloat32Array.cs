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

    [JsonConverter(typeof(CachedEntityConverter<DynamicFloat32Array>))]
    public class DynamicFloat32Array : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public decimal itemLength
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "itemLength"); }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public DynamicFloat32Array()
            : base() { }

        public DynamicFloat32Array(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public DynamicFloat32Array(decimal itemCapacity)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicFloat32Array" },
                itemCapacity
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal at(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "at" }, index }
            );
        }

        public decimal[] subarray(decimal start, decimal end)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "subarray" }, start, end }
            );
        }

        public void push(decimal item)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "push" }, item }
            );
        }
        #endregion
    }
}
