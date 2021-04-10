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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Matrix>))]
    public class Matrix : CachedEntityObject
    {
        #region Static Accessors
        
        public static async ValueTask<bool> get_Use64Bits()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Matrix.Use64Bits"
                );
        }

        private static Matrix __IdentityReadOnly;
        public static async ValueTask<Matrix> get_IdentityReadOnly()
        {
            if(__IdentityReadOnly == null)
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
        public static async ValueTask<Matrix> FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromArray" }, array, offset
                }
            );
        }

        public static async ValueTask FromArrayToRef(decimal[] array, decimal offset, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromArrayToRef" }, array, offset, result
                }
            );
        }

        public static async ValueTask FromFloat32ArrayToRefScaled(decimal[] array, decimal offset, decimal scale, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromFloat32ArrayToRefScaled" }, array, offset, scale, result
                }
            );
        }

        public static async ValueTask FromValuesToRef(decimal initialM11, decimal initialM12, decimal initialM13, decimal initialM14, decimal initialM21, decimal initialM22, decimal initialM23, decimal initialM24, decimal initialM31, decimal initialM32, decimal initialM33, decimal initialM34, decimal initialM41, decimal initialM42, decimal initialM43, decimal initialM44, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromValuesToRef" }, initialM11, initialM12, initialM13, initialM14, initialM21, initialM22, initialM23, initialM24, initialM31, initialM32, initialM33, initialM34, initialM41, initialM42, initialM43, initialM44, result
                }
            );
        }

        public static async ValueTask<Matrix> FromValues(decimal initialM11, decimal initialM12, decimal initialM13, decimal initialM14, decimal initialM21, decimal initialM22, decimal initialM23, decimal initialM24, decimal initialM31, decimal initialM32, decimal initialM33, decimal initialM34, decimal initialM41, decimal initialM42, decimal initialM43, decimal initialM44)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromValues" }, initialM11, initialM12, initialM13, initialM14, initialM21, initialM22, initialM23, initialM24, initialM31, initialM32, initialM33, initialM34, initialM41, initialM42, initialM43, initialM44
                }
            );
        }

        public static async ValueTask<Matrix> Compose(Vector3 scale, Quaternion rotation, Vector3 translation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Compose" }, scale, rotation, translation
                }
            );
        }

        public static async ValueTask ComposeToRef(Vector3 scale, Quaternion rotation, Vector3 translation, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "ComposeToRef" }, scale, rotation, translation, result
                }
            );
        }

        public static async ValueTask<Matrix> Identity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Identity" }
                }
            );
        }

        public static async ValueTask IdentityToRef(Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "IdentityToRef" }, result
                }
            );
        }

        public static async ValueTask<Matrix> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Zero" }
                }
            );
        }

        public static async ValueTask<Matrix> RotationX(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationX" }, angle
                }
            );
        }

        public static async ValueTask<Matrix> Invert(Matrix source)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Invert" }, source
                }
            );
        }

        public static async ValueTask RotationXToRef(decimal angle, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationXToRef" }, angle, result
                }
            );
        }

        public static async ValueTask<Matrix> RotationY(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationY" }, angle
                }
            );
        }

        public static async ValueTask RotationYToRef(decimal angle, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationYToRef" }, angle, result
                }
            );
        }

        public static async ValueTask<Matrix> RotationZ(decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationZ" }, angle
                }
            );
        }

        public static async ValueTask RotationZToRef(decimal angle, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationZToRef" }, angle, result
                }
            );
        }

        public static async ValueTask<Matrix> RotationAxis(Vector3 axis, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationAxis" }, axis, angle
                }
            );
        }

        public static async ValueTask RotationAxisToRef(Vector3 axis, decimal angle, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationAxisToRef" }, axis, angle, result
                }
            );
        }

        public static async ValueTask RotationAlignToRef(Vector3 from, Vector3 to, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationAlignToRef" }, from, to, result
                }
            );
        }

        public static async ValueTask<Matrix> RotationYawPitchRoll(decimal yaw, decimal pitch, decimal roll)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationYawPitchRoll" }, yaw, pitch, roll
                }
            );
        }

        public static async ValueTask RotationYawPitchRollToRef(decimal yaw, decimal pitch, decimal roll, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "RotationYawPitchRollToRef" }, yaw, pitch, roll, result
                }
            );
        }

        public static async ValueTask<Matrix> Scaling(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Scaling" }, x, y, z
                }
            );
        }

        public static async ValueTask ScalingToRef(decimal x, decimal y, decimal z, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "ScalingToRef" }, x, y, z, result
                }
            );
        }

        public static async ValueTask<Matrix> Translation(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Translation" }, x, y, z
                }
            );
        }

        public static async ValueTask TranslationToRef(decimal x, decimal y, decimal z, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "TranslationToRef" }, x, y, z, result
                }
            );
        }

        public static async ValueTask<Matrix> Lerp(Matrix startValue, Matrix endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Lerp" }, startValue, endValue, gradient
                }
            );
        }

        public static async ValueTask LerpToRef(Matrix startValue, Matrix endValue, decimal gradient, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "LerpToRef" }, startValue, endValue, gradient, result
                }
            );
        }

        public static async ValueTask<Matrix> DecomposeLerp(Matrix startValue, Matrix endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "DecomposeLerp" }, startValue, endValue, gradient
                }
            );
        }

        public static async ValueTask DecomposeLerpToRef(Matrix startValue, Matrix endValue, decimal gradient, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "DecomposeLerpToRef" }, startValue, endValue, gradient, result
                }
            );
        }

        public static async ValueTask<Matrix> LookAtLH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "LookAtLH" }, eye, target, up
                }
            );
        }

        public static async ValueTask LookAtLHToRef(Vector3 eye, Vector3 target, Vector3 up, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "LookAtLHToRef" }, eye, target, up, result
                }
            );
        }

        public static async ValueTask<Matrix> LookAtRH(Vector3 eye, Vector3 target, Vector3 up)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "LookAtRH" }, eye, target, up
                }
            );
        }

        public static async ValueTask LookAtRHToRef(Vector3 eye, Vector3 target, Vector3 up, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "LookAtRHToRef" }, eye, target, up, result
                }
            );
        }

        public static async ValueTask<Matrix> OrthoLH(decimal width, decimal height, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoLH" }, width, height, znear, zfar
                }
            );
        }

        public static async ValueTask OrthoLHToRef(decimal width, decimal height, decimal znear, decimal zfar, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoLHToRef" }, width, height, znear, zfar, result
                }
            );
        }

        public static async ValueTask<Matrix> OrthoOffCenterLH(decimal left, decimal right, decimal bottom, decimal top, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterLH" }, left, right, bottom, top, znear, zfar
                }
            );
        }

        public static async ValueTask OrthoOffCenterLHToRef(decimal left, decimal right, decimal bottom, decimal top, decimal znear, decimal zfar, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterLHToRef" }, left, right, bottom, top, znear, zfar, result
                }
            );
        }

        public static async ValueTask<Matrix> OrthoOffCenterRH(decimal left, decimal right, decimal bottom, decimal top, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterRH" }, left, right, bottom, top, znear, zfar
                }
            );
        }

        public static async ValueTask OrthoOffCenterRHToRef(decimal left, decimal right, decimal bottom, decimal top, decimal znear, decimal zfar, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "OrthoOffCenterRHToRef" }, left, right, bottom, top, znear, zfar, result
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveLH(decimal width, decimal height, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveLH" }, width, height, znear, zfar
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveFovLH(decimal fov, decimal aspect, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovLH" }, fov, aspect, znear, zfar
                }
            );
        }

        public static async ValueTask PerspectiveFovLHToRef(decimal fov, decimal aspect, decimal znear, decimal zfar, Matrix result, System.Nullable<bool> isVerticalFovFixed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovLHToRef" }, fov, aspect, znear, zfar, result, isVerticalFovFixed
                }
            );
        }

        public static async ValueTask PerspectiveFovReverseLHToRef(decimal fov, decimal aspect, decimal znear, decimal zfar, Matrix result, System.Nullable<bool> isVerticalFovFixed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovReverseLHToRef" }, fov, aspect, znear, zfar, result, isVerticalFovFixed
                }
            );
        }

        public static async ValueTask<Matrix> PerspectiveFovRH(decimal fov, decimal aspect, decimal znear, decimal zfar)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovRH" }, fov, aspect, znear, zfar
                }
            );
        }

        public static async ValueTask PerspectiveFovRHToRef(decimal fov, decimal aspect, decimal znear, decimal zfar, Matrix result, System.Nullable<bool> isVerticalFovFixed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovRHToRef" }, fov, aspect, znear, zfar, result, isVerticalFovFixed
                }
            );
        }

        public static async ValueTask PerspectiveFovReverseRHToRef(decimal fov, decimal aspect, decimal znear, decimal zfar, Matrix result, System.Nullable<bool> isVerticalFovFixed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovReverseRHToRef" }, fov, aspect, znear, zfar, result, isVerticalFovFixed
                }
            );
        }

        public static async ValueTask PerspectiveFovWebVRToRef(object fov, decimal znear, decimal zfar, Matrix result, System.Nullable<bool> rightHanded = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "PerspectiveFovWebVRToRef" }, fov, znear, zfar, result, rightHanded
                }
            );
        }

        public static async ValueTask<Matrix> GetFinalMatrix(Viewport viewport, Matrix world, Matrix view, Matrix projection, decimal zmin, decimal zmax)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "GetFinalMatrix" }, viewport, world, view, projection, zmin, zmax
                }
            );
        }

        public static async ValueTask<decimal[]> GetAsMatrix2x2(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "GetAsMatrix2x2" }, matrix
                }
            );
        }

        public static async ValueTask<decimal[]> GetAsMatrix3x3(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Matrix", "GetAsMatrix3x3" }, matrix
                }
            );
        }

        public static async ValueTask<Matrix> Transpose(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Transpose" }, matrix
                }
            );
        }

        public static async ValueTask TransposeToRef(Matrix matrix, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "TransposeToRef" }, matrix, result
                }
            );
        }

        public static async ValueTask<Matrix> Reflection(IPlaneLike plane)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "Reflection" }, plane
                }
            );
        }

        public static async ValueTask ReflectionToRef(IPlaneLike plane, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "ReflectionToRef" }, plane, result
                }
            );
        }

        public static async ValueTask FromXYZAxesToRef(Vector3 xaxis, Vector3 yaxis, Vector3 zaxis, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromXYZAxesToRef" }, xaxis, yaxis, zaxis, result
                }
            );
        }

        public static async ValueTask FromQuaternionToRef(Quaternion quat, Matrix result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Matrix", "FromQuaternionToRef" }, quat, result
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal[]> get_m()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "m"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_updateFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateFlag"
                );
        }
        public ValueTask set_updateFlag(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateFlag",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Matrix() : base() { } 

        public Matrix(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask<bool> isIdentity()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isIdentity" }
                }
            );
        }

        public async ValueTask<bool> isIdentityAs3x2()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isIdentityAs3x2" }
                }
            );
        }

        public async ValueTask<decimal> determinant()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "determinant" }
                }
            );
        }

        public async ValueTask<decimal[]> toArray()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }
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

        public async ValueTask<Matrix> invert()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "invert" }
                }
            );
        }

        public async ValueTask<Matrix> reset()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask<Matrix> add(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, other
                }
            );
        }

        public async ValueTask<Matrix> addToRef(Matrix other, Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToRef" }, other, result
                }
            );
        }

        public async ValueTask<Matrix> addToSelf(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addToSelf" }, other
                }
            );
        }

        public async ValueTask<Matrix> invertToRef(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "invertToRef" }, other
                }
            );
        }

        public async ValueTask<Matrix> addAtIndex(decimal index, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAtIndex" }, index, value
                }
            );
        }

        public async ValueTask<Matrix> multiplyAtIndex(decimal index, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyAtIndex" }, index, value
                }
            );
        }

        public async ValueTask<Matrix> setTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setTranslationFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Matrix> addTranslationFromFloats(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addTranslationFromFloats" }, x, y, z
                }
            );
        }

        public async ValueTask<Matrix> setTranslation(Vector3 vector3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setTranslation" }, vector3
                }
            );
        }

        public async ValueTask<Vector3> getTranslation()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTranslation" }
                }
            );
        }

        public async ValueTask<Matrix> getTranslationToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTranslationToRef" }, result
                }
            );
        }

        public async ValueTask<Matrix> removeRotationAndScaling()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeRotationAndScaling" }
                }
            );
        }

        public async ValueTask<Matrix> multiply(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiply" }, other
                }
            );
        }

        public async ValueTask<Matrix> copyFrom(Matrix other)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, other
                }
            );
        }

        public async ValueTask<Matrix> copyToArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyToArray" }, array, offset
                }
            );
        }

        public async ValueTask<Matrix> multiplyToRef(Matrix other, Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToRef" }, other, result
                }
            );
        }

        public async ValueTask<Matrix> multiplyToArray(Matrix other, decimal[] result, decimal offset)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyToArray" }, other, result, offset
                }
            );
        }

        public async ValueTask<bool> equals(Matrix value)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, value
                }
            );
        }

        public async ValueTask<Matrix> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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

        public async ValueTask<bool> decompose(Vector3 scale = null, Quaternion rotation = null, Vector3 translation = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "decompose" }, scale, rotation, translation
                }
            );
        }

        public async ValueTask<Vector4> getRow(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector4>(
                entity => new Vector4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRow" }, index
                }
            );
        }

        public async ValueTask<Matrix> setRow(decimal index, Vector4 row)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setRow" }, index, row
                }
            );
        }

        public async ValueTask<Matrix> transpose()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transpose" }
                }
            );
        }

        public async ValueTask<Matrix> transposeToRef(Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transposeToRef" }, result
                }
            );
        }

        public async ValueTask<Matrix> setRowFromFloats(decimal index, decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setRowFromFloats" }, index, x, y, z, w
                }
            );
        }

        public async ValueTask<Matrix> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, scale
                }
            );
        }

        public async ValueTask<Matrix> scaleToRef(decimal scale, Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleToRef" }, scale, result
                }
            );
        }

        public async ValueTask<Matrix> scaleAndAddToRef(decimal scale, Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "scaleAndAddToRef" }, scale, result
                }
            );
        }

        public async ValueTask toNormalMatrix(Matrix @ref)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toNormalMatrix" }, @ref
                }
            );
        }

        public async ValueTask<Matrix> getRotationMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotationMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getRotationMatrixToRef(Matrix result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotationMatrixToRef" }, result
                }
            );
        }

        public async ValueTask toggleModelMatrixHandInPlace()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toggleModelMatrixHandInPlace" }
                }
            );
        }

        public async ValueTask toggleProjectionMatrixHandInPlace()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toggleProjectionMatrixHandInPlace" }
                }
            );
        }
        #endregion
    }
}