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

        public bool useUbo
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useUbo"); }
        }

        public bool isSync
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSync"); }
        }

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
        }

        private Effect __currentEffect;
        public Effect currentEffect
        {
            get
            {
                if (__currentEffect == null)
                {
                    __currentEffect = EventHorizonBlazorInterop.GetClass<Effect>(
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

        public UniformBuffer(
            AbstractEngine engine,
            decimal[] data = null,
            System.Nullable<bool> dynamic = null,
            string name = null,
            System.Nullable<bool> forceNoUniformBuffer = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "UniformBuffer" },
                engine,
                data,
                dynamic,
                name,
                forceNoUniformBuffer
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateMatrix3x3(string name, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix3x3" }, name, matrix }
            );
        }

        public void updateMatrix2x2(string name, decimal[] matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix2x2" }, name, matrix }
            );
        }

        public void updateFloat(string name, decimal x)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloat" }, name, x }
            );
        }

        public void updateFloat2(string name, decimal x, decimal y, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloat2" }, name, x, y, suffix }
            );
        }

        public void updateFloat3(string name, decimal x, decimal y, decimal z, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void updateFloat4(
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

        public void updateFloatArray(string name, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateFloatArray" }, name, array }
            );
        }

        public void updateArray(string name, decimal[] array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateArray" }, name, array }
            );
        }

        public void updateIntArray(string name, Int32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateIntArray" }, name, array }
            );
        }

        public void updateUIntArray(string name, Uint32Array array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUIntArray" }, name, array }
            );
        }

        public void updateMatrix(string name, IMatrixLike mat)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrix" }, name, mat }
            );
        }

        public void updateMatrices(string name, decimal[] mat)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateMatrices" }, name, mat }
            );
        }

        public void updateVector3(string name, IVector3Like vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateVector3" }, name, vector }
            );
        }

        public void updateVector4(string name, IVector4Like vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateVector4" }, name, vector }
            );
        }

        public void updateColor3(string name, IColor3Like color, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateColor3" }, name, color, suffix }
            );
        }

        public void updateColor4(
            string name,
            IColor3Like color,
            decimal alpha,
            string suffix = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void updateDirectColor4(string name, IColor4Like color, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDirectColor4" },
                    name,
                    color,
                    suffix
                }
            );
        }

        public void updateInt(string name, decimal x, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt" }, name, x, suffix }
            );
        }

        public void updateInt2(string name, decimal x, decimal y, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt2" }, name, x, y, suffix }
            );
        }

        public void updateInt3(string name, decimal x, decimal y, decimal z, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateInt3" }, name, x, y, z, suffix }
            );
        }

        public void updateInt4(
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

        public void updateUInt(string name, decimal x, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt" }, name, x, suffix }
            );
        }

        public void updateUInt2(string name, decimal x, decimal y, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt2" }, name, x, y, suffix }
            );
        }

        public void updateUInt3(string name, decimal x, decimal y, decimal z, string suffix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateUInt3" }, name, x, y, z, suffix }
            );
        }

        public void updateUInt4(
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

        public bool isDynamic()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDynamic" } }
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

        public void addUniform(string name, decimal size, System.Nullable<decimal> arraySize = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addUniform" }, name, size, arraySize }
            );
        }

        public void addMatrix(string name, IMatrixLike mat)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix" }, name, mat }
            );
        }

        public void addFloat2(string name, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addFloat2" }, name, x, y }
            );
        }

        public void addFloat3(string name, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addFloat3" }, name, x, y, z }
            );
        }

        public void addColor3(string name, IColor3Like color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColor3" }, name, color }
            );
        }

        public void addColor4(string name, IColor3Like color, decimal alpha)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColor4" }, name, color, alpha }
            );
        }

        public void addVector3(string name, IVector3Like vector)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addVector3" }, name, vector }
            );
        }

        public void addMatrix3x3(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix3x3" }, name }
            );
        }

        public void addMatrix2x2(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addMatrix2x2" }, name }
            );
        }

        public void create()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "create" } }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" } }
            );
        }

        public void updateUniform(string uniformName, decimal[] data, decimal size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniform" },
                    uniformName,
                    data,
                    size
                }
            );
        }

        public void updateUniformArray(string uniformName, decimal[] data, decimal size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformArray" },
                    uniformName,
                    data,
                    size
                }
            );
        }

        public void setTexture(string name, ThinTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTexture" }, name, texture }
            );
        }

        public void bindTexture(string name, InternalTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindTexture" }, name, texture }
            );
        }

        public void updateUniformDirectly(string uniformName, decimal[] data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformDirectly" },
                    uniformName,
                    data
                }
            );
        }

        public void bindToEffect(Effect effect, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindToEffect" }, effect, name }
            );
        }

        public void bindUniformBuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bindUniformBuffer" } }
            );
        }

        public void unbindEffect()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unbindEffect" } }
            );
        }

        public bool setDataBuffer(DataBuffer dataBuffer)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setDataBuffer" }, dataBuffer }
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
