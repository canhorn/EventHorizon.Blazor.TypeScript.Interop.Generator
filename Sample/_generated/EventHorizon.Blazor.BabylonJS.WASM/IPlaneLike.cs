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
        public IVector3LikeCachedEntity normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInterop.GetClass<IVector3LikeCachedEntity>(
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
            set
            {
__normal = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
            }
        }

        
        public decimal d
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "d",
                    value
                );
            }
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
        public void normalize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }
        #endregion
    }
}