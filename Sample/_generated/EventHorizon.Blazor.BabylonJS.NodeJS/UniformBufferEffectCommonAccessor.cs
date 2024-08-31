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

    [JsonConverter(typeof(CachedEntityConverter<UniformBufferEffectCommonAccessor>))]
    public class UniformBufferEffectCommonAccessor : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public UniformBufferEffectCommonAccessor()
            : base() { }

        public UniformBufferEffectCommonAccessor(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public UniformBufferEffectCommonAccessor(UniformBuffer uboOrEffect)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "UniformBufferEffectCommonAccessor" },
                uboOrEffect
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setMatrix3x3(string name, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, name, matrix }
            );
        }

        public void setMatrix2x2(string name, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, name, matrix }
            );
        }

        public void setFloat(string name, decimal x)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat" }, name, x }
            );
        }

        public void setFloat2(string name, decimal x, decimal y, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat2" }, name, x, y, suffix }
            );
        }

        public void setFloat3(string name, decimal x, decimal y, decimal z, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat3" }, name, x, y, z, suffix }
            );
        }

        public void setFloat4(
            string name,
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            string suffix = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFloat4" },
                    name,
                    x,
                    y,
                    z,
                    w,
                    suffix
                }
            );
        }

        public void setFloatArray(string name, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloatArray" }, name, array }
            );
        }

        public void setArray(string name, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray" }, name, array }
            );
        }

        public void setIntArray(string name, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray" }, name, array }
            );
        }

        public void setMatrix(string name, IMatrixLike mat)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix" }, name, mat }
            );
        }

        public void setMatrices(string name, decimal[] mat)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrices" }, name, mat }
            );
        }

        public void setVector3(string name, IVector3Like vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector3" }, name, vector }
            );
        }

        public void setVector4(string name, IVector4Like vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector4" }, name, vector }
            );
        }

        public void setColor3(string name, IColor3Like color, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColor3" }, name, color, suffix }
            );
        }

        public void setColor4(string name, IColor3Like color, decimal alpha, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColor4" },
                    name,
                    color,
                    alpha,
                    suffix
                }
            );
        }

        public void setDirectColor4(string name, IColor4Like color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDirectColor4" }, name, color }
            );
        }

        public void setInt(string name, decimal x, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt" }, name, x, suffix }
            );
        }

        public void setInt2(string name, decimal x, decimal y, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt2" }, name, x, y, suffix }
            );
        }

        public void setInt3(string name, decimal x, decimal y, decimal z, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt3" }, name, x, y, z, suffix }
            );
        }

        public void setInt4(
            string name,
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            string suffix = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt4" }, name, x, y, z, w, suffix }
            );
        }
        #endregion
    }
}
