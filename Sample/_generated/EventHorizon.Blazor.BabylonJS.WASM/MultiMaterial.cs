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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiMaterial>))]
    public class MultiMaterial : Material
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static MultiMaterial ParseMultiMaterial(object parsedMultiMaterial, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<MultiMaterial>(
                entity => new MultiMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MultiMaterial", "ParseMultiMaterial" }, parsedMultiMaterial, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public Material[] subMaterials
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Material>(
                    this.___guid,
                    "subMaterials",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMaterials",
                    value
                );
            }
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

        public MultiMaterial(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiMaterial" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Material[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public Material getSubMaterial(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSubMaterial" }, index
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public MultiMaterial clone(string name, System.Nullable<bool> cloneChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<MultiMaterial>(
                entity => new MultiMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, cloneChildren
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

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> forceDisposeChildren = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, forceDisposeChildren
                }
            );
        }
        #endregion
    }
}