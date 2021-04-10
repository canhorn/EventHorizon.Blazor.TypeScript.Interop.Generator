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
        public async ValueTask<IOfflineProviderCachedEntity> get_offlineProvider()
        {
            if(__offlineProvider == null)
            {
                __offlineProvider = await EventHorizonBlazorInterop.GetClass<IOfflineProviderCachedEntity>(
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
        public ValueTask set_offlineProvider(IOfflineProviderCachedEntity value)
        {
__offlineProvider = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offlineProvider",
                    value
                );
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