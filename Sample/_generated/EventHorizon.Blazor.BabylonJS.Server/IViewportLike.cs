/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IViewportLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IViewportLikeCachedEntity>))]
    public class IViewportLikeCachedEntity : CachedEntityObject, IViewportLike
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

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IViewportLikeCachedEntity() : base() { }

        public IViewportLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}