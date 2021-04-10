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

    
    
    [JsonConverter(typeof(CachedEntityConverter<VertexBuffer>))]
    public class VertexBuffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_BYTE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.BYTE"
                );
        }

        
        public static async ValueTask<decimal> get_UNSIGNED_BYTE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_BYTE"
                );
        }

        
        public static async ValueTask<decimal> get_SHORT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.SHORT"
                );
        }

        
        public static async ValueTask<decimal> get_UNSIGNED_SHORT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_SHORT"
                );
        }

        
        public static async ValueTask<decimal> get_INT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.INT"
                );
        }

        
        public static async ValueTask<decimal> get_UNSIGNED_INT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_INT"
                );
        }

        
        public static async ValueTask<decimal> get_FLOAT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.FLOAT"
                );
        }

        
        public static async ValueTask<string> get_PositionKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.PositionKind"
                );
        }

        
        public static async ValueTask<string> get_NormalKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.NormalKind"
                );
        }

        
        public static async ValueTask<string> get_TangentKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.TangentKind"
                );
        }

        
        public static async ValueTask<string> get_UVKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UVKind"
                );
        }

        
        public static async ValueTask<string> get_UV2Kind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV2Kind"
                );
        }

        
        public static async ValueTask<string> get_UV3Kind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV3Kind"
                );
        }

        
        public static async ValueTask<string> get_UV4Kind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV4Kind"
                );
        }

        
        public static async ValueTask<string> get_UV5Kind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV5Kind"
                );
        }

        
        public static async ValueTask<string> get_UV6Kind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV6Kind"
                );
        }

        
        public static async ValueTask<string> get_ColorKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.ColorKind"
                );
        }

        
        public static async ValueTask<string> get_MatricesIndicesKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesIndicesKind"
                );
        }

        
        public static async ValueTask<string> get_MatricesWeightsKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesWeightsKind"
                );
        }

        
        public static async ValueTask<string> get_MatricesIndicesExtraKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesIndicesExtraKind"
                );
        }

        
        public static async ValueTask<string> get_MatricesWeightsExtraKind()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesWeightsExtraKind"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<decimal> DeduceStride(string kind)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexBuffer", "DeduceStride" }, kind
                }
            );
        }

        public static async ValueTask<decimal> GetTypeByteLength(decimal type)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexBuffer", "GetTypeByteLength" }, type
                }
            );
        }

        public static async ValueTask ForEach(decimal[] data, decimal byteOffset, decimal byteStride, decimal componentCount, decimal componentType, decimal count, bool normalized, ActionCallback<decimal, decimal> callback)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexBuffer", "ForEach" }, data, byteOffset, byteStride, componentCount, componentType, count, normalized, callback
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_instanceDivisor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instanceDivisor"
                );
        }
        public ValueTask set_instanceDivisor(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instanceDivisor",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_byteStride()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "byteStride"
                );
        }

        
        public async ValueTask<decimal> get_byteOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "byteOffset"
                );
        }

        
        public async ValueTask<bool> get_normalized()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "normalized"
                );
        }

        
        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
        }
        #endregion
        
        #region Constructor
        public VertexBuffer() : base() { } 

        public VertexBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<VertexBuffer> NewVertexBuffer(
            object engine, decimal[] data, string kind, bool updatable, System.Nullable<bool> postponeInternalCreation = null, System.Nullable<decimal> stride = null, System.Nullable<bool> instanced = null, System.Nullable<decimal> offset = null, System.Nullable<decimal> size = null, System.Nullable<decimal> type = null, System.Nullable<bool> normalized = null, System.Nullable<bool> useBytes = null, System.Nullable<decimal> divisor = null, System.Nullable<bool> takeBufferOwnership = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "VertexBuffer" },
                engine, data, kind, updatable, postponeInternalCreation, stride, instanced, offset, size, type, normalized, useBytes, divisor, takeBufferOwnership
            );

            return new VertexBuffer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getKind()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getKind" }
                }
            );
        }

        public async ValueTask<bool> isUpdatable()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isUpdatable" }
                }
            );
        }

        public async ValueTask<decimal[]> getData()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public async ValueTask<DataBuffer> getBuffer()
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBuffer" }
                }
            );
        }

        public async ValueTask<decimal> getStrideSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStrideSize" }
                }
            );
        }

        public async ValueTask<decimal> getOffset()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getOffset" }
                }
            );
        }

        public async ValueTask<decimal> getSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getSize" }
                }
            );
        }

        public async ValueTask<bool> getIsInstanced()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getIsInstanced" }
                }
            );
        }

        public async ValueTask<decimal> getInstanceDivisor()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getInstanceDivisor" }
                }
            );
        }

        public async ValueTask create(decimal[] data = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "create" }, data
                }
            );
        }

        public async ValueTask update(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, data
                }
            );
        }

        public async ValueTask updateDirectly(decimal[] data, decimal offset, System.Nullable<bool> useBytes = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDirectly" }, data, offset, useBytes
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask forEach(decimal count, ActionCallback<decimal, decimal> callback)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forEach" }, count, callback
                }
            );
        }
        #endregion
    }
}