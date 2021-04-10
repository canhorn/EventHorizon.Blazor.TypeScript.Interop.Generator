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

    public interface IOfflineProvider : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IOfflineProviderCachedEntity>))]
    public class IOfflineProviderCachedEntity : CachedEntityObject, IOfflineProvider
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
        
        public async ValueTask<bool> get_enableSceneOffline()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableSceneOffline"
                );
        }
        public ValueTask set_enableSceneOffline(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableSceneOffline",
                    value
                );
        }

        
        public async ValueTask<bool> get_enableTexturesOffline()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableTexturesOffline"
                );
        }
        public ValueTask set_enableTexturesOffline(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableTexturesOffline",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IOfflineProviderCachedEntity() : base() { }

        public IOfflineProviderCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask open(ActionCallback successCallback, ActionCallback errorCallback)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "open" }, successCallback, errorCallback
                }
            );
        }

        public async ValueTask loadImage(string url, HTMLImageElement image)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "loadImage" }, url, image
                }
            );
        }

        public async ValueTask loadFile(string url, ActionCallback<object> sceneLoaded, ActionCallback<object> progressCallBack = null, ActionCallback errorCallback = null, System.Nullable<bool> useArrayBuffer = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "loadFile" }, url, sceneLoaded, progressCallBack, errorCallback, useArrayBuffer
                }
            );
        }
        #endregion
    }
}