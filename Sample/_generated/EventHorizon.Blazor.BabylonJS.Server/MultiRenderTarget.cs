/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<MultiRenderTarget>))]
public class MultiRenderTarget : RenderTargetTexture
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    public async ValueTask<bool> get_isSupported()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSupported");
    }

    public async ValueTask<Texture[]> get_textures()
    {
        return await EventHorizonBlazorInterop.GetArrayClass<Texture>(
            this.___guid,
            "textures",
            (entity) =>
            {
                return new Texture() { ___guid = entity.___guid };
            }
        );
    }

    public async ValueTask<decimal> get_count()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "count");
    }

    private Texture __depthTexture;

    public async ValueTask<Texture> get_depthTexture()
    {
        if (__depthTexture == null)
        {
            __depthTexture = await EventHorizonBlazorInterop.GetClass<Texture>(
                this.___guid,
                "depthTexture",
                (entity) =>
                {
                    return new Texture() { ___guid = entity.___guid };
                }
            );
        }
        return __depthTexture;
    }

    public async ValueTask<decimal> get_samples()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples");
    }

    public ValueTask set_samples(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
    }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public MultiRenderTarget()
        : base() { }

    public MultiRenderTarget(ICachedEntity entity)
        : base(entity) { }

    public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
        string name,
        object size,
        decimal count,
        Scene scene,
        IMultiRenderTargetOptions options = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            name,
            size,
            count,
            scene,
            options
        );

        return new MultiRenderTarget(entity);
    }

    public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
        string name,
        decimal size,
        Scene scene,
        System.Nullable<bool> generateMipMaps = null,
        System.Nullable<bool> doNotChangeAspectRatio = null,
        System.Nullable<decimal> type = null,
        System.Nullable<bool> isCube = null,
        System.Nullable<decimal> samplingMode = null,
        System.Nullable<bool> generateDepthBuffer = null,
        System.Nullable<bool> generateStencilBuffer = null,
        System.Nullable<bool> isMulti = null,
        System.Nullable<decimal> format = null,
        System.Nullable<bool> delayAllocation = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            name,
            size,
            scene,
            generateMipMaps,
            doNotChangeAspectRatio,
            type,
            isCube,
            samplingMode,
            generateDepthBuffer,
            generateStencilBuffer,
            isMulti,
            format,
            delayAllocation
        );

        return new MultiRenderTarget(entity);
    }

    public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
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
            new string[] { "MultiRenderTarget" },
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

        return new MultiRenderTarget(entity);
    }

    public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(Scene sceneOrEngine)
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            sceneOrEngine
        );

        return new MultiRenderTarget(entity);
    }

    public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
        InternalTexture internalTexture
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            internalTexture
        );

        return new MultiRenderTarget(entity);
    }
    #endregion

    #region Methods
    public async ValueTask replaceTexture(Texture texture, decimal index)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "replaceTexture" }, texture, index }
        );
    }

    public async ValueTask resize(object size)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "resize" }, size }
        );
    }

    public async ValueTask updateCount(decimal count, IMultiRenderTargetOptions options = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateCount" }, count, options }
        );
    }

    public async ValueTask dispose()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "dispose" } }
        );
    }

    public async ValueTask releaseInternalTextures()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "releaseInternalTextures" } }
        );
    }
    #endregion
}
