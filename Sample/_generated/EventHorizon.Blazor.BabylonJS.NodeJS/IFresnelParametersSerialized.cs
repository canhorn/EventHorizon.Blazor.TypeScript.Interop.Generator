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

    [JsonConverter(typeof(CachedEntityConverter<IFresnelParametersSerialized>))]
    public class IFresnelParametersSerialized : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal[] leftColor
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(
                    "BABYLON",
                    "IFresnelParametersSerialized.leftColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersSerialized.leftColor",
                    value
                );
            }
        }

        public static decimal[] rightColor
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(
                    "BABYLON",
                    "IFresnelParametersSerialized.rightColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersSerialized.rightColor",
                    value
                );
            }
        }

        public static decimal bias
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "IFresnelParametersSerialized.bias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersSerialized.bias",
                    value
                );
            }
        }

        public static decimal power
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "IFresnelParametersSerialized.power"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersSerialized.power",
                    value
                );
            }
        }

        public static bool isEnabled
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "IFresnelParametersSerialized.isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersSerialized.isEnabled",
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
        public IFresnelParametersSerialized()
            : base() { }

        public IFresnelParametersSerialized(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
