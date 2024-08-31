/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<GradientColorStop>))]
    public class GradientColorStop : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_offset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.GradientColorStop.offset"
            );
        }

        public static ValueTask set_offset(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GUI.GradientColorStop.offset", value);
        }

        public static async ValueTask<string> get_color()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "GUI.GradientColorStop.color"
            );
        }

        public static ValueTask set_color(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GUI.GradientColorStop.color", value);
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public GradientColorStop()
            : base() { }

        public GradientColorStop(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
