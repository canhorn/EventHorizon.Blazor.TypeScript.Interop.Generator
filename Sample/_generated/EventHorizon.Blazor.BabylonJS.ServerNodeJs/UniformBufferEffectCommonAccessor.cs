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

        public static async ValueTask<UniformBufferEffectCommonAccessor> NewUniformBufferEffectCommonAccessor(
            UniformBuffer uboOrEffect
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "UniformBufferEffectCommonAccessor" },
                uboOrEffect
            );

            return new UniformBufferEffectCommonAccessor(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setMatrix3x3(string name, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, name, matrix }
            );
        }

        public async ValueTask setMatrix2x2(string name, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, name, matrix }
            );
        }

        public async ValueTask setFloat(string name, decimal x)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat" }, name, x }
            );
        }

        public async ValueTask setFloat2(string name, decimal x, decimal y, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat2" }, name, x, y, suffix }
            );
        }

        public async ValueTask setFloat3(
            string name,
            decimal x,
            decimal y,
            decimal z,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat3" }, name, x, y, z, suffix }
            );
        }

        public async ValueTask setFloat4(
            string name,
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask setFloatArray(string name, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloatArray" }, name, array }
            );
        }

        public async ValueTask setArray(string name, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray" }, name, array }
            );
        }

        public async ValueTask setIntArray(string name, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray" }, name, array }
            );
        }

        public async ValueTask setMatrix(string name, IMatrixLike mat)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix" }, name, mat }
            );
        }

        public async ValueTask setMatrices(string name, decimal[] mat)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrices" }, name, mat }
            );
        }

        public async ValueTask setVector3(string name, IVector3Like vector)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector3" }, name, vector }
            );
        }

        public async ValueTask setVector4(string name, IVector4Like vector)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector4" }, name, vector }
            );
        }

        public async ValueTask setColor3(string name, IColor3Like color, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColor3" }, name, color, suffix }
            );
        }

        public async ValueTask setColor4(
            string name,
            IColor3Like color,
            decimal alpha,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask setDirectColor4(string name, IColor4Like color)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDirectColor4" }, name, color }
            );
        }

        public async ValueTask setInt(string name, decimal x, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt" }, name, x, suffix }
            );
        }

        public async ValueTask setInt2(string name, decimal x, decimal y, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt2" }, name, x, y, suffix }
            );
        }

        public async ValueTask setInt3(
            string name,
            decimal x,
            decimal y,
            decimal z,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt3" }, name, x, y, z, suffix }
            );
        }

        public async ValueTask setInt4(
            string name,
            decimal x,
            decimal y,
            decimal z,
            decimal w,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt4" }, name, x, y, z, w, suffix }
            );
        }
        #endregion
    }
}
