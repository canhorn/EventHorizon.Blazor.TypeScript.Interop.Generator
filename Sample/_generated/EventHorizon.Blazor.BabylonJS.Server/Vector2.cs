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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector2>))]
    public class Vector2 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Vector2> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Zero" }
                }
            );
        }

        public static async ValueTask<Vector2> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "One" }
                }
            );
        }

        public static async ValueTask<Vector2> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, decimal offset, Vector2 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask<Vector2> CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "CatmullRom" }, value1, value2, value3, value4, amount
                }
            );
        }

        public static async ValueTask<Vector2> Clamp(Vector2 value, Vector2 min, Vector2 max)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Clamp" }, value, min, max
                }
            );
        }

        public static async ValueTask<Vector2> Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Hermite" }, value1, tangent1, value2, tangent2, amount
                }
            );
        }

        public static async ValueTask<Vector2> Lerp(Vector2 start, Vector2 end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Lerp" }, start, end, amount
                }
            );
        }

        public static async ValueTask<decimal> Dot(Vector2 left, Vector2 right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Dot" }, left, right
                }
            );
        }

        public static async ValueTask<Vector2> Normalize(Vector2 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Normalize" }, vector
                }
            );
        }

        public static async ValueTask<Vector2> Minimize(Vector2 left, Vector2 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Minimize" }, left, right
                }
            );
        }

        public static async ValueTask<Vector2> Maximize(Vector2 left, Vector2 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Maximize" }, left, right
                }
            );
        }

        public static async ValueTask<Vector2> Transform(Vector2 vector, Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Transform" }, vector, transformation
                }
            );
        }

        public static async ValueTask TransformToRef(Vector2 vector, Matrix transformation, Vector2 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "TransformToRef" }, vector, transformation, result
                }
            );
        }

        public static async ValueTask<bool> PointInTriangle(Vector2 p, Vector2 p0, Vector2 p1, Vector2 p2)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "PointInTriangle" }, p, p0, p1, p2
                }
            );
        }

        public static async ValueTask<decimal> Distance(Vector2 value1, Vector2 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Distance" }, value1, value2
                }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(Vector2 value1, Vector2 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "DistanceSquared" }, value1, value2
                }
            );
        }

        public static async ValueTask<Vector2> Center(Vector2 value1, Vector2 value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "Center" }, value1, value2
                }
            );
        }

        public static async ValueTask<decimal> DistanceOfPointFromSegment(Vector2 p, Vector2 segA, Vector2 segB)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector2", "DistanceOfPointFromSegment" }, p, segA, segB
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
        #endregion
        
        #region Constructor
        public Vector2() : base() { } 

        public Vector2(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Vector2> NewVector2(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector2" },
                x, y
            );

            return new Vector2(entity);
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

        public async ValueTask<Vector2> toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public async ValueTask<Vector2> fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fromArray" }, array, index
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

        public async ValueTask<Vector2> copyFrom(Vector2 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public async ValueTask<Vector2> copyFromFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y
                }
            );
        }

        public async ValueTask<Vector2> set(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, x, y
                }
            );
        }

        public async ValueTask<Vector2> add(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> addToRef(Vector2 otherVector, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector2> addInPlace(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> addVector3(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addVector3" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> subtract(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> subtractToRef(Vector2 otherVector, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector2> subtractInPlace(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> multiplyInPlace(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> multiply(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> multiplyToRef(Vector2 otherVector, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector2> multiplyByFloats(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyByFloats" }, x, y
                }
            );
        }

        public async ValueTask<Vector2> divide(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divide" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> divideToRef(Vector2 otherVector, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector2> divideInPlace(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector2> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public async ValueTask<Vector2> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateInPlace" }
                }
            );
        }

        public async ValueTask<Vector2> negateToRef(Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateToRef" }, result
                }
            );
        }

        public async ValueTask<Vector2> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleInPlace" }, scale
                }
            );
        }

        public async ValueTask<Vector2> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Vector2> scaleToRef(decimal scale, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Vector2> scaleAndAddToRef(decimal scale, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<bool> equals(Vector2 otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherVector
                }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(Vector2 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherVector, epsilon
                }
            );
        }

        public async ValueTask<Vector2> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public async ValueTask<Vector2> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
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

        public async ValueTask<Vector2> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public async ValueTask<Vector2> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
        #endregion
    }
}