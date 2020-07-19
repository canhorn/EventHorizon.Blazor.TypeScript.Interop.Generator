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
    public class SceneLoader : CachedEntityObject
    {
        #region Static Accessors
        
        public static bool ForceFullSceneLoadingForIncremental
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ForceFullSceneLoadingForIncremental"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "SceneLoader.ShowLoadingScreen"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.loggingLevel"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "SceneLoader.CleanBoneMatrixWeights"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.NO_LOGGING"
                );
            }
        }

        
        public static decimal MINIMAL_LOGGING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.MINIMAL_LOGGING"
                );
            }
        }

        
        public static decimal SUMMARY_LOGGING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "SceneLoader.SUMMARY_LOGGING"
                );
            }
        }

        
        public static decimal DETAILED_LOGGING
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
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
                __OnPluginActivatedObservable = EventHorizonBlazorInteropt.GetClass<Observable<ISceneLoaderPluginCachedEntity>>(
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
                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "SceneLoader.OnPluginActivatedObservable",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static ISceneLoaderPluginCachedEntity GetPluginForExtension(string extension)
        {
            return EventHorizonBlazorInteropt.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "GetPluginForExtension" }, extension
                }
            );
        }

        public static bool IsPluginForExtensionAvailable(string extension)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "IsPluginForExtensionAvailable" }, extension
                }
            );
        }

        public static void RegisterPlugin(ISceneLoaderPluginCachedEntity plugin)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "RegisterPlugin" }, plugin
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity ImportMesh(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMesh" }, meshNames, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static void ImportMeshAsync(object meshNames, string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onProgress = null, string pluginExtension = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportMeshAsync" }, meshNames, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity Load(string rootUrl, string sceneFilename = null, Engine engine = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "Load" }, rootUrl, sceneFilename, engine, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static void LoadAsync(string rootUrl, string sceneFilename = null, Engine engine = null, CachedEntity onProgress = null, string pluginExtension = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAsync" }, rootUrl, sceneFilename, engine, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity Append(string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "Append" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static void AppendAsync(string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onProgress = null, string pluginExtension = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "AppendAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static ISceneLoaderPluginCachedEntity LoadAssetContainer(string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null, string pluginExtension = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ISceneLoaderPluginCachedEntity>(
                entity => new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainer" }, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension
                }
            );
        }

        public static void LoadAssetContainerAsync(string rootUrl, string sceneFilename = null, Scene scene = null, CachedEntity onProgress = null, string pluginExtension = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "LoadAssetContainerAsync" }, rootUrl, sceneFilename, scene, onProgress, pluginExtension
                }
            );
        }

        public static void ImportAnimations(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, SceneLoaderAnimationGroupLoadingMode animationGroupLoadingMode = null, CachedEntity targetConverter = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportAnimations" }, rootUrl, sceneFilename, scene, overwriteAnimations, animationGroupLoadingMode, targetConverter, onSuccess, onProgress, onError
                }
            );
        }

        public static void ImportAnimationsAsync(string rootUrl, string sceneFilename = null, Scene scene = null, System.Nullable<bool> overwriteAnimations = null, SceneLoaderAnimationGroupLoadingMode animationGroupLoadingMode = null, CachedEntity targetConverter = null, CachedEntity onSuccess = null, CachedEntity onProgress = null, CachedEntity onError = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoader", "ImportAnimationsAsync" }, rootUrl, sceneFilename, scene, overwriteAnimations, animationGroupLoadingMode, targetConverter, onSuccess, onProgress, onError
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