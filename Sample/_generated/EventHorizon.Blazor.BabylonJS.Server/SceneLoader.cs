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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneLoader>))]
    public class SceneLoader : CachedEntityObject
    {
        #region Static Accessors
        
        public static async ValueTask<bool> get_ForceFullSceneLoadingForIncremental()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ForceFullSceneLoadingForIncremental"
                );
        }
        public static ValueTask set_ForceFullSceneLoadingForIncremental(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.ForceFullSceneLoadingForIncremental",
                    value
                );
        }

        
        public static async ValueTask<bool> get_ShowLoadingScreen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ShowLoadingScreen"
                );
        }
        public static ValueTask set_ShowLoadingScreen(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.ShowLoadingScreen",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_loggingLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.loggingLevel"
                );
        }
        public static ValueTask set_loggingLevel(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.loggingLevel",
                    value
                );
        }

        
        public static async ValueTask<bool> get_CleanBoneMatrixWeights()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "SceneLoader.CleanBoneMatrixWeights"
                );
        }
        public static ValueTask set_CleanBoneMatrixWeights(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.CleanBoneMatrixWeights",
                    value
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_NO_LOGGING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.NO_LOGGING"
                );
        }

        
        public static async ValueTask<decimal> get_MINIMAL_LOGGING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.MINIMAL_LOGGING"
                );
        }

        
        public static async ValueTask<decimal> get_SUMMARY_LOGGING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.SUMMARY_LOGGING"
                );
        }

        
        public static async ValueTask<decimal> get_DETAILED_LOGGING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.DETAILED_LOGGING"
                );
        }

        private static Observable<ISceneLoaderPluginCachedEntity> __OnPluginActivatedObservable;
        public static async ValueTask<Observable<ISceneLoaderPluginCachedEntity>> get_OnPluginActivatedObservable()
        {
            if(__OnPluginActivatedObservable == null)
            {
                __OnPluginActivatedObservable = await EventHorizonBlazorInterop.GetClass<Observable<ISceneLoaderPluginCachedEntity>>(
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
        public static ValueTask set_OnPluginActivatedObservable(Observable<ISceneLoaderPluginCachedEntity> value)
        {
__OnPluginActivatedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SceneLoader.OnPluginActivatedObservable",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<IRegisteredPluginCachedEntity> GetDefaultPlugin()
        {
            return await EventHorizonBlazorInterop.FuncClass<IRegisteredPluginCachedEntity>(
                entity => new IRegisteredPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "GetDefaultPlugin" }
                }
            );
        }

        public static async ValueTask<ISceneLoaderPluginCachedEntity> GetPluginForExtension(string extension)
        {
            return await EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "GetPluginForExtension" }, extension
                }
            );
        }

        public static async ValueTask<bool> IsPluginForExtensionAvailable(string extension)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "IsPluginForExtensionAvailable" }, extension
                }
            );
        }

        public static async ValueTask RegisterPlugin(ISceneLoaderPlugin plugin)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "RegisterPlugin" }, plugin
                }
            );
        }

        public static async ValueTask<ISceneLoaderPluginCachedEntity> ImportMesh(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[], TransformNode[], Geometry[], Light[]> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMesh" }, meshNames, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static async ValueTask<ISceneLoaderAsyncResultCachedEntity> ImportMeshAsync(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<ISceneLoaderAsyncResultCachedEntity>(
                entity => new ISceneLoaderAsyncResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMeshAsync" }, meshNames, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static async ValueTask<ISceneLoaderPluginCachedEntity> Load(string rootUrl, string sceneFilename = null, Engine engine = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "Load" }, rootUrl, sceneFilename, engine, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static async ValueTask<Scene> LoadAsync(string rootUrl, string sceneFilename = null, Engine engine = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAsync" }, rootUrl, sceneFilename, engine, onProgress, pluginExtension
                }
            );
        }

        public static async ValueTask<ISceneLoaderPluginCachedEntity> Append(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "Append" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static async ValueTask<Scene> AppendAsync(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "AppendAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static async ValueTask<ISceneLoaderPluginCachedEntity> LoadAssetContainer(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<AssetContainer> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainer" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static async ValueTask<AssetContainer> LoadAssetContainerAsync(string rootUrl, string sceneFilename = null, Scene scene = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<AssetContainer>(
                entity => new AssetContainer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainerAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static async ValueTask ImportAnimations(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, System.Nullable<int> animationGroupLoadingMode = null, ActionCallback<CachedEntity> targetConverter = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportAnimations" }, rootUrl, sceneFilename, scene, overwriteAnimations, animationGroupLoadingMode, targetConverter, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static async ValueTask<Scene> ImportAnimationsAsync(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, System.Nullable<int> animationGroupLoadingMode = null, ActionCallback<CachedEntity> targetConverter = null, ActionCallback<Scene> onSuccess = null, ActionCallback<ISceneLoaderProgressEvent> onProgress = null, ActionCallback<Scene, string, CachedEntity> onError = null, string pluginExtension = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<Scene>(
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