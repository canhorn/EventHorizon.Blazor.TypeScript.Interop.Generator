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

    public interface ICustomAnimationFrameRequester : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICustomAnimationFrameRequesterCachedEntity>))]
    public class ICustomAnimationFrameRequesterCachedEntity : CachedEntityObject, ICustomAnimationFrameRequester
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
        
        public async ValueTask<decimal> get_requestID()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "requestID"
                );
        }
        public ValueTask set_requestID(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requestID",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ICustomAnimationFrameRequesterCachedEntity() : base() { }

        public ICustomAnimationFrameRequesterCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask renderFunction()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "renderFunction" }
                }
            );
        }

        public async ValueTask requestAnimationFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "requestAnimationFrame" }
                }
            );
        }
        #endregion
    }
}