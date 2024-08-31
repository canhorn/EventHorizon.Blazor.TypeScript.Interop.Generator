/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Matrix2D>))]
    public class Matrix2D : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Matrix2D> Identity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "GUI", "Matrix2D", "Identity" } }
            );
        }

        public static async ValueTask IdentityToRef(Matrix2D result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "IdentityToRef" },
                    result
                }
            );
        }

        public static async ValueTask TranslationToRef(decimal x, decimal y, Matrix2D result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "TranslationToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public static async ValueTask ScalingToRef(decimal x, decimal y, Matrix2D result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "ScalingToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public static async ValueTask RotationToRef(decimal angle, Matrix2D result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "RotationToRef" },
                    angle,
                    result
                }
            );
        }

        public static async ValueTask ComposeToRef(
            decimal tx,
            decimal ty,
            decimal angle,
            decimal scaleX,
            decimal scaleY,
            Matrix2D parentMatrix,
            Matrix2D result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "ComposeToRef" },
                    tx,
                    ty,
                    angle,
                    scaleX,
                    scaleY,
                    parentMatrix,
                    result
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<decimal[]> get_m()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "m");
        }

        public ValueTask set_m(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m", value);
        }
        #endregion

        #region Constructor
        public Matrix2D()
            : base() { }

        public Matrix2D(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Matrix2D> NewMatrix2D(
            decimal m00,
            decimal m01,
            decimal m10,
            decimal m11,
            decimal m20,
            decimal m21
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Matrix2D" },
                m00,
                m01,
                m10,
                m11,
                m20,
                m21
            );

            return new Matrix2D(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Matrix2D> fromValues(
            decimal m00,
            decimal m01,
            decimal m10,
            decimal m11,
            decimal m20,
            decimal m21
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "fromValues" },
                    m00,
                    m01,
                    m10,
                    m11,
                    m20,
                    m21
                }
            );
        }

        public async ValueTask<decimal> determinant()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "determinant" } }
            );
        }

        public async ValueTask<Matrix2D> invertToRef(Matrix2D result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertToRef" }, result }
            );
        }

        public async ValueTask<Matrix2D> multiplyToRef(Matrix2D other, Matrix2D result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public async ValueTask<Matrix2D> transformCoordinates(decimal x, decimal y, Vector2 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transformCoordinates" }, x, y, result }
            );
        }
        #endregion
    }
}
