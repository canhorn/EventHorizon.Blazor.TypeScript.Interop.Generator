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

    public interface ISceneLoaderProgressEvent : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISceneLoaderProgressEventCachedEntity>))]
    public class ISceneLoaderProgressEventCachedEntity : CachedEntityObject, ISceneLoaderProgressEvent
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
        
        public async ValueTask<bool> get_lengthComputable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lengthComputable"
                );
        }

        
        public async ValueTask<decimal> get_loaded()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loaded"
                );
        }

        
        public async ValueTask<decimal> get_total()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
        }
        #endregion
        
        #region Constructor
        public ISceneLoaderProgressEventCachedEntity() : base() { }

        public ISceneLoaderProgressEventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}