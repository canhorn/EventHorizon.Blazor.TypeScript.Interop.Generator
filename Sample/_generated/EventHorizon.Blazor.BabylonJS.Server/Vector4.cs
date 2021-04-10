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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector4>))]
    public class Vector4 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Vector4> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, decimal offset, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask FromFloatArrayToRef(decimal[] array, decimal offset, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask FromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatsToRef" }, x, y, z, w, result
                }
            );
        }

        public static async ValueTask<Vector4> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Zero" }
                }
            );
        }

        public static async ValueTask<Vector4> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "One" }
                }
            );
        }

        public static async ValueTask<Vector4> Normalize(Vector4 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Normalize" }, vector
                }
            );
        }

        public static async ValueTask NormalizeToRef(Vector4 vector, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "NormalizeToRef" }, vector, result
                }
            );
        }

        public static async ValueTask<Vector4> Minimize(Vector4 left, Vector4 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Minimize" }, left, right
                }
            );
        }

        public static async ValueTask<Vector4> Maximize(Vector4 left, Vector4 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Maximize" }, left, right
                }
            );
        }

        public static async ValueTask<decimal> Distance(Vector4 value1, Vector4 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Distance" }, value1, value2
                }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(Vector4 value1, Vector4 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "DistanceSquared" }, value1, value2
                }
            );
        }

        public static async ValueTask<Vector4> Center(Vector4 value1, Vector4 value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "Center" }, value1, value2
                }
            );
        }

        public static async ValueTask<Vector4> TransformNormal(Vector4 vector, Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormal" }, vector, transformation
                }
            );
        }

        public static async ValueTask TransformNormalToRef(Vector4 vector, Matrix transformation, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalToRef" }, vector, transformation, result
                }
            );
        }

        public static async ValueTask TransformNormalFromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Matrix transformation, Vector4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalFromFloatsToRef" }, x, y, z, w, transformation, result
                }
            );
        }

        public static async ValueTask<Vector4> FromVector3(Vector3 source, System.Nullable<decimal> w = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector4", "FromVector3" }, source, w
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
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
        
        #region Constructor
        public Vector4() : base() { } 

        public Vector4(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Vector4> NewVector4(
            decimal x, decimal y, decimal z, decimal w
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector4" },
                x, y, z, w
            );

            return new Vector4(entity);
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

        public async ValueTask<Vector4> toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public async ValueTask<Vector4> fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fromArray" }, array, index
                }
            );
        }

        public async ValueTask<Vector4> addInPlace(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> add(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> addToRef(Vector4 otherVector, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector4> subtractInPlace(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> subtract(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> subtractToRef(Vector4 otherVector, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector4> subtractFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractFromFloats" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Vector4> subtractFromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" }, x, y, z, w, result
                }
            );
        }

        public async ValueTask<Vector4> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public async ValueTask<Vector4> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateInPlace" }
                }
            );
        }

        public async ValueTask<Vector4> negateToRef(Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateToRef" }, result
                }
            );
        }

        public async ValueTask<Vector4> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleInPlace" }, scale
                }
            );
        }

        public async ValueTask<Vector4> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Vector4> scaleToRef(decimal scale, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Vector4> scaleAndAddToRef(decimal scale, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<bool> equals(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherVector
                }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(Vector4 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherVector, epsilon
                }
            );
        }

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsToFloats" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Vector4> multiplyInPlace(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> multiply(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> multiplyToRef(Vector4 otherVector, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector4> multiplyByFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Vector4> divide(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divide" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> divideToRef(Vector4 otherVector, Vector4 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector4> divideInPlace(Vector4 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector4> minimizeInPlace(Vector4 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "minimizeInPlace" }, other
                }
            );
        }

        public async ValueTask<Vector4> maximizeInPlace(Vector4 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "maximizeInPlace" }, other
                }
            );
        }

        public async ValueTask<Vector4> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public async ValueTask<Vector4> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fract" }
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

        public async ValueTask<decimal> lengthSquared()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "lengthSquared" }
                }
            );
        }

        public async ValueTask<Vector4> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public async ValueTask<Vector3> toVector3()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toVector3" }
                }
            );
        }

        public async ValueTask<Vector4> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<Vector4> copyFrom(Vector4 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public async ValueTask<Vector4> copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Vector4> set(decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public async ValueTask<Vector4> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setAll" }, v
                }
            );
        }
        #endregion
    }
}