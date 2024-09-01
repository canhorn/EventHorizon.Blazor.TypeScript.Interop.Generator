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

    [JsonConverter(typeof(CachedEntityConverter<PrePassRenderTarget>))]
    public class PrePassRenderTarget : MultiRenderTarget
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
        private ImageProcessingPostProcess __imageProcessingPostProcess;

        public async ValueTask<ImageProcessingPostProcess> get_imageProcessingPostProcess()
        {
            if (__imageProcessingPostProcess == null)
            {
                __imageProcessingPostProcess =
                    await EventHorizonBlazorInterop.GetClass<ImageProcessingPostProcess>(
                        this.___guid,
                        "imageProcessingPostProcess",
                        (entity) =>
                        {
                            return new ImageProcessingPostProcess() { ___guid = entity.___guid };
                        }
                    );
            }
            return __imageProcessingPostProcess;
        }

        public ValueTask set_imageProcessingPostProcess(ImageProcessingPostProcess value)
        {
            __imageProcessingPostProcess = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "imageProcessingPostProcess", value);
        }

        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled");
        }

        public ValueTask set_enabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
        }

        private RenderTargetTexture __renderTargetTexture;

        public async ValueTask<RenderTargetTexture> get_renderTargetTexture()
        {
            if (__renderTargetTexture == null)
            {
                __renderTargetTexture =
                    await EventHorizonBlazorInterop.GetClass<RenderTargetTexture>(
                        this.___guid,
                        "renderTargetTexture",
                        (entity) =>
                        {
                            return new RenderTargetTexture() { ___guid = entity.___guid };
                        }
                    );
            }
            return __renderTargetTexture;
        }

        public ValueTask set_renderTargetTexture(RenderTargetTexture value)
        {
            __renderTargetTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "renderTargetTexture", value);
        }
        #endregion

        #region Constructor
        public PrePassRenderTarget()
            : base() { }

        public PrePassRenderTarget(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
            string name,
            RenderTargetTexture renderTargetTexture,
            object size,
            decimal count,
            Scene scene = null,
            IMultiRenderTargetOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                renderTargetTexture,
                size,
                count,
                scene,
                options
            );

            return new PrePassRenderTarget(entity);
        }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
            string name,
            object size,
            decimal count,
            Scene scene = null,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                size,
                count,
                scene,
                options,
                textureNames
            );

            return new PrePassRenderTarget(entity);
        }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                size,
                scene,
                options
            );

            return new PrePassRenderTarget(entity);
        }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
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
                new string[] { "BABYLON", "PrePassRenderTarget" },
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

            return new PrePassRenderTarget(entity);
        }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                sceneOrEngine,
                internalTexture
            );

            return new PrePassRenderTarget(entity);
        }

        public static async ValueTask<PrePassRenderTarget> NewPrePassRenderTarget(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                internalTexture
            );

            return new PrePassRenderTarget(entity);
        }
        #endregion

        #region Methods
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

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
