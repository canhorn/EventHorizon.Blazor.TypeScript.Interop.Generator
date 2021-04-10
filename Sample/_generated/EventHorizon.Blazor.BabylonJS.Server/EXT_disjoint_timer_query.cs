/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        
        public async ValueTask<decimal> get_QUERY_COUNTER_BITS_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_COUNTER_BITS_EXT"
                );
        }
        public ValueTask set_QUERY_COUNTER_BITS_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_COUNTER_BITS_EXT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_TIME_ELAPSED_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TIME_ELAPSED_EXT"
                );
        }
        public ValueTask set_TIME_ELAPSED_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TIME_ELAPSED_EXT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_TIMESTAMP_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "TIMESTAMP_EXT"
                );
        }
        public ValueTask set_TIMESTAMP_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "TIMESTAMP_EXT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_GPU_DISJOINT_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "GPU_DISJOINT_EXT"
                );
        }
        public ValueTask set_GPU_DISJOINT_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "GPU_DISJOINT_EXT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_QUERY_RESULT_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT_EXT"
                );
        }
        public ValueTask set_QUERY_RESULT_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT_EXT",
                    value
                );
        }

        
        public async ValueTask<decimal> get_QUERY_RESULT_AVAILABLE_EXT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE_EXT"
                );
        }
        public ValueTask set_QUERY_RESULT_AVAILABLE_EXT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE_EXT",
                    value
                );
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
        public async ValueTask queryCounterEXT(WebGLQuery query, decimal target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "queryCounterEXT" }, query, target
                }
            );
        }

        public async ValueTask<WebGLQueryCachedEntity> createQueryEXT()
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLQueryCachedEntity>(
                entity => new WebGLQueryCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createQueryEXT" }
                }
            );
        }

        public async ValueTask beginQueryEXT(decimal target, WebGLQuery query)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginQueryEXT" }, target, query
                }
            );
        }

        public async ValueTask endQueryEXT(decimal target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endQueryEXT" }, target
                }
            );
        }

        public async ValueTask<CachedEntity> getQueryObjectEXT(WebGLQuery query, decimal target)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getQueryObjectEXT" }, query, target
                }
            );
        }

        public async ValueTask deleteQueryEXT(WebGLQuery query)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteQueryEXT" }, query
                }
            );
        }
    #endregion
}