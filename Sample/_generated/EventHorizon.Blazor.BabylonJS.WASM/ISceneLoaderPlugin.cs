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

    public interface ISceneLoaderPlugin : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISceneLoaderPluginCachedEntity>))]
    public class ISceneLoaderPluginCachedEntity : CachedEntityObject, ISceneLoaderPlugin
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public ISceneLoaderPluginCachedEntity() : base() { }

        public ISceneLoaderPluginCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public bool importMesh(object meshesNames, Scene scene, object data, string rootUrl, AbstractMesh[] meshes, IParticleSystem[] particleSystems, Skeleton[] skeletons, ActionCallback<string, object> onError = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "importMesh" }, meshesNames, scene, data, rootUrl, meshes, particleSystems, skeletons, onError
                }
            );
        }

        public bool load(Scene scene, object data, string rootUrl, ActionCallback<string, object> onError = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, scene, data, rootUrl, onError
                }
            );
        }

        public AssetContainer loadAssetContainer(Scene scene, object data, string rootUrl, ActionCallback<string, object> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AssetContainer>(
                entity => new AssetContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "loadAssetContainer" }, scene, data, rootUrl, onError
                }
            );
        }
        #endregion
    }
}