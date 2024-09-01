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

        public async ValueTask<bool> get_canRescale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRescale");
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public DynamicTexture()
            : base() { }

        public DynamicTexture(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<DynamicTexture> NewDynamicTexture(
            string name,
            object options,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> format = null,
            System.Nullable<bool> invertY = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                name,
                options,
                scene,
                generateMipMaps,
                samplingMode,
                format,
                invertY
            );

            return new DynamicTexture(entity);
        }

        public static async ValueTask<DynamicTexture> NewDynamicTexture(
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

            return new DynamicTexture(entity);
        }

        public static async ValueTask<DynamicTexture> NewDynamicTexture(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                sceneOrEngine,
                internalTexture
            );

            return new DynamicTexture(entity);
        }

        public static async ValueTask<DynamicTexture> NewDynamicTexture(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                internalTexture
            );

            return new DynamicTexture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public async ValueTask scaleTo(decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scaleTo" }, width, height }
            );
        }

        public async ValueTask<ICanvasRenderingContextCachedEntity> getContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<ICanvasRenderingContextCachedEntity>(
                entity => new ICanvasRenderingContextCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getContext" } }
            );
        }

        public async ValueTask clear(string clearColor = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clear" }, clearColor }
            );
        }

        public async ValueTask update(
            System.Nullable<bool> invertY = null,
            System.Nullable<bool> premulAlpha = null,
            System.Nullable<bool> allowGPUOptimization = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" },
                    invertY,
                    premulAlpha,
                    allowGPUOptimization
                }
            );
        }

        public async ValueTask drawText(
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
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask<DynamicTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<DynamicTexture>(
                entity => new DynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }
        #endregion
    }
}
