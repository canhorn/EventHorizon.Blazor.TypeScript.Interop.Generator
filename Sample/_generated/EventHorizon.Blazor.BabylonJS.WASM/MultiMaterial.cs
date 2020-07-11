/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class MultiMaterial : Material
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static MultiMaterial ParseMultiMaterial(CachedEntity parsedMultiMaterial, Scene scene)
        {
            return EventHorizonBlazorInteropt.FuncClass<MultiMaterial>(
                entity => new MultiMaterial(entity),
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
            return EventHorizonBlazorInteropt.GetArrayClass<Material>(
                    this.___guid,
                    "subMaterials",
                    (entity) =>
                    {
                        return new Material(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "MultiMaterial" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Material[] getChildren()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Material>(
                entity => new Material(entity),
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public Material getSubMaterial(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSubMaterial" }, index
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture(entity),
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, BaseSubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public MultiMaterial clone(string name, System.Nullable<bool> cloneChildren = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<MultiMaterial>(
                entity => new MultiMaterial(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, cloneChildren
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> forceDisposeChildren = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, forceDisposeChildren
                }
            );
        }
        #endregion
    }
}