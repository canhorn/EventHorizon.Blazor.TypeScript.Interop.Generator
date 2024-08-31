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

    [JsonConverter(typeof(CachedEntityConverter<RawTexture>))]
    public class RawTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static RawTexture CreateLuminanceTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateLuminanceTexture" },
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

        public static RawTexture CreateLuminanceAlphaTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateLuminanceAlphaTexture" },
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

        public static RawTexture CreateAlphaTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateAlphaTexture" },
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

        public static RawTexture CreateRGBTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> type = null,
            System.Nullable<decimal> creationFlags = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateRGBTexture" },
                    data,
                    width,
                    height,
                    sceneOrEngine,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    type,
                    creationFlags,
                    useSRGBBuffer
                }
            );
        }

        public static RawTexture CreateRGBATexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> type = null,
            System.Nullable<decimal> creationFlags = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateRGBATexture" },
                    data,
                    width,
                    height,
                    sceneOrEngine,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    type,
                    creationFlags,
                    useSRGBBuffer
                }
            );
        }

        public static RawTexture CreateRGBAStorageTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> type = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateRGBAStorageTexture" },
                    data,
                    width,
                    height,
                    sceneOrEngine,
                    generateMipMaps,
                    invertY,
                    samplingMode,
                    type,
                    useSRGBBuffer
                }
            );
        }

        public static RawTexture CreateRTexture(
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
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateRTexture" },
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

        public static RawTexture CreateRStorageTexture(
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
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "RawTexture", "CreateRStorageTexture" },
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

        public decimal format
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "format"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "format", value);
            }
        }
        #endregion

        #region Constructor
        public RawTexture()
            : base() { }

        public RawTexture(ICachedEntity entity)
            : base(entity) { }

        public RawTexture(
            ArrayBufferView data,
            decimal width,
            decimal height,
            decimal format,
            Scene sceneOrEngine,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> type = null,
            System.Nullable<decimal> creationFlags = null,
            System.Nullable<bool> useSRGBBuffer = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RawTexture" },
                data,
                width,
                height,
                format,
                sceneOrEngine,
                generateMipMaps,
                invertY,
                samplingMode,
                type,
                creationFlags,
                useSRGBBuffer
            );
            ___guid = entity.___guid;
        }

        public RawTexture(
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
                new string[] { "BABYLON", "RawTexture" },
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

        public RawTexture(Scene sceneOrEngine = null, InternalTexture internalTexture = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RawTexture" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public RawTexture(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RawTexture" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void update(ArrayBufferView data)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" }, data }
            );
        }

        public Texture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }
        #endregion
    }
}
