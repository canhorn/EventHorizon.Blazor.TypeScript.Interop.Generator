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
        public InternalTexture depthStencilTexture
        {
            get
            {
                if (__depthStencilTexture == null)
                {
                    __depthStencilTexture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
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
        }

        public bool depthStencilTextureWithStencil
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthStencilTextureWithStencil"
                );
            }
        }

        public bool isCube
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCube"); }
        }

        public bool isMulti
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMulti"); }
        }

        public bool is2DArray
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "is2DArray"); }
        }

        public bool is3D
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "is3D"); }
        }

        public decimal size
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "size"); }
        }

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
        }

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
        }

        public decimal layers
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "layers"); }
        }

        public decimal depth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "depth"); }
        }

        private InternalTexture __texture;
        public InternalTexture texture
        {
            get
            {
                if (__texture == null)
                {
                    __texture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
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
        }

        public InternalTexture[] textures
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<InternalTexture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
                    }
                );
            }
        }

        public decimal[] faceIndices
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "faceIndices"); }
        }

        public decimal[] layerIndices
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "layerIndices");
            }
        }

        public decimal samples
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
        }
        #endregion

        #region Properties

        public string label
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "label"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "label", value);
            }
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

        public RenderTargetWrapper(
            bool isMulti,
            bool isCube,
            decimal size,
            AbstractEngine engine,
            string label = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderTargetWrapper" },
                isMulti,
                isCube,
                size,
                engine,
                label
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal setSamples(
            decimal value,
            System.Nullable<bool> initializeBuffers = null,
            System.Nullable<bool> force = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setSamples" },
                    value,
                    initializeBuffers,
                    force
                }
            );
        }

        public void setTextures(InternalTexture textures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTextures" }, textures }
            );
        }

        public void setTexture(
            InternalTexture texture,
            System.Nullable<decimal> index = null,
            System.Nullable<bool> disposePrevious = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" },
                    texture,
                    index,
                    disposePrevious
                }
            );
        }

        public void setLayerAndFaceIndices(decimal[] layers, decimal[] faces)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndices" },
                    layers,
                    faces
                }
            );
        }

        public void setLayerAndFaceIndex(
            System.Nullable<decimal> index = null,
            System.Nullable<decimal> layer = null,
            System.Nullable<decimal> face = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLayerAndFaceIndex" },
                    index,
                    layer,
                    face
                }
            );
        }

        public InternalTexture createDepthStencilTexture(
            System.Nullable<decimal> comparisonFunction = null,
            System.Nullable<bool> bilinearFiltering = null,
            System.Nullable<bool> generateStencil = null,
            System.Nullable<decimal> samples = null,
            System.Nullable<decimal> format = null,
            string label = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
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

        public void shareDepth(RenderTargetWrapper renderTarget)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "shareDepth" }, renderTarget }
            );
        }

        public void releaseTextures()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "releaseTextures" } }
            );
        }

        public void dispose(System.Nullable<bool> disposeOnlyFramebuffers = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, disposeOnlyFramebuffers }
            );
        }
        #endregion
    }
}
