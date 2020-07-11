/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Buffer : CachedEntityObject
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
        
        public decimal byteStride
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "byteStride"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Buffer() : base() { } 

        public Buffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Buffer(
            CachedEntity engine, DataArray data, bool updatable, System.Nullable<decimal> stride = null, System.Nullable<bool> postponeInternalCreation = null, System.Nullable<bool> instanced = null, System.Nullable<bool> useBytes = null, System.Nullable<decimal> divisor = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Buffer" },
                engine, data, updatable, stride, postponeInternalCreation, instanced, useBytes, divisor
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public VertexBuffer createVertexBuffer(string kind, decimal offset, decimal size, System.Nullable<decimal> stride = null, System.Nullable<bool> instanced = null, System.Nullable<bool> useBytes = null, System.Nullable<decimal> divisor = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexBuffer>(
                entity => new VertexBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createVertexBuffer" }, kind, offset, size, stride, instanced, useBytes, divisor
                }
            );
        }

        public bool isUpdatable()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isUpdatable" }
                }
            );
        }

        public DataArray getData()
        {
            return EventHorizonBlazorInteropt.FuncClass<DataArray>(
                entity => new DataArray(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public DataBuffer getBuffer()
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBuffer" }
                }
            );
        }

        public decimal getStrideSize()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStrideSize" }
                }
            );
        }

        public void create(DataArray data = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "create" }, data
                }
            );
        }

        public void update(DataArray data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, data
                }
            );
        }

        public void updateDirectly(DataArray data, decimal offset, System.Nullable<decimal> vertexCount = null, System.Nullable<bool> useBytes = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDirectly" }, data, offset, vertexCount, useBytes
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}