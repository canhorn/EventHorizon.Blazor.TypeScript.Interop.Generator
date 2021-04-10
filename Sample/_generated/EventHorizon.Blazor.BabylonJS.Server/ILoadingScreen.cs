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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingUIBackgroundColor",
                    value
                );
        }

        
        public async ValueTask<string> get_loadingUIText()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loadingUIText"
                );
        }
        public ValueTask set_loadingUIText(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingUIText",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ILoadingScreenCachedEntity() : base() { }

        public ILoadingScreenCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region displayLoadingUI TODO: Get Comments as metadata identification
        private bool _isDisplayLoadingUIEnabled = false;
        private readonly IDictionary<string, Func<Task>> _displayLoadingUIActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> displayLoadingUI(
            Func<Task> callback
        )
        {
            await SetupDisplayLoadingUILoop();

            var handle = Guid.NewGuid().ToString();
            _displayLoadingUIActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupDisplayLoadingUILoop()
        {
            if (_isDisplayLoadingUIEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "displayLoadingUI",
                "CallDisplayLoadingUIActions",
                _invokableReference
            );
            _isDisplayLoadingUIEnabled = true;
        }

        [JSInvokable]
        public async Task CallDisplayLoadingUIActions()
        {
            foreach (var action in _displayLoadingUIActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region hideLoadingUI TODO: Get Comments as metadata identification
        private bool _isHideLoadingUIEnabled = false;
        private readonly IDictionary<string, Func<Task>> _hideLoadingUIActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> hideLoadingUI(
            Func<Task> callback
        )
        {
            await SetupHideLoadingUILoop();

            var handle = Guid.NewGuid().ToString();
            _hideLoadingUIActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupHideLoadingUILoop()
        {
            if (_isHideLoadingUIEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "hideLoadingUI",
                "CallHideLoadingUIActions",
                _invokableReference
            );
            _isHideLoadingUIEnabled = true;
        }

        [JSInvokable]
        public async Task CallHideLoadingUIActions()
        {
            foreach (var action in _hideLoadingUIActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}