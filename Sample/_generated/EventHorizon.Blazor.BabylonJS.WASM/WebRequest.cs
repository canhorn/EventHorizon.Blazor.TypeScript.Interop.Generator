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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebRequest>))]
    public class WebRequest : CachedEntityObject, IWebRequest
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static CachedEntity CustomRequestHeaders
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "WebRequest.CustomRequestHeaders",
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
                    "WebRequest.CustomRequestHeaders",
                    value
                );
            }
        }

        
        public static ActionResultCallback<ActionCallback<XMLHttpRequest, string>>[] CustomRequestModifiers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<ActionResultCallback<ActionCallback<XMLHttpRequest, string>>>(
                    "BABYLON",
                    "WebRequest.CustomRequestModifiers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "WebRequest.CustomRequestModifiers",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public ActionResultCallback<ActionResultCallback<XMLHttpRequest, ProgressEvent, CachedEntity>> onprogress
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionResultCallback<ActionResultCallback<XMLHttpRequest, ProgressEvent, CachedEntity>>>(
                    this.___guid,
                    "onprogress"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onprogress",
                    value
                );
            }
        }

        
        public decimal readyState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "readyState"
                );
            }
        }

        
        public decimal status
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "status"
                );
            }
        }

        
        public string statusText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "statusText"
                );
            }
        }

        
        public CachedEntity response
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "response"
                );
            }
        }

        
        public string responseURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseURL"
                );
            }
        }

        
        public string responseText
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "responseText"
                );
            }
        }

        private XMLHttpRequestResponseType __responseType;
        public XMLHttpRequestResponseType responseType
        {
            get
            {
            if(__responseType == null)
            {
                __responseType = EventHorizonBlazorInterop.GetClass<XMLHttpRequestResponseType>(
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
            set
            {
__responseType = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "responseType",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public WebRequest() : base() { }

        public WebRequest(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void addEventListener<K>(K type, ActionResultCallback<XMLHttpRequest, K, CachedEntity> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener<K>(K type, ActionResultCallback<XMLHttpRequest, K, CachedEntity> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, listener, options
                }
            );
        }

        public void abort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "abort" }
                }
            );
        }

        public void send(Document body = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "send" }, body
                }
            );
        }

        public void open(string method, string url)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "open" }, method, url
                }
            );
        }

        public void setRequestHeader(string name, string value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRequestHeader" }, name, value
                }
            );
        }

        public string getResponseHeader(string name)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getResponseHeader" }, name
                }
            );
        }
        #endregion
    }
}