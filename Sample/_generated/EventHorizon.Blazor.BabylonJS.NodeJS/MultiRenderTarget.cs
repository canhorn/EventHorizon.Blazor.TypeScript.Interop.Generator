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
            Scene scene = null,
            IMultiRenderTargetOptions options = null,
            string[] textureNames = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                name,
                size,
                count,
                scene,
                options,
                textureNames
            );
            ___guid = entity.___guid;
        }

        public MultiRenderTarget(
            string name,
            decimal size,
            Scene scene = null,
            RenderTargetTextureOptions options = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                name,
                size,
                scene,
                options
            );
            ___guid = entity.___guid;
        }

        public MultiRenderTarget(
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
            ___guid = entity.___guid;
        }

        public MultiRenderTarget(Scene sceneOrEngine = null, InternalTexture internalTexture = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public MultiRenderTarget(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setInternalTexture(
            InternalTexture texture,
            decimal index,
            System.Nullable<bool> disposePrevious = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setInternalTexture" },
                    texture,
                    index,
                    disposePrevious
                }
            );
        }

        public void setLayerAndFaceIndex(
            decimal index,
            System.Nullable<decimal> layerIndex = null,
            System.Nullable<decimal> faceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndex" },
                    index,
                    layerIndex,
                    faceIndex
                }
            );
        }

        public void setLayerAndFaceIndices(decimal[] layerIndices, decimal[] faceIndices)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndices" },
                    layerIndices,
                    faceIndices
                }
            );
        }

        public void resize(object size)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resize" }, size }
            );
        }

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

        public void dispose(System.Nullable<bool> doNotDisposeInternalTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" },
                    doNotDisposeInternalTextures
                }
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
}
