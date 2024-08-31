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

    [JsonConverter(typeof(CachedEntityConverter<GoldbergVertexDataOption>))]
    public class GoldbergVertexDataOption : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal size
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergVertexDataOption.size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergVertexDataOption.size", value);
            }
        }

        public static decimal sizeX
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergVertexDataOption.sizeX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergVertexDataOption.sizeX", value);
            }
        }

        public static decimal sizeY
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergVertexDataOption.sizeY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergVertexDataOption.sizeY", value);
            }
        }

        public static decimal sizeZ
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergVertexDataOption.sizeZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergVertexDataOption.sizeZ", value);
            }
        }

        public static decimal sideOrientation
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergVertexDataOption.sideOrientation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "GoldbergVertexDataOption.sideOrientation",
                    value
                );
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
