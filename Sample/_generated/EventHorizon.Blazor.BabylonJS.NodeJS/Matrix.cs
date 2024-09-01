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

    [JsonConverter(typeof(CachedEntityConverter<Matrix>))]
    public class Matrix : CachedEntityObject, Tensor<_Tuple<T, N, R>, Matrix>, IMatrixLike
    {
        #region Static Accessors

        public static bool Use64Bits
        {
            get { return EventHorizonBlazorInterop.Get<bool>("BABYLON", "Matrix.Use64Bits"); }
        }

        private static Matrix __IdentityReadOnly;
        public static Matrix IdentityReadOnly
        {
            get
            {
                if (__IdentityReadOnly == null)
                {
                    __IdentityReadOnly = EventHorizonBlazorInterop.GetClass<Matrix>(
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
        }
        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Matrix FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "FromArray" }, array, offset }
            );
        }

        public static T FromArrayToRef<T>(decimal[] array, decimal offset, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T FromFloat32ArrayToRefScaled<T>(
            decimal[] array,
            decimal offset,
            decimal scale,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static void FromValuesToRef(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public static Matrix FromValues(
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
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static Matrix Compose(Vector3 scale, Quaternion rotation, Vector3 translation)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T ComposeToRef<T>(
            Vector3 scale,
            Quaternion rotation,
            Vector3 translation,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix Identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Identity" } }
            );
        }

        public static T IdentityToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "IdentityToRef" }, result }
            );
        }

        public static Matrix Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Zero" } }
            );
        }

        public static Matrix RotationX(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationX" }, angle }
            );
        }

        public static Matrix Invert(Matrix source)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Invert" }, source }
            );
        }

        public static T RotationXToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationXToRef" },
                    angle,
                    result
                }
            );
        }

        public static Matrix RotationY(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationY" }, angle }
            );
        }

        public static T RotationYToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationYToRef" },
                    angle,
                    result
                }
            );
        }

        public static Matrix RotationZ(decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationZ" }, angle }
            );
        }

        public static T RotationZToRef<T>(decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "RotationZToRef" },
                    angle,
                    result
                }
            );
        }

        public static Matrix RotationAxis(Vector3 axis, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "RotationAxis" }, axis, angle }
            );
        }

        public static T RotationAxisToRef<T>(Vector3 axis, decimal angle, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T RotationAlignToRef<T>(
            Vector3 from,
            Vector3 to,
            T result,
            System.Nullable<bool> useYAxisForCoplanar = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T RotationYawPitchRollToRef<T>(
            decimal yaw,
            decimal pitch,
            decimal roll,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix Scaling(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Scaling" }, x, y, z }
            );
        }

        public static T ScalingToRef<T>(decimal x, decimal y, decimal z, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix Translation(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Translation" }, x, y, z }
            );
        }

        public static T TranslationToRef<T>(decimal x, decimal y, decimal z, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix Lerp(Matrix startValue, Matrix endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T LerpToRef<T>(Matrix startValue, Matrix endValue, decimal gradient, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix DecomposeLerp(Matrix startValue, Matrix endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T DecomposeLerpToRef<T>(
            Matrix startValue,
            Matrix endValue,
            decimal gradient,
            T result
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix LookAtLH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "LookAtLH" }, eye, target, up }
            );
        }

        public static Matrix LookAtLHToRef(Vector3 eye, Vector3 target, Vector3 up, Matrix result)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static Matrix LookAtRH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "LookAtRH" }, eye, target, up }
            );
        }

        public static T LookAtRHToRef<T>(Vector3 eye, Vector3 target, Vector3 up, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix LookDirectionLH(Vector3 forward, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionLH" },
                    forward,
                    up
                }
            );
        }

        public static T LookDirectionLHToRef<T>(Vector3 forward, Vector3 up, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix LookDirectionRH(Vector3 forward, Vector3 up)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "LookDirectionRH" },
                    forward,
                    up
                }
            );
        }

        public static T LookDirectionRHToRef<T>(Vector3 forward, Vector3 up, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix OrthoLH(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T OrthoLHToRef<T>(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            T result,
            System.Nullable<bool> halfZRange = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix OrthoOffCenterLH(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T OrthoOffCenterLHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T ObliqueOffCenterLHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix OrthoOffCenterRH(
            decimal left,
            decimal right,
            decimal bottom,
            decimal top,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T OrthoOffCenterRHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T ObliqueOffCenterRHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix PerspectiveLH(
            decimal width,
            decimal height,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static Matrix PerspectiveFovLH(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T PerspectiveFovLHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T PerspectiveFovReverseLHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix PerspectiveFovRH(
            decimal fov,
            decimal aspect,
            decimal znear,
            decimal zfar,
            System.Nullable<bool> halfZRange = null,
            System.Nullable<decimal> projectionPlaneTilt = null,
            System.Nullable<bool> reverseDepthBufferMode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static T PerspectiveFovRHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T PerspectiveFovReverseRHToRef<T>(
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
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static Matrix GetFinalMatrix(
            Viewport viewport,
            Matrix world,
            Matrix view,
            Matrix projection,
            decimal zmin,
            decimal zmax
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public static decimal[] GetAsMatrix2x2(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Matrix", "GetAsMatrix2x2" }, matrix }
            );
        }

        public static decimal[] GetAsMatrix3x3(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { "BABYLON", "Matrix", "GetAsMatrix3x3" }, matrix }
            );
        }

        public static Matrix Transpose(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Transpose" }, matrix }
            );
        }

        public static T TransposeToRef<T>(Matrix matrix, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "TransposeToRef" },
                    matrix,
                    result
                }
            );
        }

        public static Matrix Reflection(IPlaneLike plane)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Matrix", "Reflection" }, plane }
            );
        }

        public static T ReflectionToRef<T>(IPlaneLike plane, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "ReflectionToRef" },
                    plane,
                    result
                }
            );
        }

        public static T FromXYZAxesToRef<T>(Vector3 xaxis, Vector3 yaxis, Vector3 zaxis, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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

        public static T FromQuaternionToRef<T>(Quaternion quat, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
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
        public _Tuple<T, N, R> m
        {
            get
            {
                if (__m == null)
                {
                    __m = EventHorizonBlazorInterop.GetClass<_Tuple<T, N, R>>(
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

        public decimal updateFlag
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "updateFlag"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "updateFlag", value);
            }
        }
        #endregion

        #region Constructor
        public Matrix()
            : base() { }

        public Matrix(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void markAsUpdated()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsUpdated" } }
            );
        }

        public bool isIdentity()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isIdentity" } }
            );
        }

        public bool isIdentityAs3x2()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isIdentityAs3x2" } }
            );
        }

        public decimal determinant()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "determinant" } }
            );
        }

        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" } }
            );
        }

        public decimal[] toArray(decimal[] array, decimal index)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public _Tuple<T, N, R> asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<_Tuple<T, N, R>>(
                entity => new _Tuple<T, N, R>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public Matrix fromArray(decimal[] array, System.Nullable<decimal> index = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public Matrix copyFromFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, floats }
            );
        }

        public Matrix set(_Tuple<T, N, R> values)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, values }
            );
        }

        public Matrix setAll(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public Matrix invert()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invert" } }
            );
        }

        public Matrix reset()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public Matrix add(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public T addToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public Matrix addToSelf(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToSelf" }, other }
            );
        }

        public Matrix addInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public Matrix addInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, floats }
            );
        }

        public Matrix subtract(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public T subtractToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public Matrix subtractInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public Matrix subtractFromFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, floats }
            );
        }

        public T subtractFromFloatsToRef<T>(T args)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloatsToRef" }, args }
            );
        }

        public T invertToRef<T>(T other)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertToRef" }, other }
            );
        }

        public Matrix addAtIndex(decimal index, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addAtIndex" }, index, value }
            );
        }

        public Matrix multiplyAtIndex(decimal index, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyAtIndex" }, index, value }
            );
        }

        public Matrix setTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setTranslationFromFloats" }, x, y, z }
            );
        }

        public Matrix addTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addTranslationFromFloats" }, x, y, z }
            );
        }

        public Matrix setTranslation(Vector3 vector3)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setTranslation" }, vector3 }
            );
        }

        public Vector3 getTranslation()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTranslation" } }
            );
        }

        public T getTranslationToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTranslationToRef" }, result }
            );
        }

        public Matrix removeRotationAndScaling()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeRotationAndScaling" } }
            );
        }

        public Matrix copyFrom(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public Matrix copyToArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyToArray" }, array, offset }
            );
        }

        public Matrix multiply(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, other }
            );
        }

        public Matrix multiplyInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public Matrix multiplyByFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, floats }
            );
        }

        public T multiplyByFloatsToRef<T>(T args)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloatsToRef" }, args }
            );
        }

        public T multiplyToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public Matrix multiplyToArray(Matrix other, decimal[] result, decimal offset)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public Matrix divide(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, other }
            );
        }

        public T divideToRef<T>(Matrix other, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, other, result }
            );
        }

        public Matrix divideInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, other }
            );
        }

        public Matrix minimizeInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public Matrix minimizeInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, floats }
            );
        }

        public Matrix maximizeInPlace(Matrix other)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public Matrix maximizeInPlaceFromFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, floats }
            );
        }

        public Matrix negate()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public Matrix negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
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

        public bool equals(Matrix value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, value }
            );
        }

        public bool equalsWithEpsilon(Matrix other, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsWithEpsilon" }, other, epsilon }
            );
        }

        public bool equalsToFloats(_Tuple<T, N, R> floats)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, floats }
            );
        }

        public Matrix floor()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
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

        public Matrix fract()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
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

        public Matrix clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
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

        public bool decomposeToTransformNode(TransformNode node)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "decomposeToTransformNode" }, node }
            );
        }

        public bool decompose(
            Vector3 scale = null,
            Quaternion rotation = null,
            Vector3 translation = null,
            TransformNode preserveScalingNode = null,
            System.Nullable<bool> useAbsoluteScaling = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
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

        public Vector4 getRow(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRow" }, index }
            );
        }

        public T getRowToRef<T>(decimal index, T rowVector)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRowToRef" }, index, rowVector }
            );
        }

        public Matrix setRow(decimal index, Vector4 row)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setRow" }, index, row }
            );
        }

        public Matrix transpose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transpose" } }
            );
        }

        public T transposeToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transposeToRef" }, result }
            );
        }

        public Matrix setRowFromFloats(decimal index, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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

        public Matrix scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
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

        public T scaleAndAddToRef<T>(decimal scale, T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public Matrix scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public T toNormalMatrix<T>(T @ref)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toNormalMatrix" }, @ref }
            );
        }

        public Matrix getRotationMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotationMatrix" } }
            );
        }

        public T getRotationMatrixToRef<T>(T result)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotationMatrixToRef" }, result }
            );
        }

        public Matrix toggleModelMatrixHandInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toggleModelMatrixHandInPlace" } }
            );
        }

        public Matrix toggleProjectionMatrixHandInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toggleProjectionMatrixHandInPlace" } }
            );
        }
        #endregion
    }
}
