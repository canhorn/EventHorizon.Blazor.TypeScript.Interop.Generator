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
        public static Quaternion FromRotationMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrix" },
                    matrix
                }
            );
        }

        public static T FromRotationMatrixToRef<T>(Matrix matrix, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrixToRef" },
                    matrix,
                    result
                }
            );
        }

        public static decimal Dot(Quaternion left, Quaternion right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Quaternion", "Dot" }, left, right }
            );
        }

        public static bool AreClose(
            Quaternion quat0,
            Quaternion quat1,
            System.Nullable<decimal> epsilon = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "AreClose" },
                    quat0,
                    quat1,
                    epsilon
                }
            );
        }

        public static T SmoothToRef<T>(
            Quaternion source,
            Quaternion goal,
            decimal deltaTime,
            decimal lerpTime,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Zero" } }
            );
        }

        public static Quaternion Inverse(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Inverse" }, q }
            );
        }

        public static T InverseToRef<T>(Quaternion q, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "InverseToRef" }, q, result }
            );
        }

        public static Quaternion Identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Identity" } }
            );
        }

        public static bool IsIdentity(Quaternion quaternion)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { "BABYLON", "Quaternion", "IsIdentity" }, quaternion }
            );
        }

        public static Quaternion RotationAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxis" },
                    axis,
                    angle
                }
            );
        }

        public static T RotationAxisToRef<T>(Vector3 axis, decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromArray" },
                    array,
                    offset
                }
            );
        }

        public static T FromArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T FromFloatsToRef<T>(decimal x, decimal y, decimal z, decimal w, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion FromEulerAngles(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T FromEulerAnglesToRef<T>(decimal x, decimal y, decimal z, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion FromEulerVector(Vector3 vec)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "FromEulerVector" }, vec }
            );
        }

        public static T FromEulerVectorToRef<T>(Vector3 vec, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVectorToRef" },
                    vec,
                    result
                }
            );
        }

        public static T FromUnitVectorsToRef<T>(
            Vector3 vecFrom,
            Vector3 vecTo,
            T result,
            System.Nullable<decimal> epsilon = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T RotationYawPitchRollToRef<T>(
            decimal yaw,
            decimal pitch,
            decimal roll,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion RotationAlphaBetaGamma(decimal alpha, decimal beta, decimal gamma)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T RotationAlphaBetaGammaToRef<T>(
            decimal alpha,
            decimal beta,
            decimal gamma,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion RotationQuaternionFromAxis(
            Vector3 axis1,
            Vector3 axis2,
            Vector3 axis3
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T RotationQuaternionFromAxisToRef<T>(
            Vector3 axis1,
            Vector3 axis2,
            Vector3 axis3,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion FromLookDirectionLH(Vector3 forward, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionLH" },
                    forward,
                    up
                }
            );
        }

        public static T FromLookDirectionLHToRef<T>(Vector3 forward, Vector3 up, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion FromLookDirectionRH(Vector3 forward, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromLookDirectionRH" },
                    forward,
                    up
                }
            );
        }

        public static T FromLookDirectionRHToRef<T>(Vector3 forward, Vector3 up, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion Slerp(Quaternion left, Quaternion right, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T SlerpToRef<T>(Quaternion left, Quaternion right, decimal amount, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion Hermite(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static Quaternion Hermite1stDerivative(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal time
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
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

        public static T Hermite1stDerivativeToRef<T>(
            Quaternion value1,
            Quaternion tangent1,
            Quaternion value2,
            Quaternion tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion Normalize(Quaternion quat)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Normalize" }, quat }
            );
        }

        public static T NormalizeToRef<T>(Quaternion quat, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "NormalizeToRef" },
                    quat,
                    result
                }
            );
        }

        public static Quaternion Clamp(Quaternion value, Quaternion min, Quaternion max)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Clamp" }, value, min, max }
            );
        }

        public static T ClampToRef<T>(Quaternion value, Quaternion min, Quaternion max, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Quaternion Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Quaternion", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static Quaternion Minimize()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Minimize" } }
            );
        }

        public static Quaternion Maximize()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Maximize" } }
            );
        }

        public static decimal Distance(Quaternion value1, Quaternion value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Distance" },
                    value1,
                    value2
                }
            );
        }

        public static decimal DistanceSquared(Quaternion value1, Quaternion value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static Quaternion Center(Quaternion value1, Quaternion value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Quaternion", "Center" }, value1, value2 }
            );
        }

        public static T CenterToRef<T>(Quaternion value1, Quaternion value2, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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
        #endregion

        #region Properties
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
        public Quaternion()
            : base() { }

        public Quaternion(ICachedEntity entity)
            : base(entity) { }

        public Quaternion(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null,
            System.Nullable<decimal> w = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Quaternion" },
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

        public Quaternion toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Quaternion fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public bool equals(Quaternion otherQuaternion)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherQuaternion }
            );
        }

        public bool equalsWithEpsilon(
            Quaternion otherQuaternion,
            System.Nullable<decimal> epsilon = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherQuaternion,
                    epsilon
                }
            );
        }

        public Quaternion clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public Quaternion copyFrom(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public Quaternion copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z, w }
            );
        }

        public Quaternion set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z, w }
            );
        }

        public Quaternion setAll(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public Quaternion add(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public Quaternion addInPlace(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public T addToRef<T>(Quaternion other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public Quaternion addInPlaceFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z, w }
            );
        }

        public T subtractToRef<T>(Quaternion other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public Quaternion subtractFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public Quaternion subtract(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public Quaternion subtractInPlace(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public Quaternion scale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, value }
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

        public Quaternion scaleInPlace(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, value }
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

        public Quaternion multiply(Quaternion q1)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, q1 }
            );
        }

        public T multiplyToRef<T>(Quaternion q1, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, q1, result }
            );
        }

        public Quaternion multiplyInPlace(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public Quaternion multiplyByFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w }
            );
        }

        public Quaternion divide(Quaternion _other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, _other }
            );
        }

        public T divideToRef<T>(Quaternion _other, T _result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, _other, _result }
            );
        }

        public Quaternion divideInPlace(Quaternion _other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, _other }
            );
        }

        public Quaternion minimizeInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" } }
            );
        }

        public Quaternion minimizeInPlaceFromFloats()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" } }
            );
        }

        public Quaternion maximizeInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" } }
            );
        }

        public Quaternion maximizeInPlaceFromFloats()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" } }
            );
        }

        public Quaternion negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public Quaternion negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public bool equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z, w }
            );
        }

        public T floorToRef<T>(T _result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, _result }
            );
        }

        public Quaternion floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public T fractToRef<T>(T _result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, _result }
            );
        }

        public Quaternion fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public T conjugateToRef<T>(T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugateToRef" }, @ref }
            );
        }

        public Quaternion conjugateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugateInPlace" } }
            );
        }

        public Quaternion conjugate()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "conjugate" } }
            );
        }

        public Quaternion invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invert" } }
            );
        }

        public Quaternion invertInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertInPlace" } }
            );
        }

        public decimal lengthSquared()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public Quaternion normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public Quaternion normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public Quaternion normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
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

        public Vector3 toEulerAngles()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toEulerAngles" } }
            );
        }

        public T toEulerAnglesToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toEulerAnglesToRef" }, result }
            );
        }

        public T toAlphaBetaGammaToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toAlphaBetaGammaToRef" }, result }
            );
        }

        public T toRotationMatrix<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toRotationMatrix" }, result }
            );
        }

        public Quaternion fromRotationMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromRotationMatrix" }, matrix }
            );
        }

        public decimal dot(Quaternion other)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, other }
            );
        }
        #endregion
    }
}
