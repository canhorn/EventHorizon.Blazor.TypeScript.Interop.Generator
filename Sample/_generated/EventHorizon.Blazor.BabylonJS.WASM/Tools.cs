/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<Tools>))]
public class Tools : CachedEntityObject
{
    #region Static Accessors

    public static string BaseUrl
    {
        get { return EventHorizonBlazorInterop.Get<string>("Tools", "BaseUrl"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "BaseUrl", value);
        }
    }

    public static ActionResultCallback<string, WebRequest, decimal, decimal> DefaultRetryStrategy
    {
        get
        {
            return EventHorizonBlazorInterop.Get<
                ActionResultCallback<string, WebRequest, decimal, decimal>
            >("Tools", "DefaultRetryStrategy");
        }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "DefaultRetryStrategy", value);
        }
    }

    public static string CorsBehavior
    {
        get { return EventHorizonBlazorInterop.Get<string>("Tools", "CorsBehavior"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "CorsBehavior", value);
        }
    }

    public static bool UseFallbackTexture
    {
        get { return EventHorizonBlazorInterop.Get<bool>("Tools", "UseFallbackTexture"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "UseFallbackTexture", value);
        }
    }

    public static CachedEntity RegisteredExternalClasses
    {
        get
        {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                "Tools",
                "RegisteredExternalClasses"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "RegisteredExternalClasses", value);
        }
    }

    public static string fallbackTexture
    {
        get { return EventHorizonBlazorInterop.Get<string>("Tools", "fallbackTexture"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "fallbackTexture", value);
        }
    }

    public static ActionResultCallback<string, string> PreprocessUrl
    {
        get
        {
            return EventHorizonBlazorInterop.Get<ActionResultCallback<string, string>>(
                "Tools",
                "PreprocessUrl"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "PreprocessUrl", value);
        }
    }

    public static decimal errorsCount
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "errorsCount"); }
    }

    public static string LogCache
    {
        get { return EventHorizonBlazorInterop.Get<string>("Tools", "LogCache"); }
    }

    public static decimal Now
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "Now"); }
    }
    #endregion

    #region Static Properties

    public static bool UseCustomRequestHeaders
    {
        get { return EventHorizonBlazorInterop.Get<bool>("Tools", "UseCustomRequestHeaders"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "UseCustomRequestHeaders", value);
        }
    }

    public static CachedEntity CustomRequestHeaders
    {
        get
        {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "Tools",
                "CustomRequestHeaders",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "CustomRequestHeaders", value);
        }
    }

    public static string GetDOMTextContent
    {
        get { return EventHorizonBlazorInterop.Get<string>("Tools", "GetDOMTextContent"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "GetDOMTextContent", value);
        }
    }

    public static decimal NoneLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "NoneLogLevel"); }
    }

    public static decimal MessageLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "MessageLogLevel"); }
    }

    public static decimal WarningLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "WarningLogLevel"); }
    }

    public static decimal ErrorLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "ErrorLogLevel"); }
    }

    public static decimal AllLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "AllLogLevel"); }
    }

    public static bool IsWindowObjectExist
    {
        get { return EventHorizonBlazorInterop.Get<bool>("Tools", "IsWindowObjectExist"); }
        set
        {

            EventHorizonBlazorInterop.Set("Tools", "IsWindowObjectExist", value);
        }
    }

    public static decimal PerformanceNoneLogLevel
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceNoneLogLevel"); }
    }

    public static decimal PerformanceUserMarkLogLevel
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceUserMarkLogLevel");
        }
    }

    public static decimal PerformanceConsoleLogLevel
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceConsoleLogLevel");
        }
    }
    #endregion

    #region Static Methods
    public static void FetchToRef(
        decimal u,
        decimal v,
        decimal width,
        decimal height,
        decimal[] pixels,
        IColor4Like color
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "FetchToRef" },
                u,
                v,
                width,
                height,
                pixels,
                color
            }
        );
    }

    public static decimal Mix(decimal a, decimal b, decimal alpha)
    {
        return EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "Mix" }, a, b, alpha }
        );
    }

    public static CachedEntity Instantiate(string className)
    {
        return EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Instantiate" }, className }
        );
    }

    public static T Slice<T>(
        T data,
        System.Nullable<decimal> start = null,
        System.Nullable<decimal> end = null
    )
        where T : CachedEntity, new()
    {
        return EventHorizonBlazorInterop.FuncClass<T>(
            entity => new T() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "Slice" }, data, start, end }
        );
    }

    public static P[] SliceToArray<T, P>(
        T data,
        System.Nullable<decimal> start = null,
        System.Nullable<decimal> end = null
    )
        where T : CachedEntity, new()
        where P : CachedEntity, new()
    {
        return EventHorizonBlazorInterop.FuncArrayClass<P>(
            entity => new P() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "SliceToArray" }, data, start, end }
        );
    }

    public static void SetImmediate(ActionCallback action)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "SetImmediate" }, action }
        );
    }

    public static bool IsExponentOfTwo(decimal value)
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsExponentOfTwo" }, value }
        );
    }

    public static decimal FloatRound(decimal value)
    {
        return EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "FloatRound" }, value }
        );
    }

    public static string GetFilename(string path)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetFilename" }, path }
        );
    }

    public static string GetFolderPath(
        string uri,
        System.Nullable<bool> returnUnchangedIfNoSlash = null
    )
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[]
            {
                new string[] { "Tools", "GetFolderPath" },
                uri,
                returnUnchangedIfNoSlash
            }
        );
    }

    public static decimal ToDegrees(decimal angle)
    {
        return EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "ToDegrees" }, angle }
        );
    }

    public static decimal ToRadians(decimal angle)
    {
        return EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "ToRadians" }, angle }
        );
    }

    public static CachedEntity[] MakeArray(
        object obj,
        System.Nullable<bool> allowsNullUndefined = null
    )
    {
        return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
            new object[] { new string[] { "Tools", "MakeArray" }, obj, allowsNullUndefined }
        );
    }

    public static string GetPointerPrefix(Engine engine)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetPointerPrefix" }, engine }
        );
    }

    public static void SetCorsBehavior(string url, string element)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "SetCorsBehavior" }, url, element }
        );
    }

    public static string CleanUrl(string url)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "CleanUrl" }, url }
        );
    }

    public static HTMLImageElement LoadImage(
        string input,
        HTMLImageElement onLoad,
        ActionCallback<string, object> onError,
        IOfflineProvider offlineProvider,
        string mimeType = null
    )
    {
        return EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
            entity => new HTMLImageElement() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Tools", "LoadImage" },
                input,
                onLoad,
                onError,
                offlineProvider,
                mimeType
            }
        );
    }

    public static IFileRequestCachedEntity LoadFile(
        string url,
        string onSuccess,
        ActionCallback<object> onProgress = null,
        IOfflineProvider offlineProvider = null,
        System.Nullable<bool> useArrayBuffer = null,
        ActionCallback<WebRequest, object> onError = null
    )
    {
        return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
            entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Tools", "LoadFile" },
                url,
                onSuccess,
                onProgress,
                offlineProvider,
                useArrayBuffer,
                onError
            }
        );
    }

    public static ValueTask<ArrayBuffer> LoadFileAsync(
        string url,
        System.Nullable<bool> useArrayBuffer = null
    )
    {
        return EventHorizonBlazorInterop.TaskClass<ArrayBuffer>(
            entity => new ArrayBuffer() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "LoadFileAsync" }, url, useArrayBuffer }
        );
    }

    public static void LoadScript(
        string scriptUrl,
        ActionCallback onSuccess,
        ActionCallback<string, object> onError = null,
        string scriptId = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "LoadScript" },
                scriptUrl,
                onSuccess,
                onError,
                scriptId
            }
        );
    }

    public static async ValueTask LoadScriptAsync(string scriptUrl, string scriptId = null)
    {
        await EventHorizonBlazorInterop.Task<Void_>(
            new object[] { new string[] { "Tools", "LoadScriptAsync" }, scriptUrl, scriptId }
        );
    }

    public static IFileRequestCachedEntity ReadFileAsDataURL(
        Blob fileToLoad,
        ActionCallback<object> callback,
        ActionResultCallback<ProgressEvent, CachedEntity> progressCallback
    )
    {
        return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
            entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Tools", "ReadFileAsDataURL" },
                fileToLoad,
                callback,
                progressCallback
            }
        );
    }

    public static IFileRequestCachedEntity ReadFile(
        File file,
        ActionCallback<object> onSuccess,
        ActionResultCallback<ProgressEvent, CachedEntity> onProgress = null,
        System.Nullable<bool> useArrayBuffer = null,
        ActionCallback<ReadFileError> onError = null
    )
    {
        return EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
            entity => new IFileRequestCachedEntity() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Tools", "ReadFile" },
                file,
                onSuccess,
                onProgress,
                useArrayBuffer,
                onError
            }
        );
    }

    public static string FileAsURL(string content)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "FileAsURL" }, content }
        );
    }

    public static string Format(decimal value, System.Nullable<decimal> decimals = null)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "Format" }, value, decimals }
        );
    }

    public static void DeepCopy(
        object source,
        object destination,
        string[] doNotCopyList = null,
        string[] mustCopyList = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "DeepCopy" },
                source,
                destination,
                doNotCopyList,
                mustCopyList
            }
        );
    }

    public static bool IsEmpty(object obj)
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsEmpty" }, obj }
        );
    }

    public static void RegisterTopRootEvents(Window windowElement, CachedEntity[] events)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "RegisterTopRootEvents" },
                windowElement,
                events
            }
        );
    }

    public static void UnregisterTopRootEvents(Window windowElement, CachedEntity[] events)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "UnregisterTopRootEvents" },
                windowElement,
                events
            }
        );
    }

    public static void DumpFramebuffer(
        decimal width,
        decimal height,
        Engine engine,
        ActionCallback<string> successCallback = null,
        string mimeType = null,
        string fileName = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "DumpFramebuffer" },
                width,
                height,
                engine,
                successCallback,
                mimeType,
                fileName
            }
        );
    }

    public static void ToBlob(
        HTMLCanvasElement canvas,
        ActionCallback<Blob> successCallback,
        string mimeType = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "ToBlob" }, canvas, successCallback, mimeType }
        );
    }

    public static void EncodeScreenshotCanvasData(
        ActionCallback<string> successCallback = null,
        string mimeType = null,
        string fileName = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "EncodeScreenshotCanvasData" },
                successCallback,
                mimeType,
                fileName
            }
        );
    }

    public static void Download(Blob blob, string fileName)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Download" }, blob, fileName }
        );
    }

    public static bool BackCompatCameraNoPreventDefault(IArguments args)
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "BackCompatCameraNoPreventDefault" }, args }
        );
    }

    public static void CreateScreenshot(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        ActionCallback<string> successCallback = null,
        string mimeType = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "CreateScreenshot" },
                engine,
                camera,
                size,
                successCallback,
                mimeType
            }
        );
    }

    public static ValueTask<string> CreateScreenshotAsync(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        string mimeType = null
    )
    {
        return EventHorizonBlazorInterop.Task<string>(
            new object[]
            {
                new string[] { "Tools", "CreateScreenshotAsync" },
                engine,
                camera,
                size,
                mimeType
            }
        );
    }

    public static void CreateScreenshotUsingRenderTarget(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        ActionCallback<string> successCallback = null,
        string mimeType = null,
        System.Nullable<decimal> samples = null,
        System.Nullable<bool> antialiasing = null,
        string fileName = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "CreateScreenshotUsingRenderTarget" },
                engine,
                camera,
                size,
                successCallback,
                mimeType,
                samples,
                antialiasing,
                fileName
            }
        );
    }

    public static ValueTask<string> CreateScreenshotUsingRenderTargetAsync(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        string mimeType = null,
        System.Nullable<decimal> samples = null,
        System.Nullable<bool> antialiasing = null,
        string fileName = null
    )
    {
        return EventHorizonBlazorInterop.Task<string>(
            new object[]
            {
                new string[] { "Tools", "CreateScreenshotUsingRenderTargetAsync" },
                engine,
                camera,
                size,
                mimeType,
                samples,
                antialiasing,
                fileName
            }
        );
    }

    public static string RandomId()
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "RandomId" } }
        );
    }

    public static bool IsBase64(string uri)
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsBase64" }, uri }
        );
    }

    public static ArrayBuffer DecodeBase64(string uri)
    {
        return EventHorizonBlazorInterop.FuncClass<ArrayBuffer>(
            entity => new ArrayBuffer() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "DecodeBase64" }, uri }
        );
    }

    public static string GetAbsoluteUrl(string url)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetAbsoluteUrl" }, url }
        );
    }

    public static void OnNewCacheEntry(string entry)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "OnNewCacheEntry" }, entry }
        );
    }

    public static void Log(string message)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Log" }, message }
        );
    }

    public static void Warn(string message)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Warn" }, message }
        );
    }

    public static void Error(string message)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Error" }, message }
        );
    }

    public static void ClearLogCache()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "ClearLogCache" } }
        );
    }

    public static void StartPerformanceCounter(
        string counterName,
        System.Nullable<bool> condition = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "StartPerformanceCounter" },
                counterName,
                condition
            }
        );
    }

    public static void EndPerformanceCounter(
        string counterName,
        System.Nullable<bool> condition = null
    )
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "EndPerformanceCounter" },
                counterName,
                condition
            }
        );
    }

    public static string GetClassName(object @object, System.Nullable<bool> isType = null)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetClassName" }, @object, isType }
        );
    }

    public static T First<T>(T[] array, ActionResultCallback<T, bool> predicate)
        where T : CachedEntity, new()
    {
        return EventHorizonBlazorInterop.FuncClass<T>(
            entity => new T() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "First" }, array, predicate }
        );
    }

    public static string getFullClassName(object @object, System.Nullable<bool> isType = null)
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "getFullClassName" }, @object, isType }
        );
    }

    public static async ValueTask DelayAsync(decimal delay)
    {
        await EventHorizonBlazorInterop.Task<Void_>(
            new object[] { new string[] { "Tools", "DelayAsync" }, delay }
        );
    }

    public static bool IsSafari()
    {
        return EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsSafari" } }
        );
    }
    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion

    #region Constructor
    public Tools()
        : base() { }

    public Tools(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    #endregion

    #region Methods

    #endregion
}
