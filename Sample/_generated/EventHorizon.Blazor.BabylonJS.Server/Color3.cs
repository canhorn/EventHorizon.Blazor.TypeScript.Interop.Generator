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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Color3>))]
    public class Color3 : CachedEntityObject
    {
        #region Static Accessors
        private static Color3 __BlackReadOnly;
        public static async ValueTask<Color3> get_BlackReadOnly()
        {
            if(__BlackReadOnly == null)
            {
                __BlackReadOnly = await EventHorizonBlazorInterop.GetClass<Color3>(
                    "BABYLON",
                    "Color3.BlackReadOnly",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __BlackReadOnly;
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask HSVtoRGBToRef(decimal hue, decimal saturation, decimal value, Color3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "HSVtoRGBToRef" }, hue, saturation, value, result
                }
            );
        }

        public static async ValueTask<Color3> FromHexString(string hex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromHexString" }, hex
                }
            );
        }

        public static async ValueTask<Color3> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, Color3 result, System.Nullable<decimal> offset = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask<Color3> FromInts(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "FromInts" }, r, g, b
                }
            );
        }

        public static async ValueTask<Color3> Lerp(Color3 start, Color3 end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Lerp" }, start, end, amount
                }
            );
        }

        public static async ValueTask LerpToRef(Color3 left, Color3 right, decimal amount, Color3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "LerpToRef" }, left, right, amount, result
                }
            );
        }

        public static async ValueTask<Color3> Red()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Red" }
                }
            );
        }

        public static async ValueTask<Color3> Green()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Green" }
                }
            );
        }

        public static async ValueTask<Color3> Blue()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Blue" }
                }
            );
        }

        public static async ValueTask<Color3> Black()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Black" }
                }
            );
        }

        public static async ValueTask<Color3> White()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "White" }
                }
            );
        }

        public static async ValueTask<Color3> Purple()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Purple" }
                }
            );
        }

        public static async ValueTask<Color3> Magenta()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Magenta" }
                }
            );
        }

        public static async ValueTask<Color3> Yellow()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Yellow" }
                }
            );
        }

        public static async ValueTask<Color3> Gray()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Gray" }
                }
            );
        }

        public static async ValueTask<Color3> Teal()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color3", "Teal" }
                }
            );
        }

        public static async ValueTask<Color3> Random()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
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
        
        public async ValueTask<decimal> get_r()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "r"
                );
        }
        public ValueTask set_r(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "r",
                    value
                );
        }

        
        public async ValueTask<decimal> get_g()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "g"
                );
        }
        public ValueTask set_g(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "g",
                    value
                );
        }

        
        public async ValueTask<decimal> get_b()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
        }
        public ValueTask set_b(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
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

        public static async ValueTask<Color3> NewColor3(
            System.Nullable<decimal> r = null, System.Nullable<decimal> g = null, System.Nullable<decimal> b = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color3" },
                r, g, b
            );

            return new Color3(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public async ValueTask<Color3> toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public async ValueTask<Color3> fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public async ValueTask<Color4> toColor4(System.Nullable<decimal> alpha = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toColor4" }, alpha
                }
            );
        }

        public async ValueTask<decimal[]> asArray()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public async ValueTask<decimal> toLuminance()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "toLuminance" }
                }
            );
        }

        public async ValueTask<Color3> multiply(Color3 otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, otherColor
                }
            );
        }

        public async ValueTask<Color3> multiplyToRef(Color3 otherColor, Color3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherColor, result
                }
            );
        }

        public async ValueTask<bool> equals(Color3 otherColor)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherColor
                }
            );
        }

        public async ValueTask<bool> equalsFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsFloats" }, r, g, b
                }
            );
        }

        public async ValueTask<Color3> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Color3> scaleToRef(decimal scale, Color3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Color3> scaleAndAddToRef(decimal scale, Color3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Color3> clampToRef(Color3 result, System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clampToRef" }, min, max, result
                }
            );
        }

        public async ValueTask<Color3> add(Color3 otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherColor
                }
            );
        }

        public async ValueTask<Color3> addToRef(Color3 otherColor, Color3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, otherColor, result
                }
            );
        }

        public async ValueTask<Color3> subtract(Color3 otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherColor
                }
            );
        }

        public async ValueTask<Color3> subtractToRef(Color3 otherColor, Color3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, otherColor, result
                }
            );
        }

        public async ValueTask<Color3> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<Color3> copyFrom(Color3 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public async ValueTask<Color3> copyFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, r, g, b
                }
            );
        }

        public async ValueTask<Color3> set(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, r, g, b
                }
            );
        }

        public async ValueTask<string> toHexString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toHexString" }
                }
            );
        }

        public async ValueTask<Color3> toLinearSpace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpace" }
                }
            );
        }

        public async ValueTask<Color3> toHSV()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toHSV" }
                }
            );
        }

        public async ValueTask toHSVToRef(Color3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toHSVToRef" }, result
                }
            );
        }

        public async ValueTask<Color3> toLinearSpaceToRef(Color3 convertedColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" }, convertedColor
                }
            );
        }

        public async ValueTask<Color3> toGammaSpace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGammaSpace" }
                }
            );
        }

        public async ValueTask<Color3> toGammaSpaceToRef(Color3 convertedColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGammaSpaceToRef" }, convertedColor
                }
            );
        }
        #endregion
    }
}