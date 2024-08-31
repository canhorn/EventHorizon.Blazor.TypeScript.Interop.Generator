/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<Tools>))]
public class Tools : CachedEntityObject
{
    #region Static Accessors

    public static async ValueTask<string> get_BaseUrl()
    {
        return await EventHorizonBlazorInterop.Get<string>("Tools", "BaseUrl");
    }

    public static ValueTask set_BaseUrl(string value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "BaseUrl", value);
    }

    public static async ValueTask<
        ActionResultCallback<string, WebRequest, decimal, decimal>
    > get_DefaultRetryStrategy()
    {
        return await EventHorizonBlazorInterop.Get<
            ActionResultCallback<string, WebRequest, decimal, decimal>
        >("Tools", "DefaultRetryStrategy");
    }

    public static ValueTask set_DefaultRetryStrategy(
        ActionResultCallback<string, WebRequest, decimal, decimal> value
    )
    {
        return EventHorizonBlazorInterop.Set("Tools", "DefaultRetryStrategy", value);
    }

    public static async ValueTask<string> get_CorsBehavior()
    {
        return await EventHorizonBlazorInterop.Get<string>("Tools", "CorsBehavior");
    }

    public static ValueTask set_CorsBehavior(string value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "CorsBehavior", value);
    }

    public static async ValueTask<bool> get_UseFallbackTexture()
    {
        return await EventHorizonBlazorInterop.Get<bool>("Tools", "UseFallbackTexture");
    }

    public static ValueTask set_UseFallbackTexture(bool value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "UseFallbackTexture", value);
    }

    public static async ValueTask<CachedEntity> get_RegisteredExternalClasses()
    {
        return await EventHorizonBlazorInterop.Get<CachedEntity>(
            "Tools",
            "RegisteredExternalClasses"
        );
    }

    public static ValueTask set_RegisteredExternalClasses(CachedEntity value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "RegisteredExternalClasses", value);
    }

    public static async ValueTask<string> get_fallbackTexture()
    {
        return await EventHorizonBlazorInterop.Get<string>("Tools", "fallbackTexture");
    }

    public static ValueTask set_fallbackTexture(string value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "fallbackTexture", value);
    }

    public static async ValueTask<ActionResultCallback<string, string>> get_PreprocessUrl()
    {
        return await EventHorizonBlazorInterop.Get<ActionResultCallback<string, string>>(
            "Tools",
            "PreprocessUrl"
        );
    }

    public static ValueTask set_PreprocessUrl(ActionResultCallback<string, string> value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "PreprocessUrl", value);
    }

    public static async ValueTask<decimal> get_errorsCount()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "errorsCount");
    }

    public static async ValueTask<string> get_LogCache()
    {
        return await EventHorizonBlazorInterop.Get<string>("Tools", "LogCache");
    }

    public static async ValueTask<decimal> get_Now()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "Now");
    }
    #endregion

    #region Static Properties

    public static async ValueTask<bool> get_UseCustomRequestHeaders()
    {
        return await EventHorizonBlazorInterop.Get<bool>("Tools", "UseCustomRequestHeaders");
    }

    public static ValueTask set_UseCustomRequestHeaders(bool value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "UseCustomRequestHeaders", value);
    }

    public static async ValueTask<CachedEntity> get_CustomRequestHeaders()
    {
        return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
            "Tools",
            "CustomRequestHeaders",
            (entity) =>
            {
                return new CachedEntity() { ___guid = entity.___guid };
            }
        );
    }

    public static ValueTask set_CustomRequestHeaders(CachedEntity value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "CustomRequestHeaders", value);
    }

    public static async ValueTask<string> get_GetDOMTextContent()
    {
        return await EventHorizonBlazorInterop.Get<string>("Tools", "GetDOMTextContent");
    }

    public static ValueTask set_GetDOMTextContent(string value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "GetDOMTextContent", value);
    }

    public static async ValueTask<decimal> get_NoneLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "NoneLogLevel");
    }

    public static async ValueTask<decimal> get_MessageLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "MessageLogLevel");
    }

    public static async ValueTask<decimal> get_WarningLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "WarningLogLevel");
    }

    public static async ValueTask<decimal> get_ErrorLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "ErrorLogLevel");
    }

    public static async ValueTask<decimal> get_AllLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "AllLogLevel");
    }

    public static async ValueTask<bool> get_IsWindowObjectExist()
    {
        return await EventHorizonBlazorInterop.Get<bool>("Tools", "IsWindowObjectExist");
    }

    public static ValueTask set_IsWindowObjectExist(bool value)
    {
        return EventHorizonBlazorInterop.Set("Tools", "IsWindowObjectExist", value);
    }

    public static async ValueTask<decimal> get_PerformanceNoneLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceNoneLogLevel");
    }

    public static async ValueTask<decimal> get_PerformanceUserMarkLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceUserMarkLogLevel");
    }

    public static async ValueTask<decimal> get_PerformanceConsoleLogLevel()
    {
        return await EventHorizonBlazorInterop.Get<decimal>("Tools", "PerformanceConsoleLogLevel");
    }
    #endregion

    #region Static Methods
    public static async ValueTask FetchToRef(
        decimal u,
        decimal v,
        decimal width,
        decimal height,
        decimal[] pixels,
        IColor4Like color
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask<decimal> Mix(decimal a, decimal b, decimal alpha)
    {
        return await EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "Mix" }, a, b, alpha }
        );
    }

    public static async ValueTask<CachedEntity> Instantiate(string className)
    {
        return await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Instantiate" }, className }
        );
    }

    public static async ValueTask<T> Slice<T>(
        T data,
        System.Nullable<decimal> start = null,
        System.Nullable<decimal> end = null
    )
        where T : CachedEntity, new()
    {
        return await EventHorizonBlazorInterop.FuncClass<T>(
            entity => new T() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "Slice" }, data, start, end }
        );
    }

    public static async ValueTask<P[]> SliceToArray<T, P>(
        T data,
        System.Nullable<decimal> start = null,
        System.Nullable<decimal> end = null
    )
        where T : CachedEntity, new()
        where P : CachedEntity, new()
    {
        return await EventHorizonBlazorInterop.FuncArrayClass<P>(
            entity => new P() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "SliceToArray" }, data, start, end }
        );
    }

    public static async ValueTask SetImmediate(ActionCallback action)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "SetImmediate" }, action }
        );
    }

    public static async ValueTask<bool> IsExponentOfTwo(decimal value)
    {
        return await EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsExponentOfTwo" }, value }
        );
    }

    public static async ValueTask<decimal> FloatRound(decimal value)
    {
        return await EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "FloatRound" }, value }
        );
    }

    public static async ValueTask<string> GetFilename(string path)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetFilename" }, path }
        );
    }

    public static async ValueTask<string> GetFolderPath(
        string uri,
        System.Nullable<bool> returnUnchangedIfNoSlash = null
    )
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[]
            {
                new string[] { "Tools", "GetFolderPath" },
                uri,
                returnUnchangedIfNoSlash
            }
        );
    }

    public static async ValueTask<decimal> ToDegrees(decimal angle)
    {
        return await EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "ToDegrees" }, angle }
        );
    }

    public static async ValueTask<decimal> ToRadians(decimal angle)
    {
        return await EventHorizonBlazorInterop.Func<decimal>(
            new object[] { new string[] { "Tools", "ToRadians" }, angle }
        );
    }

    public static async ValueTask<CachedEntity[]> MakeArray(
        object obj,
        System.Nullable<bool> allowsNullUndefined = null
    )
    {
        return await EventHorizonBlazorInterop.FuncArray<CachedEntity>(
            new object[] { new string[] { "Tools", "MakeArray" }, obj, allowsNullUndefined }
        );
    }

    public static async ValueTask<string> GetPointerPrefix(Engine engine)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetPointerPrefix" }, engine }
        );
    }

    public static async ValueTask SetCorsBehavior(string url, string element)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "SetCorsBehavior" }, url, element }
        );
    }

    public static async ValueTask<string> CleanUrl(string url)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "CleanUrl" }, url }
        );
    }

    public static async ValueTask<HTMLImageElement> LoadImage(
        string input,
        HTMLImageElement onLoad,
        ActionCallback<string, object> onError,
        IOfflineProvider offlineProvider,
        string mimeType = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<HTMLImageElement>(
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

    public static async ValueTask<IFileRequestCachedEntity> LoadFile(
        string url,
        string onSuccess,
        ActionCallback<object> onProgress = null,
        IOfflineProvider offlineProvider = null,
        System.Nullable<bool> useArrayBuffer = null,
        ActionCallback<WebRequest, object> onError = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
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

    public static async ValueTask<ArrayBuffer> LoadFileAsync(
        string url,
        System.Nullable<bool> useArrayBuffer = null
    )
    {
        return await EventHorizonBlazorInterop.TaskClass<ArrayBuffer>(
            entity => new ArrayBuffer() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "LoadFileAsync" }, url, useArrayBuffer }
        );
    }

    public static async ValueTask LoadScript(
        string scriptUrl,
        ActionCallback onSuccess,
        ActionCallback<string, object> onError = null,
        string scriptId = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask<IFileRequestCachedEntity> ReadFileAsDataURL(
        Blob fileToLoad,
        ActionCallback<object> callback,
        ActionResultCallback<ProgressEvent, CachedEntity> progressCallback
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
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

    public static async ValueTask<IFileRequestCachedEntity> ReadFile(
        File file,
        ActionCallback<object> onSuccess,
        ActionResultCallback<ProgressEvent, CachedEntity> onProgress = null,
        System.Nullable<bool> useArrayBuffer = null,
        ActionCallback<ReadFileError> onError = null
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<IFileRequestCachedEntity>(
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

    public static async ValueTask<string> FileAsURL(string content)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "FileAsURL" }, content }
        );
    }

    public static async ValueTask<string> Format(
        decimal value,
        System.Nullable<decimal> decimals = null
    )
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "Format" }, value, decimals }
        );
    }

    public static async ValueTask DeepCopy(
        object source,
        object destination,
        string[] doNotCopyList = null,
        string[] mustCopyList = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask<bool> IsEmpty(object obj)
    {
        return await EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsEmpty" }, obj }
        );
    }

    public static async ValueTask RegisterTopRootEvents(Window windowElement, CachedEntity[] events)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "RegisterTopRootEvents" },
                windowElement,
                events
            }
        );
    }

    public static async ValueTask UnregisterTopRootEvents(
        Window windowElement,
        CachedEntity[] events
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "UnregisterTopRootEvents" },
                windowElement,
                events
            }
        );
    }

    public static async ValueTask DumpFramebuffer(
        decimal width,
        decimal height,
        Engine engine,
        ActionCallback<string> successCallback = null,
        string mimeType = null,
        string fileName = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask ToBlob(
        HTMLCanvasElement canvas,
        ActionCallback<Blob> successCallback,
        string mimeType = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "ToBlob" }, canvas, successCallback, mimeType }
        );
    }

    public static async ValueTask EncodeScreenshotCanvasData(
        ActionCallback<string> successCallback = null,
        string mimeType = null,
        string fileName = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "EncodeScreenshotCanvasData" },
                successCallback,
                mimeType,
                fileName
            }
        );
    }

    public static async ValueTask Download(Blob blob, string fileName)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Download" }, blob, fileName }
        );
    }

    public static async ValueTask<bool> BackCompatCameraNoPreventDefault(IArguments args)
    {
        return await EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "BackCompatCameraNoPreventDefault" }, args }
        );
    }

    public static async ValueTask CreateScreenshot(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        ActionCallback<string> successCallback = null,
        string mimeType = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask<string> CreateScreenshotAsync(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        string mimeType = null
    )
    {
        return await EventHorizonBlazorInterop.Task<string>(
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

    public static async ValueTask CreateScreenshotUsingRenderTarget(
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
        await EventHorizonBlazorInterop.Func<CachedEntity>(
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

    public static async ValueTask<string> CreateScreenshotUsingRenderTargetAsync(
        Engine engine,
        Camera camera,
        IScreenshotSize size,
        string mimeType = null,
        System.Nullable<decimal> samples = null,
        System.Nullable<bool> antialiasing = null,
        string fileName = null
    )
    {
        return await EventHorizonBlazorInterop.Task<string>(
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

    public static async ValueTask<string> RandomId()
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "RandomId" } }
        );
    }

    public static async ValueTask<bool> IsBase64(string uri)
    {
        return await EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { "Tools", "IsBase64" }, uri }
        );
    }

    public static async ValueTask<ArrayBuffer> DecodeBase64(string uri)
    {
        return await EventHorizonBlazorInterop.FuncClass<ArrayBuffer>(
            entity => new ArrayBuffer() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "DecodeBase64" }, uri }
        );
    }

    public static async ValueTask<string> GetAbsoluteUrl(string url)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetAbsoluteUrl" }, url }
        );
    }

    public static async ValueTask OnNewCacheEntry(string entry)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "OnNewCacheEntry" }, entry }
        );
    }

    public static async ValueTask Log(string message)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Log" }, message }
        );
    }

    public static async ValueTask Warn(string message)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Warn" }, message }
        );
    }

    public static async ValueTask Error(string message)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "Error" }, message }
        );
    }

    public static async ValueTask ClearLogCache()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { "Tools", "ClearLogCache" } }
        );
    }

    public static async ValueTask StartPerformanceCounter(
        string counterName,
        System.Nullable<bool> condition = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "StartPerformanceCounter" },
                counterName,
                condition
            }
        );
    }

    public static async ValueTask EndPerformanceCounter(
        string counterName,
        System.Nullable<bool> condition = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { "Tools", "EndPerformanceCounter" },
                counterName,
                condition
            }
        );
    }

    public static async ValueTask<string> GetClassName(
        object @object,
        System.Nullable<bool> isType = null
    )
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "GetClassName" }, @object, isType }
        );
    }

    public static async ValueTask<T> First<T>(T[] array, ActionResultCallback<T, bool> predicate)
        where T : CachedEntity, new()
    {
        return await EventHorizonBlazorInterop.FuncClass<T>(
            entity => new T() { ___guid = entity.___guid },
            new object[] { new string[] { "Tools", "First" }, array, predicate }
        );
    }

    public static async ValueTask<string> getFullClassName(
        object @object,
        System.Nullable<bool> isType = null
    )
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { "Tools", "getFullClassName" }, @object, isType }
        );
    }

    public static async ValueTask DelayAsync(decimal delay)
    {
        await EventHorizonBlazorInterop.Task<Void_>(
            new object[] { new string[] { "Tools", "DelayAsync" }, delay }
        );
    }

    public static async ValueTask<bool> IsSafari()
    {
        return await EventHorizonBlazorInterop.Func<bool>(
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
