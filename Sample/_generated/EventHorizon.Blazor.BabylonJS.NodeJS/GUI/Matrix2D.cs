/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Matrix2D>))]
    public class Matrix2D : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Matrix2D Identity()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "GUI", "Matrix2D", "Identity" } }
            );
        }

        public static void IdentityToRef(Matrix2D result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "IdentityToRef" },
                    result
                }
            );
        }

        public static void TranslationToRef(decimal x, decimal y, Matrix2D result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "TranslationToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public static void ScalingToRef(decimal x, decimal y, Matrix2D result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "ScalingToRef" },
                    x,
                    y,
                    result
                }
            );
        }

        public static void RotationToRef(decimal angle, Matrix2D result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Matrix2D", "RotationToRef" },
                    angle,
                    result
                }
            );
        }

        public static void ComposeToRef(
            decimal tx,
            decimal ty,
            decimal angle,
            decimal scaleX,
            decimal scaleY,
            Matrix2D parentMatrix,
            Matrix2D result
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public decimal[] m
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "m"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m", value);
            }
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

        public Matrix2D(
            decimal m00,
            decimal m01,
            decimal m10,
            decimal m11,
            decimal m20,
            decimal m21
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Matrix2D" },
                m00,
                m01,
                m10,
                m11,
                m20,
                m21
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Matrix2D fromValues(
            decimal m00,
            decimal m01,
            decimal m10,
            decimal m11,
            decimal m20,
            decimal m21
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix2D>(
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

        public decimal determinant()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "determinant" } }
            );
        }

        public Matrix2D invertToRef(Matrix2D result)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "invertToRef" }, result }
            );
        }

        public Matrix2D multiplyToRef(Matrix2D other, Matrix2D result)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public Matrix2D transformCoordinates(decimal x, decimal y, Vector2 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix2D>(
                entity => new Matrix2D() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "transformCoordinates" }, x, y, result }
            );
        }
        #endregion
    }
}
