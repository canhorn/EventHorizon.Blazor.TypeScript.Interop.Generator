/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        public async ValueTask<NodeMaterialConnectionPoint> get_uv()
        {
            if(__uv == null)
            {
                __uv = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __rgba;
        public async ValueTask<NodeMaterialConnectionPoint> get_rgba()
        {
            if(__rgba == null)
            {
                __rgba = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __rgb;
        public async ValueTask<NodeMaterialConnectionPoint> get_rgb()
        {
            if(__rgb == null)
            {
                __rgb = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __r;
        public async ValueTask<NodeMaterialConnectionPoint> get_r()
        {
            if(__r == null)
            {
                __r = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __g;
        public async ValueTask<NodeMaterialConnectionPoint> get_g()
        {
            if(__g == null)
            {
                __g = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __b;
        public async ValueTask<NodeMaterialConnectionPoint> get_b()
        {
            if(__b == null)
            {
                __b = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialConnectionPoint __a;
        public async ValueTask<NodeMaterialConnectionPoint> get_a()
        {
            if(__a == null)
            {
                __a = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        
        public async ValueTask<int> get_target()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
        }
        #endregion

        #region Properties
        private Texture __texture;
        public async ValueTask<Texture> get_texture()
        {
            if(__texture == null)
            {
                __texture = await EventHorizonBlazorInterop.GetClass<Texture>(
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
        public ValueTask set_texture(Texture value)
        {
__texture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
        }

        
        public async ValueTask<bool> get_convertToGammaSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToGammaSpace"
                );
        }
        public ValueTask set_convertToGammaSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToGammaSpace",
                    value
                );
        }

        
        public async ValueTask<bool> get_convertToLinearSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToLinearSpace"
                );
        }
        public ValueTask set_convertToLinearSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToLinearSpace",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public TextureBlock() : base() { }

        public TextureBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<TextureBlock> NewTextureBlock(
            string name, System.Nullable<bool> fragmentOnly = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TextureBlock" },
                name, fragmentOnly
            );

            return new TextureBlock(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask autoConfigure(NodeMaterial material)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "autoConfigure" }, material
                }
            );
        }

        public async ValueTask initializeDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "initializeDefines" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public async ValueTask prepareDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, mesh, nodeMaterial, defines
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask bind(Effect effect, NodeMaterial nodeMaterial, Mesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, effect, nodeMaterial, mesh
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}