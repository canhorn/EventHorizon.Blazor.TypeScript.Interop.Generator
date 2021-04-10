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

    public interface IPipelineContext : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IPipelineContextCachedEntity>))]
    public class IPipelineContextCachedEntity : CachedEntityObject, IPipelineContext
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
        
        public async ValueTask<bool> get_isAsync()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAsync"
                );
        }
        public ValueTask set_isAsync(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAsync",
                    value
                );
        }

        
        public async ValueTask<bool> get_isReady()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isReady"
                );
        }
        public ValueTask set_isReady(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isReady",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IPipelineContextCachedEntity() : base() { }

        public IPipelineContextCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}