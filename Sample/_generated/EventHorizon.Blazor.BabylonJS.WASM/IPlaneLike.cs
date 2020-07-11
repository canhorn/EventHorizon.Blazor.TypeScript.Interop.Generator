/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IPlaneLike { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
        private IVector3Like __normal;
        public IVector3Like normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInteropt.GetClass<IVector3Like>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new IVector3LikeCachedEntity(entity);
                    }
                );
            }
            return __normal;
            }
            set
            {
__normal = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }
        #endregion
    }
}