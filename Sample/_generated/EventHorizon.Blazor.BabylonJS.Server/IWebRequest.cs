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

    public interface IWebRequest : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IWebRequestCachedEntity>))]
    public class IWebRequestCachedEntity : CachedEntityObject, IWebRequest
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
        
        public async ValueTask<string> get_responseURL()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseURL"
                );
        }
        public ValueTask set_responseURL(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "responseURL",
                    value
                );
        }

        
        public async ValueTask<decimal> get_status()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "status"
                );
        }
        public ValueTask set_status(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "status",
                    value
                );
        }

        
        public async ValueTask<string> get_statusText()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "statusText"
                );
        }
        public ValueTask set_statusText(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "statusText",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IWebRequestCachedEntity() : base() { }

        public IWebRequestCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}