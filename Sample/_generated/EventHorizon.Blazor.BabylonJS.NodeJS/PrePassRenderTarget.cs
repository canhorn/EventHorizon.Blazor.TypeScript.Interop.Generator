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
        public ImageProcessingPostProcess imageProcessingPostProcess
        {
            get
            {
                if (__imageProcessingPostProcess == null)
                {
                    __imageProcessingPostProcess =
                        EventHorizonBlazorInterop.GetClass<ImageProcessingPostProcess>(
                            this.___guid,
                            "imageProcessingPostProcess",
                            (entity) =>
                            {
                                return new ImageProcessingPostProcess()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __imageProcessingPostProcess;
            }
            set
            {
                __imageProcessingPostProcess = null;
                EventHorizonBlazorInterop.Set(this.___guid, "imageProcessingPostProcess", value);
            }
        }

        public bool enabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
            }
        }

        private RenderTargetTexture __renderTargetTexture;
        public RenderTargetTexture renderTargetTexture
        {
            get
            {
                if (__renderTargetTexture == null)
                {
                    __renderTargetTexture = EventHorizonBlazorInterop.GetClass<RenderTargetTexture>(
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
            set
            {
                __renderTargetTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "renderTargetTexture", value);
            }
        }
        #endregion

        #region Constructor
        public PrePassRenderTarget()
            : base() { }

        public PrePassRenderTarget(ICachedEntity entity)
            : base(entity) { }

        public PrePassRenderTarget(
            string name,
            RenderTargetTexture renderTargetTexture,
            object size,
            decimal count,
            Scene scene = null,
            IMultiRenderTargetOptions options = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                renderTargetTexture,
                size,
                count,
                scene,
                options
            );
            ___guid = entity.___guid;
        }

        public PrePassRenderTarget(
            string name,
            object size,
            decimal count,
            Scene scene = null,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                size,
                count,
                scene,
                options,
                textureNames
            );
            ___guid = entity.___guid;
        }

        public PrePassRenderTarget(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                name,
                size,
                scene,
                options
            );
            ___guid = entity.___guid;
        }

        public PrePassRenderTarget(
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
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
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
            ___guid = entity.___guid;
        }

        public PrePassRenderTarget(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public PrePassRenderTarget(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderTarget" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateCount(
            decimal count,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCount" },
                    count,
                    options,
                    textureNames
                }
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
