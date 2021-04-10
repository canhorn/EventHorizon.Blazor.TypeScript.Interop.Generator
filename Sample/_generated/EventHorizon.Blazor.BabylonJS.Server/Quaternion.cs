/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Quaternion>))]
    public class Quaternion : CachedEntityObject
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
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrix" }, matrix
                }
            );
        }

        public static async ValueTask FromRotationMatrixToRef(Matrix matrix, Quaternion result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromRotationMatrixToRef" }, matrix, result
                }
            );
        }

        public static async ValueTask<decimal> Dot(Quaternion left, Quaternion right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Dot" }, left, right
                }
            );
        }

        public static async ValueTask<bool> AreClose(Quaternion quat0, Quaternion quat1)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "AreClose" }, quat0, quat1
                }
            );
        }

        public static async ValueTask<Quaternion> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Zero" }
                }
            );
        }

        public static async ValueTask<Quaternion> Inverse(Quaternion q)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Inverse" }, q
                }
            );
        }

        public static async ValueTask<Quaternion> InverseToRef(Quaternion q, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "InverseToRef" }, q, result
                }
            );
        }

        public static async ValueTask<Quaternion> Identity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Identity" }
                }
            );
        }

        public static async ValueTask<bool> IsIdentity(Quaternion quaternion)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "IsIdentity" }, quaternion
                }
            );
        }

        public static async ValueTask<Quaternion> RotationAxis(Vector3 axis, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxis" }, axis, angle
                }
            );
        }

        public static async ValueTask<Quaternion> RotationAxisToRef(Vector3 axis, decimal angle, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAxisToRef" }, axis, angle, result
                }
            );
        }

        public static async ValueTask<Quaternion> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, decimal offset, Quaternion result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerAngles(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAngles" }, x, y, z
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerAnglesToRef(decimal x, decimal y, decimal z, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerAnglesToRef" }, x, y, z, result
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerVector(Vector3 vec)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVector" }, vec
                }
            );
        }

        public static async ValueTask<Quaternion> FromEulerVectorToRef(Vector3 vec, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "FromEulerVectorToRef" }, vec, result
                }
            );
        }

        public static async ValueTask<Quaternion> RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRoll" }, yaw, pitch, roll
                }
            );
        }

        public static async ValueTask RotationYawPitchRollToRef(decimal yaw, decimal pitch, decimal roll, Quaternion result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationYawPitchRollToRef" }, yaw, pitch, roll, result
                }
            );
        }

        public static async ValueTask<Quaternion> RotationAlphaBetaGamma(decimal alpha, decimal beta, decimal gamma)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGamma" }, alpha, beta, gamma
                }
            );
        }

        public static async ValueTask RotationAlphaBetaGammaToRef(decimal alpha, decimal beta, decimal gamma, Quaternion result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationAlphaBetaGammaToRef" }, alpha, beta, gamma, result
                }
            );
        }

        public static async ValueTask<Quaternion> RotationQuaternionFromAxis(Vector3 axis1, Vector3 axis2, Vector3 axis3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxis" }, axis1, axis2, axis3
                }
            );
        }

        public static async ValueTask RotationQuaternionFromAxisToRef(Vector3 axis1, Vector3 axis2, Vector3 axis3, Quaternion @ref)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "RotationQuaternionFromAxisToRef" }, axis1, axis2, axis3, @ref
                }
            );
        }

        public static async ValueTask<Quaternion> Slerp(Quaternion left, Quaternion right, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Slerp" }, left, right, amount
                }
            );
        }

        public static async ValueTask SlerpToRef(Quaternion left, Quaternion right, decimal amount, Quaternion result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "SlerpToRef" }, left, right, amount, result
                }
            );
        }

        public static async ValueTask<Quaternion> Hermite(Quaternion value1, Quaternion tangent1, Quaternion value2, Quaternion tangent2, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Quaternion", "Hermite" }, value1, tangent1, value2, tangent2, amount
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_x()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
        }
        public ValueTask set_x(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
        }

        
        public async ValueTask<decimal> get_y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
        }
        public ValueTask set_y(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
        }

        
        public async ValueTask<decimal> get_z()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
        }
        public ValueTask set_z(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
        }

        
        public async ValueTask<decimal> get_w()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
        }
        public ValueTask set_w(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
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

        public static async ValueTask<Quaternion> NewQuaternion(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null, System.Nullable<decimal> w = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Quaternion" },
                x, y, z, w
            );

            return new Quaternion(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public async ValueTask<decimal[]> asArray()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public async ValueTask<bool> equals(Quaternion otherQuaternion)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherQuaternion
                }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(Quaternion otherQuaternion, System.Nullable<decimal> epsilon = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherQuaternion, epsilon
                }
            );
        }

        public async ValueTask<Quaternion> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<Quaternion> copyFrom(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, other
                }
            );
        }

        public async ValueTask<Quaternion> copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Quaternion> set(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Quaternion> add(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, other
                }
            );
        }

        public async ValueTask<Quaternion> addInPlace(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlace" }, other
                }
            );
        }

        public async ValueTask<Quaternion> subtract(Quaternion other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, other
                }
            );
        }

        public async ValueTask<Quaternion> scale(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, value
                }
            );
        }

        public async ValueTask<Quaternion> scaleToRef(decimal scale, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Quaternion> scaleInPlace(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleInPlace" }, value
                }
            );
        }

        public async ValueTask<Quaternion> scaleAndAddToRef(decimal scale, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Quaternion> multiply(Quaternion q1)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, q1
                }
            );
        }

        public async ValueTask<Quaternion> multiplyToRef(Quaternion q1, Quaternion result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, q1, result
                }
            );
        }

        public async ValueTask<Quaternion> multiplyInPlace(Quaternion q1)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyInPlace" }, q1
                }
            );
        }

        public async ValueTask<Quaternion> conjugateToRef(Quaternion @ref)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "conjugateToRef" }, @ref
                }
            );
        }

        public async ValueTask<Quaternion> conjugateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "conjugateInPlace" }
                }
            );
        }

        public async ValueTask<Quaternion> conjugate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "conjugate" }
                }
            );
        }

        public async ValueTask<decimal> length()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "length" }
                }
            );
        }

        public async ValueTask<Quaternion> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public async ValueTask<Vector3> toEulerAngles(string order = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toEulerAngles" }, order
                }
            );
        }

        public async ValueTask<Quaternion> toEulerAnglesToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toEulerAnglesToRef" }, result
                }
            );
        }

        public async ValueTask<Quaternion> toRotationMatrix(Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toRotationMatrix" }, result
                }
            );
        }

        public async ValueTask<Quaternion> fromRotationMatrix(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
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