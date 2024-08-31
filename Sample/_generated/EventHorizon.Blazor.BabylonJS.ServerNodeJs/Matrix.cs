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

    [JsonConverter(typeof(CachedEntityConverter<Matrix>))]
    public class Matrix : CachedEntityObject, Tensor<_Tuple<T, N, R>, Matrix>, IMatrixLike
    {
        #region Static Accessors

        public static async ValueTask<bool> get_Use64Bits()
        {
            return await EventHorizonBlazorInterop.Get<bool>("BABYLON", "Matrix.Use64Bits");
        }

        private static Matrix __IdentityReadOnly;

        public static async ValueTask<Matrix> get_IdentityReadOnly()
        {
            if (__IdentityReadOnly == null)
            {
                __IdentityReadOnly = await EventHorizonBlazorInterop.GetClass<Matrix>(
                    "BABYLON",
                    "Matrix.IdentityReadOnly",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __IdentityReadOnly;
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Matrix> FromArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "FromArray" }, array, offset }
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
                    new string[] { "BABYLON", "Matrix", "FromArrayToRef" },
                    array,
                    offset,
                    result
                }
            );
        }

        public static async ValueTask<T> FromFloat32ArrayToRefScaled<T>(
            decimal[] array,
            decimal offset,
            decimal scale,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "FromFloat32ArrayToRefScaled" },
                    array,
                    offset,
                    scale,
                    result
                }
            );
        }

        public static async ValueTask FromValuesToRef(
            decimal initialM11,
            decimal initialM12,
            decimal initialM13,
            decimal initialM14,
            decimal initialM21,
            decimal initialM22,
            decimal initialM23,
            decimal initialM24,
            decimal initialM31,
            decimal initialM32,
            decimal initialM33,
            decimal initialM34,
            decimal initialM41,
            decimal initialM42,
            decimal initialM43,
            decimal initialM44,
            Matrix result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "FromValuesToRef" },
                    initialM11,
                    initialM12,
                    initialM13,
                    initialM14,
                    initialM21,
                    initialM22,
                    initialM23,
                    initialM24,
                    initialM31,
                    initialM32,
                    initialM33,
                    initialM34,
                    initialM41,
                    initialM42,
                    initialM43,
                    initialM44,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> FromValues(
            decimal initialM11,
            decimal initialM12,
            decimal initialM13,
            decimal initialM14,
            decimal initialM21,
            decimal initialM22,
            decimal initialM23,
            decimal initialM24,
            decimal initialM31,
            decimal initialM32,
            decimal initialM33,
            decimal initialM34,
            decimal initialM41,
            decimal initialM42,
            decimal initialM43,
            decimal initialM44
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "FromValues" },
                    initialM11,
                    initialM12,
                    initialM13,
                    initialM14,
                    initialM21,
                    initialM22,
                    initialM23,
                    initialM24,
                    initialM31,
                    initialM32,
                    initialM33,
                    initialM34,
                    initialM41,
                    initialM42,
                    initialM43,
                    initialM44
                }
            );
        }

        public static async ValueTask<Matrix> Compose(
            Vector3 scale,
            Quaternion rotation,
            Vector3 translation
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "Compose" },
                    scale,
                    rotation,
                    translation
                }
            );
        }

        public static async ValueTask<T> ComposeToRef<T>(
            Vector3 scale,
            Quaternion rotation,
            Vector3 translation,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ComposeToRef" },
                    scale,
                    rotation,
                    translation,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> Identity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Identity" } }
            );
        }

        public static async ValueTask<T> IdentityToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "IdentityToRef" }, result }
            );
        }

        public static async ValueTask<Matrix> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Zero" } }
            );
        }

        public static async ValueTask<Matrix> RotationX(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationX" }, angle }
            );
        }

        public static async ValueTask<Matrix> Invert(Matrix source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Invert" }, source }
            );
        }

        public static async ValueTask<T> RotationXToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationXToRef" },
                    angle,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> RotationY(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationY" }, angle }
            );
        }

        public static async ValueTask<T> RotationYToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationYToRef" },
                    angle,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> RotationZ(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationZ" }, angle }
            );
        }

        public static async ValueTask<T> RotationZToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationZToRef" },
                    angle,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> RotationAxis(Vector3 axis, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationAxis" }, axis, angle }
            );
        }

        public static async ValueTask<T> RotationAxisToRef<T>(Vector3 axis, decimal angle, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationAxisToRef" },
                    axis,
                    angle,
                    result
                }
            );
        }

        public static async ValueTask<T> RotationAlignToRef<T>(
            Vector3 from,
            Vector3 to,
            T result,
            System.Nullable<bool> useYAxisForCoplanar = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationAlignToRef" },
                    from,
                    to,
                    result,
                    useYAxisForCoplanar
                }
            );
        }

        public static async ValueTask<Matrix> RotationYawPitchRoll(
            decimal yaw,
            decimal pitch,
            decimal roll
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationYawPitchRoll" },
                    yaw,
                    pitch,
                    roll
                }
            );
        }

        public static async ValueTask<T> RotationYawPitchRollToRef<T>(
            decimal yaw,
            decimal pitch,
            decimal roll,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationYawPitchRollToRef" },
                    yaw,
                    pitch,
                    roll,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> Scaling(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Scaling" }, x, y, z }
            );
        }

        public static async ValueTask<T> ScalingToRef<T>(decimal x, decimal y, decimal z, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ScalingToRef" },
                    x,
                    y,
                    z,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> Translation(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Translation" }, x, y, z }
            );
        }

        public static async ValueTask<T> TranslationToRef<T>(
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
                    new string[] { "BABYLON", "Matrix", "TranslationToRef" },
                    x,
                    y,
                    z,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> Lerp(
            Matrix startValue,
            Matrix endValue,
            decimal gradient
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "Lerp" },
                    startValue,
                    endValue,
                    gradient
                }
            );
        }

        public static async ValueTask<T> LerpToRef<T>(
            Matrix startValue,
            Matrix endValue,
            decimal gradient,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LerpToRef" },
                    startValue,
                    endValue,
                    gradient,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> DecomposeLerp(
            Matrix startValue,
            Matrix endValue,
            decimal gradient
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "DecomposeLerp" },
                    startValue,
                    endValue,
                    gradient
                }
            );
        }

        public static async ValueTask<T> DecomposeLerpToRef<T>(
            Matrix startValue,
            Matrix endValue,
            decimal gradient,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "DecomposeLerpToRef" },
                    startValue,
                    endValue,
                    gradient,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> LookAtLH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "LookAtLH" }, eye, target, up }
            );
        }

        public static async ValueTask<Matrix> LookAtLHToRef(
            Vector3 eye,
            Vector3 target,
            Vector3 up,
            Matrix result
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookAtLHToRef" },
                    eye,
                    target,
                    up,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> LookAtRH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "LookAtRH" }, eye, target, up }
            );
        }

        public static async ValueTask<T> LookAtRHToRef<T>(
            Vector3 eye,
            Vector3 target,
            Vector3 up,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookAtRHToRef" },
                    eye,
                    target,
                    up,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> LookDirectionLH(Vector3 forward, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionLH" },
                    forward,
                    up
                }
            );
        }

        public static async ValueTask<T> LookDirectionLHToRef<T>(
            Vector3 forward,
            Vector3 up,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionLHToRef" },
                    forward,
                    up,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> LookDirectionRH(Vector3 forward, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionRH" },
                    forward,
                    up
                }
            );
        }

        public static async ValueTask<T> LookDirectionRHToRef<T>(
            Vector3 forward,
            Vector3 up,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionRHToRef" },
                    forward,
                    up,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> OrthoLH(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoLH" },
                    width,
                    height,
                    znear,
                    zfar,
                    halfZRange
                }
            );
        }

        public static async ValueTask<T> OrthoLHToRef<T>(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoLHToRef" },
                    width,
                    height,
                    znear,
                    zfar,
                    result,
                    halfZRange
                }
            );
        }

        public static async ValueTask<Matrix> OrthoOffCenterLH(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterLH" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    halfZRange
                }
            );
        }

        public static async ValueTask<T> OrthoOffCenterLHToRef<T>(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterLHToRef" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    result,
                    halfZRange
                }
            );
        }

        public static async ValueTask<T> ObliqueOffCenterLHToRef<T>(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            decimal length,
            decimal angle,
            decimal distance,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ObliqueOffCenterLHToRef" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    length,
                    angle,
                    distance,
                    result,
                    halfZRange
                }
            );
        }

        public static async ValueTask<Matrix> OrthoOffCenterRH(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterRH" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    halfZRange
                }
            );
        }

        public static async ValueTask<T> OrthoOffCenterRHToRef<T>(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterRHToRef" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    result,
                    halfZRange
                }
            );
        }

        public static async ValueTask<T> ObliqueOffCenterRHToRef<T>(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            decimal length,
            decimal angle,
            decimal distance,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ObliqueOffCenterRHToRef" },
                    left,
                    right,
                    bottom,
                    top,
                    znear,
                    zfar,
                    length,
                    angle,
                    distance,
                    result,
                    halfZRange
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveLH(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveLH" },
                    width,
                    height,
                    znear,
                    zfar,
                    halfZRange,
                    projectionPlaneTilt
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveFovLH(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovLH" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    halfZRange,
                    projectionPlaneTilt,
                    reverseDepthBufferMode
                }
            );
        }

        public static async ValueTask<T> PerspectiveFovLHToRef<T>(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> isVerticalFovFixed = null,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovLHToRef" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    result,
                    isVerticalFovFixed,
                    halfZRange,
                    projectionPlaneTilt,
                    reverseDepthBufferMode
                }
            );
        }

        public static async ValueTask<T> PerspectiveFovReverseLHToRef<T>(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> isVerticalFovFixed = null,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovReverseLHToRef" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    result,
                    isVerticalFovFixed,
                    halfZRange,
                    projectionPlaneTilt
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveFovRH(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovRH" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    halfZRange,
                    projectionPlaneTilt,
                    reverseDepthBufferMode
                }
            );
        }

        public static async ValueTask<T> PerspectiveFovRHToRef<T>(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> isVerticalFovFixed = null,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovRHToRef" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    result,
                    isVerticalFovFixed,
                    halfZRange,
                    projectionPlaneTilt,
                    reverseDepthBufferMode
                }
            );
        }

        public static async ValueTask<T> PerspectiveFovReverseRHToRef<T>(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> isVerticalFovFixed = null,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovReverseRHToRef" },
                    fov,
                    aspect,
                    znear,
                    zfar,
                    result,
                    isVerticalFovFixed,
                    halfZRange,
                    projectionPlaneTilt
                }
            );
        }

        public static async ValueTask<Matrix> GetFinalMatrix(
            Viewport viewport,
            Matrix world,
            Matrix view,
            Matrix projection,
            decimal zmin,
            decimal zmax
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "GetFinalMatrix" },
                    viewport,
                    world,
                    view,
                    projection,
                    zmin,
                    zmax
                }
            );
        }

        public static async ValueTask<decimal[]> GetAsMatrix2x2(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Matrix", "GetAsMatrix2x2" }, matrix }
            );
        }

        public static async ValueTask<decimal[]> GetAsMatrix3x3(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Matrix", "GetAsMatrix3x3" }, matrix }
            );
        }

        public static async ValueTask<Matrix> Transpose(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Transpose" }, matrix }
            );
        }

        public static async ValueTask<T> TransposeToRef<T>(Matrix matrix, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "TransposeToRef" },
                    matrix,
                    result
                }
            );
        }

        public static async ValueTask<Matrix> Reflection(IPlaneLike plane)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Reflection" }, plane }
            );
        }

        public static async ValueTask<T> ReflectionToRef<T>(IPlaneLike plane, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ReflectionToRef" },
                    plane,
                    result
                }
            );
        }

        public static async ValueTask<T> FromXYZAxesToRef<T>(
            Vector3 xaxis,
            Vector3 yaxis,
            Vector3 zaxis,
            T result
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "FromXYZAxesToRef" },
                    xaxis,
                    yaxis,
                    zaxis,
                    result
                }
            );
        }

        public static async ValueTask<T> FromQuaternionToRef<T>(Quaternion quat, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "FromQuaternionToRef" },
                    quat,
                    result
                }
            );
        }
        #endregion

        #region Accessors
        private _Tuple<T, N, R> __m;

        public async ValueTask<_Tuple<T, N, R>> get_m()
        {
            if (__m == null)
            {
                __m = await EventHorizonBlazorInterop.GetClass<_Tuple<T, N, R>>(
                    this.___guid,
                    "m",
                    (entity) =>
                    {
                        return new _Tuple<T, N, R>() { ___guid = entity.___guid };
                    }
                );
            }
            return __m;
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

        public async ValueTask<decimal> get_updateFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "updateFlag");
        }

        public ValueTask set_updateFlag(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "updateFlag", value);
        }
        #endregion

        #region Constructor
        public Matrix()
            : base() { }

        public Matrix(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask markAsUpdated()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsUpdated" } }
            );
        }

        public async ValueTask<bool> isIdentity()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isIdentity" } }
            );
        }

        public async ValueTask<bool> isIdentityAs3x2()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isIdentityAs3x2" } }
            );
        }

        public async ValueTask<decimal> determinant()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "determinant" } }
            );
        }

        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" } }
            );
        }

        public async ValueTask<decimal[]> toArray(decimal[] array, decimal index)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<_Tuple<T, N, R>> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<Matrix> fromArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public async ValueTask<Matrix> copyFromFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, floats }
            );
        }

        public async ValueTask<Matrix> set(_Tuple<T, N, R> values)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, values }
            );
        }

        public async ValueTask<Matrix> setAll(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public async ValueTask<Matrix> invert()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invert" } }
            );
        }

        public async ValueTask<Matrix> reset()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public async ValueTask<Matrix> add(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public async ValueTask<T> addToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public async ValueTask<Matrix> addToSelf(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToSelf" }, other }
            );
        }

        public async ValueTask<Matrix> addInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> addInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<Matrix> subtract(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public async ValueTask<T> subtractToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public async ValueTask<Matrix> subtractInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> subtractFromFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, floats }
            );
        }

        public async ValueTask<T> subtractFromFloatsToRef<T>(T args)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloatsToRef" }, args }
            );
        }

        public async ValueTask<T> invertToRef<T>(T other)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertToRef" }, other }
            );
        }

        public async ValueTask<Matrix> addAtIndex(decimal index, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addAtIndex" }, index, value }
            );
        }

        public async ValueTask<Matrix> multiplyAtIndex(decimal index, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyAtIndex" }, index, value }
            );
        }

        public async ValueTask<Matrix> setTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setTranslationFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<Matrix> addTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addTranslationFromFloats" }, x, y, z }
            );
        }

        public async ValueTask<Matrix> setTranslation(Vector3 vector3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setTranslation" }, vector3 }
            );
        }

        public async ValueTask<Vector3> getTranslation()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTranslation" } }
            );
        }

        public async ValueTask<T> getTranslationToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTranslationToRef" }, result }
            );
        }

        public async ValueTask<Matrix> removeRotationAndScaling()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeRotationAndScaling" } }
            );
        }

        public async ValueTask<Matrix> copyFrom(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public async ValueTask<Matrix> copyToArray(
            decimal[] array,
            System.Nullable<decimal> offset = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyToArray" }, array, offset }
            );
        }

        public async ValueTask<Matrix> multiply(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, other }
            );
        }

        public async ValueTask<Matrix> multiplyInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> multiplyByFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, floats }
            );
        }

        public async ValueTask<T> multiplyByFloatsToRef<T>(T args)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloatsToRef" }, args }
            );
        }

        public async ValueTask<T> multiplyToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public async ValueTask<Matrix> multiplyToArray(
            Matrix other,
            decimal[] result,
            decimal offset
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyToArray" },
                    other,
                    result,
                    offset
                }
            );
        }

        public async ValueTask<Matrix> divide(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, other }
            );
        }

        public async ValueTask<T> divideToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, other, result }
            );
        }

        public async ValueTask<Matrix> divideInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> minimizeInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> minimizeInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<Matrix> maximizeInPlace(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<Matrix> maximizeInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<Matrix> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<Matrix> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
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

        public async ValueTask<bool> equals(Matrix value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, value }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            Matrix other,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsWithEpsilon" }, other, epsilon }
            );
        }

        public async ValueTask<bool> equalsToFloats(_Tuple<T, N, R> floats)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, floats }
            );
        }

        public async ValueTask<Matrix> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
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

        public async ValueTask<Matrix> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
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

        public async ValueTask<Matrix> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
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

        public async ValueTask<bool> decomposeToTransformNode(TransformNode node)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "decomposeToTransformNode" }, node }
            );
        }

        public async ValueTask<bool> decompose(
            Vector3 scale = null,
            Quaternion rotation = null,
            Vector3 translation = null,
            TransformNode preserveScalingNode = null,
            System.Nullable<bool> useAbsoluteScaling = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "decompose" },
                    scale,
                    rotation,
                    translation,
                    preserveScalingNode,
                    useAbsoluteScaling
                }
            );
        }

        public async ValueTask<Vector4> getRow(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRow" }, index }
            );
        }

        public async ValueTask<T> getRowToRef<T>(decimal index, T rowVector)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRowToRef" }, index, rowVector }
            );
        }

        public async ValueTask<Matrix> setRow(decimal index, Vector4 row)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setRow" }, index, row }
            );
        }

        public async ValueTask<Matrix> transpose()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transpose" } }
            );
        }

        public async ValueTask<T> transposeToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transposeToRef" }, result }
            );
        }

        public async ValueTask<Matrix> setRowFromFloats(
            decimal index,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRowFromFloats" },
                    index,
                    x,
                    y,
                    z,
                    w
                }
            );
        }

        public async ValueTask<Matrix> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
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

        public async ValueTask<T> scaleAndAddToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public async ValueTask<Matrix> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<T> toNormalMatrix<T>(T @ref)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toNormalMatrix" }, @ref }
            );
        }

        public async ValueTask<Matrix> getRotationMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotationMatrix" } }
            );
        }

        public async ValueTask<T> getRotationMatrixToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotationMatrixToRef" }, result }
            );
        }

        public async ValueTask<Matrix> toggleModelMatrixHandInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toggleModelMatrixHandInPlace" } }
            );
        }

        public async ValueTask<Matrix> toggleProjectionMatrixHandInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toggleProjectionMatrixHandInPlace" } }
            );
        }
        #endregion
    }
}
