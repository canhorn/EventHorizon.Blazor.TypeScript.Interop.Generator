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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Color4>))]
    public class Color4 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Color4> FromHexString(string hex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "FromHexString" }, hex
                }
            );
        }

        public static async ValueTask<Color4> Lerp(Color4 left, Color4 right, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "Lerp" }, left, right, amount
                }
            );
        }

        public static async ValueTask LerpToRef(Color4 left, Color4 right, decimal amount, Color4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "LerpToRef" }, left, right, amount, result
                }
            );
        }

        public static async ValueTask<Color4> FromColor3(Color3 color3, System.Nullable<decimal> alpha = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "FromColor3" }, color3, alpha
                }
            );
        }

        public static async ValueTask<Color4> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, Color4 result, System.Nullable<decimal> offset = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask<Color4> FromInts(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Color4", "FromInts" }, r, g, b, a
                }
            );
        }

        public static async ValueTask<decimal[]> CheckColors4(decimal[] colors, decimal count)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
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

        
        public async ValueTask<decimal> get_a()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "a"
                );
        }
        public ValueTask set_a(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "a",
                    value
                );
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

        public static async ValueTask<Color4> NewColor4(
            System.Nullable<decimal> r = null, System.Nullable<decimal> g = null, System.Nullable<decimal> b = null, System.Nullable<decimal> a = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color4" },
                r, g, b, a
            );

            return new Color4(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Color4> addInPlace(Color4 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlace" }, right
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

        public async ValueTask<Color4> toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public async ValueTask<Color4> fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fromArray" }, array, offset
                }
            );
        }

        public async ValueTask<bool> equals(Color4 otherColor)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherColor
                }
            );
        }

        public async ValueTask<Color4> add(Color4 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, right
                }
            );
        }

        public async ValueTask<Color4> subtract(Color4 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, right
                }
            );
        }

        public async ValueTask<Color4> subtractToRef(Color4 right, Color4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, right, result
                }
            );
        }

        public async ValueTask<Color4> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Color4> scaleToRef(decimal scale, Color4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Color4> scaleAndAddToRef(decimal scale, Color4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Color4> clampToRef(Color4 result, System.Nullable<decimal> min = null, System.Nullable<decimal> max = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clampToRef" }, min, max, result
                }
            );
        }

        public async ValueTask<Color4> multiply(Color4 color)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, color
                }
            );
        }

        public async ValueTask<Color4> multiplyToRef(Color4 color, Color4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, color, result
                }
            );
        }

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

        public async ValueTask<Color4> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<Color4> copyFrom(Color4 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public async ValueTask<Color4> copyFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, r, g, b, a
                }
            );
        }

        public async ValueTask<Color4> set(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, r, g, b, a
                }
            );
        }

        public async ValueTask<string> toHexString(System.Nullable<bool> returnAsColor3 = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toHexString" }, returnAsColor3
                }
            );
        }

        public async ValueTask<Color4> toLinearSpace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpace" }
                }
            );
        }

        public async ValueTask<Color4> toLinearSpaceToRef(Color4 convertedColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" }, convertedColor
                }
            );
        }

        public async ValueTask<Color4> toGammaSpace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGammaSpace" }
                }
            );
        }

        public async ValueTask<Color4> toGammaSpaceToRef(Color4 convertedColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
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