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

    [JsonConverter(typeof(CachedEntityConverter<DynamicTexture>))]
    public class DynamicTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool canRescale
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRescale"); }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public DynamicTexture()
            : base() { }

        public DynamicTexture(ICachedEntity entity)
            : base(entity) { }

        public DynamicTexture(
            string name,
            object options,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> format = null,
            System.Nullable<bool> invertY = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                name,
                options,
                scene,
                generateMipMaps,
                samplingMode,
                format,
                invertY
            );
            ___guid = entity.___guid;
        }

        public DynamicTexture(
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
                new string[] { "BABYLON", "DynamicTexture" },
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

        public DynamicTexture(Scene sceneOrEngine = null, InternalTexture internalTexture = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public DynamicTexture(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public void scaleTo(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scaleTo" }, width, height }
            );
        }

        public ICanvasRenderingContextCachedEntity getContext()
        {
            return EventHorizonBlazorInterop.FuncClass<ICanvasRenderingContextCachedEntity>(
                entity => new ICanvasRenderingContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getContext" } }
            );
        }

        public void clear(string clearColor = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clear" }, clearColor }
            );
        }

        public void update(
            System.Nullable<bool> invertY = null,
            System.Nullable<bool> premulAlpha = null,
            System.Nullable<bool> allowGPUOptimization = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" },
                    invertY,
                    premulAlpha,
                    allowGPUOptimization
                }
            );
        }

        public void drawText(
            string text,
            string font,
            System.Nullable<decimal> x = null,
            System.Nullable<decimal> y = null,
            string color = null,
            string fillColor = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<bool> update = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawText" },
                    text,
                    x,
                    y,
                    font,
                    color,
                    fillColor,
                    invertY,
                    update
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public DynamicTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicTexture>(
                entity => new DynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }
        #endregion
    }
}
