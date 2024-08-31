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

    [JsonConverter(typeof(CachedEntityConverter<IFresnelParametersCreationOptions>))]
    public class IFresnelParametersCreationOptions : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Color3 __leftColor;

        public static async ValueTask<Color3> get_leftColor()
        {
            if (__leftColor == null)
            {
                __leftColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.leftColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftColor;
        }

        public static ValueTask set_leftColor(Color3 value)
        {
            __leftColor = null;
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersCreationOptions.leftColor",
                value
            );
        }

        private static Color3 __rightColor;

        public static async ValueTask<Color3> get_rightColor()
        {
            if (__rightColor == null)
            {
                __rightColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.rightColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightColor;
        }

        public static ValueTask set_rightColor(Color3 value)
        {
            __rightColor = null;
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersCreationOptions.rightColor",
                value
            );
        }

        public static async ValueTask<decimal> get_bias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "IFresnelParametersCreationOptions.bias"
            );
        }

        public static ValueTask set_bias(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersCreationOptions.bias",
                value
            );
        }

        public static async ValueTask<decimal> get_power()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "IFresnelParametersCreationOptions.power"
            );
        }

        public static ValueTask set_power(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersCreationOptions.power",
                value
            );
        }

        public static async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "IFresnelParametersCreationOptions.isEnabled"
            );
        }

        public static ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "IFresnelParametersCreationOptions.isEnabled",
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
        public IFresnelParametersCreationOptions()
            : base() { }

        public IFresnelParametersCreationOptions(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
