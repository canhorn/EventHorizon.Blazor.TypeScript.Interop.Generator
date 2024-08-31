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

    [JsonConverter(typeof(CachedEntityConverter<Color3>))]
    public class Color3 : CachedEntityObject, Tensor<_Tuple<T, N, R>, IColor3Like>, IColor3Like
    {
        #region Static Accessors
        private static Color3 __BlackReadOnly;

        public static async ValueTask<Color3> get_BlackReadOnly()
        {
            if (__BlackReadOnly == null)
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
        public static async ValueTask<T> HSVtoRGBToRef<T>(
            decimal hue,
            decimal saturation,
            decimal value,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "HSVtoRGBToRef" },
                    hue,
                    saturation,
                    value,
                    result
                }
            );
        }

        public static async ValueTask<Color3> FromHSV(
            decimal hue,
            decimal saturation,
            decimal value
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "FromHSV" },
                    hue,
                    saturation,
                    value
                }
            );
        }

        public static async ValueTask<Color3> FromHexString(string hex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromHexString" }, hex }
            );
        }

        public static async ValueTask<Color3> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromArray" }, array, offset }
            );
        }

        public static async ValueTask FromArrayToRef(
            decimal[] array,
            Color3 result,
            System.Nullable<decimal> offset = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static async ValueTask<Color3> FromInts(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromInts" }, r, g, b }
            );
        }

        public static async ValueTask<Color3> Lerp(Color3 start, Color3 end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Lerp" }, start, end, amount }
            );
        }

        public static async ValueTask LerpToRef(
            Color3 left,
            Color3 right,
            decimal amount,
            Color3 result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "LerpToRef" },
                    left,
                    right,
                    amount,
                    result
                }
            );
        }

        public static async ValueTask<Color3> Hermite(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "Hermite" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    amount
                }
            );
        }

        public static async ValueTask<Color3> Hermite1stDerivative(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal time
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "Hermite1stDerivative" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time
                }
            );
        }

        public static async ValueTask Hermite1stDerivativeToRef(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal time,
            Color3 result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "Hermite1stDerivativeToRef" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time,
                    result
                }
            );
        }

        public static async ValueTask<Color3> Red()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Red" } }
            );
        }

        public static async ValueTask<Color3> Green()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Green" } }
            );
        }

        public static async ValueTask<Color3> Blue()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Blue" } }
            );
        }

        public static async ValueTask<Color3> Black()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Black" } }
            );
        }

        public static async ValueTask<Color3> White()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "White" } }
            );
        }

        public static async ValueTask<Color3> Purple()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Purple" } }
            );
        }

        public static async ValueTask<Color3> Magenta()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Magenta" } }
            );
        }

        public static async ValueTask<Color3> Yellow()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Yellow" } }
            );
        }

        public static async ValueTask<Color3> Gray()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Gray" } }
            );
        }

        public static async ValueTask<Color3> Teal()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Teal" } }
            );
        }

        public static async ValueTask<Color3> Random()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Random" } }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<decimal> get_r()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "r");
        }

        public ValueTask set_r(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "r", value);
        }

        public async ValueTask<decimal> get_g()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "g");
        }

        public ValueTask set_g(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "g", value);
        }

        public async ValueTask<decimal> get_b()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "b");
        }

        public ValueTask set_b(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "b", value);
        }

        private CachedEntityObject __dimension;

        public async ValueTask<CachedEntityObject> get_dimension()
        {
            if (__dimension == null)
            {
                __dimension = await EventHorizonBlazorInterop.GetClass<CachedEntityObject>(
                    this.___guid,
                    "dimension",
                    (entity) =>
                    {
                        return new CachedEntityObject() { ___guid = entity.___guid };
                    }
                );
            }
            return __dimension;
        }

        public async ValueTask<CachedEntity> get_rank()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "rank",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }
        #endregion

        #region Constructor
        public Color3()
            : base() { }

        public Color3(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Color3> NewColor3(
            System.Nullable<decimal> r = null,
            System.Nullable<decimal> g = null,
            System.Nullable<decimal> b = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color3" },
                r,
                g,
                b
            );

            return new Color3(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHashCode" } }
            );
        }

        public async ValueTask<Color3> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Color3> fromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public async ValueTask<Color4> toColor4(System.Nullable<decimal> alpha = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toColor4" }, alpha }
            );
        }

        public async ValueTask<_Tuple<T, N, R>> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<decimal> toLuminance()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "toLuminance" } }
            );
        }

        public async ValueTask<Color3> multiply(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherColor }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherColor, result }
            );
        }

        public async ValueTask<Color3> multiplyInPlace(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color3> multiplyByFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, r, g, b }
            );
        }

        public async ValueTask<CachedEntityObject> divide(IColor3Like _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public async ValueTask<CachedEntityObject> divideToRef(
            IColor3Like _other,
            IColor3Like _result
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public async ValueTask<CachedEntityObject> divideInPlace(IColor3Like _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public async ValueTask<Color3> minimizeInPlace(IColor3Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Color3> maximizeInPlace(IColor3Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Color3> minimizeInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, r, g, b }
            );
        }

        public async ValueTask<Color3> maximizeInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, r, g, b }
            );
        }

        public async ValueTask<CachedEntityObject> floorToRef(IColor3Like _result)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, _result }
            );
        }

        public async ValueTask<CachedEntityObject> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public async ValueTask<CachedEntityObject> fractToRef(IColor3Like _result)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, _result }
            );
        }

        public async ValueTask<CachedEntityObject> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public async ValueTask<bool> equals(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherColor }
            );
        }

        public async ValueTask<bool> equalsFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsFloats" }, r, g, b }
            );
        }

        public async ValueTask<bool> equalsToFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, r, g, b }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            IColor3Like otherColor,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherColor,
                    epsilon
                }
            );
        }

        public async ValueTask<CachedEntityObject> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<CachedEntityObject> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public async ValueTask<CachedEntityObject> negateToRef(IColor3Like _result)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, _result }
            );
        }

        public async ValueTask<Color3> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public async ValueTask<Color3> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<T> scaleToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleToRef" }, scale, result }
            );
        }

        public async ValueTask<T> scaleAndAddToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public async ValueTask<T> clampToRef<T>(
            T result,
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clampToRef" }, min, max, result }
            );
        }

        public async ValueTask<Color3> add(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherColor }
            );
        }

        public async ValueTask<Color3> addInPlace(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color3> addInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, r, g, b }
            );
        }

        public async ValueTask<T> addToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherColor, result }
            );
        }

        public async ValueTask<Color3> subtract(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherColor }
            );
        }

        public async ValueTask<T> subtractToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherColor, result }
            );
        }

        public async ValueTask<Color3> subtractInPlace(IColor3Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color3> subtractFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, r, g, b }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(
            decimal r,
            decimal g,
            decimal b,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" },
                    r,
                    g,
                    b,
                    result
                }
            );
        }

        public async ValueTask<Color3> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<Color3> copyFrom(IColor3Like source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<Color3> copyFromFloats(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, r, g, b }
            );
        }

        public async ValueTask<Color3> set(decimal r, decimal g, decimal b)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, r, g, b }
            );
        }

        public async ValueTask<Color3> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public async ValueTask<string> toHexString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toHexString" } }
            );
        }

        public async ValueTask<Color3> toHSV()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toHSV" } }
            );
        }

        public async ValueTask<T> toHSVToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toHSVToRef" }, result }
            );
        }

        public async ValueTask<Color3> toLinearSpace(System.Nullable<bool> exact = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toLinearSpace" }, exact }
            );
        }

        public async ValueTask<Color3> toLinearSpaceToRef(
            IColor3Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" },
                    convertedColor,
                    exact
                }
            );
        }

        public async ValueTask<Color3> toGammaSpace(System.Nullable<bool> exact = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toGammaSpace" }, exact }
            );
        }

        public async ValueTask<Color3> toGammaSpaceToRef(
            IColor3Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGammaSpaceToRef" },
                    convertedColor,
                    exact
                }
            );
        }
        #endregion
    }
}
