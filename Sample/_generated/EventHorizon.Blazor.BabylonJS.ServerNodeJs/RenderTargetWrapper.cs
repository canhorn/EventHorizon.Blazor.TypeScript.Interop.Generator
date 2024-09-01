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

    [JsonConverter(typeof(CachedEntityConverter<RenderTargetWrapper>))]
    public class RenderTargetWrapper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private InternalTexture __depthStencilTexture;

        public async ValueTask<InternalTexture> get_depthStencilTexture()
        {
            if (__depthStencilTexture == null)
            {
                __depthStencilTexture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
                    this.___guid,
                    "depthStencilTexture",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __depthStencilTexture;
        }

        public async ValueTask<bool> get_depthStencilTextureWithStencil()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "depthStencilTextureWithStencil"
            );
        }

        public async ValueTask<bool> get_isCube()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCube");
        }

        public async ValueTask<bool> get_isMulti()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti");
        }

        public async ValueTask<bool> get_is2DArray()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "is2DArray");
        }

        public async ValueTask<bool> get_is3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "is3D");
        }

        public async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "size");
        }

        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width");
        }

        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height");
        }

        public async ValueTask<decimal> get_layers()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "layers");
        }

        public async ValueTask<decimal> get_depth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "depth");
        }

        private InternalTexture __texture;

        public async ValueTask<InternalTexture> get_texture()
        {
            if (__texture == null)
            {
                __texture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
        }

        public async ValueTask<InternalTexture[]> get_textures()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<InternalTexture>(
                this.___guid,
                "textures",
                (entity) =>
                {
                    return new InternalTexture() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<decimal[]> get_faceIndices()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "faceIndices");
        }

        public async ValueTask<decimal[]> get_layerIndices()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerIndices");
        }

        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples");
        }
        #endregion

        #region Properties

        public async ValueTask<string> get_label()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "label");
        }

        public ValueTask set_label(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "label", value);
        }
        #endregion

        #region Constructor
        public RenderTargetWrapper()
            : base() { }

        public RenderTargetWrapper(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<RenderTargetWrapper> NewRenderTargetWrapper(
            bool isMulti,
            bool isCube,
            decimal size,
            AbstractEngine engine,
            string label = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetWrapper" },
                isMulti,
                isCube,
                size,
                engine,
                label
            );

            return new RenderTargetWrapper(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> setSamples(
            decimal value,
            System.Nullable<bool> initializeBuffers = null,
            System.Nullable<bool> force = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setSamples" },
                    value,
                    initializeBuffers,
                    force
                }
            );
        }

        public async ValueTask setTextures(InternalTexture textures)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTextures" }, textures }
            );
        }

        public async ValueTask setTexture(
            InternalTexture texture,
            System.Nullable<decimal> index = null,
            System.Nullable<bool> disposePrevious = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" },
                    texture,
                    index,
                    disposePrevious
                }
            );
        }

        public async ValueTask setLayerAndFaceIndices(decimal[] layers, decimal[] faces)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndices" },
                    layers,
                    faces
                }
            );
        }

        public async ValueTask setLayerAndFaceIndex(
            System.Nullable<decimal> index = null,
            System.Nullable<decimal> layer = null,
            System.Nullable<decimal> face = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndex" },
                    index,
                    layer,
                    face
                }
            );
        }

        public async ValueTask<InternalTexture> createDepthStencilTexture(
            System.Nullable<decimal> comparisonFunction = null,
            System.Nullable<bool> bilinearFiltering = null,
            System.Nullable<bool> generateStencil = null,
            System.Nullable<decimal> samples = null,
            System.Nullable<decimal> format = null,
            string label = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDepthStencilTexture" },
                    comparisonFunction,
                    bilinearFiltering,
                    generateStencil,
                    samples,
                    format,
                    label
                }
            );
        }

        public async ValueTask shareDepth(RenderTargetWrapper renderTarget)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "shareDepth" }, renderTarget }
            );
        }

        public async ValueTask releaseTextures()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseTextures" } }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> disposeOnlyFramebuffers = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, disposeOnlyFramebuffers }
            );
        }
        #endregion
    }
}
