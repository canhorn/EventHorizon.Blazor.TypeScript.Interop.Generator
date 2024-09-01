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

    public interface IAccessibilityTag : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IAccessibilityTagCachedEntity>))]
    public class IAccessibilityTagCachedEntity : CachedEntityObject, IAccessibilityTag
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

        public string description
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "description"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "description", value);
            }
        }

        public CachedEntity role
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "role",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "role", value);
            }
        }

        public CachedEntity aria
        {
            get { return EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "aria"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "aria", value);
            }
        }
        #endregion

        #region Constructor
        public IAccessibilityTagCachedEntity()
            : base() { }

        public IAccessibilityTagCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        #region eventHandler TODO: Get Comments as metadata identification
        private bool _isEventHandlerEnabled = false;
        private readonly IDictionary<string, Func<Task>> _eventHandlerActionMap =
            new Dictionary<string, Func<Task>>();

        public string eventHandler(Func<Task> callback)
        {
            SetupEventHandlerLoop();

            var handle = Guid.NewGuid().ToString();
            _eventHandlerActionMap.Add(handle, callback);

            return handle;
        }

        public bool eventHandler_Remove(string handle)
        {
            return _eventHandlerActionMap.Remove(handle);
        }

        private void SetupEventHandlerLoop()
        {
            if (_isEventHandlerEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "eventHandler",
                "CallEventHandlerActions",
                _invokableReference
            );
            _isEventHandlerEnabled = true;
        }

        [JSInvokable]
        public async Task CallEventHandlerActions()
        {
            foreach (var action in _eventHandlerActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}
