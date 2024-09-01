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

    [JsonConverter(typeof(CachedEntityConverter<Buffer>))]
    public class Buffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_isDisposed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed");
        }
        #endregion

        #region Properties

        public async ValueTask<decimal> get_byteStride()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "byteStride");
        }
        #endregion

        #region Constructor
        public Buffer()
            : base() { }

        public Buffer(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Buffer> NewBuffer(
            AbstractEngine engine,
            decimal[] data,
            bool updatable,
            System.Nullable<decimal> stride = null,
            System.Nullable<bool> postponeInternalCreation = null,
            System.Nullable<bool> instanced = null,
            System.Nullable<bool> useBytes = null,
            System.Nullable<decimal> divisor = null,
            string label = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Buffer" },
                engine,
                data,
                updatable,
                stride,
                postponeInternalCreation,
                instanced,
                useBytes,
                divisor,
                label
            );

            return new Buffer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<VertexBuffer> createVertexBuffer(
            string kind,
            decimal offset,
            decimal size,
            System.Nullable<decimal> stride = null,
            System.Nullable<bool> instanced = null,
            System.Nullable<bool> useBytes = null,
            System.Nullable<decimal> divisor = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
                entity => new VertexBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createVertexBuffer" },
                    kind,
                    offset,
                    size,
                    stride,
                    instanced,
                    useBytes,
                    divisor
                }
            );
        }

        public async ValueTask<bool> isUpdatable()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isUpdatable" } }
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

        public async ValueTask<decimal> getStrideSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getStrideSize" } }
            );
        }

        public async ValueTask create(decimal[] data = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "create" }, data }
            );
        }

        public async ValueTask update(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" }, data }
            );
        }

        public async ValueTask updateDirectly(
            decimal[] data,
            decimal offset,
            System.Nullable<decimal> vertexCount = null,
            System.Nullable<bool> useBytes = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDirectly" },
                    data,
                    offset,
                    vertexCount,
                    useBytes
                }
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
