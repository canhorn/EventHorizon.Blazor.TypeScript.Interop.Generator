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

    public interface IPlaneLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IPlaneLikeCachedEntity>))]
    public class IPlaneLikeCachedEntity : CachedEntityObject, IPlaneLike
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
        private IVector3LikeCachedEntity __normal;
        public async ValueTask<IVector3LikeCachedEntity> get_normal()
        {
            if(__normal == null)
            {
                __normal = await EventHorizonBlazorInterop.GetClass<IVector3LikeCachedEntity>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new IVector3LikeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
        }
        public ValueTask set_normal(IVector3LikeCachedEntity value)
        {
__normal = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
        }

        
        public async ValueTask<decimal> get_d()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
        }
        public ValueTask set_d(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "d",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IPlaneLikeCachedEntity() : base() { }

        public IPlaneLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask normalize()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }
        #endregion
    }
}