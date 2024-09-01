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

    [JsonConverter(typeof(CachedEntityConverter<Vector4>))]
    public class Vector4 : CachedEntityObject, Vector<_Tuple<T, N, R>, IVector4Like>, IVector4Like
    {
        #region Static Accessors
        private static Vector4 __ZeroReadOnly;

        public static async ValueTask<Vector4> get_ZeroReadOnly()
        {
            if (__ZeroReadOnly == null)
            {
                __ZeroReadOnly = await EventHorizonBlazorInterop.GetClass<Vector4>(
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
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Vector4> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "FromArray" }, array, offset }
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
                    new string[] { "BABYLON", "Vector4", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static async ValueTask<T> FromFloatArrayToRef<T>(
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
                    new string[] { "BABYLON", "Vector4", "FromFloatArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static async ValueTask<T> FromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector4> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Zero" } }
            );
        }

        public static async ValueTask<Vector4> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "One" } }
            );
        }

        public static async ValueTask<Vector4> Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Vector4", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector4> Clamp(
            IVector4Like value,
            IVector4Like min,
            IVector4Like max
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Clamp" }, value, min, max }
            );
        }

        public static async ValueTask<T> ClampToRef<T>(
            IVector4Like value,
            IVector4Like min,
            IVector4Like max,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask CheckExtends(IVector4Like v, Vector4 min, Vector4 max)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { "BABYLON", "Vector4", "CheckExtends" }, v, min, max }
            );
        }

        public static async ValueTask<Vector4> Normalize(Vector4 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Normalize" }, vector }
            );
        }

        public static async ValueTask<T> NormalizeToRef<T>(Vector4 vector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static async ValueTask<Vector4> Minimize<T>(T left, Vector4 right)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Minimize" }, left, right }
            );
        }

        public static async ValueTask<Vector4> Maximize(IVector4Like left, IVector4Like right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Maximize" }, left, right }
            );
        }

        public static async ValueTask<decimal> Distance(IVector4Like value1, IVector4Like value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector4", "Distance" }, value1, value2 }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(
            IVector4Like value1,
            IVector4Like value2
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static async ValueTask<Vector4> Center(IVector4Like value1, IVector4Like value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "Center" }, value1, value2 }
            );
        }

        public static async ValueTask<T> CenterToRef<T>(
            IVector4Like value1,
            IVector4Like value2,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector4> TransformCoordinates(
            Vector3 vector,
            Matrix transformation
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformCoordinates" },
                    vector,
                    transformation
                }
            );
        }

        public static async ValueTask<T> TransformCoordinatesToRef<T>(
            Vector3 vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<T> TransformCoordinatesFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector4> TransformNormal(
            IVector4Like vector,
            Matrix transformation
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormal" },
                    vector,
                    transformation
                }
            );
        }

        public static async ValueTask<T> TransformNormalToRef<T>(
            IVector4Like vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<T> TransformNormalFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public static async ValueTask<Vector4> FromVector3(
            Vector3 source,
            System.Nullable<decimal> w = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector4", "FromVector3" }, source, w }
            );
        }

        public static async ValueTask<decimal> Dot(IVector4Like left, IVector4Like right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector4", "Dot" }, left, right }
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

        public async ValueTask<decimal> get_z()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "z");
        }

        public ValueTask set_z(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "z", value);
        }

        public async ValueTask<decimal> get_w()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "w");
        }

        public ValueTask set_w(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "w", value);
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
        public Vector4()
            : base() { }

        public Vector4(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Vector4> NewVector4(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null,
            System.Nullable<decimal> w = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector4" },
                x,
                y,
                z,
                w
            );

            return new Vector4(entity);
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

        public async ValueTask<_Tuple<T, N, R>> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<Vector4> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Vector4> fromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public async ValueTask<Vector4> addInPlace(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector4> addInPlaceFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Vector4> add(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public async ValueTask<T> addToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector4> subtractInPlace(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector4> subtract(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public async ValueTask<T> subtractToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector4> subtractFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
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

        public async ValueTask<Vector4> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<Vector4> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public async ValueTask<Vector4> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<Vector4> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
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

        public async ValueTask<bool> equals(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            IVector4Like otherVector,
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

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Vector4> multiplyInPlace(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector4> multiply(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector4> multiplyByFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Vector4> divide(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public async ValueTask<T> divideToRef<T>(IVector4Like otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector4> divideInPlace(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector4> minimizeInPlace(IVector4Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector4> maximizeInPlace(IVector4Like other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector4> minimizeInPlaceFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
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

        public async ValueTask<Vector4> maximizeInPlaceFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
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

        public async ValueTask<T> floorToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public async ValueTask<Vector4> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
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

        public async ValueTask<Vector4> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
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

        public async ValueTask<Vector4> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public async ValueTask<Vector4> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public async ValueTask<Vector4> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public async ValueTask<T> normalizeToRef<T>(T reference)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, reference }
            );
        }

        public async ValueTask<Vector3> toVector3()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toVector3" } }
            );
        }

        public async ValueTask<Vector4> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<Vector4> copyFrom(IVector4Like source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<Vector4> copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Vector4> set(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z, w }
            );
        }

        public async ValueTask<Vector4> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public async ValueTask<decimal> dot(IVector4Like otherVector)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
