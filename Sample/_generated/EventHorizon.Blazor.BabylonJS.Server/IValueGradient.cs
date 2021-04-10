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

    public interface IValueGradient : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IValueGradientCachedEntity>))]
    public class IValueGradientCachedEntity : CachedEntityObject, IValueGradient
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
        
        public async ValueTask<decimal> get_gradient()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
        }
        public ValueTask set_gradient(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradient",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IValueGradientCachedEntity() : base() { }

        public IValueGradientCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}