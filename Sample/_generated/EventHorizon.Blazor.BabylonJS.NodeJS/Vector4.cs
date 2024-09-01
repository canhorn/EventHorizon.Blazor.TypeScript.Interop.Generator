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

    [JsonConverter(typeof(CachedEntityConverter<Vector4>))]
    public class Vector4 : CachedEntityObject, Vector<_Tuple<T, N, R>, IVector4Like>, IVector4Like
    {
        #region Static Accessors
        private static Vector4 __ZeroReadOnly;
        public static Vector4 ZeroReadOnly
        {
            get
            {
                if (__ZeroReadOnly == null)
                {
                    __ZeroReadOnly = EventHorizonBlazorInterop.GetClass<Vector4>(
                        "BABYLON",
                        "Vector4.ZeroReadOnly",
                        (entity) =>
                        {
                            return new Vector4() { ___guid = entity.___guid };
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
        public static Vector4 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "FromArray" }, array, offset }
            );
        }

        public static T FromArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static T FromFloatArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static T FromFloatsToRef<T>(decimal x, decimal y, decimal z, decimal w, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatsToRef" },
                    x,
                    y,
                    z,
                    w,
                    result
                }
            );
        }

        public static Vector4 Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Zero" } }
            );
        }

        public static Vector4 One()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "One" } }
            );
        }

        public static Vector4 Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Vector4", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static Vector4 Clamp(IVector4Like value, IVector4Like min, IVector4Like max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Clamp" }, value, min, max }
            );
        }

        public static T ClampToRef<T>(
            IVector4Like value,
            IVector4Like min,
            IVector4Like max,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "ClampToRef" },
                    value,
                    min,
                    max,
                    result
                }
            );
        }

        public static void CheckExtends(IVector4Like v, Vector4 min, Vector4 max)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { "BABYLON", "Vector4", "CheckExtends" }, v, min, max }
            );
        }

        public static Vector4 Normalize(Vector4 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Normalize" }, vector }
            );
        }

        public static T NormalizeToRef<T>(Vector4 vector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static Vector4 Minimize<T>(T left, Vector4 right)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Minimize" }, left, right }
            );
        }

        public static Vector4 Maximize(IVector4Like left, IVector4Like right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Maximize" }, left, right }
            );
        }

        public static decimal Distance(IVector4Like value1, IVector4Like value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector4", "Distance" }, value1, value2 }
            );
        }

        public static decimal DistanceSquared(IVector4Like value1, IVector4Like value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static Vector4 Center(IVector4Like value1, IVector4Like value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Center" }, value1, value2 }
            );
        }

        public static T CenterToRef<T>(IVector4Like value1, IVector4Like value2, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "CenterToRef" },
                    value1,
                    value2,
                    @ref
                }
            );
        }

        public static Vector4 TransformCoordinates(Vector3 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformCoordinates" },
                    vector,
                    transformation
                }
            );
        }

        public static T TransformCoordinatesToRef<T>(
            Vector3 vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformCoordinatesToRef" },
                    vector,
                    transformation,
                    result
                }
            );
        }

        public static T TransformCoordinatesFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformCoordinatesFromFloatsToRef" },
                    x,
                    y,
                    z,
                    transformation,
                    result
                }
            );
        }

        public static Vector4 TransformNormal(IVector4Like vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormal" },
                    vector,
                    transformation
                }
            );
        }

        public static T TransformNormalToRef<T>(
            IVector4Like vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalToRef" },
                    vector,
                    transformation,
                    result
                }
            );
        }

        public static T TransformNormalFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalFromFloatsToRef" },
                    x,
                    y,
                    z,
                    w,
                    transformation,
                    result
                }
            );
        }

        public static Vector4 FromVector3(Vector3 source, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "FromVector3" }, source, w }
            );
        }

        public static decimal Dot(IVector4Like left, IVector4Like right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector4", "Dot" }, left, right }
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

        public decimal z
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "z"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "z", value);
            }
        }

        public decimal w
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "w"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "w", value);
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
        public Vector4()
            : base() { }

        public Vector4(ICachedEntity entity)
            : base(entity) { }

        public Vector4(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null,
            System.Nullable<decimal> w = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector4" },
                x,
                y,
                z,
                w
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

        public _Tuple<T, N, R> asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public Vector4 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Vector4 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public Vector4 addInPlace(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public Vector4 addInPlaceFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z, w }
            );
        }

        public Vector4 add(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public T addToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public Vector4 subtractInPlace(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public Vector4 subtract(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public T subtractToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public Vector4 subtractFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y, z, w }
            );
        }

        public T subtractFromFloatsToRef<T>(decimal x, decimal y, decimal z, decimal w, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" },
                    x,
                    y,
                    z,
                    w,
                    result
                }
            );
        }

        public Vector4 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public Vector4 negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public Vector4 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public Vector4 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public bool equals(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public bool equalsWithEpsilon(
            IVector4Like otherVector,
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

        public bool equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

        public Vector4 multiplyInPlace(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public Vector4 multiply(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public T multiplyToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public Vector4 multiplyByFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w }
            );
        }

        public Vector4 divide(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public T divideToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public Vector4 divideInPlace(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public Vector4 minimizeInPlace(IVector4Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Vector4 maximizeInPlace(IVector4Like other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Vector4 minimizeInPlaceFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "minimizeInPlaceFromFloats" },
                    x,
                    y,
                    z,
                    w
                }
            );
        }

        public Vector4 maximizeInPlaceFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "maximizeInPlaceFromFloats" },
                    x,
                    y,
                    z,
                    w
                }
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

        public Vector4 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
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

        public Vector4 fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
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

        public Vector4 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public Vector4 normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public Vector4 normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public T normalizeToRef<T>(T reference)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, reference }
            );
        }

        public Vector3 toVector3()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toVector3" } }
            );
        }

        public Vector4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public Vector4 copyFrom(IVector4Like source)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public Vector4 copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z, w }
            );
        }

        public Vector4 set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z, w }
            );
        }

        public Vector4 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public decimal dot(IVector4Like otherVector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
