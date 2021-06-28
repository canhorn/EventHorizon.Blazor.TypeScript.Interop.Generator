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
        
        public bool enableSceneOffline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableSceneOffline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableSceneOffline",
                    value
                );
            }
        }

        
        public bool enableTexturesOffline
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableTexturesOffline"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableTexturesOffline",
                    value
                );
            }
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
        public void open(ActionCallback successCallback, ActionCallback errorCallback)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "open" }, successCallback, errorCallback
                }
            );
        }

        public void loadImage(string url, HTMLImageElement image)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadImage" }, url, image
                }
            );
        }

        public void loadFile(string url, ActionCallback<object> sceneLoaded, ActionCallback<object> progressCallBack = null, ActionCallback errorCallback = null, System.Nullable<bool> useArrayBuffer = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadFile" }, url, sceneLoaded, progressCallBack, errorCallback, useArrayBuffer
                }
            );
        }
        #endregion
    }
}