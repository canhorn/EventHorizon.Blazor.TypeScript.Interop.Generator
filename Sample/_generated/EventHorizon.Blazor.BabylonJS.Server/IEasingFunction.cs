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

    public interface IEasingFunction : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEasingFunctionCachedEntity>))]
    public class IEasingFunctionCachedEntity : CachedEntityObject, IEasingFunction
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

        #endregion
        
        #region Constructor
        public IEasingFunctionCachedEntity() : base() { }

        public IEasingFunctionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<decimal> ease(decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "ease" }, gradient
                }
            );
        }
        #endregion
    }
}