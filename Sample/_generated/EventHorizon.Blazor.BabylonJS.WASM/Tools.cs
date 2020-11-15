/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Tools>))]
    public class Tools : CachedEntityObject
    {
        #region Static Accessors
        
        public static string BaseUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Tools.BaseUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.BaseUrl",
                    value
                );
            }
        }

        
        public static ActionCallback<string, WebRequest, decimal> DefaultRetryStrategy
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<string, WebRequest, decimal>>(
                    "BABYLON",
                    "Tools.DefaultRetryStrategy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.DefaultRetryStrategy",
                    value
                );
            }
        }

        
        public static string CorsBehavior
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Tools.CorsBehavior"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.CorsBehavior",
                    value
                );
            }
        }

        
        public static bool UseFallbackTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Tools.UseFallbackTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.UseFallbackTexture",
                    value
                );
            }
        }

        
        public static CachedEntity RegisteredExternalClasses
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    "BABYLON",
                    "Tools.RegisteredExternalClasses"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.RegisteredExternalClasses",
                    value
                );
            }
        }

        
        public static string fallbackTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Tools.fallbackTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.fallbackTexture",
                    value
                );
            }
        }

        
        public static ActionCallback<string> PreprocessUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<string>>(
                    "BABYLON",
                    "Tools.PreprocessUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.PreprocessUrl",
                    value
                );
            }
        }

        
        public static decimal errorsCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.errorsCount"
                );
            }
        }

        
        public static string LogCache
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Tools.LogCache"
                );
            }
        }

        
        public static decimal Now
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.Now"
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static bool UseCustomRequestHeaders
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Tools.UseCustomRequestHeaders"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.UseCustomRequestHeaders",
                    value
                );
            }
        }

        
        public static CachedEntity CustomRequestHeaders
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "Tools.CustomRequestHeaders",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.CustomRequestHeaders",
                    value
                );
            }
        }

        private static GetDOMTextContent __GetDOMTextContent;
        public static GetDOMTextContent GetDOMTextContent
        {
            get
            {
            if(__GetDOMTextContent == null)
            {
                __GetDOMTextContent = EventHorizonBlazorInterop.GetClass<GetDOMTextContent>(
                    "BABYLON",
                    "Tools.GetDOMTextContent",
                    (entity) =>
                    {
                        return new GetDOMTextContent() { ___guid = entity.___guid };
                    }
                );
            }
            return __GetDOMTextContent;
            }
            set
            {
__GetDOMTextContent = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.GetDOMTextContent",
                    value
                );
            }
        }

        
        public static decimal NoneLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.NoneLogLevel"
                );
            }
        }

        
        public static decimal MessageLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.MessageLogLevel"
                );
            }
        }

        
        public static decimal WarningLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.WarningLogLevel"
                );
            }
        }

        
        public static decimal ErrorLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.ErrorLogLevel"
                );
            }
        }

        
        public static decimal AllLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.AllLogLevel"
                );
            }
        }

        private static IsWindowObjectExist __IsWindowObjectExist;
        public static IsWindowObjectExist IsWindowObjectExist
        {
            get
            {
            if(__IsWindowObjectExist == null)
            {
                __IsWindowObjectExist = EventHorizonBlazorInterop.GetClass<IsWindowObjectExist>(
                    "BABYLON",
                    "Tools.IsWindowObjectExist",
                    (entity) =>
                    {
                        return new IsWindowObjectExist() { ___guid = entity.___guid };
                    }
                );
            }
            return __IsWindowObjectExist;
            }
            set
            {
__IsWindowObjectExist = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Tools.IsWindowObjectExist",
                    value
                );
            }
        }

        
        public static decimal PerformanceNoneLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.PerformanceNoneLogLevel"
                );
            }
        }

        
        public static decimal PerformanceUserMarkLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.PerformanceUserMarkLogLevel"
                );
            }
        }

        
        public static decimal PerformanceConsoleLogLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Tools.PerformanceConsoleLogLevel"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void FetchToRef(decimal u, decimal v, decimal width, decimal height, decimal[] pixels, IColor4Like color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "FetchToRef" }, u, v, width, height, pixels, color
                }
            );
        }

        public static decimal Mix(decimal a, decimal b, decimal alpha)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Mix" }, a, b, alpha
                }
            );
        }

        public static CachedEntity Instantiate(string className)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Instantiate" }, className
                }
            );
        }

        public static T Slice<T>(T data, System.Nullable<decimal> start = null, System.Nullable<decimal> end = null) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Slice" }, data, start, end
                }
            );
        }

        public static P[] SliceToArray<T, P>(T data, System.Nullable<decimal> start = null, System.Nullable<decimal> end = null) where T : CachedEntity, new() where P : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<P>(
                entity => new P() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "SliceToArray" }, data, start, end
                }
            );
        }

        public static void SetImmediate(ActionCallback action)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "SetImmediate" }, action
                }
            );
        }

        public static bool IsExponentOfTwo(decimal value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "IsExponentOfTwo" }, value
                }
            );
        }

        public static decimal FloatRound(decimal value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "FloatRound" }, value
                }
            );
        }

        public static string GetFilename(string path)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "GetFilename" }, path
                }
            );
        }

        public static string GetFolderPath(string uri, System.Nullable<bool> returnUnchangedIfNoSlash = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "GetFolderPath" }, uri, returnUnchangedIfNoSlash
                }
            );
        }

        public static decimal ToDegrees(decimal angle)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ToDegrees" }, angle
                }
            );
        }

        public static decimal ToRadians(decimal angle)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ToRadians" }, angle
                }
            );
        }

        public static CachedEntity[] MakeArray(object obj, System.Nullable<bool> allowsNullUndefined = null)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "MakeArray" }, obj, allowsNullUndefined
                }
            );
        }

        public static string GetPointerPrefix(Engine engine)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "GetPointerPrefix" }, engine
                }
            );
        }

        public static void SetCorsBehavior(string url, string element)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "SetCorsBehavior" }, url, element
                }
            );
        }

        public static string CleanUrl(string url)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "CleanUrl" }, url
                }
            );
        }

        public static HTMLImageElement LoadImage(string input, HTMLImageElement onLoad, ActionCallback<string, object> onError, IOfflineProvider offlineProvider, string mimeType = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
                entity => new HTMLImageElement() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "LoadImage" }, input, onLoad, onError, offlineProvider, mimeType
                }
            );
        }

        public static IFileRequestCachedEntity LoadFile(string url, string onSuccess, ActionCallback<object> onProgress = null, IOfflineProvider offlineProvider = null, System.Nullable<bool> useArrayBuffer = null, ActionCallback<WebRequest, object> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
                entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "LoadFile" }, url, onSuccess, onProgress, offlineProvider, useArrayBuffer, onError
                }
            );
        }

        public static ValueTask<ArrayBuffer> LoadFileAsync(string url, System.Nullable<bool> useArrayBuffer = null)
        {
            return EventHorizonBlazorInterop.TaskClass<ArrayBuffer>(
                entity => new ArrayBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "LoadFileAsync" }, url, useArrayBuffer
                }
            );
        }

        public static void LoadScript(string scriptUrl, ActionCallback onSuccess, ActionCallback<string, object> onError = null, string scriptId = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "LoadScript" }, scriptUrl, onSuccess, onError, scriptId
                }
            );
        }

        public async static ValueTask LoadScriptAsync(string scriptUrl, string scriptId = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "LoadScriptAsync" }, scriptUrl, scriptId
                }
            );
        }

        public static IFileRequestCachedEntity ReadFileAsDataURL(Blob fileToLoad, ActionCallback<object> callback, ActionCallback<ProgressEvent> progressCallback)
        {
            return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
                entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ReadFileAsDataURL" }, fileToLoad, callback, progressCallback
                }
            );
        }

        public static IFileRequestCachedEntity ReadFile(File file, ActionCallback<object> onSuccess, ActionCallback<ProgressEvent> onProgress = null, System.Nullable<bool> useArrayBuffer = null, ActionCallback<ReadFileError> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
                entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ReadFile" }, file, onSuccess, onProgress, useArrayBuffer, onError
                }
            );
        }

        public static string FileAsURL(string content)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "FileAsURL" }, content
                }
            );
        }

        public static string Format(decimal value, System.Nullable<decimal> decimals = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Format" }, value, decimals
                }
            );
        }

        public static void DeepCopy(object source, object destination, string[] doNotCopyList = null, string[] mustCopyList = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "DeepCopy" }, source, destination, doNotCopyList, mustCopyList
                }
            );
        }

        public static bool IsEmpty(object obj)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "IsEmpty" }, obj
                }
            );
        }

        public static void RegisterTopRootEvents(Window windowElement, CachedEntity[] events)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "RegisterTopRootEvents" }, windowElement, events
                }
            );
        }

        public static void UnregisterTopRootEvents(Window windowElement, CachedEntity[] events)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "UnregisterTopRootEvents" }, windowElement, events
                }
            );
        }

        public static void DumpFramebuffer(decimal width, decimal height, Engine engine, ActionCallback<string> successCallback = null, string mimeType = null, string fileName = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "DumpFramebuffer" }, width, height, engine, successCallback, mimeType, fileName
                }
            );
        }

        public static void ToBlob(HTMLCanvasElement canvas, ActionCallback<Blob> successCallback, string mimeType = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ToBlob" }, canvas, successCallback, mimeType
                }
            );
        }

        public static void EncodeScreenshotCanvasData(ActionCallback<string> successCallback = null, string mimeType = null, string fileName = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "EncodeScreenshotCanvasData" }, successCallback, mimeType, fileName
                }
            );
        }

        public static void Download(Blob blob, string fileName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Download" }, blob, fileName
                }
            );
        }

        public static bool BackCompatCameraNoPreventDefault(IArguments args)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "BackCompatCameraNoPreventDefault" }, args
                }
            );
        }

        public static void CreateScreenshot(Engine engine, Camera camera, IScreenshotSize size, ActionCallback<string> successCallback = null, string mimeType = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "CreateScreenshot" }, engine, camera, size, successCallback, mimeType
                }
            );
        }

        public static ValueTask<string> CreateScreenshotAsync(Engine engine, Camera camera, IScreenshotSize size, string mimeType = null)
        {
            return EventHorizonBlazorInterop.Task<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "CreateScreenshotAsync" }, engine, camera, size, mimeType
                }
            );
        }

        public static void CreateScreenshotUsingRenderTarget(Engine engine, Camera camera, IScreenshotSize size, ActionCallback<string> successCallback = null, string mimeType = null, System.Nullable<decimal> samples = null, System.Nullable<bool> antialiasing = null, string fileName = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "CreateScreenshotUsingRenderTarget" }, engine, camera, size, successCallback, mimeType, samples, antialiasing, fileName
                }
            );
        }

        public static ValueTask<string> CreateScreenshotUsingRenderTargetAsync(Engine engine, Camera camera, IScreenshotSize size, string mimeType = null, System.Nullable<decimal> samples = null, System.Nullable<bool> antialiasing = null, string fileName = null)
        {
            return EventHorizonBlazorInterop.Task<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "CreateScreenshotUsingRenderTargetAsync" }, engine, camera, size, mimeType, samples, antialiasing, fileName
                }
            );
        }

        public static string RandomId()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "RandomId" }
                }
            );
        }

        public static bool IsBase64(string uri)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "IsBase64" }, uri
                }
            );
        }

        public static ArrayBuffer DecodeBase64(string uri)
        {
            return EventHorizonBlazorInterop.FuncClass<ArrayBuffer>(
                entity => new ArrayBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "DecodeBase64" }, uri
                }
            );
        }

        public static string GetAbsoluteUrl(string url)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "GetAbsoluteUrl" }, url
                }
            );
        }

        #region OnNewCacheEntry TODO: Get Comments as metadata identification
        private static bool IsOnNewCacheEntryEnabled = false;
        private static readonly IDictionary<string, Func<Task>> OnNewCacheEntryActionMap = new Dictionary<string, Func<Task>>();

        public static string OnNewCacheEntry(
            Func<Task> callback
        )
        {
            SetupOnNewCacheEntryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            OnNewCacheEntryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool OnNewCacheEntry_Remove(
            string handle
        )
        {
            return OnNewCacheEntryActionMap.Remove(
                handle
            );
        }

        private static void SetupOnNewCacheEntryStaticLoop()
        {
            if (IsOnNewCacheEntryEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Tools.OnNewCacheEntry",
                "CallOnNewCacheEntryStaticActions"
            );
            IsOnNewCacheEntryEnabled = true;
        }

        [JSInvokable]
        public static async Task CallOnNewCacheEntryStaticActions()
        {
            foreach (var action in OnNewCacheEntryActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static void Log(string message)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Log" }, message
                }
            );
        }

        public static void Warn(string message)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Warn" }, message
                }
            );
        }

        public static void Error(string message)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "Error" }, message
                }
            );
        }

        public static void ClearLogCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "ClearLogCache" }
                }
            );
        }

        #region StartPerformanceCounter TODO: Get Comments as metadata identification
        private static bool IsStartPerformanceCounterEnabled = false;
        private static readonly IDictionary<string, Func<Task>> StartPerformanceCounterActionMap = new Dictionary<string, Func<Task>>();

        public static string StartPerformanceCounter(
            Func<Task> callback
        )
        {
            SetupStartPerformanceCounterStaticLoop();

            var handle = Guid.NewGuid().ToString();
            StartPerformanceCounterActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool StartPerformanceCounter_Remove(
            string handle
        )
        {
            return StartPerformanceCounterActionMap.Remove(
                handle
            );
        }

        private static void SetupStartPerformanceCounterStaticLoop()
        {
            if (IsStartPerformanceCounterEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Tools.StartPerformanceCounter",
                "CallStartPerformanceCounterStaticActions"
            );
            IsStartPerformanceCounterEnabled = true;
        }

        [JSInvokable]
        public static async Task CallStartPerformanceCounterStaticActions()
        {
            foreach (var action in StartPerformanceCounterActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region EndPerformanceCounter TODO: Get Comments as metadata identification
        private static bool IsEndPerformanceCounterEnabled = false;
        private static readonly IDictionary<string, Func<Task>> EndPerformanceCounterActionMap = new Dictionary<string, Func<Task>>();

        public static string EndPerformanceCounter(
            Func<Task> callback
        )
        {
            SetupEndPerformanceCounterStaticLoop();

            var handle = Guid.NewGuid().ToString();
            EndPerformanceCounterActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool EndPerformanceCounter_Remove(
            string handle
        )
        {
            return EndPerformanceCounterActionMap.Remove(
                handle
            );
        }

        private static void SetupEndPerformanceCounterStaticLoop()
        {
            if (IsEndPerformanceCounterEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Tools.EndPerformanceCounter",
                "CallEndPerformanceCounterStaticActions"
            );
            IsEndPerformanceCounterEnabled = true;
        }

        [JSInvokable]
        public static async Task CallEndPerformanceCounterStaticActions()
        {
            foreach (var action in EndPerformanceCounterActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static string GetClassName(object @object, System.Nullable<bool> isType = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "GetClassName" }, @object, isType
                }
            );
        }

        public static T First<T>(T[] array, ActionCallback<T> predicate) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "First" }, array, predicate
                }
            );
        }

        public static string getFullClassName(object @object, System.Nullable<bool> isType = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "getFullClassName" }, @object, isType
                }
            );
        }

        public async static ValueTask DelayAsync(decimal delay)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "DelayAsync" }, delay
                }
            );
        }

        public static bool IsSafari()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "Tools", "IsSafari" }
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Tools() : base() { }

        public Tools(
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