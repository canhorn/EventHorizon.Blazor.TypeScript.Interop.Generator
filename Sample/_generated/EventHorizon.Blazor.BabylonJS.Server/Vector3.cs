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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector3>))]
    public class Vector3 : CachedEntityObject
    {
        #region Static Accessors
        private static Vector3 __UpReadOnly;
        public static async ValueTask<Vector3> get_UpReadOnly()
        {
            if(__UpReadOnly == null)
            {
                __UpReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private static Vector3 __ZeroReadOnly;
        public static async ValueTask<Vector3> get_ZeroReadOnly()
        {
            if(__ZeroReadOnly == null)
            {
                __ZeroReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<decimal> GetClipFactor(Vector3 vector0, Vector3 vector1, Vector3 axis, decimal size)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "GetClipFactor" }, vector0, vector1, axis, size
                }
            );
        }

        public static async ValueTask<decimal> GetAngleBetweenVectors(Vector3 vector0, Vector3 vector1, Vector3 normal)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectors" }, vector0, vector1, normal
                }
            );
        }

        public static async ValueTask<Vector3> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask<Vector3> FromFloatArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, decimal offset, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask FromFloatArrayToRef(decimal[] array, decimal offset, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask FromFloatsToRef(decimal x, decimal y, decimal z, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatsToRef" }, x, y, z, result
                }
            );
        }

        public static async ValueTask<Vector3> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Zero" }
                }
            );
        }

        public static async ValueTask<Vector3> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "One" }
                }
            );
        }

        public static async ValueTask<Vector3> Up()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Up" }
                }
            );
        }

        public static async ValueTask<Vector3> Down()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Down" }
                }
            );
        }

        public static async ValueTask<Vector3> Forward(System.Nullable<bool> rightHandedSystem = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Forward" }, rightHandedSystem
                }
            );
        }

        public static async ValueTask<Vector3> Backward(System.Nullable<bool> rightHandedSystem = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Backward" }, rightHandedSystem
                }
            );
        }

        public static async ValueTask<Vector3> Right()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Right" }
                }
            );
        }

        public static async ValueTask<Vector3> Left()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Left" }
                }
            );
        }

        public static async ValueTask<Vector3> TransformCoordinates(Vector3 vector, Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinates" }, vector, transformation
                }
            );
        }

        public static async ValueTask TransformCoordinatesToRef(Vector3 vector, Matrix transformation, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesToRef" }, vector, transformation, result
                }
            );
        }

        public static async ValueTask TransformCoordinatesFromFloatsToRef(decimal x, decimal y, decimal z, Matrix transformation, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesFromFloatsToRef" }, x, y, z, transformation, result
                }
            );
        }

        public static async ValueTask<Vector3> TransformNormal(Vector3 vector, Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormal" }, vector, transformation
                }
            );
        }

        public static async ValueTask TransformNormalToRef(Vector3 vector, Matrix transformation, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormalToRef" }, vector, transformation, result
                }
            );
        }

        public static async ValueTask TransformNormalFromFloatsToRef(decimal x, decimal y, decimal z, Matrix transformation, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormalFromFloatsToRef" }, x, y, z, transformation, result
                }
            );
        }

        public static async ValueTask<Vector3> CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "CatmullRom" }, value1, value2, value3, value4, amount
                }
            );
        }

        public static async ValueTask<Vector3> Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Clamp" }, value, min, max
                }
            );
        }

        public static async ValueTask ClampToRef(Vector3 value, Vector3 min, Vector3 max, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "ClampToRef" }, value, min, max, result
                }
            );
        }

        public static async ValueTask CheckExtends(Vector3 v, Vector3 min, Vector3 max)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "CheckExtends" }, v, min, max
                }
            );
        }

        public static async ValueTask<Vector3> Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Hermite" }, value1, tangent1, value2, tangent2, amount
                }
            );
        }

        public static async ValueTask<Vector3> Lerp(Vector3 start, Vector3 end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Lerp" }, start, end, amount
                }
            );
        }

        public static async ValueTask LerpToRef(Vector3 start, Vector3 end, decimal amount, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "LerpToRef" }, start, end, amount, result
                }
            );
        }

        public static async ValueTask<decimal> Dot(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Dot" }, left, right
                }
            );
        }

        public static async ValueTask<Vector3> Cross(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Cross" }, left, right
                }
            );
        }

        public static async ValueTask CrossToRef(Vector3 left, Vector3 right, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "CrossToRef" }, left, right, result
                }
            );
        }

        public static async ValueTask<Vector3> Normalize(Vector3 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Normalize" }, vector
                }
            );
        }

        public static async ValueTask NormalizeToRef(Vector3 vector, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "NormalizeToRef" }, vector, result
                }
            );
        }

        public static async ValueTask<Vector3> Project(Vector3 vector, Matrix world, Matrix transform, Viewport viewport)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Project" }, vector, world, transform, viewport
                }
            );
        }

        public static async ValueTask<Vector3> ProjectToRef(Vector3 vector, Matrix world, Matrix transform, Viewport viewport, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "ProjectToRef" }, vector, world, transform, viewport, result
                }
            );
        }

        public static async ValueTask<Vector3> UnprojectFromTransform(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix transform)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFromTransform" }, source, viewportWidth, viewportHeight, world, transform
                }
            );
        }

        public static async ValueTask<Vector3> Unproject(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Unproject" }, source, viewportWidth, viewportHeight, world, view, projection
                }
            );
        }

        public static async ValueTask UnprojectToRef(Vector3 source, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectToRef" }, source, viewportWidth, viewportHeight, world, view, projection, result
                }
            );
        }

        public static async ValueTask UnprojectFloatsToRef(decimal sourceX, decimal sourceY, decimal sourceZ, decimal viewportWidth, decimal viewportHeight, Matrix world, Matrix view, Matrix projection, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFloatsToRef" }, sourceX, sourceY, sourceZ, viewportWidth, viewportHeight, world, view, projection, result
                }
            );
        }

        public static async ValueTask<Vector3> Minimize(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Minimize" }, left, right
                }
            );
        }

        public static async ValueTask<Vector3> Maximize(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Maximize" }, left, right
                }
            );
        }

        public static async ValueTask<decimal> Distance(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Distance" }, value1, value2
                }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "DistanceSquared" }, value1, value2
                }
            );
        }

        public static async ValueTask<Vector3> Center(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "Center" }, value1, value2
                }
            );
        }

        public static async ValueTask<Vector3> RotationFromAxis(Vector3 axis1, Vector3 axis2, Vector3 axis3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "RotationFromAxis" }, axis1, axis2, axis3
                }
            );
        }

        public static async ValueTask RotationFromAxisToRef(Vector3 axis1, Vector3 axis2, Vector3 axis3, Vector3 @ref)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Vector3", "RotationFromAxisToRef" }, axis1, axis2, axis3, @ref
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

        
        public async ValueTask<bool> get_isNonUniform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isNonUniform"
                );
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

        public static async ValueTask<Vector3> NewVector3(
            System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<decimal> z = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector3" },
                x, y, z
            );

            return new Vector3(entity);
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

        public async ValueTask<Vector3> toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toArray" }, array, index
                }
            );
        }

        public async ValueTask<Vector3> fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "fromArray" }, array, index
                }
            );
        }

        public async ValueTask<Quaternion> toQuaternion()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toQuaternion" }
                }
            );
        }

        public async ValueTask<Vector3> addInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> addInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> add(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> addToRef(Vector3 otherVector, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector3> subtractInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> subtract(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> subtractToRef(Vector3 otherVector, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector3> subtractFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> subtractFromFloatsToRef(decimal x, decimal y, decimal z, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtractFromFloatsToRef" }, x, y, z, result
                }
            );
        }

        public async ValueTask<Vector3> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negate" }
                }
            );
        }

        public async ValueTask<Vector3> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateInPlace" }
                }
            );
        }

        public async ValueTask<Vector3> negateToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "negateToRef" }, result
                }
            );
        }

        public async ValueTask<Vector3> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleInPlace" }, scale
                }
            );
        }

        public async ValueTask<Vector3> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Vector3> scaleToRef(decimal scale, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Vector3> scaleAndAddToRef(decimal scale, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Vector3> projectOnPlane(Plane plane, Vector3 origin)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "projectOnPlane" }, plane, origin
                }
            );
        }

        public async ValueTask projectOnPlaneToRef(Plane plane, Vector3 origin, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "projectOnPlaneToRef" }, plane, origin, result
                }
            );
        }

        public async ValueTask<bool> equals(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, otherVector
                }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(Vector3 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsWithEpsilon" }, otherVector, epsilon
                }
            );
        }

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equalsToFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> multiplyInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> multiply(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> multiplyToRef(Vector3 otherVector, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector3> multiplyByFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyByFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> divide(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divide" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> divideToRef(Vector3 otherVector, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideToRef" }, otherVector, result
                }
            );
        }

        public async ValueTask<Vector3> divideInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "divideInPlace" }, otherVector
                }
            );
        }

        public async ValueTask<Vector3> minimizeInPlace(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "minimizeInPlace" }, other
                }
            );
        }

        public async ValueTask<Vector3> maximizeInPlace(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "maximizeInPlace" }, other
                }
            );
        }

        public async ValueTask<Vector3> minimizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> maximizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<bool> isNonUniformWithinEpsilon(decimal epsilon)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isNonUniformWithinEpsilon" }, epsilon
                }
            );
        }

        public async ValueTask<Vector3> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "floor" }
                }
            );
        }

        public async ValueTask<Vector3> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public async ValueTask<Vector3> reorderInPlace(string order)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "reorderInPlace" }, order
                }
            );
        }

        public async ValueTask<Vector3> rotateByQuaternionToRef(Quaternion quaternion, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "rotateByQuaternionToRef" }, quaternion, result
                }
            );
        }

        public async ValueTask<Vector3> rotateByQuaternionAroundPointToRef(Quaternion quaternion, Vector3 point, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "rotateByQuaternionAroundPointToRef" }, quaternion, point, result
                }
            );
        }

        public async ValueTask<Vector3> cross(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "cross" }, other
                }
            );
        }

        public async ValueTask<Vector3> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalizeFromLength" }, len
                }
            );
        }

        public async ValueTask<Vector3> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalizeToNew" }
                }
            );
        }

        public async ValueTask<Vector3> normalizeToRef(Vector3 reference)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalizeToRef" }, reference
                }
            );
        }

        public async ValueTask<Vector3> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<Vector3> copyFrom(Vector3 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, source
                }
            );
        }

        public async ValueTask<Vector3> copyFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> set(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, x, y, z
                }
            );
        }

        public async ValueTask<Vector3> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
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