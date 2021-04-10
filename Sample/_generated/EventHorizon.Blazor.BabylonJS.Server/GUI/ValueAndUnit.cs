/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ValueAndUnit>))]
    public class ValueAndUnit : CachedEntityObject
    {
        #region Static Accessors
        
        public static async ValueTask<decimal> get_UNITMODE_PERCENTAGE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.ValueAndUnit.UNITMODE_PERCENTAGE"
                );
        }

        
        public static async ValueTask<decimal> get_UNITMODE_PIXEL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.ValueAndUnit.UNITMODE_PIXEL"
                );
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isPercentage()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPercentage"
                );
        }

        
        public async ValueTask<bool> get_isPixel()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPixel"
                );
        }

        
        public async ValueTask<decimal> get_internalValue()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "internalValue"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_unit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "unit"
                );
        }
        public ValueTask set_unit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "unit",
                    value
                );
        }

        
        public async ValueTask<bool> get_negativeValueAllowed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "negativeValueAllowed"
                );
        }
        public ValueTask set_negativeValueAllowed(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "negativeValueAllowed",
                    value
                );
        }

        
        public async ValueTask<bool> get_ignoreAdaptiveScaling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreAdaptiveScaling"
                );
        }
        public ValueTask set_ignoreAdaptiveScaling(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreAdaptiveScaling",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ValueAndUnit() : base() { } 

        public ValueAndUnit(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<ValueAndUnit> NewValueAndUnit(
            decimal value, System.Nullable<decimal> unit = null, System.Nullable<bool> negativeValueAllowed = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "ValueAndUnit" },
                value, unit, negativeValueAllowed
            );

            return new ValueAndUnit(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> getValueInPixel(AdvancedDynamicTexture host, decimal refValue)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getValueInPixel" }, host, refValue
                }
            );
        }

        public async ValueTask<ValueAndUnit> updateInPlace(decimal value, System.Nullable<decimal> unit = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateInPlace" }, value, unit
                }
            );
        }

        public async ValueTask<decimal> getValue(AdvancedDynamicTexture host)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getValue" }, host
                }
            );
        }

        public async ValueTask<string> toString(AdvancedDynamicTexture host, System.Nullable<decimal> decimals = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, host, decimals
                }
            );
        }

        public async ValueTask<bool> fromString(string source)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "fromString" }, source
                }
            );
        }
        #endregion
    }
}