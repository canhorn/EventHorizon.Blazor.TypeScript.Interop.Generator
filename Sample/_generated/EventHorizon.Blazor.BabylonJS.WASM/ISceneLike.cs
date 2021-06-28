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

    public interface ISceneLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISceneLikeCachedEntity>))]
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
        private IOfflineProviderCachedEntity __offlineProvider;
        public IOfflineProviderCachedEntity offlineProvider
        {
            get
            {
            if(__offlineProvider == null)
            {
                __offlineProvider = EventHorizonBlazorInterop.GetClass<IOfflineProviderCachedEntity>(
                    this.___guid,
                    "offlineProvider",
                    (entity) =>
                    {
                        return new IOfflineProviderCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __offlineProvider;
            }
            set
            {
__offlineProvider = null;
                EventHorizonBlazorInterop.Set(
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