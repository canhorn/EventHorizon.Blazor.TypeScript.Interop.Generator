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

    [JsonConverter(typeof(CachedEntityConverter<Vector2>))]
    public class Vector2 : CachedEntityObject, Vector<_Tuple<T, N, R>, IVector2Like>, IVector2Like
    {
        #region Static Accessors
        private static Vector2 __ZeroReadOnly;
        public static Vector2 ZeroReadOnly
        {
            get
            {
                if (__ZeroReadOnly == null)
                {
                    __ZeroReadOnly = EventHorizonBlazorInterop.GetClass<Vector2>(
                        "BABYLON",
                        "Vector2.ZeroReadOnly",
                        (entity) =>
                        {
                            return new Vector2() { ___guid = entity.___guid };
                        }
                    );
                }
                return __ZeroReadOnly;
            }
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Vector2 Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Zero" } }
            );
        }

        public static Vector2 One()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "One" } }
            );
        }

        public static Vector2 Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Random" }, min, max }
            );
        }

        public static T RandomToRef<T>(
            T @ref,
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static Vector2 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "FromArray" }, array, offset }
            );
        }

        public static T FromArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static T FromFloatsToRef<T>(decimal x, decimal y, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "FromFloatsToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public static Vector2 CatmullRom(
            IVector2Like value1,
            IVector2Like value2,
            IVector2Like value3,
            IVector2Like value4,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "CatmullRom" },
                    value1,
                    value2,
                    value3,
                    value4,
                    amount
                }
            );
        }

        public static T ClampToRef<T>(
            IVector2Like value,
            IVector2Like min,
            IVector2Like max,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "ClampToRef" },
                    value,
                    min,
                    max,
                    @ref
                }
            );
        }

        public static Vector2 Clamp(IVector2Like value, IVector2Like min, IVector2Like max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Clamp" }, value, min, max }
            );
        }

        public static Vector2 Hermite(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "Hermite" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    amount
                }
            );
        }

        public static Vector2 Hermite1stDerivative(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal time
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "Hermite1stDerivative" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time
                }
            );
        }

        public static T Hermite1stDerivativeToRef<T>(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "Hermite1stDerivativeToRef" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time,
                    result
                }
            );
        }

        public static Vector2 Lerp(IVector2Like start, IVector2Like end, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Lerp" }, start, end, amount }
            );
        }

        public static Vector2 LerpToRef(
            IVector2Like start,
            IVector2Like end,
            decimal amount,
            Vector2 result
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "LerpToRef" },
                    start,
                    end,
                    amount,
                    result
                }
            );
        }

        public static decimal Dot(IVector2Like left, IVector2Like right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector2", "Dot" }, left, right }
            );
        }

        public static Vector2 Normalize(Vector2 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Normalize" }, vector }
            );
        }

        public static T NormalizeToRef<T>(Vector2 vector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static Vector2 Minimize(IVector2Like left, IVector2Like right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Minimize" }, left, right }
            );
        }

        public static Vector2 Maximize(IVector2Like left, IVector2Like right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Maximize" }, left, right }
            );
        }

        public static Vector2 Transform(IVector2Like vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "Transform" },
                    vector,
                    transformation
                }
            );
        }

        public static T TransformToRef<T>(IVector2Like vector, Matrix transformation, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "TransformToRef" },
                    vector,
                    transformation,
                    result
                }
            );
        }

        public static bool PointInTriangle(
            IVector2Like p,
            IVector2Like p0,
            IVector2Like p1,
            IVector2Like p2
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "PointInTriangle" },
                    p,
                    p0,
                    p1,
                    p2
                }
            );
        }

        public static decimal Distance(IVector2Like value1, IVector2Like value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector2", "Distance" }, value1, value2 }
            );
        }

        public static decimal DistanceSquared(IVector2Like value1, IVector2Like value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static Vector2 Center(IVector2Like value1, IVector2Like value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Center" }, value1, value2 }
            );
        }

        public static T CenterToRef<T>(IVector2Like value1, IVector2Like value2, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "CenterToRef" },
                    value1,
                    value2,
                    @ref
                }
            );
        }

        public static decimal DistanceOfPointFromSegment(Vector2 p, Vector2 segA, Vector2 segB)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "DistanceOfPointFromSegment" },
                    p,
                    segA,
                    segB
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public decimal x
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "x"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "x", value);
            }
        }

        public decimal y
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "y"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "y", value);
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
        public Vector2()
            : base() { }

        public Vector2(ICachedEntity entity)
            : base(entity) { }

        public Vector2(System.Nullable<decimal> x = null, System.Nullable<decimal> y = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(new string[] { "BABYLON", "Vector2" }, x, y);
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

        public Vector2 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Vector2 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public CachedEntityObject asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public Vector2 copyFrom(IVector2Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public Vector2 copyFromFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y }
            );
        }

        public Vector2 set(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y }
            );
        }

        public Vector2 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public Vector2 add(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public T addToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public Vector2 addInPlace(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public Vector2 addInPlaceFromFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y }
            );
        }

        public Vector2 addVector3(IVector3Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addVector3" }, otherVector }
            );
        }

        public Vector2 subtract(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public T subtractToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public Vector2 subtractInPlace(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public Vector2 multiplyInPlace(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public Vector2 multiply(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public T multiplyToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public Vector2 multiplyByFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y }
            );
        }

        public Vector2 divide(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public T divideToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public Vector2 divideInPlace(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public Vector2 minimizeInPlace(IVector2Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Vector2 maximizeInPlace(IVector2Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Vector2 minimizeInPlaceFromFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y }
            );
        }

        public Vector2 maximizeInPlaceFromFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y }
            );
        }

        public Vector2 subtractFromFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y }
            );
        }

        public T subtractFromFloatsToRef<T>(decimal x, decimal y, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public Vector2 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public Vector2 negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public T negateToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, result }
            );
        }

        public Vector2 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public Vector2 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
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

        public bool equals(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public bool equalsWithEpsilon(
            IVector2Like otherVector,
            System.Nullable<decimal> epsilon = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherVector,
                    epsilon
                }
            );
        }

        public bool equalsToFloats(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y }
            );
        }

        public Vector2 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public T floorToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public Vector2 fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public T fractToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, result }
            );
        }

        public T rotateToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "rotateToRef" }, angle, result }
            );
        }

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public decimal lengthSquared()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public Vector2 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public Vector2 normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public Vector2 normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public T normalizeToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, result }
            );
        }

        public Vector2 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public decimal dot(IVector2Like otherVector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
