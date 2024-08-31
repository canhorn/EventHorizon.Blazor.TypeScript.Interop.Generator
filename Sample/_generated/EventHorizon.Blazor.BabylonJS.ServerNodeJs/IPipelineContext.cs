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

    public interface IPipelineContext : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPipelineContextCachedEntity>))]
    public class IPipelineContextCachedEntity : CachedEntityObject, IPipelineContext
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

        public async ValueTask<bool> get_isAsync()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isAsync");
        }

        public async ValueTask<bool> get_isReady()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReady");
        }

        public async ValueTask<CachedEntity> get_vertexBufferKindToType()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "vertexBufferKindToType",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_vertexBufferKindToType(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "vertexBufferKindToType", value);
        }
        #endregion

        #region Constructor
        public IPipelineContextCachedEntity()
            : base() { }

        public IPipelineContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask setEngine<T>(T engine)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEngine" }, engine }
            );
        }

        public async ValueTask setInt(string uniformName, decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt" }, uniformName, value }
            );
        }

        public async ValueTask setInt2(string uniformName, decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt2" }, uniformName, x, y }
            );
        }

        public async ValueTask setInt3(string uniformName, decimal x, decimal y, decimal z)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt3" }, uniformName, x, y, z }
            );
        }

        public async ValueTask setInt4(
            string uniformName,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt4" }, uniformName, x, y, z, w }
            );
        }

        public async ValueTask setIntArray(string uniformName, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray" }, uniformName, array }
            );
        }

        public async ValueTask setIntArray2(string uniformName, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray2" }, uniformName, array }
            );
        }

        public async ValueTask setIntArray3(string uniformName, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray3" }, uniformName, array }
            );
        }

        public async ValueTask setIntArray4(string uniformName, Int32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray4" }, uniformName, array }
            );
        }

        public async ValueTask setUInt(string uniformName, decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt" }, uniformName, value }
            );
        }

        public async ValueTask setUInt2(string uniformName, decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt2" }, uniformName, x, y }
            );
        }

        public async ValueTask setUInt3(string uniformName, decimal x, decimal y, decimal z)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt3" }, uniformName, x, y, z }
            );
        }

        public async ValueTask setUInt4(
            string uniformName,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt4" }, uniformName, x, y, z, w }
            );
        }

        public async ValueTask setUIntArray(string uniformName, Uint32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray" }, uniformName, array }
            );
        }

        public async ValueTask setUIntArray2(string uniformName, Uint32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray2" }, uniformName, array }
            );
        }

        public async ValueTask setUIntArray3(string uniformName, Uint32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray3" }, uniformName, array }
            );
        }

        public async ValueTask setUIntArray4(string uniformName, Uint32Array array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray4" }, uniformName, array }
            );
        }

        public async ValueTask setArray(string uniformName, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray" }, uniformName, array }
            );
        }

        public async ValueTask setArray2(string uniformName, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray2" }, uniformName, array }
            );
        }

        public async ValueTask setArray3(string uniformName, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray3" }, uniformName, array }
            );
        }

        public async ValueTask setArray4(string uniformName, decimal[] array)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray4" }, uniformName, array }
            );
        }

        public async ValueTask setMatrices(string uniformName, decimal[] matrices)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrices" }, uniformName, matrices }
            );
        }

        public async ValueTask setMatrix(string uniformName, IMatrixLike matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix" }, uniformName, matrix }
            );
        }

        public async ValueTask setMatrix3x3(string uniformName, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, uniformName, matrix }
            );
        }

        public async ValueTask setMatrix2x2(string uniformName, decimal[] matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, uniformName, matrix }
            );
        }

        public async ValueTask setFloat(string uniformName, decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat" }, uniformName, value }
            );
        }

        public async ValueTask setVector2(string uniformName, IVector2Like vector2)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector2" }, uniformName, vector2 }
            );
        }

        public async ValueTask setFloat2(string uniformName, decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat2" }, uniformName, x, y }
            );
        }

        public async ValueTask setVector3(string uniformName, IVector3Like vector3)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector3" }, uniformName, vector3 }
            );
        }

        public async ValueTask setFloat3(string uniformName, decimal x, decimal y, decimal z)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat3" }, uniformName, x, y, z }
            );
        }

        public async ValueTask setVector4(string uniformName, IVector4Like vector4)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector4" }, uniformName, vector4 }
            );
        }

        public async ValueTask setQuaternion(string uniformName, IQuaternionLike quaternion)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setQuaternion" },
                    uniformName,
                    quaternion
                }
            );
        }

        public async ValueTask setFloat4(
            string uniformName,
            decimal x,
            decimal y,
            decimal z,
            decimal w
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat4" }, uniformName, x, y, z, w }
            );
        }

        public async ValueTask setColor3(string uniformName, IColor3Like color3)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColor3" }, uniformName, color3 }
            );
        }

        public async ValueTask setColor4(string uniformName, IColor3Like color3, decimal alpha)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColor4" },
                    uniformName,
                    color3,
                    alpha
                }
            );
        }

        public async ValueTask setDirectColor4(string uniformName, IColor4Like color4)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDirectColor4" },
                    uniformName,
                    color4
                }
            );
        }
        #endregion
    }
}
