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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneLoader>))]
    public class SceneLoader : CachedEntityObject
    {
        #region Static Accessors
        
        public static bool ForceFullSceneLoadingForIncremental
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ForceFullSceneLoadingForIncremental"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.ForceFullSceneLoadingForIncremental",
                    value
                );
            }
        }

        
        public static bool ShowLoadingScreen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ShowLoadingScreen"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.ShowLoadingScreen",
                    value
                );
            }
        }

        
        public static decimal loggingLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.loggingLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.loggingLevel",
                    value
                );
            }
        }

        
        public static bool CleanBoneMatrixWeights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.CleanBoneMatrixWeights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.CleanBoneMatrixWeights",
                    value
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal NO_LOGGING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.NO_LOGGING"
                );
            }
        }

        
        public static decimal MINIMAL_LOGGING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.MINIMAL_LOGGING"
                );
            }
        }

        
        public static decimal SUMMARY_LOGGING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.SUMMARY_LOGGING"
                );
            }
        }

        
        public static decimal DETAILED_LOGGING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.DETAILED_LOGGING"
                );
            }
        }

        private static Observable<ISceneLoaderPluginCachedEntity> __OnPluginActivatedObservable;
        public static Observable<ISceneLoaderPluginCachedEntity> OnPluginActivatedObservable
        {
            get
            {
            if(__OnPluginActivatedObservable == null)
            {
                __OnPluginActivatedObservable = EventHorizonBlazorInterop.GetClass<Observable<ISceneLoaderPluginCachedEntity>>(
                    "BABYLON",
                    "SceneLoader.OnPluginActivatedObservable",
                    (entity) =>
                    {
                        return new Observable<ISceneLoaderPluginCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __OnPluginActivatedObservable;
            }
            set
            {
__OnPluginActivatedObservable = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.OnPluginActivatedObservable",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static IRegisteredPluginCachedEntity GetDefaultPlugin()
        {
            return EventHorizonBlazorInterop.FuncClass<IRegisteredPluginCachedEntity>(
                entity => new IRegisteredPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "GetDefaultPlugin" }
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity GetPluginForExtension(string extension)
        {
            return EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "GetPluginForExtension" }, extension
                }
            );
        }

        public static bool IsPluginForExtensionAvailable(string extension)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "IsPluginForExtensionAvailable" }, extension
                }
            );
        }

        public static void RegisterPlugin(ISceneLoaderPlugin plugin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "RegisterPlugin" }, plugin
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity ImportMesh(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[], TransformNode[], Geometry[], Light[]> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMesh" }, meshNames, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static ValueTask<ISceneLoaderAsyncResultCachedEntity> ImportMeshAsync(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.TaskClass<ISceneLoaderAsyncResultCachedEntity>(
                entity => new ISceneLoaderAsyncResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMeshAsync" }, meshNames, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity Load(string rootUrl, string sceneFilename = null, Engine engine = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "Load" }, rootUrl, sceneFilename, engine, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static ValueTask<Scene> LoadAsync(string rootUrl, string sceneFilename = null, Engine engine = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAsync" }, rootUrl, sceneFilename, engine, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity Append(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "Append" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static ValueTask<Scene> AppendAsync(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "AppendAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity LoadAssetContainer(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<AssetContainer> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainer" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static ValueTask<AssetContainer> LoadAssetContainerAsync(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.TaskClass<AssetContainer>(
                entity => new AssetContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainerAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static void ImportAnimations(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, System.Nullable<int> animationGroupLoadingMode = null, ActionResultCallback<CachedEntity, CachedEntity> targetConverter = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportAnimations" }, rootUrl, sceneFilename, scene, overwriteAnimations, animationGroupLoadingMode, targetConverter, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static ValueTask<Scene> ImportAnimationsAsync(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, System.Nullable<int> animationGroupLoadingMode = null, ActionResultCallback<CachedEntity, CachedEntity> targetConverter = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportAnimationsAsync" }, rootUrl, sceneFilename, scene, overwriteAnimations, animationGroupLoadingMode, targetConverter, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public SceneLoader() : base() { }

        public SceneLoader(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}