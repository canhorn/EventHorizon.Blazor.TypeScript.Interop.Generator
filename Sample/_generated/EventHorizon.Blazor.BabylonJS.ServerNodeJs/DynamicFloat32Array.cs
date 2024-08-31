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

        public async ValueTask<decimal> get_itemLength()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "itemLength");
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

        public static async ValueTask<DynamicFloat32Array> NewDynamicFloat32Array(
            decimal itemCapacity
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicFloat32Array" },
                itemCapacity
            );

            return new DynamicFloat32Array(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> at(decimal index)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "at" }, index }
            );
        }

        public async ValueTask<decimal[]> subarray(decimal start, decimal end)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "subarray" }, start, end }
            );
        }

        public async ValueTask push(decimal item)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "push" }, item }
            );
        }
        #endregion
    }
}
