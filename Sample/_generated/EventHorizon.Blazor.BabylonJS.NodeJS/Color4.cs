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
    public class Color4 : CachedEntityObject, Tensor<_Tuple<T, N, R>, IColor4Like>, IColor4Like
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
                new object[] { new string[] { "BABYLON", "Color4", "FromHexString" }, hex }
            );
        }

        public static Color4 Lerp(IColor4Like left, IColor4Like right, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "Lerp" }, left, right, amount }
            );
        }

        public static T LerpToRef<T>(IColor4Like left, IColor4Like right, decimal amount, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Color4 Hermite(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
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

        public static Color4 Hermite1stDerivative(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal time
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
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

        public static void Hermite1stDerivativeToRef(
            IColor4Like value1,
            IColor4Like tangent1,
            IColor4Like value2,
            IColor4Like tangent2,
            decimal time,
            IColor4Like result
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public static Color4 FromColor3(IColor3Like color3, System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromColor3" }, color3, alpha }
            );
        }

        public static Color4 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromArray" }, array, offset }
            );
        }

        public static void FromArrayToRef(
            decimal[] array,
            Color4 result,
            System.Nullable<decimal> offset = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color4", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static Color4 FromInts(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color4", "FromInts" }, r, g, b, a }
            );
        }

        public static decimal[] CheckColors4(decimal[] colors, decimal count)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Color4", "CheckColors4" }, colors, count }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public decimal r
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "r"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "r", value);
            }
        }

        public decimal g
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "g"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "g", value);
            }
        }

        public decimal b
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "b"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "b", value);
            }
        }

        public decimal a
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "a"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "a", value);
            }
        }

        private CachedEntityObject __dimension;
        public CachedEntityObject dimension
        {
            get
            {
                if (__dimension == null)
                {
                    __dimension = EventHorizonBlazorInterop.GetClass<CachedEntityObject>(
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
        }

        public CachedEntity rank
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "rank",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
        #endregion

        #region Constructor
        public Color4()
            : base() { }

        public Color4(ICachedEntity entity)
            : base(entity) { }

        public Color4(
            System.Nullable<decimal> r = null,
            System.Nullable<decimal> g = null,
            System.Nullable<decimal> b = null,
            System.Nullable<decimal> a = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color4" },
                r,
                g,
                b,
                a
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public _Tuple<T, N, R> asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public Color4 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Color4 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public bool equals(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherColor }
            );
        }

        public Color4 add(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherColor }
            );
        }

        public T addToRef<T>(IColor4Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherColor, result }
            );
        }

        public Color4 addInPlace(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherColor }
            );
        }

        public Color4 addInPlaceFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, r, g, b, a }
            );
        }

        public Color4 subtract(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherColor }
            );
        }

        public T subtractToRef<T>(IColor4Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherColor, result }
            );
        }

        public Color4 subtractInPlace(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherColor }
            );
        }

        public Color4 subtractFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, r, g, b, a }
            );
        }

        public T subtractFromFloatsToRef<T>(decimal r, decimal g, decimal b, decimal a, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public Color4 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public Color4 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public T scaleToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleToRef" }, scale, result }
            );
        }

        public T scaleAndAddToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public T clampToRef<T>(
            T result,
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clampToRef" }, min, max, result }
            );
        }

        public Color4 multiply(IColor4Like color)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, color }
            );
        }

        public T multiplyToRef<T>(IColor4Like color, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, color, result }
            );
        }

        public Color4 multiplyInPlace(IColor4Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherColor }
            );
        }

        public Color4 multiplyByFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, r, g, b, a }
            );
        }

        public CachedEntityObject divide(IColor4Like _other)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public CachedEntityObject divideToRef(IColor4Like _other, IColor4Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public CachedEntityObject divideInPlace(IColor4Like _other)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public Color4 minimizeInPlace(IColor4Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Color4 maximizeInPlace(IColor4Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Color4 minimizeInPlaceFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
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

        public Color4 maximizeInPlaceFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
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

        public CachedEntityObject floorToRef(IColor4Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, _result }
            );
        }

        public CachedEntityObject floor()
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public CachedEntityObject fractToRef(IColor4Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, _result }
            );
        }

        public CachedEntityObject fract()
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public CachedEntityObject negate()
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public CachedEntityObject negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public CachedEntityObject negateToRef(IColor4Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, _result }
            );
        }

        public bool equalsWithEpsilon(
            IColor4Like otherColor,
            System.Nullable<decimal> epsilon = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherColor,
                    epsilon
                }
            );
        }

        public bool equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHashCode" } }
            );
        }

        public Color4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public Color4 copyFrom(IColor4Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public Color4 copyFromFloats(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, r, g, b, a }
            );
        }

        public Color4 set(decimal r, decimal g, decimal b, decimal a)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, r, g, b, a }
            );
        }

        public Color4 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public string toHexString(System.Nullable<bool> returnAsColor3 = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toHexString" }, returnAsColor3 }
            );
        }

        public Color4 toLinearSpace(System.Nullable<bool> exact = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toLinearSpace" }, exact }
            );
        }

        public Color4 toLinearSpaceToRef(
            IColor4Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" },
                    convertedColor,
                    exact
                }
            );
        }

        public Color4 toGammaSpace(System.Nullable<bool> exact = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toGammaSpace" }, exact }
            );
        }

        public Color4 toGammaSpaceToRef(
            IColor4Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
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
