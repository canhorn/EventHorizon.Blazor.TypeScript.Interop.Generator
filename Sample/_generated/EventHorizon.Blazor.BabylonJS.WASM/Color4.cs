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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Color4>))]
    public class Color4 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Color4 FromHexString(string hex)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromHexString" }, hex
                }
            );
        }

        public static Color4 Lerp(Color4 left, Color4 right, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "Lerp" }, left, right, amount
                }
            );
        }

        public static void LerpToRef(Color4 left, Color4 right, decimal amount, Color4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "LerpToRef" }, left, right, amount, result
                }
            );
        }

        public static Color4 FromColor3(Color3 color3, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromColor3" }, color3, alpha
                }
            );
        }

        public static Color4 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromArray" }, array, offset
                }
            );
        }

        public static void FromArrayToRef(decimal[] array, Color4 result, System.Nullable<decimal> offset = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static Color4 FromInts(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromInts" }, r, g, b, a
                }
            );
        }

        public static decimal[] CheckColors4(decimal[] colors, decimal count)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "CheckColors4" }, colors, count
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "r"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "g"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
            }
        }

        
        public decimal a
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Color4() : base() { }

        public Color4(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Color4(
            System.Nullable<decimal> r = null, System.Nullable<decimal> g = null, System.Nullable<decimal> b = null, System.Nullable<decimal> a = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color4" },
                r, g, b, a
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Color4 addInPlace(Color4 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addInPlace" }, right
                }
            );
        }

        public decimal[] asArray()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public Color4 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public Color4 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public bool equals(Color4 otherColor)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, otherColor
                }
            );
        }

        public Color4 add(Color4 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, right
                }
            );
        }

        public Color4 subtract(Color4 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, right
                }
            );
        }

        public Color4 subtractToRef(Color4 right, Color4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractToRef" }, right, result
                }
            );
        }

        public Color4 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public Color4 scaleToRef(decimal scale, Color4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public Color4 scaleAndAddToRef(decimal scale, Color4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public Color4 clampToRef(Color4 result, System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clampToRef" }, min, max, result
                }
            );
        }

        public Color4 multiply(Color4 color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, color
                }
            );
        }

        public Color4 multiplyToRef(Color4 color, Color4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToRef" }, color, result
                }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public Color4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Color4 copyFrom(Color4 source)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public Color4 copyFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" }, r, g, b, a
                }
            );
        }

        public Color4 set(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, r, g, b, a
                }
            );
        }

        public string toHexString(System.Nullable<bool> returnAsColor3 = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toHexString" }, returnAsColor3
                }
            );
        }

        public Color4 toLinearSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpace" }
                }
            );
        }

        public Color4 toLinearSpaceToRef(Color4 convertedColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" }, convertedColor
                }
            );
        }

        public Color4 toGammaSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGammaSpace" }
                }
            );
        }

        public Color4 toGammaSpaceToRef(Color4 convertedColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGammaSpaceToRef" }, convertedColor
                }
            );
        }
        #endregion
    }
}