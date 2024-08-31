/// Generated - Do Not Edit
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
        Engine engine,
        decimal[] data = null,
        System.Nullable<bool> dynamic = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "UniformBuffer" },
            engine,
            data,
            dynamic
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
            new object[] { new string[] { this.___guid, "updateFloat3" }, name, x, y, z, suffix }
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
            new object[] { new string[] { this.___guid, "updateFloat4" }, name, x, y, z, w, suffix }
        );
    }

    public async ValueTask updateMatrix(string name, Matrix mat)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateMatrix" }, name, mat }
        );
    }

    public async ValueTask updateVector3(string name, Vector3 vector)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateVector3" }, name, vector }
        );
    }

    public async ValueTask updateVector4(string name, Vector4 vector)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateVector4" }, name, vector }
        );
    }

    public async ValueTask updateColor3(string name, Color3 color, string suffix = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateColor3" }, name, color, suffix }
        );
    }

    public async ValueTask updateColor4(
        string name,
        Color3 color,
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

    public async ValueTask addUniform(string name, decimal size)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addUniform" }, name, size }
        );
    }

    public async ValueTask addMatrix(string name, Matrix mat)
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

    public async ValueTask addColor3(string name, Color3 color)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addColor3" }, name, color }
        );
    }

    public async ValueTask addColor4(string name, Color3 color, decimal alpha)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "addColor4" }, name, color, alpha }
        );
    }

    public async ValueTask addVector3(string name, Vector3 vector)
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
            new object[] { new string[] { this.___guid, "updateUniform" }, uniformName, data, size }
        );
    }

    public async ValueTask setTexture(string name, BaseTexture texture)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "setTexture" }, name, texture }
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

    public async ValueTask dispose()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "dispose" } }
        );
    }
    #endregion
}
