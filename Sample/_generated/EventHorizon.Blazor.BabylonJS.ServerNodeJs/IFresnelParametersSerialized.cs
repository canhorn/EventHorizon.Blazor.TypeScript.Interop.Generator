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

    [JsonConverter(typeof(CachedEntityConverter<IFresnelParametersSerialized>))]
    public class IFresnelParametersSerialized : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal[]> get_leftColor()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                "BABYLON",
                "IFresnelParametersSerialized.leftColor"
            );
        }

        public static ValueTask set_leftColor(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersSerialized.leftColor",
                value
            );
        }

        public static async ValueTask<decimal[]> get_rightColor()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                "BABYLON",
                "IFresnelParametersSerialized.rightColor"
            );
        }

        public static ValueTask set_rightColor(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersSerialized.rightColor",
                value
            );
        }

        public static async ValueTask<decimal> get_bias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "IFresnelParametersSerialized.bias"
            );
        }

        public static ValueTask set_bias(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersSerialized.bias",
                value
            );
        }

        public static async ValueTask<decimal> get_power()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "IFresnelParametersSerialized.power"
            );
        }

        public static ValueTask set_power(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersSerialized.power",
                value
            );
        }

        public static async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "IFresnelParametersSerialized.isEnabled"
            );
        }

        public static ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersSerialized.isEnabled",
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
