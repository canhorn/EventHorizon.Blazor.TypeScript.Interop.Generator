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

    public interface IImage : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IImageCachedEntity>))]
    public class IImageCachedEntity : CachedEntityObject, IImage
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

        public async ValueTask<string> get_src()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "src");
        }

        public ValueTask set_src(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "src", value);
        }

        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width");
        }

        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height");
        }

        public async ValueTask<decimal> get_naturalHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "naturalHeight");
        }

        public async ValueTask<decimal> get_naturalWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "naturalWidth");
        }

        public async ValueTask<string> get_crossOrigin()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "crossOrigin");
        }

        public ValueTask set_crossOrigin(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "crossOrigin", value);
        }

        public async ValueTask<string> get_referrerPolicy()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "referrerPolicy");
        }

        public ValueTask set_referrerPolicy(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "referrerPolicy", value);
        }
        #endregion

        #region Constructor
        public IImageCachedEntity()
            : base() { }

        public IImageCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        #region onload TODO: Get Comments as metadata identification
        private bool _isOnloadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onloadActionMap =
            new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onload(Func<Task> callback)
        {
            await SetupOnloadLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadActionMap.Add(handle, callback);

            return handle;
        }

        private async ValueTask SetupOnloadLoop()
        {
            if (_isOnloadEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onload",
                "CallOnloadActions",
                _invokableReference
            );
            _isOnloadEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnloadActions()
        {
            foreach (var action in _onloadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onerror TODO: Get Comments as metadata identification
        private bool _isOnerrorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onerrorActionMap =
            new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onerror(Func<Task> callback)
        {
            await SetupOnerrorLoop();

            var handle = Guid.NewGuid().ToString();
            _onerrorActionMap.Add(handle, callback);

            return handle;
        }

        private async ValueTask SetupOnerrorLoop()
        {
            if (_isOnerrorEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onerror",
                "CallOnerrorActions",
                _invokableReference
            );
            _isOnerrorEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnerrorActions()
        {
            foreach (var action in _onerrorActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}
