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

        public string src
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "src"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "src", value);
            }
        }

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
        }

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
        }

        public decimal naturalHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "naturalHeight"); }
        }

        public decimal naturalWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "naturalWidth"); }
        }

        public string crossOrigin
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "crossOrigin"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "crossOrigin", value);
            }
        }

        public string referrerPolicy
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "referrerPolicy"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "referrerPolicy", value);
            }
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

        public string onload(Func<Task> callback)
        {
            SetupOnloadLoop();

            var handle = Guid.NewGuid().ToString();
            _onloadActionMap.Add(handle, callback);

            return handle;
        }

        public bool onload_Remove(string handle)
        {
            return _onloadActionMap.Remove(handle);
        }

        private void SetupOnloadLoop()
        {
            if (_isOnloadEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string onerror(Func<Task> callback)
        {
            SetupOnerrorLoop();

            var handle = Guid.NewGuid().ToString();
            _onerrorActionMap.Add(handle, callback);

            return handle;
        }

        public bool onerror_Remove(string handle)
        {
            return _onerrorActionMap.Remove(handle);
        }

        private void SetupOnerrorLoop()
        {
            if (_isOnerrorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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
