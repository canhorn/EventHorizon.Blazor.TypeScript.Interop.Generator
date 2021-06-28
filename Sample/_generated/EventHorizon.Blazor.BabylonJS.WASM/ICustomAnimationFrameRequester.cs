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
        
        public decimal requestID
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "requestID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requestID",
                    value
                );
            }
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
        public void renderFunction()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "renderFunction" }
                }
            );
        }

        public void requestAnimationFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "requestAnimationFrame" }
                }
            );
        }
        #endregion
    }
}