/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<FresnelParameters>))]
    public class FresnelParameters : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<FresnelParameters> Parse(CachedEntity parsedFresnelParameters)
        {
            return await EventHorizonBlazorInterop.FuncClass<FresnelParameters>(
                entity => new FresnelParameters() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "FresnelParameters", "Parse" }, parsedFresnelParameters
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
        }
        public ValueTask set_isEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
        }
        #endregion

        #region Properties
        private Color3 __leftColor;
        public async ValueTask<Color3> get_leftColor()
        {
            if(__leftColor == null)
            {
                __leftColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "leftColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftColor;
        }
        public ValueTask set_leftColor(Color3 value)
        {
__leftColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftColor",
                    value
                );
        }

        private Color3 __rightColor;
        public async ValueTask<Color3> get_rightColor()
        {
            if(__rightColor == null)
            {
                __rightColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "rightColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightColor;
        }
        public ValueTask set_rightColor(Color3 value)
        {
__rightColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bias"
                );
        }
        public ValueTask set_bias(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bias",
                    value
                );
        }

        
        public async ValueTask<decimal> get_power()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "power"
                );
        }
        public ValueTask set_power(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "power",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public FresnelParameters() : base() { } 

        public FresnelParameters(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<FresnelParameters> NewFresnelParameters(
            CachedEntity options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FresnelParameters" },
                options
            );

            return new FresnelParameters(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<FresnelParameters> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<FresnelParameters>(
                entity => new FresnelParameters() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<bool> equals(FresnelParameters otherFresnelParameters)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherFresnelParameters
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}