/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISceneLoaderPlugin : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ISceneLoaderPluginCachedEntity : CachedEntityObject, ISceneLoaderPlugin
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

        #endregion
        
        #region Constructor
        public ISceneLoaderPluginCachedEntity() : base() { }

        public ISceneLoaderPluginCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region importMesh TODO: Get Comments as metadata identification
        private bool _isImportMeshEnabled = false;
        private readonly IDictionary<string, Func<Task>> _importMeshActionMap = new Dictionary<string, Func<Task>>();

        public string importMesh(
            Func<Task> callback
        )
        {
            SetupImportMeshLoop();

            var handle = Guid.NewGuid().ToString();
            _importMeshActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupImportMeshLoop()
        {
            if (_isImportMeshEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "importMesh",
                "CallImportMeshActions",
                _invokableReference
            );
            _isImportMeshEnabled = true;
        }

        [JSInvokable]
        public async Task CallImportMeshActions()
        {
            foreach (var action in _importMeshActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region load TODO: Get Comments as metadata identification
        private bool _isLoadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _loadActionMap = new Dictionary<string, Func<Task>>();

        public string load(
            Func<Task> callback
        )
        {
            SetupLoadLoop();

            var handle = Guid.NewGuid().ToString();
            _loadActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupLoadLoop()
        {
            if (_isLoadEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "load",
                "CallLoadActions",
                _invokableReference
            );
            _isLoadEnabled = true;
        }

        [JSInvokable]
        public async Task CallLoadActions()
        {
            foreach (var action in _loadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region loadAssetContainer TODO: Get Comments as metadata identification
        private bool _isLoadAssetContainerEnabled = false;
        private readonly IDictionary<string, Func<Task>> _loadAssetContainerActionMap = new Dictionary<string, Func<Task>>();

        public string loadAssetContainer(
            Func<Task> callback
        )
        {
            SetupLoadAssetContainerLoop();

            var handle = Guid.NewGuid().ToString();
            _loadAssetContainerActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupLoadAssetContainerLoop()
        {
            if (_isLoadAssetContainerEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "loadAssetContainer",
                "CallLoadAssetContainerActions",
                _invokableReference
            );
            _isLoadAssetContainerEnabled = true;
        }

        [JSInvokable]
        public async Task CallLoadAssetContainerActions()
        {
            foreach (var action in _loadAssetContainerActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}