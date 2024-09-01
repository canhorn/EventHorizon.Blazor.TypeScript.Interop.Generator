/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<WebRequest>))]
public class WebRequest : CachedEntityObject, IWebRequest
{
    #region Static Accessors

    #endregion

    #region Static Properties

    public static async ValueTask<CachedEntity> get_CustomRequestHeaders()
    {
        return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
            "WebRequest",
            "CustomRequestHeaders",
            (entity) =>
            {
                return new CachedEntity() { ___guid = entity.___guid };
            }
        );
    }

    public static ValueTask set_CustomRequestHeaders(CachedEntity value)
    {
        return EventHorizonBlazorInterop.Set("WebRequest", "CustomRequestHeaders", value);
    }

    public static async ValueTask<ActionResultCallback<
        ActionCallback<XMLHttpRequest, string>
    >[]> get_CustomRequestModifiers()
    {
        return await EventHorizonBlazorInterop.GetArray<
            ActionResultCallback<ActionCallback<XMLHttpRequest, string>>
        >("WebRequest", "CustomRequestModifiers");
    }

    public static ValueTask set_CustomRequestModifiers(
        ActionResultCallback<ActionCallback<XMLHttpRequest, string>>[] value
    )
    {
        return EventHorizonBlazorInterop.Set("WebRequest", "CustomRequestModifiers", value);
    }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    public async ValueTask<
        ActionResultCallback<ActionResultCallback<XMLHttpRequest, ProgressEvent, CachedEntity>>
    > get_onprogress()
    {
        return await EventHorizonBlazorInterop.Get<
            ActionResultCallback<ActionResultCallback<XMLHttpRequest, ProgressEvent, CachedEntity>>
        >(this.___guid, "onprogress");
    }

    public ValueTask set_onprogress(
        ActionResultCallback<
            ActionResultCallback<XMLHttpRequest, ProgressEvent, CachedEntity>
        > value
    )
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "onprogress", value);
    }

    public async ValueTask<decimal> get_readyState()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "readyState");
    }

    public async ValueTask<decimal> get_status()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "status");
    }

    public async ValueTask<string> get_statusText()
    {
        return await EventHorizonBlazorInterop.Get<string>(this.___guid, "statusText");
    }

    public async ValueTask<CachedEntity> get_response()
    {
        return await EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "response");
    }

    public async ValueTask<string> get_responseURL()
    {
        return await EventHorizonBlazorInterop.Get<string>(this.___guid, "responseURL");
    }

    public async ValueTask<string> get_responseText()
    {
        return await EventHorizonBlazorInterop.Get<string>(this.___guid, "responseText");
    }

    private XMLHttpRequestResponseType __responseType;

    public async ValueTask<XMLHttpRequestResponseType> get_responseType()
    {
        if (__responseType == null)
        {
            __responseType = await EventHorizonBlazorInterop.GetClass<XMLHttpRequestResponseType>(
                this.___guid,
                "responseType",
                (entity) =>
                {
                    return new XMLHttpRequestResponseType() { ___guid = entity.___guid };
                }
            );
        }
        return __responseType;
    }

    public ValueTask set_responseType(XMLHttpRequestResponseType value)
    {
        __responseType = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "responseType", value);
    }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public WebRequest()
        : base() { }

    public WebRequest(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    public async ValueTask addEventListener<K>(
        K type,
        ActionResultCallback<XMLHttpRequest, K, CachedEntity> listener,
        System.Nullable<bool> options = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { this.___guid, "addEventListener" },
                type,
                listener,
                options
            }
        );
    }

    public async ValueTask removeEventListener<K>(
        K type,
        ActionResultCallback<XMLHttpRequest, K, CachedEntity> listener,
        System.Nullable<bool> options = null
    )
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[]
            {
                new string[] { this.___guid, "removeEventListener" },
                type,
                listener,
                options
            }
        );
    }

    public async ValueTask abort()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "abort" } }
        );
    }

    public async ValueTask send(Document body = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "send" }, body }
        );
    }

    public async ValueTask open(string method, string url)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "open" }, method, url }
        );
    }

    public async ValueTask setRequestHeader(string name, string value)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "setRequestHeader" }, name, value }
        );
    }

    public async ValueTask<string> getResponseHeader(string name)
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getResponseHeader" }, name }
        );
    }
    #endregion
}
