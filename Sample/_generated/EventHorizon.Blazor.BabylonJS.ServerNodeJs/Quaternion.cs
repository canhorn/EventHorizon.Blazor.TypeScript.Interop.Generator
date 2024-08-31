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

    [JsonConverter(typeof(CachedEntityConverter<Quaternion>))]
    public class Quaternion
        : CachedEntityObject,
            Tensor<_Tuple<T, N, R>, Quaternion>,
            IQuaternionLike
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Quaternion> FromRotationMatrix(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrix" },
                    matrix
                }
            );
        }

        public static async ValueTask<T> FromRotationMatrixToRef<T>(Matrix matrix, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrixToRef" },
                    matrix,
                    result
                }
            );
        }

        public static async ValueTask<decimal> Dot(Quaternion left, Quaternion right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Quaternion", "Dot" }, left, right }
            );
        }

        public static async ValueTask<bool> AreClose(
            Quaternion quat0,
            Quaternion quat1,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "AreClose" },
                    quat0,
                    quat1,
                    epsilon
                }
            );
        }

        public static async ValueTask<T> SmoothToRef<T>(
            Quaternion source,
            Quaternion goal,
            decimal deltaTime,
            decimal lerpTime,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "SmoothToRef" },
                    source,
                    goal,
                    deltaTime,
                    lerpTime,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Zero" } }
            );
        }

        public static async ValueTask<Quaternion> Inverse(Quaternion q)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Inverse" }, q }
            );
        }

        public static async ValueTask<T> InverseToRef<T>(Quaternion q, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "InverseToRef" }, q, result }
            );
        }

        public static async ValueTask<Quaternion> Identity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Identity" } }
            );
        }

        public static async ValueTask<bool> IsIdentity(Quaternion quaternion)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { "BABYLON", "Quaternion", "IsIdentity" }, quaternion }
            );
        }

        public static async ValueTask<Quaternion> RotationAxis(Vector3 axis, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxis" },
                    axis,
                    angle
                }
            );
        }

        public static async ValueTask<T> RotationAxisToRef<T>(Vector3 axis, decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxisToRef" },
                    axis,
                    angle,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromArray" },
                    array,
                    offset
                }
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
                    new string[] { "BABYLON", "Quaternion", "FromArrayToRef" },
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
                    new string[] { "BABYLON", "Quaternion", "FromFloatsToRef" },
                    x,
                    y,
                    z,
                    w,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerAngles(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAngles" },
                    x,
                    y,
                    z
                }
            );
        }

        public static async ValueTask<T> FromEulerAnglesToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAnglesToRef" },
                    x,
                    y,
                    z,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerVector(Vector3 vec)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "FromEulerVector" }, vec }
            );
        }

        public static async ValueTask<T> FromEulerVectorToRef<T>(Vector3 vec, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVectorToRef" },
                    vec,
                    result
                }
            );
        }

        public static async ValueTask<T> FromUnitVectorsToRef<T>(
            Vector3 vecFrom,
            Vector3 vecTo,
            T result,
            System.Nullable<decimal> epsilon = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromUnitVectorsToRef" },
                    vecFrom,
                    vecTo,
                    result,
                    epsilon
                }
            );
        }

        public static async ValueTask<Quaternion> RotationYawPitchRoll(
            decimal yaw,
            decimal pitch,
            decimal roll
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRoll" },
                    yaw,
                    pitch,
                    roll
                }
            );
        }

        public static async ValueTask<T> RotationYawPitchRollToRef<T>(
            decimal yaw,
            decimal pitch,
            decimal roll,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRollToRef" },
                    yaw,
                    pitch,
                    roll,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> RotationAlphaBetaGamma(
            decimal alpha,
            decimal beta,
            decimal gamma
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGamma" },
                    alpha,
                    beta,
                    gamma
                }
            );
        }

        public static async ValueTask<T> RotationAlphaBetaGammaToRef<T>(
            decimal alpha,
            decimal beta,
            decimal gamma,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGammaToRef" },
                    alpha,
                    beta,
                    gamma,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> RotationQuaternionFromAxis(
            Vector3 axis1,
            Vector3 axis2,
            Vector3 axis3
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxis" },
                    axis1,
                    axis2,
                    axis3
                }
            );
        }

        public static async ValueTask<T> RotationQuaternionFromAxisToRef<T>(
            Vector3 axis1,
            Vector3 axis2,
            Vector3 axis3,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxisToRef" },
                    axis1,
                    axis2,
                    axis3,
                    @ref
                }
            );
        }

        public static async ValueTask<Quaternion> FromLookDirectionLH(Vector3 forward, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionLH" },
                    forward,
                    up
                }
            );
        }

        public static async ValueTask<T> FromLookDirectionLHToRef<T>(
            Vector3 forward,
            Vector3 up,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionLHToRef" },
                    forward,
                    up,
                    @ref
                }
            );
        }

        public static async ValueTask<Quaternion> FromLookDirectionRH(Vector3 forward, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionRH" },
                    forward,
                    up
                }
            );
        }

        public static async ValueTask<T> FromLookDirectionRHToRef<T>(
            Vector3 forward,
            Vector3 up,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionRHToRef" },
                    forward,
                    up,
                    @ref
                }
            );
        }

        public static async ValueTask<Quaternion> Slerp(
            Quaternion left,
            Quaternion right,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Slerp" },
                    left,
                    right,
                    amount
                }
            );
        }

        public static async ValueTask<T> SlerpToRef<T>(
            Quaternion left,
            Quaternion right,
            decimal amount,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "SlerpToRef" },
                    left,
                    right,
                    amount,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> Hermite(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Hermite" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    amount
                }
            );
        }

        public static async ValueTask<Quaternion> Hermite1stDerivative(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal time
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Hermite1stDerivative" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time
                }
            );
        }

        public static async ValueTask<T> Hermite1stDerivativeToRef<T>(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Hermite1stDerivativeToRef" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> Normalize(Quaternion quat)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Normalize" }, quat }
            );
        }

        public static async ValueTask<T> NormalizeToRef<T>(Quaternion quat, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "NormalizeToRef" },
                    quat,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> Clamp(
            Quaternion value,
            Quaternion min,
            Quaternion max
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Clamp" }, value, min, max }
            );
        }

        public static async ValueTask<T> ClampToRef<T>(
            Quaternion value,
            Quaternion min,
            Quaternion max,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "ClampToRef" },
                    value,
                    min,
                    max,
                    result
                }
            );
        }

        public static async ValueTask<Quaternion> Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Quaternion", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static async ValueTask<Quaternion> Minimize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Minimize" } }
            );
        }

        public static async ValueTask<Quaternion> Maximize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Maximize" } }
            );
        }

        public static async ValueTask<decimal> Distance(Quaternion value1, Quaternion value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Distance" },
                    value1,
                    value2
                }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(Quaternion value1, Quaternion value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static async ValueTask<Quaternion> Center(Quaternion value1, Quaternion value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Center" }, value1, value2 }
            );
        }

        public static async ValueTask<T> CenterToRef<T>(
            Quaternion value1,
            Quaternion value2,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "CenterToRef" },
                    value1,
                    value2,
                    @ref
                }
            );
        }
        #endregion

        #region Accessors

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
        #endregion

        #region Properties
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
        public Quaternion()
            : base() { }

        public Quaternion(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Quaternion> NewQuaternion(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null,
            System.Nullable<decimal> w = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Quaternion" },
                x,
                y,
                z,
                w
            );

            return new Quaternion(entity);
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

        public async ValueTask<Quaternion> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Quaternion> fromArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public async ValueTask<bool> equals(Quaternion otherQuaternion)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherQuaternion }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            Quaternion otherQuaternion,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherQuaternion,
                    epsilon
                }
            );
        }

        public async ValueTask<Quaternion> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<Quaternion> copyFrom(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public async ValueTask<Quaternion> copyFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Quaternion> set(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z, w }
            );
        }

        public async ValueTask<Quaternion> setAll(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public async ValueTask<Quaternion> add(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public async ValueTask<Quaternion> addInPlace(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public async ValueTask<T> addToRef<T>(Quaternion other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public async ValueTask<Quaternion> addInPlaceFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<T> subtractToRef<T>(Quaternion other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public async ValueTask<Quaternion> subtractFromFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public async ValueTask<Quaternion> subtract(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public async ValueTask<Quaternion> subtractInPlace(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public async ValueTask<Quaternion> scale(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, value }
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

        public async ValueTask<Quaternion> scaleInPlace(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, value }
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

        public async ValueTask<Quaternion> multiply(Quaternion q1)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, q1 }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(Quaternion q1, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, q1, result }
            );
        }

        public async ValueTask<Quaternion> multiplyInPlace(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public async ValueTask<Quaternion> multiplyByFloats(
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<Quaternion> divide(Quaternion _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public async ValueTask<T> divideToRef<T>(Quaternion _other, T _result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public async ValueTask<Quaternion> divideInPlace(Quaternion _other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public async ValueTask<Quaternion> minimizeInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" } }
            );
        }

        public async ValueTask<Quaternion> minimizeInPlaceFromFloats()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" } }
            );
        }

        public async ValueTask<Quaternion> maximizeInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" } }
            );
        }

        public async ValueTask<Quaternion> maximizeInPlaceFromFloats()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" } }
            );
        }

        public async ValueTask<Quaternion> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<Quaternion> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

        public async ValueTask<T> floorToRef<T>(T _result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, _result }
            );
        }

        public async ValueTask<Quaternion> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public async ValueTask<T> fractToRef<T>(T _result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, _result }
            );
        }

        public async ValueTask<Quaternion> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public async ValueTask<T> conjugateToRef<T>(T @ref)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugateToRef" }, @ref }
            );
        }

        public async ValueTask<Quaternion> conjugateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugateInPlace" } }
            );
        }

        public async ValueTask<Quaternion> conjugate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugate" } }
            );
        }

        public async ValueTask<Quaternion> invert()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invert" } }
            );
        }

        public async ValueTask<Quaternion> invertInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertInPlace" } }
            );
        }

        public async ValueTask<decimal> lengthSquared()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public async ValueTask<decimal> length()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public async ValueTask<Quaternion> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public async ValueTask<Quaternion> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public async ValueTask<Quaternion> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> toEulerAngles()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toEulerAngles" } }
            );
        }

        public async ValueTask<T> toEulerAnglesToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toEulerAnglesToRef" }, result }
            );
        }

        public async ValueTask<T> toAlphaBetaGammaToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toAlphaBetaGammaToRef" }, result }
            );
        }

        public async ValueTask<T> toRotationMatrix<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toRotationMatrix" }, result }
            );
        }

        public async ValueTask<Quaternion> fromRotationMatrix(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromRotationMatrix" }, matrix }
            );
        }

        public async ValueTask<decimal> dot(Quaternion other)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, other }
            );
        }
        #endregion
    }
}
