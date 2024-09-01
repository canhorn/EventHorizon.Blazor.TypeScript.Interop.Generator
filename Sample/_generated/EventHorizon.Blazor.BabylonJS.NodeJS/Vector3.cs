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
    public class Vector3 : CachedEntityObject, Vector<_Tuple<T, N, R>, Vector3>, IVector3Like
    {
        #region Static Accessors
        private static Vector3 __UpReadOnly;
        public static Vector3 UpReadOnly
        {
            get
            {
                if (__UpReadOnly == null)
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

        private static Vector3 __DownReadOnly;
        public static Vector3 DownReadOnly
        {
            get
            {
                if (__DownReadOnly == null)
                {
                    __DownReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __RightReadOnly;
        public static Vector3 RightReadOnly
        {
            get
            {
                if (__RightReadOnly == null)
                {
                    __RightReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __LeftReadOnly;
        public static Vector3 LeftReadOnly
        {
            get
            {
                if (__LeftReadOnly == null)
                {
                    __LeftReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __LeftHandedForwardReadOnly;
        public static Vector3 LeftHandedForwardReadOnly
        {
            get
            {
                if (__LeftHandedForwardReadOnly == null)
                {
                    __LeftHandedForwardReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __RightHandedForwardReadOnly;
        public static Vector3 RightHandedForwardReadOnly
        {
            get
            {
                if (__RightHandedForwardReadOnly == null)
                {
                    __RightHandedForwardReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __LeftHandedBackwardReadOnly;
        public static Vector3 LeftHandedBackwardReadOnly
        {
            get
            {
                if (__LeftHandedBackwardReadOnly == null)
                {
                    __LeftHandedBackwardReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __RightHandedBackwardReadOnly;
        public static Vector3 RightHandedBackwardReadOnly
        {
            get
            {
                if (__RightHandedBackwardReadOnly == null)
                {
                    __RightHandedBackwardReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        private static Vector3 __ZeroReadOnly;
        public static Vector3 ZeroReadOnly
        {
            get
            {
                if (__ZeroReadOnly == null)
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

        private static Vector3 __OneReadOnly;
        public static Vector3 OneReadOnly
        {
            get
            {
                if (__OneReadOnly == null)
                {
                    __OneReadOnly = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static decimal GetClipFactor(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 axis,
            decimal size
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
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

        public static decimal GetAngleBetweenVectors(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 normal
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectors" },
                    vector0,
                    vector1,
                    normal
                }
            );
        }

        public static decimal GetAngleBetweenVectorsOnPlane(
            Vector3 vector0,
            Vector3 vector1,
            Vector3 normal
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "GetAngleBetweenVectorsOnPlane" },
                    vector0,
                    vector1,
                    normal
                }
            );
        }

        public static T PitchYawRollToMoveBetweenPointsToRef<T>(
            Vector3 start,
            Vector3 target,
            T @ref
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 PitchYawRollToMoveBetweenPoints(Vector3 start, Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "PitchYawRollToMoveBetweenPoints" },
                    start,
                    target
                }
            );
        }

        public static T SlerpToRef<T>(Vector3 vector0, Vector3 vector1, decimal slerp, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T SmoothToRef<T>(
            Vector3 source,
            Vector3 goal,
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
                    new string[] { "BABYLON", "Vector3", "SmoothToRef" },
                    source,
                    goal,
                    deltaTime,
                    lerpTime,
                    result
                }
            );
        }

        public static Vector3 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "FromArray" }, array, offset }
            );
        }

        public static Vector3 FromFloatArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "FromFloatArray" },
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
                    new string[] { "BABYLON", "Vector3", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static T FromFloatArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T FromFloatsToRef<T>(decimal x, decimal y, decimal z, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Zero" } }
            );
        }

        public static Vector3 One()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "One" } }
            );
        }

        public static Vector3 Up()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Up" } }
            );
        }

        public static Vector3 Down()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Down" } }
            );
        }

        public static Vector3 Forward(System.Nullable<bool> rightHandedSystem = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Forward" }, rightHandedSystem }
            );
        }

        public static Vector3 Backward(System.Nullable<bool> rightHandedSystem = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Backward" },
                    rightHandedSystem
                }
            );
        }

        public static Vector3 Right()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Right" } }
            );
        }

        public static Vector3 Left()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Left" } }
            );
        }

        public static Vector3 Random(
            System.Nullable<decimal> min = null,
            System.Nullable<decimal> max = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Random" }, min, max }
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
                    new string[] { "BABYLON", "Vector3", "RandomToRef" },
                    min,
                    max,
                    @ref
                }
            );
        }

        public static Vector3 TransformCoordinates(Vector3 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformCoordinates" },
                    vector,
                    transformation
                }
            );
        }

        public static T TransformCoordinatesToRef<T>(
            Vector3 vector,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T TransformCoordinatesFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 TransformNormal(Vector3 vector, Matrix transformation)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "TransformNormal" },
                    vector,
                    transformation
                }
            );
        }

        public static T TransformNormalToRef<T>(Vector3 vector, Matrix transformation, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T TransformNormalFromFloatsToRef<T>(
            decimal x,
            decimal y,
            decimal z,
            Matrix transformation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 CatmullRom(
            Vector3 value1,
            Vector3 value2,
            Vector3 value3,
            Vector3 value4,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Clamp" }, value, min, max }
            );
        }

        public static T ClampToRef<T>(Vector3 value, Vector3 min, Vector3 max, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static void CheckExtends(Vector3 v, Vector3 min, Vector3 max)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { "BABYLON", "Vector3", "CheckExtends" }, v, min, max }
            );
        }

        public static Vector3 Hermite(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal amount
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static Vector3 Hermite1stDerivative(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal time
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static T Hermite1stDerivativeToRef<T>(
            Vector3 value1,
            Vector3 tangent1,
            Vector3 value2,
            Vector3 tangent2,
            decimal time,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 Lerp(Vector3 start, Vector3 end, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Lerp" }, start, end, amount }
            );
        }

        public static T LerpToRef<T>(Vector3 start, Vector3 end, decimal amount, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static decimal Dot(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector3", "Dot" }, left, right }
            );
        }

        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Cross" }, left, right }
            );
        }

        public static T CrossToRef<T>(Vector3 left, Vector3 right, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 Normalize(Vector3 vector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Normalize" }, vector }
            );
        }

        public static T NormalizeToRef<T>(Vector3 vector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "NormalizeToRef" },
                    vector,
                    result
                }
            );
        }

        public static Vector3 Project(
            Vector3 vector,
            Matrix world,
            Matrix transform,
            Viewport viewport
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static T ProjectToRef<T>(
            Vector3 vector,
            Matrix world,
            Matrix transform,
            Viewport viewport,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 Reflect(Vector3 inDirection, Vector3 normal)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "Reflect" },
                    inDirection,
                    normal
                }
            );
        }

        public static T ReflectToRef<T>(Vector3 inDirection, Vector3 normal, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 UnprojectFromTransform(
            Vector3 source,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix transform
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static Vector3 Unproject(
            Vector3 source,
            decimal viewportWidth,
            decimal viewportHeight,
            Matrix world,
            Matrix view,
            Matrix projection
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static T UnprojectToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T UnprojectFloatsToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 Minimize(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Minimize" }, left, right }
            );
        }

        public static Vector3 Maximize(Vector3 left, Vector3 right)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Maximize" }, left, right }
            );
        }

        public static decimal Distance(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { "BABYLON", "Vector3", "Distance" }, value1, value2 }
            );
        }

        public static decimal DistanceSquared(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Vector3", "DistanceSquared" },
                    value1,
                    value2
                }
            );
        }

        public static decimal ProjectOnTriangleToRef(
            Vector3 vector,
            Vector3 p0,
            Vector3 p1,
            Vector3 p2,
            Vector3 @ref
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
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

        public static Vector3 Center(Vector3 value1, Vector3 value2)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Vector3", "Center" }, value1, value2 }
            );
        }

        public static T CenterToRef<T>(Vector3 value1, Vector3 value2, T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Vector3 RotationFromAxis(Vector3 axis1, Vector3 axis2, Vector3 axis3)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
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

        public static T RotationFromAxisToRef<T>(
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

        public bool isNonUniform
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNonUniform"); }
        }

        public bool hasAZeroComponent
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasAZeroComponent"); }
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
        public Vector3()
            : base() { }

        public Vector3(ICachedEntity entity)
            : base(entity) { }

        public Vector3(
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            System.Nullable<decimal> z = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Vector3" },
                x,
                y,
                z
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

        public Vector3 toArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public Vector3 fromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, offset }
            );
        }

        public Quaternion toQuaternion()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toQuaternion" } }
            );
        }

        public Vector3 addInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, otherVector }
            );
        }

        public Vector3 addInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, x, y, z }
            );
        }

        public Vector3 add(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, otherVector }
            );
        }

        public T addToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, otherVector, result }
            );
        }

        public Vector3 subtractInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, otherVector }
            );
        }

        public Vector3 subtract(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, otherVector }
            );
        }

        public T subtractToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, otherVector, result }
            );
        }

        public Vector3 subtractFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, x, y, z }
            );
        }

        public T subtractFromFloatsToRef<T>(decimal x, decimal y, decimal z, T result)
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
                    result
                }
            );
        }

        public Vector3 negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public Vector3 negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public Vector3 scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public Vector3 scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
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

        public Vector3 getNormalToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getNormalToRef" }, result }
            );
        }

        public T applyRotationQuaternionToRef<T>(Quaternion q, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyRotationQuaternionToRef" },
                    q,
                    result
                }
            );
        }

        public Vector3 applyRotationQuaternionInPlace(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyRotationQuaternionInPlace" }, q }
            );
        }

        public Vector3 applyRotationQuaternion(Quaternion q)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyRotationQuaternion" }, q }
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

        public Vector3 projectOnPlane(Plane plane, Vector3 origin)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "projectOnPlane" }, plane, origin }
            );
        }

        public T projectOnPlaneToRef<T>(Plane plane, Vector3 origin, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public bool equals(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, otherVector }
            );
        }

        public bool equalsWithEpsilon(Vector3 otherVector, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equalsWithEpsilon" },
                    otherVector,
                    epsilon
                }
            );
        }

        public bool equalsToFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, x, y, z }
            );
        }

        public Vector3 multiplyInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, otherVector }
            );
        }

        public Vector3 multiply(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, otherVector }
            );
        }

        public T multiplyToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, otherVector, result }
            );
        }

        public Vector3 multiplyByFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, x, y, z }
            );
        }

        public Vector3 divide(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, otherVector }
            );
        }

        public T divideToRef<T>(Vector3 otherVector, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, otherVector, result }
            );
        }

        public Vector3 divideInPlace(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, otherVector }
            );
        }

        public Vector3 minimizeInPlace(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Vector3 maximizeInPlace(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Vector3 minimizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, x, y, z }
            );
        }

        public Vector3 maximizeInPlaceFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, x, y, z }
            );
        }

        public bool isNonUniformWithinEpsilon(decimal epsilon)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isNonUniformWithinEpsilon" }, epsilon }
            );
        }

        public T floorToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public Vector3 floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public T fractToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, result }
            );
        }

        public Vector3 fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public decimal lengthSquared()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public Vector3 normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public Vector3 reorderInPlace(string order)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reorderInPlace" }, order }
            );
        }

        public T rotateByQuaternionToRef<T>(Quaternion quaternion, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateByQuaternionToRef" },
                    quaternion,
                    result
                }
            );
        }

        public T rotateByQuaternionAroundPointToRef<T>(
            Quaternion quaternion,
            Vector3 point,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public Vector3 cross(Vector3 other)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "cross" }, other }
            );
        }

        public Vector3 normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public Vector3 normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
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

        public Vector3 clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public Vector3 copyFrom(Vector3 source)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public Vector3 copyFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, x, y, z }
            );
        }

        public Vector3 set(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, x, y, z }
            );
        }

        public Vector3 setAll(decimal v)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, v }
            );
        }

        public decimal dot(Vector3 otherVector)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "dot" }, otherVector }
            );
        }
        #endregion
    }
}
