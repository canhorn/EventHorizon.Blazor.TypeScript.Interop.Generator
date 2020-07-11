/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ICustomAnimationFrameRequester { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "requestID"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "renderFunction" }
                }
            );
        }

        public void requestAnimationFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "requestAnimationFrame" }
                }
            );
        }
        #endregion
    }
}