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

    public interface ISize : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISizeCachedEntity>))]
    public class ISizeCachedEntity : CachedEntityObject, ISize
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
        public ISizeCachedEntity() : base() { }

        public ISizeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}