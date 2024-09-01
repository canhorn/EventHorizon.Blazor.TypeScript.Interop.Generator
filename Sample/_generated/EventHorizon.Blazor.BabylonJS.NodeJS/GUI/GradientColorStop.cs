/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<GradientColorStop>))]
    public class GradientColorStop : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal offset
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.GradientColorStop.offset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GUI.GradientColorStop.offset", value);
            }
        }

        public static string color
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "GUI.GradientColorStop.color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GUI.GradientColorStop.color", value);
            }
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
