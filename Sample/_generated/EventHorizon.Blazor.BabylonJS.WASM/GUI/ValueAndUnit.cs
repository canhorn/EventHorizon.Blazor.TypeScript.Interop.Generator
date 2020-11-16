/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ValueAndUnit>))]
    public class ValueAndUnit : CachedEntityObject
    {
        #region Static Accessors
        
        public static decimal UNITMODE_PERCENTAGE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.ValueAndUnit.UNITMODE_PERCENTAGE"
                );
            }
        }

        
        public static decimal UNITMODE_PIXEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.ValueAndUnit.UNITMODE_PIXEL"
                );
            }
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool isPercentage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPercentage"
                );
            }
        }

        
        public bool isPixel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPixel"
                );
            }
        }

        
        public decimal internalValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "internalValue"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal unit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "unit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "unit",
                    value
                );
            }
        }

        
        public bool negativeValueAllowed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "negativeValueAllowed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "negativeValueAllowed",
                    value
                );
            }
        }

        
        public bool ignoreAdaptiveScaling
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreAdaptiveScaling"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreAdaptiveScaling",
                    value
                );
            }
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

        public ValueAndUnit(
            decimal value, System.Nullable<decimal> unit = null, System.Nullable<bool> negativeValueAllowed = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "ValueAndUnit" },
                value, unit, negativeValueAllowed
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getValueInPixel(AdvancedDynamicTexture host, decimal refValue)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getValueInPixel" }, host, refValue
                }
            );
        }

        public ValueAndUnit updateInPlace(decimal value, System.Nullable<decimal> unit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateInPlace" }, value, unit
                }
            );
        }

        public decimal getValue(AdvancedDynamicTexture host)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getValue" }, host
                }
            );
        }

        public string toString(AdvancedDynamicTexture host, System.Nullable<decimal> decimals = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, host, decimals
                }
            );
        }

        public bool fromString(string source)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "fromString" }, source
                }
            );
        }
        #endregion
    }
}