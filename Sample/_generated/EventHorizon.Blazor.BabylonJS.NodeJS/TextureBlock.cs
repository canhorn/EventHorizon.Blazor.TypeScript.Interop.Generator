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

    [JsonConverter(typeof(CachedEntityConverter<TextureBlock>))]
    public class TextureBlock : NodeMaterialBlock
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Texture __texture;
        public Texture texture
        {
            get
            {
                if (__texture == null)
                {
                    __texture = EventHorizonBlazorInterop.GetClass<Texture>(
                        this.___guid,
                        "texture",
                        (entity) =>
                        {
                            return new Texture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __texture;
            }
            set
            {
                __texture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "texture", value);
            }
        }

        public string samplerName
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "samplerName"); }
        }

        public bool hasImageSource
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasImageSource"); }
        }

        public bool convertToGammaSpace
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "convertToGammaSpace"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "convertToGammaSpace", value);
            }
        }

        public bool convertToLinearSpace
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "convertToLinearSpace");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "convertToLinearSpace", value);
            }
        }

        private NodeMaterialConnectionPoint __uv;
        public NodeMaterialConnectionPoint uv
        {
            get
            {
                if (__uv == null)
                {
                    __uv = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "uv",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __uv;
            }
        }

        private NodeMaterialConnectionPoint __source;
        public NodeMaterialConnectionPoint source
        {
            get
            {
                if (__source == null)
                {
                    __source = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "source",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __source;
            }
        }

        private NodeMaterialConnectionPoint __layer;
        public NodeMaterialConnectionPoint layer
        {
            get
            {
                if (__layer == null)
                {
                    __layer = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "layer",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __layer;
            }
        }

        private NodeMaterialConnectionPoint __lod;
        public NodeMaterialConnectionPoint lod
        {
            get
            {
                if (__lod == null)
                {
                    __lod = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "lod",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __lod;
            }
        }

        private NodeMaterialConnectionPoint __rgba;
        public NodeMaterialConnectionPoint rgba
        {
            get
            {
                if (__rgba == null)
                {
                    __rgba = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "rgba",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rgba;
            }
        }

        private NodeMaterialConnectionPoint __rgb;
        public NodeMaterialConnectionPoint rgb
        {
            get
            {
                if (__rgb == null)
                {
                    __rgb = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "rgb",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rgb;
            }
        }

        private NodeMaterialConnectionPoint __r;
        public NodeMaterialConnectionPoint r
        {
            get
            {
                if (__r == null)
                {
                    __r = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "r",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __r;
            }
        }

        private NodeMaterialConnectionPoint __g;
        public NodeMaterialConnectionPoint g
        {
            get
            {
                if (__g == null)
                {
                    __g = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "g",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __g;
            }
        }

        private NodeMaterialConnectionPoint __b;
        public NodeMaterialConnectionPoint b
        {
            get
            {
                if (__b == null)
                {
                    __b = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "b",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __b;
            }
        }

        private NodeMaterialConnectionPoint __a;
        public NodeMaterialConnectionPoint a
        {
            get
            {
                if (__a == null)
                {
                    __a = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "a",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __a;
            }
        }

        private NodeMaterialConnectionPoint __level;
        public NodeMaterialConnectionPoint level
        {
            get
            {
                if (__level == null)
                {
                    __level = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                        this.___guid,
                        "level",
                        (entity) =>
                        {
                            return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __level;
            }
        }

        public int target
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "target"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "target", value);
            }
        }
        #endregion

        #region Properties

        public bool disableLevelMultiplication
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableLevelMultiplication"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableLevelMultiplication", value);
            }
        }
        #endregion

        #region Constructor
        public TextureBlock()
            : base() { }

        public TextureBlock(ICachedEntity entity)
            : base(entity) { }

        public TextureBlock(string name, System.Nullable<bool> fragmentOnly = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TextureBlock" },
                name,
                fragmentOnly
            );
            ___guid = entity.___guid;
        }

        public TextureBlock(
            string name,
            System.Nullable<int> target = null,
            System.Nullable<bool> isFinalMerger = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TextureBlock" },
                name,
                target,
                isFinalMerger
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

        public void autoConfigure(
            NodeMaterial material,
            ActionResultCallback<NodeMaterialBlock, bool> additionalFilteringInfo = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "autoConfigure" },
                    material,
                    additionalFilteringInfo
                }
            );
        }

        public void initializeDefines(
            AbstractMesh mesh,
            NodeMaterial nodeMaterial,
            NodeMaterialDefines defines
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeDefines" },
                    mesh,
                    nodeMaterial,
                    defines
                }
            );
        }

        public void prepareDefines(
            AbstractMesh mesh,
            NodeMaterial nodeMaterial,
            NodeMaterialDefines defines
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" },
                    mesh,
                    nodeMaterial,
                    defines
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" } }
            );
        }

        public void bind(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bind" }, effect }
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
