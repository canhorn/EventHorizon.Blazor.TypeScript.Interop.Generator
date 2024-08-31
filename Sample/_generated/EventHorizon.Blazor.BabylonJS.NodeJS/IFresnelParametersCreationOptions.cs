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

    [JsonConverter(typeof(CachedEntityConverter<IFresnelParametersCreationOptions>))]
    public class IFresnelParametersCreationOptions : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Color3 __leftColor;
        public static Color3 leftColor
        {
            get
            {
                if (__leftColor == null)
                {
                    __leftColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __leftColor = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.leftColor",
                    value
                );
            }
        }

        private static Color3 __rightColor;
        public static Color3 rightColor
        {
            get
            {
                if (__rightColor == null)
                {
                    __rightColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __rightColor = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.rightColor",
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
                    "IFresnelParametersCreationOptions.bias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.bias",
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
                    "IFresnelParametersCreationOptions.power"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.power",
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
                    "IFresnelParametersCreationOptions.isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "IFresnelParametersCreationOptions.isEnabled",
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
