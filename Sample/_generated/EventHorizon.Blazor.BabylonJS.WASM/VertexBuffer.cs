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
    public class VertexBuffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BYTE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.BYTE"
                );
            }
        }

        
        public static decimal UNSIGNED_BYTE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_BYTE"
                );
            }
        }

        
        public static decimal SHORT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.SHORT"
                );
            }
        }

        
        public static decimal UNSIGNED_SHORT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_SHORT"
                );
            }
        }

        
        public static decimal INT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.INT"
                );
            }
        }

        
        public static decimal UNSIGNED_INT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.UNSIGNED_INT"
                );
            }
        }

        
        public static decimal FLOAT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "VertexBuffer.FLOAT"
                );
            }
        }

        
        public static string PositionKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.PositionKind"
                );
            }
        }

        
        public static string NormalKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.NormalKind"
                );
            }
        }

        
        public static string TangentKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.TangentKind"
                );
            }
        }

        
        public static string UVKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UVKind"
                );
            }
        }

        
        public static string UV2Kind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV2Kind"
                );
            }
        }

        
        public static string UV3Kind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV3Kind"
                );
            }
        }

        
        public static string UV4Kind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV4Kind"
                );
            }
        }

        
        public static string UV5Kind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV5Kind"
                );
            }
        }

        
        public static string UV6Kind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.UV6Kind"
                );
            }
        }

        
        public static string ColorKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.ColorKind"
                );
            }
        }

        
        public static string MatricesIndicesKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesIndicesKind"
                );
            }
        }

        
        public static string MatricesWeightsKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesWeightsKind"
                );
            }
        }

        
        public static string MatricesIndicesExtraKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesIndicesExtraKind"
                );
            }
        }

        
        public static string MatricesWeightsExtraKind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "VertexBuffer.MatricesWeightsExtraKind"
                );
            }
        }
        #endregion

        #region Static Methods
        public static decimal DeduceStride(string kind)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexBuffer", "DeduceStride" }, kind
                }
            );
        }

        public static decimal GetTypeByteLength(decimal type)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexBuffer", "GetTypeByteLength" }, type
                }
            );
        }

// ForEach is not supported by the platform yet
        #endregion

        #region Accessors
        
        public decimal instanceDivisor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "instanceDivisor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "instanceDivisor",
                    value
                );
            }
        }
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

        
        public decimal byteOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "byteOffset"
                );
            }
        }

        
        public bool normalized
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "normalized"
                );
            }
        }

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
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

        public VertexBuffer(
            object engine, DataArray data, string kind, bool updatable, System.Nullable<bool> postponeInternalCreation = null, System.Nullable<decimal> stride = null, System.Nullable<bool> instanced = null, System.Nullable<decimal> offset = null, System.Nullable<decimal> size = null, System.Nullable<decimal> type = null, System.Nullable<bool> normalized = null, System.Nullable<bool> useBytes = null, System.Nullable<decimal> divisor = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "VertexBuffer" },
                engine, data, kind, updatable, postponeInternalCreation, stride, instanced, offset, size, type, normalized, useBytes, divisor
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getKind()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getKind" }
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
                entity => new DataArray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public DataBuffer getBuffer()
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
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

        public decimal getOffset()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getOffset" }
                }
            );
        }

        public decimal getSize()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getSize" }
                }
            );
        }

        public bool getIsInstanced()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getIsInstanced" }
                }
            );
        }

        public decimal getInstanceDivisor()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getInstanceDivisor" }
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

        public void updateDirectly(DataArray data, decimal offset, System.Nullable<bool> useBytes = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateDirectly" }, data, offset, useBytes
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

// forEach is not supported by the platform yet
        #endregion
    }
}