/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
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

    public bool isSupported
    {
        get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSupported"); }
    }

    public Texture[] textures
    {
        get
        {
            return EventHorizonBlazorInterop.GetArrayClass<Texture>(
                this.___guid,
                "textures",
                (entity) =>
                {
                    return new Texture() { ___guid = entity.___guid };
                }
            );
        }
    }

    public decimal count
    {
        get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "count"); }
    }

    private Texture __depthTexture;
    public Texture depthTexture
    {
        get
        {
            if (__depthTexture == null)
            {
                __depthTexture = EventHorizonBlazorInterop.GetClass<Texture>(
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
    }

    public decimal samples
    {
        get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
        }
    }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public MultiRenderTarget()
        : base() { }

    public MultiRenderTarget(ICachedEntity entity)
        : base(entity) { }

    public MultiRenderTarget(
        string name,
        object size,
        decimal count,
        Scene scene,
        IMultiRenderTargetOptions options = null
    )
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            name,
            size,
            count,
            scene,
            options
        );
        ___guid = entity.___guid;
    }

    public MultiRenderTarget(
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
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
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
        ___guid = entity.___guid;
    }

    public MultiRenderTarget(
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
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
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
        ___guid = entity.___guid;
    }

    public MultiRenderTarget(Scene sceneOrEngine)
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            sceneOrEngine
        );
        ___guid = entity.___guid;
    }

    public MultiRenderTarget(InternalTexture internalTexture)
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "MultiRenderTarget" },
            internalTexture
        );
        ___guid = entity.___guid;
    }
    #endregion

    #region Methods
    public void replaceTexture(Texture texture, decimal index)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "replaceTexture" }, texture, index }
        );
    }

    public void resize(object size)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "resize" }, size }
        );
    }

    public void updateCount(decimal count, IMultiRenderTargetOptions options = null)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "updateCount" }, count, options }
        );
    }

    public void dispose()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "dispose" } }
        );
    }

    public void releaseInternalTextures()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "releaseInternalTextures" } }
        );
    }
    #endregion
}
