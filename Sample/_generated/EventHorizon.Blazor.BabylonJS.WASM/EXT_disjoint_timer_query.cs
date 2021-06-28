/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface EXT_disjoint_timer_query : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<EXT_disjoint_timer_queryCachedEntity>))]
public class EXT_disjoint_timer_queryCachedEntity : CachedEntityObject, EXT_disjoint_timer_query
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
        
        public decimal QUERY_COUNTER_BITS_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_COUNTER_BITS_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_COUNTER_BITS_EXT",
                    value
                );
            }
        }

        
        public decimal TIME_ELAPSED_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TIME_ELAPSED_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TIME_ELAPSED_EXT",
                    value
                );
            }
        }

        
        public decimal TIMESTAMP_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TIMESTAMP_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TIMESTAMP_EXT",
                    value
                );
            }
        }

        
        public decimal GPU_DISJOINT_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GPU_DISJOINT_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GPU_DISJOINT_EXT",
                    value
                );
            }
        }

        
        public decimal QUERY_RESULT_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT_EXT",
                    value
                );
            }
        }

        
        public decimal QUERY_RESULT_AVAILABLE_EXT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE_EXT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE_EXT",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public EXT_disjoint_timer_queryCachedEntity() : base() { }

        public EXT_disjoint_timer_queryCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void queryCounterEXT(WebGLQuery query, decimal target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "queryCounterEXT" }, query, target
                }
            );
        }

        public WebGLQueryCachedEntity createQueryEXT()
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLQueryCachedEntity>(
                entity => new WebGLQueryCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createQueryEXT" }
                }
            );
        }

        public void beginQueryEXT(decimal target, WebGLQuery query)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginQueryEXT" }, target, query
                }
            );
        }

        public void endQueryEXT(decimal target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "endQueryEXT" }, target
                }
            );
        }

        public CachedEntity getQueryObjectEXT(WebGLQuery query, decimal target)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getQueryObjectEXT" }, query, target
                }
            );
        }

        public void deleteQueryEXT(WebGLQuery query)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteQueryEXT" }, query
                }
            );
        }
    #endregion
}
