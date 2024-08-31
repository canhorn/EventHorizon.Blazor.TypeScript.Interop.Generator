/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<Matrix>))]
public class Matrix : CachedEntityObject
{
    #region Static Accessors

    public static bool Use64Bits
    {
        get { return EventHorizonBlazorInterop.Get<bool>("Matrix", "Use64Bits"); }
    }

    private static Matrix __IdentityReadOnly;
    public static Matrix IdentityReadOnly
    {
        get
        {
            if (__IdentityReadOnly == null)
            {
                __IdentityReadOnly = EventHorizonBlazorInterop.GetClass<Matrix>(
                    "Matrix",
                    "IdentityReadOnly",
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
            new object[] { new string[] { "Matrix", "FromArray" }, array, offset }
        );
    }

    public static void FromArrayToRef(decimal[] array, decimal offset, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "FromArrayToRef" }, array, offset, result }
        );
    }

    public static void FromFloat32ArrayToRefScaled(
        decimal[] array,
        decimal offset,
        decimal scale,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "FromFloat32ArrayToRefScaled" },
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
                new string[] { "Matrix", "FromValuesToRef" },
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
                new string[] { "Matrix", "FromValues" },
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
            new object[] { new string[] { "Matrix", "Compose" }, scale, rotation, translation }
        );
    }

    public static void ComposeToRef(
        Vector3 scale,
        Quaternion rotation,
        Vector3 translation,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "ComposeToRef" },
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
            new object[] { new string[] { "Matrix", "Identity" } }
        );
    }

    public static void IdentityToRef(Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "IdentityToRef" }, result }
        );
    }

    public static Matrix Zero()
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Zero" } }
        );
    }

    public static Matrix RotationX(decimal angle)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "RotationX" }, angle }
        );
    }

    public static Matrix Invert(Matrix source)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Invert" }, source }
        );
    }

    public static void RotationXToRef(decimal angle, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "RotationXToRef" }, angle, result }
        );
    }

    public static Matrix RotationY(decimal angle)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "RotationY" }, angle }
        );
    }

    public static void RotationYToRef(decimal angle, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "RotationYToRef" }, angle, result }
        );
    }

    public static Matrix RotationZ(decimal angle)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "RotationZ" }, angle }
        );
    }

    public static void RotationZToRef(decimal angle, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "RotationZToRef" }, angle, result }
        );
    }

    public static Matrix RotationAxis(Vector3 axis, decimal angle)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "RotationAxis" }, axis, angle }
        );
    }

    public static void RotationAxisToRef(Vector3 axis, decimal angle, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "RotationAxisToRef" }, axis, angle, result }
        );
    }

    public static void RotationAlignToRef(Vector3 from, Vector3 to, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "RotationAlignToRef" }, from, to, result }
        );
    }

    public static Matrix RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "RotationYawPitchRoll" }, yaw, pitch, roll }
        );
    }

    public static void RotationYawPitchRollToRef(
        decimal yaw,
        decimal pitch,
        decimal roll,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "RotationYawPitchRollToRef" },
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
            new object[] { new string[] { "Matrix", "Scaling" }, x, y, z }
        );
    }

    public static void ScalingToRef(decimal x, decimal y, decimal z, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "ScalingToRef" }, x, y, z, result }
        );
    }

    public static Matrix Translation(decimal x, decimal y, decimal z)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Translation" }, x, y, z }
        );
    }

    public static void TranslationToRef(decimal x, decimal y, decimal z, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "TranslationToRef" }, x, y, z, result }
        );
    }

    public static Matrix Lerp(Matrix startValue, Matrix endValue, decimal gradient)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Lerp" }, startValue, endValue, gradient }
        );
    }

    public static void LerpToRef(
        Matrix startValue,
        Matrix endValue,
        decimal gradient,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "LerpToRef" },
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
                new string[] { "Matrix", "DecomposeLerp" },
                startValue,
                endValue,
                gradient
            }
        );
    }

    public static void DecomposeLerpToRef(
        Matrix startValue,
        Matrix endValue,
        decimal gradient,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "DecomposeLerpToRef" },
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
            new object[] { new string[] { "Matrix", "LookAtLH" }, eye, target, up }
        );
    }

    public static void LookAtLHToRef(Vector3 eye, Vector3 target, Vector3 up, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "LookAtLHToRef" }, eye, target, up, result }
        );
    }

    public static Matrix LookAtRH(Vector3 eye, Vector3 target, Vector3 up)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "LookAtRH" }, eye, target, up }
        );
    }

    public static void LookAtRHToRef(Vector3 eye, Vector3 target, Vector3 up, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "LookAtRHToRef" }, eye, target, up, result }
        );
    }

    public static Matrix OrthoLH(decimal width, decimal height, decimal znear, decimal zfar)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "OrthoLH" }, width, height, znear, zfar }
        );
    }

    public static void OrthoLHToRef(
        decimal width,
        decimal height,
        decimal znear,
        decimal zfar,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "OrthoLHToRef" },
                width,
                height,
                znear,
                zfar,
                result
            }
        );
    }

    public static Matrix OrthoOffCenterLH(
        decimal left,
        decimal right,
        decimal bottom,
        decimal top,
        decimal znear,
        decimal zfar
    )
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Matrix", "OrthoOffCenterLH" },
                left,
                right,
                bottom,
                top,
                znear,
                zfar
            }
        );
    }

    public static void OrthoOffCenterLHToRef(
        decimal left,
        decimal right,
        decimal bottom,
        decimal top,
        decimal znear,
        decimal zfar,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "OrthoOffCenterLHToRef" },
                left,
                right,
                bottom,
                top,
                znear,
                zfar,
                result
            }
        );
    }

    public static Matrix OrthoOffCenterRH(
        decimal left,
        decimal right,
        decimal bottom,
        decimal top,
        decimal znear,
        decimal zfar
    )
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Matrix", "OrthoOffCenterRH" },
                left,
                right,
                bottom,
                top,
                znear,
                zfar
            }
        );
    }

    public static void OrthoOffCenterRHToRef(
        decimal left,
        decimal right,
        decimal bottom,
        decimal top,
        decimal znear,
        decimal zfar,
        Matrix result
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "OrthoOffCenterRHToRef" },
                left,
                right,
                bottom,
                top,
                znear,
                zfar,
                result
            }
        );
    }

    public static Matrix PerspectiveLH(decimal width, decimal height, decimal znear, decimal zfar)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "PerspectiveLH" }, width, height, znear, zfar }
        );
    }

    public static Matrix PerspectiveFovLH(decimal fov, decimal aspect, decimal znear, decimal zfar)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "PerspectiveFovLH" }, fov, aspect, znear, zfar }
        );
    }

    public static void PerspectiveFovLHToRef(
        decimal fov,
        decimal aspect,
        decimal znear,
        decimal zfar,
        Matrix result,
        System.Nullable<bool> isVerticalFovFixed = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "PerspectiveFovLHToRef" },
                fov,
                aspect,
                znear,
                zfar,
                result,
                isVerticalFovFixed
            }
        );
    }

    public static void PerspectiveFovReverseLHToRef(
        decimal fov,
        decimal aspect,
        decimal znear,
        decimal zfar,
        Matrix result,
        System.Nullable<bool> isVerticalFovFixed = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "PerspectiveFovReverseLHToRef" },
                fov,
                aspect,
                znear,
                zfar,
                result,
                isVerticalFovFixed
            }
        );
    }

    public static Matrix PerspectiveFovRH(decimal fov, decimal aspect, decimal znear, decimal zfar)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "PerspectiveFovRH" }, fov, aspect, znear, zfar }
        );
    }

    public static void PerspectiveFovRHToRef(
        decimal fov,
        decimal aspect,
        decimal znear,
        decimal zfar,
        Matrix result,
        System.Nullable<bool> isVerticalFovFixed = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "PerspectiveFovRHToRef" },
                fov,
                aspect,
                znear,
                zfar,
                result,
                isVerticalFovFixed
            }
        );
    }

    public static void PerspectiveFovReverseRHToRef(
        decimal fov,
        decimal aspect,
        decimal znear,
        decimal zfar,
        Matrix result,
        System.Nullable<bool> isVerticalFovFixed = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "PerspectiveFovReverseRHToRef" },
                fov,
                aspect,
                znear,
                zfar,
                result,
                isVerticalFovFixed
            }
        );
    }

    public static void PerspectiveFovWebVRToRef(
        object fov,
        decimal znear,
        decimal zfar,
        Matrix result,
        System.Nullable<bool> rightHanded = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "PerspectiveFovWebVRToRef" },
                fov,
                znear,
                zfar,
                result,
                rightHanded
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
                new string[] { "Matrix", "GetFinalMatrix" },
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
            new object[] { new string[] { "Matrix", "GetAsMatrix2x2" }, matrix }
        );
    }

    public static decimal[] GetAsMatrix3x3(Matrix matrix)
    {
        return EventHorizonBlazorInterop.FuncArray<decimal>(
            new object[] { new string[] { "Matrix", "GetAsMatrix3x3" }, matrix }
        );
    }

    public static Matrix Transpose(Matrix matrix)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Transpose" }, matrix }
        );
    }

    public static void TransposeToRef(Matrix matrix, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "TransposeToRef" }, matrix, result }
        );
    }

    public static Matrix Reflection(IPlaneLike plane)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { "Matrix", "Reflection" }, plane }
        );
    }

    public static void ReflectionToRef(IPlaneLike plane, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "ReflectionToRef" }, plane, result }
        );
    }

    public static void FromXYZAxesToRef(Vector3 xaxis, Vector3 yaxis, Vector3 zaxis, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Matrix", "FromXYZAxesToRef" },
                xaxis,
                yaxis,
                zaxis,
                result
            }
        );
    }

    public static void FromQuaternionToRef(Quaternion quat, Matrix result)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Matrix", "FromQuaternionToRef" }, quat, result }
        );
    }
    #endregion

    #region Accessors

    public decimal[] m
    {
        get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "m"); }
    }
    #endregion

    #region Properties

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
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    #endregion

    #region Methods
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

    public decimal[] toArray()
    {
        return EventHorizonBlazorInterop.FuncArray<decimal>(
            new object[] { new string[] { this.___guid, "toArray" } }
        );
    }

    public decimal[] asArray()
    {
        return EventHorizonBlazorInterop.FuncArray<decimal>(
            new object[] { new string[] { this.___guid, "asArray" } }
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

    public Matrix addToRef(Matrix other, Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
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

    public Matrix invertToRef(Matrix other)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
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

    public Matrix getTranslationToRef(Vector3 result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
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

    public Matrix multiply(Matrix other)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "multiply" }, other }
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

    public Matrix multiplyToRef(Matrix other, Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
        );
    }

    public Matrix multiplyToArray(Matrix other, decimal[] result, decimal offset)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "multiplyToArray" }, other, result, offset }
        );
    }

    public bool equals(Matrix value)
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { this.___guid, "equals" }, value }
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

    public bool decompose(
        Vector3 scale = null,
        Quaternion rotation = null,
        Vector3 translation = null
    )
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[]
            {
                new string[] { this.___guid, "decompose" },
                scale,
                rotation,
                translation
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

    public Matrix transposeToRef(Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "transposeToRef" }, result }
        );
    }

    public Matrix setRowFromFloats(decimal index, decimal x, decimal y, decimal z, decimal w)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "setRowFromFloats" }, index, x, y, z, w }
        );
    }

    public Matrix scale(decimal scale)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "scale" }, scale }
        );
    }

    public Matrix scaleToRef(decimal scale, Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "scaleToRef" }, scale, result }
        );
    }

    public Matrix scaleAndAddToRef(decimal scale, Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
        );
    }

    public void toNormalMatrix(Matrix @ref)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public Matrix getRotationMatrixToRef(Matrix result)
    {
        return EventHorizonBlazorInterop.FuncClass<Matrix>(
            entity => new Matrix() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "getRotationMatrixToRef" }, result }
        );
    }

    public void toggleModelMatrixHandInPlace()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "toggleModelMatrixHandInPlace" } }
        );
    }

    public void toggleProjectionMatrixHandInPlace()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "toggleProjectionMatrixHandInPlace" } }
        );
    }
    #endregion
}
