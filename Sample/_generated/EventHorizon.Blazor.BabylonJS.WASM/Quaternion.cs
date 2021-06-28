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
    public class Quaternion : CachedEntityObject
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
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrix" }, matrix
                }
            );
        }

        public static void FromRotationMatrixToRef(Matrix matrix, Quaternion result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrixToRef" }, matrix, result
                }
            );
        }

        public static decimal Dot(Quaternion left, Quaternion right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Dot" }, left, right
                }
            );
        }

        public static bool AreClose(Quaternion quat0, Quaternion quat1)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "AreClose" }, quat0, quat1
                }
            );
        }

        public static Quaternion Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Zero" }
                }
            );
        }

        public static Quaternion Inverse(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Inverse" }, q
                }
            );
        }

        public static Quaternion InverseToRef(Quaternion q, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "InverseToRef" }, q, result
                }
            );
        }

        public static Quaternion Identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Identity" }
                }
            );
        }

        public static bool IsIdentity(Quaternion quaternion)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "IsIdentity" }, quaternion
                }
            );
        }

        public static Quaternion RotationAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxis" }, axis, angle
                }
            );
        }

        public static Quaternion RotationAxisToRef(Vector3 axis, decimal angle, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxisToRef" }, axis, angle, result
                }
            );
        }

        public static Quaternion FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromArray" }, array, offset
                }
            );
        }

        public static void FromArrayToRef(decimal[] array, decimal offset, Quaternion result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static Quaternion FromEulerAngles(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAngles" }, x, y, z
                }
            );
        }

        public static Quaternion FromEulerAnglesToRef(decimal x, decimal y, decimal z, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAnglesToRef" }, x, y, z, result
                }
            );
        }

        public static Quaternion FromEulerVector(Vector3 vec)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVector" }, vec
                }
            );
        }

        public static Quaternion FromEulerVectorToRef(Vector3 vec, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVectorToRef" }, vec, result
                }
            );
        }

        public static Quaternion RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRoll" }, yaw, pitch, roll
                }
            );
        }

        public static void RotationYawPitchRollToRef(decimal yaw, decimal pitch, decimal roll, Quaternion result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRollToRef" }, yaw, pitch, roll, result
                }
            );
        }

        public static Quaternion RotationAlphaBetaGamma(decimal alpha, decimal beta, decimal gamma)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGamma" }, alpha, beta, gamma
                }
            );
        }

        public static void RotationAlphaBetaGammaToRef(decimal alpha, decimal beta, decimal gamma, Quaternion result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGammaToRef" }, alpha, beta, gamma, result
                }
            );
        }

        public static Quaternion RotationQuaternionFromAxis(Vector3 axis1, Vector3 axis2, Vector3 axis3)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxis" }, axis1, axis2, axis3
                }
            );
        }

        public static void RotationQuaternionFromAxisToRef(Vector3 axis1, Vector3 axis2, Vector3 axis3, Quaternion @ref)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxisToRef" }, axis1, axis2, axis3, @ref
                }
            );
        }

        public static Quaternion Slerp(Quaternion left, Quaternion right, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Slerp" }, left, right, amount
                }
            );
        }

        public static void SlerpToRef(Quaternion left, Quaternion right, decimal amount, Quaternion result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "SlerpToRef" }, left, right, amount, result
                }
            );
        }

        public static Quaternion Hermite(Quaternion value1, Quaternion tangent1, Quaternion value2, Quaternion tangent2, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Quaternion", "Hermite" }, value1, tangent1, value2, tangent2, amount
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
            }
        }

        
        public decimal w
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Quaternion() : base() { }

        public Quaternion(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Quaternion(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Quaternion" },
                x, y, z, w
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public decimal[] asArray()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public bool equals(Quaternion otherQuaternion)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, otherQuaternion
                }
            );
        }

        public bool equalsWithEpsilon(Quaternion otherQuaternion, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherQuaternion, epsilon
                }
            );
        }

        public Quaternion clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Quaternion copyFrom(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, other
                }
            );
        }

        public Quaternion copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z, w
                }
            );
        }

        public Quaternion set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public Quaternion add(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, other
                }
            );
        }

        public Quaternion addInPlace(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addInPlace" }, other
                }
            );
        }

        public Quaternion subtract(Quaternion other)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, other
                }
            );
        }

        public Quaternion scale(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, value
                }
            );
        }

        public Quaternion scaleToRef(decimal scale, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public Quaternion scaleInPlace(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleInPlace" }, value
                }
            );
        }

        public Quaternion scaleAndAddToRef(decimal scale, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public Quaternion multiply(Quaternion q1)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, q1
                }
            );
        }

        public Quaternion multiplyToRef(Quaternion q1, Quaternion result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToRef" }, q1, result
                }
            );
        }

        public Quaternion multiplyInPlace(Quaternion q1)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyInPlace" }, q1
                }
            );
        }

        public Quaternion conjugateToRef(Quaternion @ref)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "conjugateToRef" }, @ref
                }
            );
        }

        public Quaternion conjugateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "conjugateInPlace" }
                }
            );
        }

        public Quaternion conjugate()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "conjugate" }
                }
            );
        }

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "length" }
                }
            );
        }

        public Quaternion normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Vector3 toEulerAngles(string order = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toEulerAngles" }, order
                }
            );
        }

        public Quaternion toEulerAnglesToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toEulerAnglesToRef" }, result
                }
            );
        }

        public Quaternion toRotationMatrix(Matrix result)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toRotationMatrix" }, result
                }
            );
        }

        public Quaternion fromRotationMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromRotationMatrix" }, matrix
                }
            );
        }
        #endregion
    }
}