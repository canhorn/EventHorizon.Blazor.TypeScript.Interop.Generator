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

    public interface ILoadingScreen : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ILoadingScreenCachedEntity>))]
    public class ILoadingScreenCachedEntity : CachedEntityObject, ILoadingScreen
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

        public async ValueTask<string> get_loadingUIBackgroundColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "loadingUIBackgroundColor"
            );
        }

        public ValueTask set_loadingUIBackgroundColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "loadingUIBackgroundColor", value);
        }

        public async ValueTask<string> get_loadingUIText()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "loadingUIText");
        }

        public ValueTask set_loadingUIText(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "loadingUIText", value);
        }
        #endregion

        #region Constructor
        public ILoadingScreenCachedEntity()
            : base() { }

        public ILoadingScreenCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask displayLoadingUI()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "displayLoadingUI" } }
            );
        }

        public async ValueTask hideLoadingUI()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "hideLoadingUI" } }
            );
        }
        #endregion
    }
}
