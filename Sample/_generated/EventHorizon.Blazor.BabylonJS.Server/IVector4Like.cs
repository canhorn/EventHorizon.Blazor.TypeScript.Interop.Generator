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

    public interface IVector4Like : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IVector4LikeCachedEntity>))]
    public class IVector4LikeCachedEntity : CachedEntityObject, IVector4Like
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
        
        public async ValueTask<decimal> get_x()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
        }
        public ValueTask set_x(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
        }

        
        public async ValueTask<decimal> get_y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
        }
        public ValueTask set_y(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
        }

        
        public async ValueTask<decimal> get_z()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "z"
                );
        }
        public ValueTask set_z(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "z",
                    value
                );
        }

        
        public async ValueTask<decimal> get_w()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "w"
                );
        }
        public ValueTask set_w(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "w",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IVector4LikeCachedEntity() : base() { }

        public IVector4LikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}