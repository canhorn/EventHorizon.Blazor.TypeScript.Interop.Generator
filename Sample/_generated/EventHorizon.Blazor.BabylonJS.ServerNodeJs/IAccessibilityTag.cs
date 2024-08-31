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

        public async ValueTask<string> get_description()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "description");
        }

        public ValueTask set_description(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "description", value);
        }

        public async ValueTask<CachedEntity> get_role()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "role",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_role(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "role", value);
        }

        public async ValueTask<CachedEntity> get_aria()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "aria");
        }

        public ValueTask set_aria(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "aria", value);
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

        public async ValueTask<string> eventHandler(Func<Task> callback)
        {
            await SetupEventHandlerLoop();

            var handle = Guid.NewGuid().ToString();
            _eventHandlerActionMap.Add(handle, callback);

            return handle;
        }

        private async ValueTask SetupEventHandlerLoop()
        {
            if (_isEventHandlerEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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
