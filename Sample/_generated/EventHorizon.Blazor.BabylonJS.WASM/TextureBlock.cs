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
        private NodeMaterialConnectionPoint __uv;
        public NodeMaterialConnectionPoint uv
        {
            get
            {
            if(__uv == null)
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

        private NodeMaterialConnectionPoint __rgba;
        public NodeMaterialConnectionPoint rgba
        {
            get
            {
            if(__rgba == null)
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
            if(__rgb == null)
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
            if(__r == null)
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
            if(__g == null)
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
            if(__b == null)
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
            if(__a == null)
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

        
        public int target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
            }
        }
        #endregion

        #region Properties
        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public bool convertToGammaSpace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToGammaSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToGammaSpace",
                    value
                );
            }
        }

        
        public bool convertToLinearSpace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToLinearSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToLinearSpace",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextureBlock() : base() { }

        public TextureBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextureBlock(
            string name, System.Nullable<bool> fragmentOnly = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TextureBlock" },
                name, fragmentOnly
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void autoConfigure(NodeMaterial material)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "autoConfigure" }, material
                }
            );
        }

        public void initializeDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeDefines" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public void prepareDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, mesh, nodeMaterial, defines
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void bind(Effect effect, NodeMaterial nodeMaterial, Mesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, effect, nodeMaterial, mesh
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}