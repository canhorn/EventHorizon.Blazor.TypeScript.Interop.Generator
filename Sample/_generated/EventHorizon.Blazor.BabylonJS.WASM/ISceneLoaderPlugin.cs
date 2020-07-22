/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISceneLoaderPlugin : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
// importMesh is not supported by the platform yet

// load is not supported by the platform yet

// loadAssetContainer is not supported by the platform yet
        #endregion
    }
}