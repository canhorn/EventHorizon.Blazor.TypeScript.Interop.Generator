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
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        private PostProcess __postProcess;
        public async ValueTask<PostProcess> get_postProcess()
        {
            if(__postProcess == null)
            {
                __postProcess = await EventHorizonBlazorInterop.GetClass<PostProcess>(
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
        public ValueTask set_postProcess(PostProcess value)
        {
__postProcess = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcess",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_texturesRequired()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "texturesRequired"
                );
        }
        public ValueTask set_texturesRequired(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturesRequired",
                    value
                );
        }

        
        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
        }
        public ValueTask set_enabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enabled",
                    value
                );
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

        public async ValueTask<string> dispose(
            Func<Task> callback
        )
        {
            await SetupDisposeLoop();

            var handle = Guid.NewGuid().ToString();
            _disposeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupDisposeLoop()
        {
            if (_isDisposeEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> createPostProcess(
            Func<Task> callback
        )
        {
            await SetupCreatePostProcessLoop();

            var handle = Guid.NewGuid().ToString();
            _createPostProcessActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCreatePostProcessLoop()
        {
            if (_isCreatePostProcessEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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