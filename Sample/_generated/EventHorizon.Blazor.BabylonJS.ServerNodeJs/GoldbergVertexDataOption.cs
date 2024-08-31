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

    [JsonConverter(typeof(CachedEntityConverter<GoldbergVertexDataOption>))]
    public class GoldbergVertexDataOption : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergVertexDataOption.size"
            );
        }

        public static ValueTask set_size(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergVertexDataOption.size", value);
        }

        public static async ValueTask<decimal> get_sizeX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergVertexDataOption.sizeX"
            );
        }

        public static ValueTask set_sizeX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GoldbergVertexDataOption.sizeX",
                value
            );
        }

        public static async ValueTask<decimal> get_sizeY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergVertexDataOption.sizeY"
            );
        }

        public static ValueTask set_sizeY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GoldbergVertexDataOption.sizeY",
                value
            );
        }

        public static async ValueTask<decimal> get_sizeZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergVertexDataOption.sizeZ"
            );
        }

        public static ValueTask set_sizeZ(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GoldbergVertexDataOption.sizeZ",
                value
            );
        }

        public static async ValueTask<decimal> get_sideOrientation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergVertexDataOption.sideOrientation"
            );
        }

        public static ValueTask set_sideOrientation(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GoldbergVertexDataOption.sideOrientation",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public GoldbergVertexDataOption()
            : base() { }

        public GoldbergVertexDataOption(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
