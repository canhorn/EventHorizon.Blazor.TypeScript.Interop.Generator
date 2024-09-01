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

    [JsonConverter(typeof(CachedEntityConverter<UniformBuffer>))]
    public class UniformBuffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_useUbo()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useUbo");
        }

        public async ValueTask<bool> get_isSync()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSync");
        }

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        private Effect __currentEffect;

        public async ValueTask<Effect> get_currentEffect()
        {
            if (__currentEffect == null)
            {
                __currentEffect = await EventHorizonBlazorInterop.GetClass<Effect>(
                    this.___guid,
                    "currentEffect",
                    (entity) =>
                    {
                        return new Effect() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentEffect;
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public UniformBuffer()
            : base() { }

        public UniformBuffer(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<UniformBuffer> NewUniformBuffer(
            AbstractEngine engine,
            decimal[] data = null,
            System.Nullable<bool> dynamic = null,
            string name = null,
            System.Nullable<bool> forceNoUniformBuffer = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "UniformBuffer" },
                engine,
                data,
                dynamic,
                name,
                forceNoUniformBuffer
            );

            return new UniformBuffer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask updateMatrix3x3(string name, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix3x3" }, name, matrix }
            );
        }

        public async ValueTask updateMatrix2x2(string name, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix2x2" }, name, matrix }
            );
        }

        public async ValueTask updateFloat(string name, decimal x)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloat" }, name, x }
            );
        }

        public async ValueTask updateFloat2(string name, decimal x, decimal y, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloat2" }, name, x, y, suffix }
            );
        }

        public async ValueTask updateFloat3(
            string name,
            decimal x,
            decimal y,
            decimal z,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateFloat3" },
                    name,
                    x,
                    y,
                    z,
                    suffix
                }
            );
        }

        public async ValueTask updateFloat4(
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
                    new string[] { this.___guid, "updateFloat4" },
                    name,
                    x,
                    y,
                    z,
                    w,
                    suffix
                }
            );
        }

        public async ValueTask updateFloatArray(string name, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloatArray" }, name, array }
            );
        }

        public async ValueTask updateArray(string name, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateArray" }, name, array }
            );
        }

        public async ValueTask updateIntArray(string name, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateIntArray" }, name, array }
            );
        }

        public async ValueTask updateUIntArray(string name, Uint32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUIntArray" }, name, array }
            );
        }

        public async ValueTask updateMatrix(string name, IMatrixLike mat)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix" }, name, mat }
            );
        }

        public async ValueTask updateMatrices(string name, decimal[] mat)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrices" }, name, mat }
            );
        }

        public async ValueTask updateVector3(string name, IVector3Like vector)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateVector3" }, name, vector }
            );
        }

        public async ValueTask updateVector4(string name, IVector4Like vector)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateVector4" }, name, vector }
            );
        }

        public async ValueTask updateColor3(string name, IColor3Like color, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateColor3" }, name, color, suffix }
            );
        }

        public async ValueTask updateColor4(
            string name,
            IColor3Like color,
            decimal alpha,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateColor4" },
                    name,
                    color,
                    alpha,
                    suffix
                }
            );
        }

        public async ValueTask updateDirectColor4(
            string name,
            IColor4Like color,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDirectColor4" },
                    name,
                    color,
                    suffix
                }
            );
        }

        public async ValueTask updateInt(string name, decimal x, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt" }, name, x, suffix }
            );
        }

        public async ValueTask updateInt2(string name, decimal x, decimal y, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt2" }, name, x, y, suffix }
            );
        }

        public async ValueTask updateInt3(
            string name,
            decimal x,
            decimal y,
            decimal z,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt3" }, name, x, y, z, suffix }
            );
        }

        public async ValueTask updateInt4(
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
                    new string[] { this.___guid, "updateInt4" },
                    name,
                    x,
                    y,
                    z,
                    w,
                    suffix
                }
            );
        }

        public async ValueTask updateUInt(string name, decimal x, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt" }, name, x, suffix }
            );
        }

        public async ValueTask updateUInt2(string name, decimal x, decimal y, string suffix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt2" }, name, x, y, suffix }
            );
        }

        public async ValueTask updateUInt3(
            string name,
            decimal x,
            decimal y,
            decimal z,
            string suffix = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt3" }, name, x, y, z, suffix }
            );
        }

        public async ValueTask updateUInt4(
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
                    new string[] { this.___guid, "updateUInt4" },
                    name,
                    x,
                    y,
                    z,
                    w,
                    suffix
                }
            );
        }

        public async ValueTask<bool> isDynamic()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDynamic" } }
            );
        }

        public async ValueTask<decimal[]> getData()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getData" } }
            );
        }

        public async ValueTask<DataBuffer> getBuffer()
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBuffer" } }
            );
        }

        public async ValueTask addUniform(
            string name,
            decimal size,
            System.Nullable<decimal> arraySize = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addUniform" }, name, size, arraySize }
            );
        }

        public async ValueTask addMatrix(string name, IMatrixLike mat)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix" }, name, mat }
            );
        }

        public async ValueTask addFloat2(string name, decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addFloat2" }, name, x, y }
            );
        }

        public async ValueTask addFloat3(string name, decimal x, decimal y, decimal z)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addFloat3" }, name, x, y, z }
            );
        }

        public async ValueTask addColor3(string name, IColor3Like color)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColor3" }, name, color }
            );
        }

        public async ValueTask addColor4(string name, IColor3Like color, decimal alpha)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColor4" }, name, color, alpha }
            );
        }

        public async ValueTask addVector3(string name, IVector3Like vector)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addVector3" }, name, vector }
            );
        }

        public async ValueTask addMatrix3x3(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix3x3" }, name }
            );
        }

        public async ValueTask addMatrix2x2(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix2x2" }, name }
            );
        }

        public async ValueTask create()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "create" } }
            );
        }

        public async ValueTask update()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" } }
            );
        }

        public async ValueTask updateUniform(string uniformName, decimal[] data, decimal size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniform" },
                    uniformName,
                    data,
                    size
                }
            );
        }

        public async ValueTask updateUniformArray(string uniformName, decimal[] data, decimal size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformArray" },
                    uniformName,
                    data,
                    size
                }
            );
        }

        public async ValueTask setTexture(string name, ThinTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTexture" }, name, texture }
            );
        }

        public async ValueTask bindTexture(string name, InternalTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindTexture" }, name, texture }
            );
        }

        public async ValueTask updateUniformDirectly(string uniformName, decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformDirectly" },
                    uniformName,
                    data
                }
            );
        }

        public async ValueTask bindToEffect(Effect effect, string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindToEffect" }, effect, name }
            );
        }

        public async ValueTask bindUniformBuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindUniformBuffer" } }
            );
        }

        public async ValueTask unbindEffect()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindEffect" } }
            );
        }

        public async ValueTask<bool> setDataBuffer(DataBuffer dataBuffer)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setDataBuffer" }, dataBuffer }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
