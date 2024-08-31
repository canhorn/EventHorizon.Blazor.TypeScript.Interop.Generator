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

        public bool isDisposed
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed"); }
        }
        #endregion

        #region Properties

        public decimal byteStride
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "byteStride"); }
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

        public Buffer(
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
            var entity = EventHorizonBlazorInterop.New(
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
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public VertexBuffer createVertexBuffer(
            string kind,
            decimal offset,
            decimal size,
            System.Nullable<decimal> stride = null,
            System.Nullable<bool> instanced = null,
            System.Nullable<bool> useBytes = null,
            System.Nullable<decimal> divisor = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
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

        public bool isUpdatable()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isUpdatable" } }
            );
        }

        public decimal[] getData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getData" } }
            );
        }

        public DataBuffer getBuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBuffer" } }
            );
        }

        public decimal getStrideSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getStrideSize" } }
            );
        }

        public void create(decimal[] data = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "create" }, data }
            );
        }

        public void update(decimal[] data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" }, data }
            );
        }

        public void updateDirectly(
            decimal[] data,
            decimal offset,
            System.Nullable<decimal> vertexCount = null,
            System.Nullable<bool> useBytes = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
