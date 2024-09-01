/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<RawTexture>))]
public class RawTexture : Texture
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
    public static async ValueTask<RawTexture> CreateLuminanceTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateLuminanceTexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode
            }
        );
    }

    public static async ValueTask<RawTexture> CreateLuminanceAlphaTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateLuminanceAlphaTexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode
            }
        );
    }

    public static async ValueTask<RawTexture> CreateAlphaTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateAlphaTexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode
            }
        );
    }

    public static async ValueTask<RawTexture> CreateRGBTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null,
        System.Nullable<decimal> type = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateRGBTexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode,
                type
            }
        );
    }

    public static async ValueTask<RawTexture> CreateRGBATexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null,
        System.Nullable<decimal> type = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateRGBATexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode,
                type
            }
        );
    }

    public static async ValueTask<RawTexture> CreateRTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null,
        System.Nullable<decimal> type = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
            entity => new RawTexture() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "RawTexture", "CreateRTexture" },
                data,
                width,
                height,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode,
                type
            }
        );
    }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    public async ValueTask<decimal> get_format()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "format");
    }

    public ValueTask set_format(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "format", value);
    }
    #endregion

    #region Constructor
    public RawTexture()
        : base() { }

    public RawTexture(ICachedEntity entity)
        : base(entity) { }

    public static async ValueTask<RawTexture> NewRawTexture(
        ArrayBufferView data,
        decimal width,
        decimal height,
        decimal format,
        Scene sceneOrEngine,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null,
        System.Nullable<decimal> type = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "RawTexture" },
            data,
            width,
            height,
            format,
            sceneOrEngine,
            generateMipMaps,
            invertY,
            samplingMode,
            type
        );

        return new RawTexture(entity);
    }

    public static async ValueTask<RawTexture> NewRawTexture(
        Scene sceneOrEngine,
        string url = null,
        System.Nullable<bool> noMipmap = null,
        System.Nullable<bool> invertY = null,
        System.Nullable<decimal> samplingMode = null,
        ActionCallback onLoad = null,
        ActionCallback<string, CachedEntity> onError = null,
        string buffer = null,
        System.Nullable<bool> deleteBuffer = null,
        System.Nullable<decimal> format = null,
        string mimeType = null,
        object loaderOptions = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "RawTexture" },
            url,
            sceneOrEngine,
            noMipmap,
            invertY,
            samplingMode,
            onLoad,
            onError,
            buffer,
            deleteBuffer,
            format,
            mimeType,
            loaderOptions
        );

        return new RawTexture(entity);
    }

    public static async ValueTask<RawTexture> NewRawTexture(Scene sceneOrEngine)
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "RawTexture" },
            sceneOrEngine
        );

        return new RawTexture(entity);
    }

    public static async ValueTask<RawTexture> NewRawTexture(InternalTexture internalTexture)
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "RawTexture" },
            internalTexture
        );

        return new RawTexture(entity);
    }
    #endregion

    #region Methods
    public async ValueTask update(ArrayBufferView data)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "update" }, data }
        );
    }
    #endregion
}
