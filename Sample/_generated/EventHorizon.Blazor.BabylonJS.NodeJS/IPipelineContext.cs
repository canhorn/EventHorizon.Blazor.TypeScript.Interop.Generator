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

        public bool isAsync
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isAsync"); }
        }

        public bool isReady
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReady"); }
        }

        public CachedEntity vertexBufferKindToType
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "vertexBufferKindToType",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "vertexBufferKindToType", value);
            }
        }
        #endregion

        #region Constructor
        public IPipelineContextCachedEntity()
            : base() { }

        public IPipelineContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public void setEngine<T>(T engine)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEngine" }, engine }
            );
        }

        public void setInt(string uniformName, decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt" }, uniformName, value }
            );
        }

        public void setInt2(string uniformName, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt2" }, uniformName, x, y }
            );
        }

        public void setInt3(string uniformName, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt3" }, uniformName, x, y, z }
            );
        }

        public void setInt4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setInt4" }, uniformName, x, y, z, w }
            );
        }

        public void setIntArray(string uniformName, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray" }, uniformName, array }
            );
        }

        public void setIntArray2(string uniformName, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray2" }, uniformName, array }
            );
        }

        public void setIntArray3(string uniformName, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray3" }, uniformName, array }
            );
        }

        public void setIntArray4(string uniformName, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setIntArray4" }, uniformName, array }
            );
        }

        public void setUInt(string uniformName, decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt" }, uniformName, value }
            );
        }

        public void setUInt2(string uniformName, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt2" }, uniformName, x, y }
            );
        }

        public void setUInt3(string uniformName, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt3" }, uniformName, x, y, z }
            );
        }

        public void setUInt4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUInt4" }, uniformName, x, y, z, w }
            );
        }

        public void setUIntArray(string uniformName, Uint32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray" }, uniformName, array }
            );
        }

        public void setUIntArray2(string uniformName, Uint32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray2" }, uniformName, array }
            );
        }

        public void setUIntArray3(string uniformName, Uint32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray3" }, uniformName, array }
            );
        }

        public void setUIntArray4(string uniformName, Uint32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setUIntArray4" }, uniformName, array }
            );
        }

        public void setArray(string uniformName, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray" }, uniformName, array }
            );
        }

        public void setArray2(string uniformName, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray2" }, uniformName, array }
            );
        }

        public void setArray3(string uniformName, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray3" }, uniformName, array }
            );
        }

        public void setArray4(string uniformName, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setArray4" }, uniformName, array }
            );
        }

        public void setMatrices(string uniformName, decimal[] matrices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrices" }, uniformName, matrices }
            );
        }

        public void setMatrix(string uniformName, IMatrixLike matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix" }, uniformName, matrix }
            );
        }

        public void setMatrix3x3(string uniformName, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix3x3" }, uniformName, matrix }
            );
        }

        public void setMatrix2x2(string uniformName, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMatrix2x2" }, uniformName, matrix }
            );
        }

        public void setFloat(string uniformName, decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat" }, uniformName, value }
            );
        }

        public void setVector2(string uniformName, IVector2Like vector2)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector2" }, uniformName, vector2 }
            );
        }

        public void setFloat2(string uniformName, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat2" }, uniformName, x, y }
            );
        }

        public void setVector3(string uniformName, IVector3Like vector3)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector3" }, uniformName, vector3 }
            );
        }

        public void setFloat3(string uniformName, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat3" }, uniformName, x, y, z }
            );
        }

        public void setVector4(string uniformName, IVector4Like vector4)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setVector4" }, uniformName, vector4 }
            );
        }

        public void setQuaternion(string uniformName, IQuaternionLike quaternion)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setQuaternion" },
                    uniformName,
                    quaternion
                }
            );
        }

        public void setFloat4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setFloat4" }, uniformName, x, y, z, w }
            );
        }

        public void setColor3(string uniformName, IColor3Like color3)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setColor3" }, uniformName, color3 }
            );
        }

        public void setColor4(string uniformName, IColor3Like color3, decimal alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setColor4" },
                    uniformName,
                    color3,
                    alpha
                }
            );
        }

        public void setDirectColor4(string uniformName, IColor4Like color4)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
