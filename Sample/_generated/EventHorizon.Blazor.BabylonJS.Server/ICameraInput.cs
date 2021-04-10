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

    public interface ICameraInput<TCamera> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICameraInputCachedEntity<CachedEntity>>))]
    public class ICameraInputCachedEntity<TCamera> : CachedEntityObject, ICameraInput<TCamera> where TCamera : CachedEntity, new()
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
        private TCamera __camera;
        public async ValueTask<TCamera> get_camera()
        {
            if(__camera == null)
            {
                __camera = await EventHorizonBlazorInterop.GetClass<TCamera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new TCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
        }
        public ValueTask set_camera(TCamera value)
        {
__camera = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ICameraInputCachedEntity() : base() { }

        public ICameraInputCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<string> getSimpleName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getSimpleName" }
                }
            );
        }

        public async ValueTask attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
                }
            );
        }

        public async ValueTask detachControl()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        #region checkInputs TODO: Get Comments as metadata identification
        private bool _isCheckInputsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _checkInputsActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> checkInputs(
            Func<Task> callback
        )
        {
            await SetupCheckInputsLoop();

            var handle = Guid.NewGuid().ToString();
            _checkInputsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCheckInputsLoop()
        {
            if (_isCheckInputsEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "checkInputs",
                "CallCheckInputsActions",
                _invokableReference
            );
            _isCheckInputsEnabled = true;
        }

        [JSInvokable]
        public async Task CallCheckInputsActions()
        {
            foreach (var action in _checkInputsActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}