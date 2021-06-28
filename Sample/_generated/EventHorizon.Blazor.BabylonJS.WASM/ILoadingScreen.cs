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
        
        public string loadingUIBackgroundColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loadingUIBackgroundColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingUIBackgroundColor",
                    value
                );
            }
        }

        
        public string loadingUIText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loadingUIText"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingUIText",
                    value
                );
            }
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

        public string displayLoadingUI(
            Func<Task> callback
        )
        {
            SetupDisplayLoadingUILoop();

            var handle = Guid.NewGuid().ToString();
            _displayLoadingUIActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool displayLoadingUI_Remove(
            string handle
        )
        {
            return _displayLoadingUIActionMap.Remove(
                handle
            );
        }

        private void SetupDisplayLoadingUILoop()
        {
            if (_isDisplayLoadingUIEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string hideLoadingUI(
            Func<Task> callback
        )
        {
            SetupHideLoadingUILoop();

            var handle = Guid.NewGuid().ToString();
            _hideLoadingUIActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool hideLoadingUI_Remove(
            string handle
        )
        {
            return _hideLoadingUIActionMap.Remove(
                handle
            );
        }

        private void SetupHideLoadingUILoop()
        {
            if (_isHideLoadingUIEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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