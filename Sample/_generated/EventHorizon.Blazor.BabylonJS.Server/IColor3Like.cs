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

    public interface IColor3Like : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IColor3LikeCachedEntity>))]
    public class IColor3LikeCachedEntity : CachedEntityObject, IColor3Like
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
        
        public async ValueTask<decimal> get_r()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "r"
                );
        }
        public ValueTask set_r(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "r",
                    value
                );
        }

        
        public async ValueTask<decimal> get_g()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "g"
                );
        }
        public ValueTask set_g(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "g",
                    value
                );
        }

        
        public async ValueTask<decimal> get_b()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "b"
                );
        }
        public ValueTask set_b(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "b",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IColor3LikeCachedEntity() : base() { }

        public IColor3LikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}