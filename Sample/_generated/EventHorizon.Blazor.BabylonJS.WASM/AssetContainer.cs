/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class AssetContainer : AbstractScene
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
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInteropt.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AssetContainer() : base() { }

        public AssetContainer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AssetContainer(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "AssetContainer" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region instantiateModelsToScene TODO: Get Comments as metadata identification
        private bool _isInstantiateModelsToSceneEnabled = false;
        private readonly IDictionary<string, Func<string, Task>> _instantiateModelsToSceneActionMap = new Dictionary<string, Func<string, Task>>();

        public string instantiateModelsToScene(
            Func<string, Task> callback
        )
        {
            SetupInstantiateModelsToSceneLoop();

            var handle = Guid.NewGuid().ToString();
            _instantiateModelsToSceneActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupInstantiateModelsToSceneLoop()
        {
            if (_isInstantiateModelsToSceneEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "instantiateModelsToScene",
                "CallInstantiateModelsToSceneActions",
                _invokableReference
            );
            _isInstantiateModelsToSceneEnabled = true;
        }

        [JSInvokable]
        public async Task CallInstantiateModelsToSceneActions(string sourceName)
        {
            foreach (var action in _instantiateModelsToSceneActionMap.Values)
            {
                await action(sourceName);
            }
        }
        #endregion

        public void addAllToScene()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAllToScene" }
                }
            );
        }

        public void removeAllFromScene()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAllFromScene" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void moveAllFromScene(KeepAssets keepAssets = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "moveAllFromScene" }, keepAssets
                }
            );
        }

        public Mesh createRootMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createRootMesh" }
                }
            );
        }

        public void mergeAnimationsTo(Animatable[] animatables, Scene scene = null, CachedEntity targetConverter = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "mergeAnimationsTo" }, scene, animatables, targetConverter
                }
            );
        }
        #endregion
    }
}