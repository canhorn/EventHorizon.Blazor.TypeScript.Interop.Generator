/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISceneLike { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ISceneLikeCachedEntity : CachedEntityObject, ISceneLike
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
        private IOfflineProvider __offlineProvider;
        public IOfflineProvider offlineProvider
        {
            get
            {
            if(__offlineProvider == null)
            {
                __offlineProvider = EventHorizonBlazorInteropt.GetClass<IOfflineProvider>(
                    this.___guid,
                    "offlineProvider",
                    (entity) =>
                    {
                        return new IOfflineProviderCachedEntity(entity);
                    }
                );
            }
            return __offlineProvider;
            }
            set
            {
__offlineProvider = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "offlineProvider",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ISceneLikeCachedEntity() : base() { }

        public ISceneLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}