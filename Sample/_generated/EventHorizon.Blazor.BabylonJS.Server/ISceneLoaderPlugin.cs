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
        public async ValueTask<bool> importMesh(object meshesNames, Scene scene, object data, string rootUrl, AbstractMesh[] meshes, IParticleSystem[] particleSystems, Skeleton[] skeletons, ActionCallback<string, object> onError = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "importMesh" }, meshesNames, scene, data, rootUrl, meshes, particleSystems, skeletons, onError
                }
            );
        }

        public async ValueTask<bool> load(Scene scene, object data, string rootUrl, ActionCallback<string, object> onError = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "load" }, scene, data, rootUrl, onError
                }
            );
        }

        public async ValueTask<AssetContainer> loadAssetContainer(Scene scene, object data, string rootUrl, ActionCallback<string, object> onError = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AssetContainer>(
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