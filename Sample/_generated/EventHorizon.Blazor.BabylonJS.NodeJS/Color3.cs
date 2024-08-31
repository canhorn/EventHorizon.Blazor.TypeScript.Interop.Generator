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

    [JsonConverter(typeof(CachedEntityConverter<Color3>))]
    public class Color3 : CachedEntityObject, Tensor<_Tuple<T, N, R>, IColor3Like>, IColor3Like
    {
        #region Static Accessors
        private static Color3 __BlackReadOnly;
        public static Color3 BlackReadOnly
        {
            get
            {
                if (__BlackReadOnly == null)
                {
                    __BlackReadOnly = EventHorizonBlazorInterop.GetClass<Color3>(
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
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static T HSVtoRGBToRef<T>(decimal hue, decimal saturation, decimal value, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Color3 FromHSV(decimal hue, decimal saturation, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
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

        public static Color3 FromHexString(string hex)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromHexString" }, hex }
            );
        }

        public static Color3 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromArray" }, array, offset }
            );
        }

        public static void FromArrayToRef(
            decimal[] array,
            Color3 result,
            System.Nullable<decimal> offset = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Color3", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static Color3 FromInts(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "FromInts" }, r, g, b }
            );
        }

        public static Color3 Lerp(Color3 start, Color3 end, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Lerp" }, start, end, amount }
            );
        }

        public static void LerpToRef(Color3 left, Color3 right, decimal amount, Color3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public static Color3 Hermite(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
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

        public static Color3 Hermite1stDerivative(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal time
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
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

        public static void Hermite1stDerivativeToRef(
            Color3 value1,
            Color3 tangent1,
            Color3 value2,
            Color3 tangent2,
            decimal time,
            Color3 result
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public static Color3 Red()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Red" } }
            );
        }

        public static Color3 Green()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Green" } }
            );
        }

        public static Color3 Blue()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Blue" } }
            );
        }

        public static Color3 Black()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Black" } }
            );
        }

        public static Color3 White()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "White" } }
            );
        }

        public static Color3 Purple()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Purple" } }
            );
        }

        public static Color3 Magenta()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Magenta" } }
            );
        }

        public static Color3 Yellow()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Yellow" } }
            );
        }

        public static Color3 Gray()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Gray" } }
            );
        }

        public static Color3 Teal()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Teal" } }
            );
        }

        public static Color3 Random()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Color3", "Random" } }
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
        public Color3()
            : base() { }

        public Color3(ICachedEntity entity)
            : base(entity) { }

        public Color3(
            System.Nullable<decimal> r = null,
            System.Nullable<decimal> g = null,
            System.Nullable<decimal> b = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color3" },
                r,
                g,
                b
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public Color3 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Color3 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public Color4 toColor4(System.Nullable<decimal> alpha = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toColor4" }, alpha }
            );
        }

        public _Tuple<T, N, R> asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public decimal toLuminance()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "toLuminance" } }
            );
        }

        public Color3 multiply(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherColor }
            );
        }

        public T multiplyToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherColor, result }
            );
        }

        public Color3 multiplyInPlace(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherColor }
            );
        }

        public Color3 multiplyByFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, r, g, b }
            );
        }

        public CachedEntityObject divide(IColor3Like _other)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public CachedEntityObject divideToRef(IColor3Like _other, IColor3Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public CachedEntityObject divideInPlace(IColor3Like _other)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public Color3 minimizeInPlace(IColor3Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Color3 maximizeInPlace(IColor3Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Color3 minimizeInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, r, g, b }
            );
        }

        public Color3 maximizeInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, r, g, b }
            );
        }

        public CachedEntityObject floorToRef(IColor3Like _result)
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

        public CachedEntityObject fractToRef(IColor3Like _result)
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

        public bool equals(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherColor }
            );
        }

        public bool equalsFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsFloats" }, r, g, b }
            );
        }

        public bool equalsToFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, r, g, b }
            );
        }

        public bool equalsWithEpsilon(
            IColor3Like otherColor,
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

        public CachedEntityObject negateToRef(IColor3Like _result)
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, _result }
            );
        }

        public Color3 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public Color3 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
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

        public Color3 add(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherColor }
            );
        }

        public Color3 addInPlace(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherColor }
            );
        }

        public Color3 addInPlaceFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, r, g, b }
            );
        }

        public T addToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherColor, result }
            );
        }

        public Color3 subtract(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherColor }
            );
        }

        public T subtractToRef<T>(IColor3Like otherColor, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherColor, result }
            );
        }

        public Color3 subtractInPlace(IColor3Like otherColor)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherColor }
            );
        }

        public Color3 subtractFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, r, g, b }
            );
        }

        public T subtractFromFloatsToRef<T>(decimal r, decimal g, decimal b, T result)
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
                    result
                }
            );
        }

        public Color3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public Color3 copyFrom(IColor3Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public Color3 copyFromFloats(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, r, g, b }
            );
        }

        public Color3 set(decimal r, decimal g, decimal b)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, r, g, b }
            );
        }

        public Color3 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public string toHexString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toHexString" } }
            );
        }

        public Color3 toHSV()
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toHSV" } }
            );
        }

        public T toHSVToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toHSVToRef" }, result }
            );
        }

        public Color3 toLinearSpace(System.Nullable<bool> exact = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toLinearSpace" }, exact }
            );
        }

        public Color3 toLinearSpaceToRef(
            IColor3Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLinearSpaceToRef" },
                    convertedColor,
                    exact
                }
            );
        }

        public Color3 toGammaSpace(System.Nullable<bool> exact = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toGammaSpace" }, exact }
            );
        }

        public Color3 toGammaSpaceToRef(
            IColor3Like convertedColor,
            System.Nullable<bool> exact = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
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
