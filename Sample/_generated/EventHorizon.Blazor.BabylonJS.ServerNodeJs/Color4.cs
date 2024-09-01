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

    [JsonConverter(typeof(CachedEntityConverter<Color4>))]
    public class Color4 : CachedEntityObject, Tensor<_Tuple<T, N, R>, IColor4Like>, IColor4Like
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
                new object[] { new string[] { "BABYLON", "Color4", "FromHexString" }, hex }
            );
        }

        public static async ValueTask<Color4> Lerp(
            IColor4Like left,
            IColor4Like right,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "Lerp" }, left, right, amount }
            );
        }

        public static async ValueTask<T> LerpToRef<T>(
            IColor4Like left,
            IColor4Like right,
            decimal amount,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "LerpToRef" },
                    left,
                    right,
                    amount,
                    result
                }
            );
        }

        public static async ValueTask<Color4> Hermite(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "Hermite" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    amount
                }
            );
        }

        public static async ValueTask<Color4> Hermite1stDerivative(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal time
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "Hermite1stDerivative" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time
                }
            );
        }

        public static async ValueTask Hermite1stDerivativeToRef(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal time,
            IColor4Like result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "Hermite1stDerivativeToRef" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time,
                    result
                }
            );
        }

        public static async ValueTask<Color4> FromColor3(
            IColor3Like color3,
            System.Nullable<decimal> alpha = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromColor3" }, color3, alpha }
            );
        }

        public static async ValueTask<Color4> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromArray" }, array, offset }
            );
        }

        public static async ValueTask FromArrayToRef(
            decimal[] array,
            Color4 result,
            System.Nullable<decimal> offset = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static async ValueTask<Color4> FromInts(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromInts" }, r, g, b, a }
            );
        }

        public static async ValueTask<decimal[]> CheckColors4(decimal[] colors, decimal count)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Color4", "CheckColors4" }, colors, count }
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

        public async ValueTask<decimal> get_a()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "a");
        }

        public ValueTask set_a(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "a", value);
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
        public Color4()
            : base() { }

        public Color4(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Color4> NewColor4(
            System.Nullable<decimal> r = null,
            System.Nullable<decimal> g = null,
            System.Nullable<decimal> b = null,
            System.Nullable<decimal> a = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color4" },
                r,
                g,
                b,
                a
            );

            return new Color4(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<_Tuple<T, N, R>> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<Color4> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Color4> fromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public async ValueTask<bool> equals(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherColor }
            );
        }

        public async ValueTask<Color4> add(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherColor }
            );
        }

        public async ValueTask<T> addToRef<T>(IColor4Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherColor, result }
            );
        }

        public async ValueTask<Color4> addInPlace(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color4> addInPlaceFromFloats(
            decimal r,
            decimal g,
            decimal b,
            decimal a
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, r, g, b, a }
            );
        }

        public async ValueTask<Color4> subtract(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherColor }
            );
        }

        public async ValueTask<T> subtractToRef<T>(IColor4Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherColor, result }
            );
        }

        public async ValueTask<Color4> subtractInPlace(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color4> subtractFromFloats(
            decimal r,
            decimal g,
            decimal b,
            decimal a
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, r, g, b, a }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(
            decimal r,
            decimal g,
            decimal b,
            decimal a,
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
                    a,
                    result
                }
            );
        }

        public async ValueTask<Color4> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public async ValueTask<Color4> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
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

        public async ValueTask<Color4> multiply(IColor4Like color)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, color }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(IColor4Like color, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, color, result }
            );
        }

        public async ValueTask<Color4> multiplyInPlace(IColor4Like otherColor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherColor }
            );
        }

        public async ValueTask<Color4> multiplyByFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, r, g, b, a }
            );
        }

        public async ValueTask<CachedEntityObject> divide(IColor4Like _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public async ValueTask<CachedEntityObject> divideToRef(
            IColor4Like _other,
            IColor4Like _result
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public async ValueTask<CachedEntityObject> divideInPlace(IColor4Like _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public async ValueTask<Color4> minimizeInPlace(IColor4Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Color4> maximizeInPlace(IColor4Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Color4> minimizeInPlaceFromFloats(
            decimal r,
            decimal g,
            decimal b,
            decimal a
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "minimizeInPlaceFromFloats" },
                    r,
                    g,
                    b,
                    a
                }
            );
        }

        public async ValueTask<Color4> maximizeInPlaceFromFloats(
            decimal r,
            decimal g,
            decimal b,
            decimal a
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "maximizeInPlaceFromFloats" },
                    r,
                    g,
                    b,
                    a
                }
            );
        }

        public async ValueTask<CachedEntityObject> floorToRef(IColor4Like _result)
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

        public async ValueTask<CachedEntityObject> fractToRef(IColor4Like _result)
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

        public async ValueTask<CachedEntityObject> negateToRef(IColor4Like _result)
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, _result }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            IColor4Like otherColor,
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

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

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

        public async ValueTask<Color4> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<Color4> copyFrom(IColor4Like source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<Color4> copyFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, r, g, b, a }
            );
        }

        public async ValueTask<Color4> set(decimal r, decimal g, decimal b, decimal a)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, r, g, b, a }
            );
        }

        public async ValueTask<Color4> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public async ValueTask<string> toHexString(System.Nullable<bool> returnAsColor3 = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toHexString" }, returnAsColor3 }
            );
        }

        public async ValueTask<Color4> toLinearSpace(System.Nullable<bool> exact = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toLinearSpace" }, exact }
            );
        }

        public async ValueTask<Color4> toLinearSpaceToRef(
            IColor4Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" },
                    convertedColor,
                    exact
                }
            );
        }

        public async ValueTask<Color4> toGammaSpace(System.Nullable<bool> exact = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toGammaSpace" }, exact }
            );
        }

        public async ValueTask<Color4> toGammaSpaceToRef(
            IColor4Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
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
