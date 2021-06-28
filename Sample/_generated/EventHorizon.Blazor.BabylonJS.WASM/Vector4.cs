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
    public class Vector4 : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Vector4 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromArray" }, array, offset
                }
            );
        }

        public static void FromArrayToRef(decimal[] array, decimal offset, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static void FromFloatArrayToRef(decimal[] array, decimal offset, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatArrayToRef" }, array, offset, result
                }
            );
        }

        public static void FromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "FromFloatsToRef" }, x, y, z, w, result
                }
            );
        }

        public static Vector4 Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Zero" }
                }
            );
        }

        public static Vector4 One()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "One" }
                }
            );
        }

        public static Vector4 Normalize(Vector4 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Normalize" }, vector
                }
            );
        }

        public static void NormalizeToRef(Vector4 vector, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "NormalizeToRef" }, vector, result
                }
            );
        }

        public static Vector4 Minimize(Vector4 left, Vector4 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Minimize" }, left, right
                }
            );
        }

        public static Vector4 Maximize(Vector4 left, Vector4 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Maximize" }, left, right
                }
            );
        }

        public static decimal Distance(Vector4 value1, Vector4 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Distance" }, value1, value2
                }
            );
        }

        public static decimal DistanceSquared(Vector4 value1, Vector4 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "DistanceSquared" }, value1, value2
                }
            );
        }

        public static Vector4 Center(Vector4 value1, Vector4 value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "Center" }, value1, value2
                }
            );
        }

        public static Vector4 TransformNormal(Vector4 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormal" }, vector, transformation
                }
            );
        }

        public static void TransformNormalToRef(Vector4 vector, Matrix transformation, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalToRef" }, vector, transformation, result
                }
            );
        }

        public static void TransformNormalFromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Matrix transformation, Vector4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector4", "TransformNormalFromFloatsToRef" }, x, y, z, w, transformation, result
                }
            );
        }

        public static Vector4 FromVector3(Vector3 source, System.Nullable<decimal> w = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
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
        
        #region Constructor
        public Vector4() : base() { }

        public Vector4(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Vector4(
            decimal x, decimal y, decimal z, decimal w
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector4" },
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

        public Vector4 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public Vector4 fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, index
                }
            );
        }

        public Vector4 addInPlace(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addInPlace" }, otherVector
                }
            );
        }

        public Vector4 add(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, otherVector
                }
            );
        }

        public Vector4 addToRef(Vector4 otherVector, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addToRef" }, otherVector, result
                }
            );
        }

        public Vector4 subtractInPlace(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractInPlace" }, otherVector
                }
            );
        }

        public Vector4 subtract(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, otherVector
                }
            );
        }

        public Vector4 subtractToRef(Vector4 otherVector, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractToRef" }, otherVector, result
                }
            );
        }

        public Vector4 subtractFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloats" }, x, y, z, w
                }
            );
        }

        public Vector4 subtractFromFloatsToRef(decimal x, decimal y, decimal z, decimal w, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" }, x, y, z, w, result
                }
            );
        }

        public Vector4 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public Vector4 negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negateInPlace" }
                }
            );
        }

        public Vector4 negateToRef(Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negateToRef" }, result
                }
            );
        }

        public Vector4 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleInPlace" }, scale
                }
            );
        }

        public Vector4 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public Vector4 scaleToRef(decimal scale, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public Vector4 scaleAndAddToRef(decimal scale, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public bool equals(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, otherVector
                }
            );
        }

        public bool equalsWithEpsilon(Vector4 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherVector, epsilon
                }
            );
        }

        public bool equalsToFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsToFloats" }, x, y, z, w
                }
            );
        }

        public Vector4 multiplyInPlace(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyInPlace" }, otherVector
                }
            );
        }

        public Vector4 multiply(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, otherVector
                }
            );
        }

        public Vector4 multiplyToRef(Vector4 otherVector, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherVector, result
                }
            );
        }

        public Vector4 multiplyByFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyByFloats" }, x, y, z, w
                }
            );
        }

        public Vector4 divide(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divide" }, otherVector
                }
            );
        }

        public Vector4 divideToRef(Vector4 otherVector, Vector4 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideToRef" }, otherVector, result
                }
            );
        }

        public Vector4 divideInPlace(Vector4 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideInPlace" }, otherVector
                }
            );
        }

        public Vector4 minimizeInPlace(Vector4 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "minimizeInPlace" }, other
                }
            );
        }

        public Vector4 maximizeInPlace(Vector4 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "maximizeInPlace" }, other
                }
            );
        }

        public Vector4 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public Vector4 fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fract" }
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

        public decimal lengthSquared()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "lengthSquared" }
                }
            );
        }

        public Vector4 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Vector3 toVector3()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toVector3" }
                }
            );
        }

        public Vector4 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Vector4 copyFrom(Vector4 source)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public Vector4 copyFromFloats(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z, w
                }
            );
        }

        public Vector4 set(decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z, w
                }
            );
        }

        public Vector4 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
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