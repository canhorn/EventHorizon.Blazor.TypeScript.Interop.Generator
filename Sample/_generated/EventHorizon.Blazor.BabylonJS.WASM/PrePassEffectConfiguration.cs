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

    public interface PrePassEffectConfiguration : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<PrePassEffectConfigurationCachedEntity>))]
    public class PrePassEffectConfigurationCachedEntity : CachedEntityObject, PrePassEffectConfiguration
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private PostProcess __postProcess;
        public PostProcess postProcess
        {
            get
            {
            if(__postProcess == null)
            {
                __postProcess = EventHorizonBlazorInterop.GetClass<PostProcess>(
                    this.___guid,
                    "postProcess",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            return __postProcess;
            }
            set
            {
__postProcess = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcess",
                    value
                );
            }
        }

        
        public decimal[] texturesRequired
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "texturesRequired"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturesRequired",
                    value
                );
            }
        }

        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PrePassEffectConfigurationCachedEntity() : base() { }

        public PrePassEffectConfigurationCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region dispose TODO: Get Comments as metadata identification
        private bool _isDisposeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _disposeActionMap = new Dictionary<string, Func<Task>>();

        public string dispose(
            Func<Task> callback
        )
        {
            SetupDisposeLoop();

            var handle = Guid.NewGuid().ToString();
            _disposeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool dispose_Remove(
            string handle
        )
        {
            return _disposeActionMap.Remove(
                handle
            );
        }

        private void SetupDisposeLoop()
        {
            if (_isDisposeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "dispose",
                "CallDisposeActions",
                _invokableReference
            );
            _isDisposeEnabled = true;
        }

        [JSInvokable]
        public async Task CallDisposeActions()
        {
            foreach (var action in _disposeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region createPostProcess TODO: Get Comments as metadata identification
        private bool _isCreatePostProcessEnabled = false;
        private readonly IDictionary<string, Func<Task>> _createPostProcessActionMap = new Dictionary<string, Func<Task>>();

        public string createPostProcess(
            Func<Task> callback
        )
        {
            SetupCreatePostProcessLoop();

            var handle = Guid.NewGuid().ToString();
            _createPostProcessActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool createPostProcess_Remove(
            string handle
        )
        {
            return _createPostProcessActionMap.Remove(
                handle
            );
        }

        private void SetupCreatePostProcessLoop()
        {
            if (_isCreatePostProcessEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "createPostProcess",
                "CallCreatePostProcessActions",
                _invokableReference
            );
            _isCreatePostProcessEnabled = true;
        }

        [JSInvokable]
        public async Task CallCreatePostProcessActions()
        {
            foreach (var action in _createPostProcessActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}