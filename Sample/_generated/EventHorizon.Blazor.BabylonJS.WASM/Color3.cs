/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Color3 : CachedEntityObject
    {
        #region Static Accessors
        private static Color3 __BlackReadOnly;
        public static Color3 BlackReadOnly
        {
            get
            {
            if(__BlackReadOnly == null)
            {
                __BlackReadOnly = EventHorizonBlazorInteropt.GetClass<Color3>(
                    "BABYLON",
                    "Color3.BlackReadOnly",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __BlackReadOnly;
            }
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void HSVtoRGBToRef(decimal hue, decimal saturation, decimal value, Color3 result)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "HSVtoRGBToRef" }, hue, saturation, value, result
                }
            );
        }

        public static Color3 FromHexString(string hex)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromHexString" }, hex
                }
            );
        }

        public static Color3 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromArray" }, array, offset
                }
            );
        }

        public static Color3 FromInts(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromInts" }, r, g, b
                }
            );
        }

        public static Color3 Lerp(Color3 start, Color3 end, decimal amount)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Lerp" }, start, end, amount
                }
            );
        }

        public static void LerpToRef(Color3 left, Color3 right, decimal amount, Color3 result)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "LerpToRef" }, left, right, amount, result
                }
            );
        }

        public static Color3 Red()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Red" }
                }
            );
        }

        public static Color3 Green()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Green" }
                }
            );
        }

        public static Color3 Blue()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Blue" }
                }
            );
        }

        public static Color3 Black()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Black" }
                }
            );
        }

        public static Color3 White()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "White" }
                }
            );
        }

        public static Color3 Purple()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Purple" }
                }
            );
        }

        public static Color3 Magenta()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Magenta" }
                }
            );
        }

        public static Color3 Yellow()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Yellow" }
                }
            );
        }

        public static Color3 Gray()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Gray" }
                }
            );
        }

        public static Color3 Teal()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Teal" }
                }
            );
        }

        public static Color3 Random()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Random" }
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal r
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "r"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "r",
                    value
                );
            }
        }

        
        public decimal g
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "g"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "g",
                    value
                );
            }
        }

        
        public decimal b
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Color3() : base() { } 

        public Color3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Color3(
            System.Nullable<decimal> r = null, System.Nullable<decimal> g = null, System.Nullable<decimal> b = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Color3" },
                r, g, b
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public Color3 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public Color4 toColor4(System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color4>(
                entity => new Color4(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toColor4" }, alpha
                }
            );
        }

        public decimal[] asArray()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public decimal toLuminance()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "toLuminance" }
                }
            );
        }

        public Color3 multiply(Color3 otherColor)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, otherColor
                }
            );
        }

        public Color3 multiplyToRef(Color3 otherColor, Color3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherColor, result
                }
            );
        }

        public bool equals(Color3 otherColor)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherColor
                }
            );
        }

        public bool equalsFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsFloats" }, r, g, b
                }
            );
        }

        public Color3 scale(decimal scale)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public Color3 scaleToRef(decimal scale, Color3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public Color3 scaleAndAddToRef(decimal scale, Color3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public Color3 clampToRef(Color3 result, System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clampToRef" }, min, max, result
                }
            );
        }

        public Color3 add(Color3 otherColor)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherColor
                }
            );
        }

        public Color3 addToRef(Color3 otherColor, Color3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, otherColor, result
                }
            );
        }

        public Color3 subtract(Color3 otherColor)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherColor
                }
            );
        }

        public Color3 subtractToRef(Color3 otherColor, Color3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, otherColor, result
                }
            );
        }

        public Color3 clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Color3 copyFrom(Color3 source)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public Color3 copyFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, r, g, b
                }
            );
        }

        public Color3 set(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "set" }, r, g, b
                }
            );
        }

        public string toHexString()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toHexString" }
                }
            );
        }

        public Color3 toLinearSpace()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpace" }
                }
            );
        }

        public Color3 toHSV()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toHSV" }
                }
            );
        }

        public void toHSVToRef(Color3 result)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toHSVToRef" }, result
                }
            );
        }

        public Color3 toLinearSpaceToRef(Color3 convertedColor)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" }, convertedColor
                }
            );
        }

        public Color3 toGammaSpace()
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toGammaSpace" }
                }
            );
        }

        public Color3 toGammaSpaceToRef(Color3 convertedColor)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toGammaSpaceToRef" }, convertedColor
                }
            );
        }
        #endregion
    }
}