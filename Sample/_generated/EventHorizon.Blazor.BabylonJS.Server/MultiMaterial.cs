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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiMaterial>))]
    public class MultiMaterial : Material
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<MultiMaterial> ParseMultiMaterial(object parsedMultiMaterial, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<MultiMaterial>(
                entity => new MultiMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MultiMaterial", "ParseMultiMaterial" }, parsedMultiMaterial, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<Material[]> get_subMaterials()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Material>(
                    this.___guid,
                    "subMaterials",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_subMaterials(Material[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMaterials",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public MultiMaterial() : base() { }

        public MultiMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<MultiMaterial> NewMultiMaterial(
            string name, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiMaterial" },
                name, scene
            );

            return new MultiMaterial(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Material[]> getChildren()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public async ValueTask<Material> getSubMaterial(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSubMaterial" }, index
                }
            );
        }

        public async ValueTask<BaseTexture[]> getActiveTextures()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public async ValueTask<MultiMaterial> clone(string name, System.Nullable<bool> cloneChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<MultiMaterial>(
                entity => new MultiMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, cloneChildren
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

        public async ValueTask dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> forceDisposeChildren = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, forceDisposeChildren
                }
            );
        }
        #endregion
    }
}