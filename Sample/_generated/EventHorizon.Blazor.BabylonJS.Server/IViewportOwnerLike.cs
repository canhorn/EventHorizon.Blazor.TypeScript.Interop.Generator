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

    public interface IViewportOwnerLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IViewportOwnerLikeCachedEntity>))]
    public class IViewportOwnerLikeCachedEntity : CachedEntityObject, IViewportOwnerLike
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
        private IViewportLikeCachedEntity __viewport;
        public async ValueTask<IViewportLikeCachedEntity> get_viewport()
        {
            if(__viewport == null)
            {
                __viewport = await EventHorizonBlazorInterop.GetClass<IViewportLikeCachedEntity>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new IViewportLikeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewport;
        }
        public ValueTask set_viewport(IViewportLikeCachedEntity value)
        {
__viewport = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewport",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IViewportOwnerLikeCachedEntity() : base() { }

        public IViewportOwnerLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}