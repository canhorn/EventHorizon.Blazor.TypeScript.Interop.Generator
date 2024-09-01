/// Generated - Do Not Edit
namespace BABYLON
{
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
            Scene scene = null,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                name,
                size,
                count,
                scene,
                options,
                textureNames
            );

            return new MultiRenderTarget(entity);
        }

        public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                name,
                size,
                scene,
                options
            );

            return new MultiRenderTarget(entity);
        }

        public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
            string url = null,
            Scene sceneOrEngine = null,
            System.Nullable<bool> noMipmapOrOptions = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            ActionCallback onLoad = null,
            ActionCallback<string, CachedEntity> onError = null,
            string buffer = null,
            System.Nullable<bool> deleteBuffer = null,
            System.Nullable<decimal> format = null,
            string mimeType = null,
            object loaderOptions = null,
            System.Nullable<decimal> creationFlags = null,
            string forcedExtension = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                url,
                sceneOrEngine,
                noMipmapOrOptions,
                invertY,
                samplingMode,
                onLoad,
                onError,
                buffer,
                deleteBuffer,
                format,
                mimeType,
                loaderOptions,
                creationFlags,
                forcedExtension
            );

            return new MultiRenderTarget(entity);
        }

        public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                sceneOrEngine,
                internalTexture
            );

            return new MultiRenderTarget(entity);
        }

        public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                internalTexture
            );

            return new MultiRenderTarget(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setInternalTexture(
            InternalTexture texture,
            decimal index,
            System.Nullable<bool> disposePrevious = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setInternalTexture" },
                    texture,
                    index,
                    disposePrevious
                }
            );
        }

        public async ValueTask setLayerAndFaceIndex(
            decimal index,
            System.Nullable<decimal> layerIndex = null,
            System.Nullable<decimal> faceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndex" },
                    index,
                    layerIndex,
                    faceIndex
                }
            );
        }

        public async ValueTask setLayerAndFaceIndices(decimal[] layerIndices, decimal[] faceIndices)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndices" },
                    layerIndices,
                    faceIndices
                }
            );
        }

        public async ValueTask resize(object size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, size }
            );
        }

        public async ValueTask updateCount(
            decimal count,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCount" },
                    count,
                    options,
                    textureNames
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> doNotDisposeInternalTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" },
                    doNotDisposeInternalTextures
                }
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
}
