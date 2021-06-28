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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector3>))]
    public class Vector3 : CachedEntityObject
    {
        #region Static Accessors
        private static Vector3 __UpReadOnly;
        public static Vector3 UpReadOnly
        {
            get
            {
            if(__UpReadOnly == null)
            {
                __UpReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.UpReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __UpReadOnly;
            }
        }

        private static Vector3 __ZeroReadOnly;
        public static Vector3 ZeroReadOnly
        {
            get
            {
            if(__ZeroReadOnly == null)
            {
                __ZeroReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.ZeroReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
        public static decimal GetClipFactor(Vector3 vector0, Vector3 vector1, Vector3 axis, decimal size)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetClipFactor" }, vector0, vector1, axis, size
                }
            );
        }

        public static decimal GetAngleBetweenVectors(Vector3 vector0, Vector3 vector1, Vector3 normal)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectors" }, vector0, vector1, normal
                }
            );
        }

        public static Vector3 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromArray" }, array, offset
                }
            );
        }

        public static Vector3 FromFloatArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArray" }, array, offset
                }
            );
        }

        public static void FromArrayToRef(decimal[] array, decimal offset, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static void FromFloatArrayToRef(decimal[] array, decimal offset, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArrayToRef" }, array, offset, result
                }
            );
        }

        public static void FromFloatsToRef(decimal x, decimal y, decimal z, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatsToRef" }, x, y, z, result
                }
            );
        }

        public static Vector3 Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Zero" }
                }
            );
        }

        public static Vector3 One()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "One" }
                }
            );
        }

        public static Vector3 Up()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Up" }
                }
            );
        }

        public static Vector3 Down()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Down" }
                }
            );
        }

        public static Vector3 Forward(System.Nullable<bool> rightHandedSystem = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Forward" }, rightHandedSystem
                }
            );
        }

        public static Vector3 Backward(System.Nullable<bool> rightHandedSystem = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Backward" }, rightHandedSystem
                }
            );
        }

        public static Vector3 Right()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Right" }
                }
            );
        }

        public static Vector3 Left()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Left" }
                }
            );
        }

        public static Vector3 TransformCoordinates(Vector3 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinates" }, vector, transformation
                }
            );
        }

        public static void TransformCoordinatesToRef(Vector3 vector, Matrix transformation, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesToRef" }, vector, transformation, result
                }
            );
        }

        public static void TransformCoordinatesFromFloatsToRef(decimal x, decimal y, decimal z, Matrix transformation, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesFromFloatsToRef" }, x, y, z, transformation, result
                }
            );
        }

        public static Vector3 TransformNormal(Vector3 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormal" }, vector, transformation
                }
            );
        }

        public static void TransformNormalToRef(Vector3 vector, Matrix transformation, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormalToRef" }, vector, transformation, result
                }
            );
        }

        public static void TransformNormalFromFloatsToRef(decimal x, decimal y, decimal z, Matrix transformation, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormalFromFloatsToRef" }, x, y, z, transformation, result
                }
            );
        }

        public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CatmullRom" }, value1, value2, value3, value4, amount
                }
            );
        }

        public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Clamp" }, value, min, max
                }
            );
        }

        public static void ClampToRef(Vector3 value, Vector3 min, Vector3 max, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ClampToRef" }, value, min, max, result
                }
            );
        }

        public static void CheckExtends(Vector3 v, Vector3 min, Vector3 max)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CheckExtends" }, v, min, max
                }
            );
        }

        public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Hermite" }, value1, tangent1, value2, tangent2, amount
                }
            );
        }

        public static Vector3 Lerp(Vector3 start, Vector3 end, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Lerp" }, start, end, amount
                }
            );
        }

        public static void LerpToRef(Vector3 start, Vector3 end, decimal amount, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "LerpToRef" }, start, end, amount, result
                }
            );
        }

        public static decimal Dot(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Dot" }, left, right
                }
            );
        }

        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Cross" }, left, right
                }
            );
        }

        public static void CrossToRef(Vector3 left, Vector3 right, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CrossToRef" }, left, right, result
                }
            );
        }

        public static Vector3 Normalize(Vector3 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Normalize" }, vector
                }
            );
        }

        public static void NormalizeToRef(Vector3 vector, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "NormalizeToRef" }, vector, result
                }
            );
        }

        public static Vector3 Project(Vector3 vector, Matrix world, Matrix transform, Viewport viewport)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Project" }, vector, world, transform, viewport
                }
            );
        }

        public static Vector3 ProjectToRef(Vector3 vector, Matrix world, Matrix transform, Viewport viewport, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ProjectToRef" }, vector, world, transform, viewport, result
                }
            );
        }

        public static Vector3 UnprojectFromTransform(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix transform)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFromTransform" }, source, viewportWidth, viewportHeight, world, transform
                }
            );
        }

        public static Vector3 Unproject(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Unproject" }, source, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public static void UnprojectToRef(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectToRef" }, source, viewportWidth, viewportHeight, world, view, projection, result
                }
            );
        }

        public static void UnprojectFloatsToRef(decimal sourceX, decimal sourceY, decimal sourceZ, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFloatsToRef" }, sourceX, sourceY, sourceZ, viewportWidth, viewportHeight, world, view, projection, result
                }
            );
        }

        public static Vector3 Minimize(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Minimize" }, left, right
                }
            );
        }

        public static Vector3 Maximize(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Maximize" }, left, right
                }
            );
        }

        public static decimal Distance(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Distance" }, value1, value2
                }
            );
        }

        public static decimal DistanceSquared(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "DistanceSquared" }, value1, value2
                }
            );
        }

        public static Vector3 Center(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Center" }, value1, value2
                }
            );
        }

        public static Vector3 RotationFromAxis(Vector3 axis1, Vector3 axis2, Vector3 axis3)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "RotationFromAxis" }, axis1, axis2, axis3
                }
            );
        }

        public static void RotationFromAxisToRef(Vector3 axis1, Vector3 axis2, Vector3 axis3, Vector3 @ref)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "RotationFromAxisToRef" }, axis1, axis2, axis3, @ref
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

        
        public bool isNonUniform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isNonUniform"
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Vector3() : base() { }

        public Vector3(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Vector3(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector3" },
                x, y, z
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

        public Vector3 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public Vector3 fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromArray" }, array, index
                }
            );
        }

        public Quaternion toQuaternion()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toQuaternion" }
                }
            );
        }

        public Vector3 addInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addInPlace" }, otherVector
                }
            );
        }

        public Vector3 addInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public Vector3 add(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, otherVector
                }
            );
        }

        public Vector3 addToRef(Vector3 otherVector, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addToRef" }, otherVector, result
                }
            );
        }

        public Vector3 subtractInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractInPlace" }, otherVector
                }
            );
        }

        public Vector3 subtract(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtract" }, otherVector
                }
            );
        }

        public Vector3 subtractToRef(Vector3 otherVector, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractToRef" }, otherVector, result
                }
            );
        }

        public Vector3 subtractFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloats" }, x, y, z
                }
            );
        }

        public Vector3 subtractFromFloatsToRef(decimal x, decimal y, decimal z, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" }, x, y, z, result
                }
            );
        }

        public Vector3 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public Vector3 negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negateInPlace" }
                }
            );
        }

        public Vector3 negateToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "negateToRef" }, result
                }
            );
        }

        public Vector3 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleInPlace" }, scale
                }
            );
        }

        public Vector3 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public Vector3 scaleToRef(decimal scale, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public Vector3 scaleAndAddToRef(decimal scale, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public Vector3 projectOnPlane(Plane plane, Vector3 origin)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "projectOnPlane" }, plane, origin
                }
            );
        }

        public void projectOnPlaneToRef(Plane plane, Vector3 origin, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "projectOnPlaneToRef" }, plane, origin, result
                }
            );
        }

        public bool equals(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, otherVector
                }
            );
        }

        public bool equalsWithEpsilon(Vector3 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherVector, epsilon
                }
            );
        }

        public bool equalsToFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsToFloats" }, x, y, z
                }
            );
        }

        public Vector3 multiplyInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyInPlace" }, otherVector
                }
            );
        }

        public Vector3 multiply(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiply" }, otherVector
                }
            );
        }

        public Vector3 multiplyToRef(Vector3 otherVector, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherVector, result
                }
            );
        }

        public Vector3 multiplyByFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyByFloats" }, x, y, z
                }
            );
        }

        public Vector3 divide(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divide" }, otherVector
                }
            );
        }

        public Vector3 divideToRef(Vector3 otherVector, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideToRef" }, otherVector, result
                }
            );
        }

        public Vector3 divideInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "divideInPlace" }, otherVector
                }
            );
        }

        public Vector3 minimizeInPlace(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "minimizeInPlace" }, other
                }
            );
        }

        public Vector3 maximizeInPlace(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "maximizeInPlace" }, other
                }
            );
        }

        public Vector3 minimizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public Vector3 maximizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public bool isNonUniformWithinEpsilon(decimal epsilon)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isNonUniformWithinEpsilon" }, epsilon
                }
            );
        }

        public Vector3 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public Vector3 fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public Vector3 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Vector3 reorderInPlace(string order)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reorderInPlace" }, order
                }
            );
        }

        public Vector3 rotateByQuaternionToRef(Quaternion quaternion, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateByQuaternionToRef" }, quaternion, result
                }
            );
        }

        public Vector3 rotateByQuaternionAroundPointToRef(Quaternion quaternion, Vector3 point, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateByQuaternionAroundPointToRef" }, quaternion, point, result
                }
            );
        }

        public Vector3 cross(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "cross" }, other
                }
            );
        }

        public Vector3 normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeFromLength" }, len
                }
            );
        }

        public Vector3 normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeToNew" }
                }
            );
        }

        public Vector3 normalizeToRef(Vector3 reference)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeToRef" }, reference
                }
            );
        }

        public Vector3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public Vector3 copyFrom(Vector3 source)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public Vector3 copyFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z
                }
            );
        }

        public Vector3 set(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, x, y, z
                }
            );
        }

        public Vector3 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAll" }, v
                }
            );
        }
        #endregion
    }
}