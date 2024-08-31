/// Generated - Do Not Edit
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

    public UniformBuffer(Engine engine, decimal[] data = null, System.Nullable<bool> dynamic = null)
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "UniformBuffer" },
            engine,
            data,
            dynamic
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
            new object[] { new string[] { this.___guid, "updateFloat3" }, name, x, y, z, suffix }
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
            new object[] { new string[] { this.___guid, "updateFloat4" }, name, x, y, z, w, suffix }
        );
    }

    public void updateMatrix(string name, Matrix mat)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateMatrix" }, name, mat }
        );
    }

    public void updateVector3(string name, Vector3 vector)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateVector3" }, name, vector }
        );
    }

    public void updateVector4(string name, Vector4 vector)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateVector4" }, name, vector }
        );
    }

    public void updateColor3(string name, Color3 color, string suffix = null)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateColor3" }, name, color, suffix }
        );
    }

    public void updateColor4(string name, Color3 color, decimal alpha, string suffix = null)
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

    public void addUniform(string name, decimal size)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addUniform" }, name, size }
        );
    }

    public void addMatrix(string name, Matrix mat)
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

    public void addColor3(string name, Color3 color)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addColor3" }, name, color }
        );
    }

    public void addColor4(string name, Color3 color, decimal alpha)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addColor4" }, name, color, alpha }
        );
    }

    public void addVector3(string name, Vector3 vector)
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
            new object[] { new string[] { this.___guid, "updateUniform" }, uniformName, data, size }
        );
    }

    public void setTexture(string name, BaseTexture texture)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "setTexture" }, name, texture }
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

    public void dispose()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "dispose" } }
        );
    }
    #endregion
}
