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

    [JsonConverter(typeof(CachedEntityConverter<Vector2>))]
    public class Vector2 : CachedEntityObject, Vector<_Tuple<T, N, R>, IVector2Like>, IVector2Like
    {
        #region Static Accessors
        private static Vector2 __ZeroReadOnly;

        public static async ValueTask<Vector2> get_ZeroReadOnly()
        {
            if (__ZeroReadOnly == null)
            {
                __ZeroReadOnly = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Vector2> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Zero" } }
            );
        }

        public static async ValueTask<Vector2> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "One" } }
            );
        }

        public static async ValueTask<Vector2> Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Random" }, min, max }
            );
        }

        public static async ValueTask<T> RandomToRef<T>(
            T @ref,
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector2> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "FromArray" }, array, offset }
            );
        }

        public static async ValueTask<T> FromArrayToRef<T>(
            decimal[] array,
            decimal offset,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<T> FromFloatsToRef<T>(decimal x, decimal y, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector2> CatmullRom(
            IVector2Like value1,
            IVector2Like value2,
            IVector2Like value3,
            IVector2Like value4,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
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

        public static async ValueTask<T> ClampToRef<T>(
            IVector2Like value,
            IVector2Like min,
            IVector2Like max,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector2> Clamp(
            IVector2Like value,
            IVector2Like min,
            IVector2Like max
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Clamp" }, value, min, max }
            );
        }

        public static async ValueTask<Vector2> Hermite(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
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

        public static async ValueTask<Vector2> Hermite1stDerivative(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal time
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
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

        public static async ValueTask<T> Hermite1stDerivativeToRef<T>(
            IVector2Like value1,
            IVector2Like tangent1,
            IVector2Like value2,
            IVector2Like tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector2> Lerp(
            IVector2Like start,
            IVector2Like end,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Lerp" }, start, end, amount }
            );
        }

        public static async ValueTask<Vector2> LerpToRef(
            IVector2Like start,
            IVector2Like end,
            decimal amount,
            Vector2 result
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
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

        public static async ValueTask<decimal> Dot(IVector2Like left, IVector2Like right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector2", "Dot" }, left, right }
            );
        }

        public static async ValueTask<Vector2> Normalize(Vector2 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Normalize" }, vector }
            );
        }

        public static async ValueTask<T> NormalizeToRef<T>(Vector2 vector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static async ValueTask<Vector2> Minimize(IVector2Like left, IVector2Like right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Minimize" }, left, right }
            );
        }

        public static async ValueTask<Vector2> Maximize(IVector2Like left, IVector2Like right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Maximize" }, left, right }
            );
        }

        public static async ValueTask<Vector2> Transform(IVector2Like vector, Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "Transform" },
                    vector,
                    transformation
                }
            );
        }

        public static async ValueTask<T> TransformToRef<T>(
            IVector2Like vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<bool> PointInTriangle(
            IVector2Like p,
            IVector2Like p0,
            IVector2Like p1,
            IVector2Like p2
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
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

        public static async ValueTask<decimal> Distance(IVector2Like value1, IVector2Like value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector2", "Distance" }, value1, value2 }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(
            IVector2Like value1,
            IVector2Like value2
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector2", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static async ValueTask<Vector2> Center(IVector2Like value1, IVector2Like value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector2", "Center" }, value1, value2 }
            );
        }

        public static async ValueTask<T> CenterToRef<T>(
            IVector2Like value1,
            IVector2Like value2,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<decimal> DistanceOfPointFromSegment(
            Vector2 p,
            Vector2 segA,
            Vector2 segB
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
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

        public async ValueTask<decimal> get_x()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "x");
        }

        public ValueTask set_x(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "x", value);
        }

        public async ValueTask<decimal> get_y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "y");
        }

        public ValueTask set_y(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "y", value);
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
        public Vector2()
            : base() { }

        public Vector2(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Vector2> NewVector2(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector2" },
                x,
                y
            );

            return new Vector2(entity);
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

        public async ValueTask<Vector2> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Vector2> fromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public async ValueTask<CachedEntityObject> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<CachedEntityObject>(
                entity => new CachedEntityObject() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<Vector2> copyFrom(IVector2Like source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<Vector2> copyFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> set(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y }
            );
        }

        public async ValueTask<Vector2> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public async ValueTask<Vector2> add(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public async ValueTask<T> addToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector2> addInPlace(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector2> addInPlaceFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> addVector3(IVector3Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addVector3" }, otherVector }
            );
        }

        public async ValueTask<Vector2> subtract(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public async ValueTask<T> subtractToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector2> subtractInPlace(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector2> multiplyInPlace(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector2> multiply(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector2> multiplyByFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> divide(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public async ValueTask<T> divideToRef<T>(IVector2Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector2> divideInPlace(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector2> minimizeInPlace(IVector2Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector2> maximizeInPlace(IVector2Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector2> minimizeInPlaceFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> maximizeInPlaceFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> subtractFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(decimal x, decimal y, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public async ValueTask<Vector2> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<Vector2> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public async ValueTask<T> negateToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, result }
            );
        }

        public async ValueTask<Vector2> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<Vector2> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
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

        public async ValueTask<bool> equals(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            IVector2Like otherVector,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherVector,
                    epsilon
                }
            );
        }

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y }
            );
        }

        public async ValueTask<Vector2> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public async ValueTask<T> floorToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public async ValueTask<Vector2> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public async ValueTask<T> fractToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, result }
            );
        }

        public async ValueTask<T> rotateToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "rotateToRef" }, angle, result }
            );
        }

        public async ValueTask<decimal> length()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public async ValueTask<decimal> lengthSquared()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public async ValueTask<Vector2> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public async ValueTask<Vector2> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public async ValueTask<Vector2> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public async ValueTask<T> normalizeToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, result }
            );
        }

        public async ValueTask<Vector2> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<decimal> dot(IVector2Like otherVector)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
