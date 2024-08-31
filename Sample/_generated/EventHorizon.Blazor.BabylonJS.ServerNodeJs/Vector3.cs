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

    [JsonConverter(typeof(CachedEntityConverter<Vector3>))]
    public class Vector3 : CachedEntityObject, Vector<_Tuple<T, N, R>, Vector3>, IVector3Like
    {
        #region Static Accessors
        private static Vector3 __UpReadOnly;

        public static async ValueTask<Vector3> get_UpReadOnly()
        {
            if (__UpReadOnly == null)
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

        private static Vector3 __DownReadOnly;

        public static async ValueTask<Vector3> get_DownReadOnly()
        {
            if (__DownReadOnly == null)
            {
                __DownReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.DownReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __DownReadOnly;
        }

        private static Vector3 __RightReadOnly;

        public static async ValueTask<Vector3> get_RightReadOnly()
        {
            if (__RightReadOnly == null)
            {
                __RightReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.RightReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __RightReadOnly;
        }

        private static Vector3 __LeftReadOnly;

        public static async ValueTask<Vector3> get_LeftReadOnly()
        {
            if (__LeftReadOnly == null)
            {
                __LeftReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.LeftReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __LeftReadOnly;
        }

        private static Vector3 __LeftHandedForwardReadOnly;

        public static async ValueTask<Vector3> get_LeftHandedForwardReadOnly()
        {
            if (__LeftHandedForwardReadOnly == null)
            {
                __LeftHandedForwardReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.LeftHandedForwardReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __LeftHandedForwardReadOnly;
        }

        private static Vector3 __RightHandedForwardReadOnly;

        public static async ValueTask<Vector3> get_RightHandedForwardReadOnly()
        {
            if (__RightHandedForwardReadOnly == null)
            {
                __RightHandedForwardReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.RightHandedForwardReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __RightHandedForwardReadOnly;
        }

        private static Vector3 __LeftHandedBackwardReadOnly;

        public static async ValueTask<Vector3> get_LeftHandedBackwardReadOnly()
        {
            if (__LeftHandedBackwardReadOnly == null)
            {
                __LeftHandedBackwardReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.LeftHandedBackwardReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __LeftHandedBackwardReadOnly;
        }

        private static Vector3 __RightHandedBackwardReadOnly;

        public static async ValueTask<Vector3> get_RightHandedBackwardReadOnly()
        {
            if (__RightHandedBackwardReadOnly == null)
            {
                __RightHandedBackwardReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.RightHandedBackwardReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __RightHandedBackwardReadOnly;
        }

        private static Vector3 __ZeroReadOnly;

        public static async ValueTask<Vector3> get_ZeroReadOnly()
        {
            if (__ZeroReadOnly == null)
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

        private static Vector3 __OneReadOnly;

        public static async ValueTask<Vector3> get_OneReadOnly()
        {
            if (__OneReadOnly == null)
            {
                __OneReadOnly = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Vector3.OneReadOnly",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __OneReadOnly;
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<decimal> GetClipFactor(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 axis,
            decimal size
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetClipFactor" },
                    vector0,
                    vector1,
                    axis,
                    size
                }
            );
        }

        public static async ValueTask<decimal> GetAngleBetweenVectors(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 normal
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectors" },
                    vector0,
                    vector1,
                    normal
                }
            );
        }

        public static async ValueTask<decimal> GetAngleBetweenVectorsOnPlane(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 normal
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectorsOnPlane" },
                    vector0,
                    vector1,
                    normal
                }
            );
        }

        public static async ValueTask<T> PitchYawRollToMoveBetweenPointsToRef<T>(
            Vector3 start,
            Vector3 target,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "PitchYawRollToMoveBetweenPointsToRef" },
                    start,
                    target,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector3> PitchYawRollToMoveBetweenPoints(
            Vector3 start,
            Vector3 target
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "PitchYawRollToMoveBetweenPoints" },
                    start,
                    target
                }
            );
        }

        public static async ValueTask<T> SlerpToRef<T>(
            Vector3 vector0,
            Vector3 vector1,
            decimal slerp,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "SlerpToRef" },
                    vector0,
                    vector1,
                    slerp,
                    result
                }
            );
        }

        public static async ValueTask<T> SmoothToRef<T>(
            Vector3 source,
            Vector3 goal,
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
                    new string[] { "BABYLON", "Vector3", "SmoothToRef" },
                    source,
                    goal,
                    deltaTime,
                    lerpTime,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "FromArray" }, array, offset }
            );
        }

        public static async ValueTask<Vector3> FromFloatArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArray" },
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
                    new string[] { "BABYLON", "Vector3", "FromArrayToRef" },
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
                    new string[] { "BABYLON", "Vector3", "FromFloatArrayToRef" },
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
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatsToRef" },
                    x,
                    y,
                    z,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Zero" } }
            );
        }

        public static async ValueTask<Vector3> One()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "One" } }
            );
        }

        public static async ValueTask<Vector3> Up()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Up" } }
            );
        }

        public static async ValueTask<Vector3> Down()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Down" } }
            );
        }

        public static async ValueTask<Vector3> Forward(
            System.Nullable<bool> rightHandedSystem = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Forward" }, rightHandedSystem }
            );
        }

        public static async ValueTask<Vector3> Backward(
            System.Nullable<bool> rightHandedSystem = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Backward" },
                    rightHandedSystem
                }
            );
        }

        public static async ValueTask<Vector3> Right()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Right" } }
            );
        }

        public static async ValueTask<Vector3> Left()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Left" } }
            );
        }

        public static async ValueTask<Vector3> Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Vector3", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector3> TransformCoordinates(
            Vector3 vector,
            Matrix transformation
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinates" },
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
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesToRef" },
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
                    new string[] { "BABYLON", "Vector3", "TransformCoordinatesFromFloatsToRef" },
                    x,
                    y,
                    z,
                    transformation,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> TransformNormal(
            Vector3 vector,
            Matrix transformation
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormal" },
                    vector,
                    transformation
                }
            );
        }

        public static async ValueTask<T> TransformNormalToRef<T>(
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
                    new string[] { "BABYLON", "Vector3", "TransformNormalToRef" },
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
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormalFromFloatsToRef" },
                    x,
                    y,
                    z,
                    transformation,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> CatmullRom(
            Vector3 value1,
            Vector3 value2,
            Vector3 value3,
            Vector3 value4,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CatmullRom" },
                    value1,
                    value2,
                    value3,
                    value4,
                    amount
                }
            );
        }

        public static async ValueTask<Vector3> Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Clamp" }, value, min, max }
            );
        }

        public static async ValueTask<T> ClampToRef<T>(
            Vector3 value,
            Vector3 min,
            Vector3 max,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ClampToRef" },
                    value,
                    min,
                    max,
                    result
                }
            );
        }

        public static async ValueTask CheckExtends(Vector3 v, Vector3 min, Vector3 max)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { "BABYLON", "Vector3", "CheckExtends" }, v, min, max }
            );
        }

        public static async ValueTask<Vector3> Hermite(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal amount
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Hermite" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    amount
                }
            );
        }

        public static async ValueTask<Vector3> Hermite1stDerivative(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal time
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Hermite1stDerivative" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time
                }
            );
        }

        public static async ValueTask<T> Hermite1stDerivativeToRef<T>(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Hermite1stDerivativeToRef" },
                    value1,
                    tangent1,
                    value2,
                    tangent2,
                    time,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Lerp(Vector3 start, Vector3 end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Lerp" }, start, end, amount }
            );
        }

        public static async ValueTask<T> LerpToRef<T>(
            Vector3 start,
            Vector3 end,
            decimal amount,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "LerpToRef" },
                    start,
                    end,
                    amount,
                    result
                }
            );
        }

        public static async ValueTask<decimal> Dot(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector3", "Dot" }, left, right }
            );
        }

        public static async ValueTask<Vector3> Cross(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Cross" }, left, right }
            );
        }

        public static async ValueTask<T> CrossToRef<T>(Vector3 left, Vector3 right, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CrossToRef" },
                    left,
                    right,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Normalize(Vector3 vector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Normalize" }, vector }
            );
        }

        public static async ValueTask<T> NormalizeToRef<T>(Vector3 vector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Project(
            Vector3 vector,
            Matrix world,
            Matrix transform,
            Viewport viewport
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Project" },
                    vector,
                    world,
                    transform,
                    viewport
                }
            );
        }

        public static async ValueTask<T> ProjectToRef<T>(
            Vector3 vector,
            Matrix world,
            Matrix transform,
            Viewport viewport,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ProjectToRef" },
                    vector,
                    world,
                    transform,
                    viewport,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Reflect(Vector3 inDirection, Vector3 normal)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Reflect" },
                    inDirection,
                    normal
                }
            );
        }

        public static async ValueTask<T> ReflectToRef<T>(
            Vector3 inDirection,
            Vector3 normal,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ReflectToRef" },
                    inDirection,
                    normal,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector3> UnprojectFromTransform(
            Vector3 source,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix transform
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFromTransform" },
                    source,
                    viewportWidth,
                    viewportHeight,
                    world,
                    transform
                }
            );
        }

        public static async ValueTask<Vector3> Unproject(
            Vector3 source,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix view,
            Matrix projection
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Unproject" },
                    source,
                    viewportWidth,
                    viewportHeight,
                    world,
                    view,
                    projection
                }
            );
        }

        public static async ValueTask<T> UnprojectToRef<T>(
            Vector3 source,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix view,
            Matrix projection,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectToRef" },
                    source,
                    viewportWidth,
                    viewportHeight,
                    world,
                    view,
                    projection,
                    result
                }
            );
        }

        public static async ValueTask<T> UnprojectFloatsToRef<T>(
            decimal sourceX,
            decimal sourceY,
            decimal sourceZ,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix view,
            Matrix projection,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "UnprojectFloatsToRef" },
                    sourceX,
                    sourceY,
                    sourceZ,
                    viewportWidth,
                    viewportHeight,
                    world,
                    view,
                    projection,
                    result
                }
            );
        }

        public static async ValueTask<Vector3> Minimize(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Minimize" }, left, right }
            );
        }

        public static async ValueTask<Vector3> Maximize(Vector3 left, Vector3 right)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Maximize" }, left, right }
            );
        }

        public static async ValueTask<decimal> Distance(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector3", "Distance" }, value1, value2 }
            );
        }

        public static async ValueTask<decimal> DistanceSquared(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static async ValueTask<decimal> ProjectOnTriangleToRef(
            Vector3 vector,
            Vector3 p0,
            Vector3 p1,
            Vector3 p2,
            Vector3 @ref
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "ProjectOnTriangleToRef" },
                    vector,
                    p0,
                    p1,
                    p2,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector3> Center(Vector3 value1, Vector3 value2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Center" }, value1, value2 }
            );
        }

        public static async ValueTask<T> CenterToRef<T>(Vector3 value1, Vector3 value2, T @ref)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "CenterToRef" },
                    value1,
                    value2,
                    @ref
                }
            );
        }

        public static async ValueTask<Vector3> RotationFromAxis(
            Vector3 axis1,
            Vector3 axis2,
            Vector3 axis3
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "RotationFromAxis" },
                    axis1,
                    axis2,
                    axis3
                }
            );
        }

        public static async ValueTask<T> RotationFromAxisToRef<T>(
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
                    new string[] { "BABYLON", "Vector3", "RotationFromAxisToRef" },
                    axis1,
                    axis2,
                    axis3,
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

        public async ValueTask<bool> get_isNonUniform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNonUniform");
        }

        public async ValueTask<bool> get_hasAZeroComponent()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasAZeroComponent");
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
        public Vector3()
            : base() { }

        public Vector3(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Vector3> NewVector3(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector3" },
                x,
                y,
                z
            );

            return new Vector3(entity);
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

        public async ValueTask<Vector3> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<Vector3> fromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public async ValueTask<Quaternion> toQuaternion()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toQuaternion" } }
            );
        }

        public async ValueTask<Vector3> addInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector3> addInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> add(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public async ValueTask<T> addToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector3> subtractInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector3> subtract(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public async ValueTask<T> subtractToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector3> subtractFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(
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
                    new string[] { this.___guid, "subtractFromFloatsToRef" },
                    x,
                    y,
                    z,
                    result
                }
            );
        }

        public async ValueTask<Vector3> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<Vector3> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<Vector3> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> getNormalToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getNormalToRef" }, result }
            );
        }

        public async ValueTask<T> applyRotationQuaternionToRef<T>(Quaternion q, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyRotationQuaternionToRef" },
                    q,
                    result
                }
            );
        }

        public async ValueTask<Vector3> applyRotationQuaternionInPlace(Quaternion q)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyRotationQuaternionInPlace" }, q }
            );
        }

        public async ValueTask<Vector3> applyRotationQuaternion(Quaternion q)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyRotationQuaternion" }, q }
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

        public async ValueTask<Vector3> projectOnPlane(Plane plane, Vector3 origin)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "projectOnPlane" }, plane, origin }
            );
        }

        public async ValueTask<T> projectOnPlaneToRef<T>(Plane plane, Vector3 origin, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "projectOnPlaneToRef" },
                    plane,
                    origin,
                    result
                }
            );
        }

        public async ValueTask<bool> equals(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            Vector3 otherVector,
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

        public async ValueTask<bool> equalsToFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> multiplyInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector3> multiply(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector3> multiplyByFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> divide(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public async ValueTask<T> divideToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public async ValueTask<Vector3> divideInPlace(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public async ValueTask<Vector3> minimizeInPlace(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector3> maximizeInPlace(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Vector3> minimizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> maximizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<bool> isNonUniformWithinEpsilon(decimal epsilon)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isNonUniformWithinEpsilon" }, epsilon }
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

        public async ValueTask<Vector3> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public async ValueTask<Vector3> reorderInPlace(string order)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reorderInPlace" }, order }
            );
        }

        public async ValueTask<T> rotateByQuaternionToRef<T>(Quaternion quaternion, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateByQuaternionToRef" },
                    quaternion,
                    result
                }
            );
        }

        public async ValueTask<T> rotateByQuaternionAroundPointToRef<T>(
            Quaternion quaternion,
            Vector3 point,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateByQuaternionAroundPointToRef" },
                    quaternion,
                    point,
                    result
                }
            );
        }

        public async ValueTask<Vector3> cross(Vector3 other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "cross" }, other }
            );
        }

        public async ValueTask<Vector3> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public async ValueTask<Vector3> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public async ValueTask<Vector3> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<Vector3> copyFrom(Vector3 source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<Vector3> copyFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> set(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z }
            );
        }

        public async ValueTask<Vector3> setAll(decimal v)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public async ValueTask<decimal> dot(Vector3 otherVector)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
