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

    public interface IEdgesRendererOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEdgesRendererOptionsCachedEntity>))]
    public class IEdgesRendererOptionsCachedEntity : CachedEntityObject, IEdgesRendererOptions
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
        
        public async ValueTask<bool> get_useAlternateEdgeFinder()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlternateEdgeFinder"
                );
        }
        public ValueTask set_useAlternateEdgeFinder(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAlternateEdgeFinder",
                    value
                );
        }

        
        public async ValueTask<bool> get_useFastVertexMerger()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useFastVertexMerger"
                );
        }
        public ValueTask set_useFastVertexMerger(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useFastVertexMerger",
                    value
                );
        }

        
        public async ValueTask<decimal> get_epsilonVertexMerge()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilonVertexMerge"
                );
        }
        public ValueTask set_epsilonVertexMerge(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilonVertexMerge",
                    value
                );
        }

        
        public async ValueTask<bool> get_applyTessellation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyTessellation"
                );
        }
        public ValueTask set_applyTessellation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyTessellation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_epsilonVertexAligned()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilonVertexAligned"
                );
        }
        public ValueTask set_epsilonVertexAligned(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilonVertexAligned",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IEdgesRendererOptionsCachedEntity() : base() { }

        public IEdgesRendererOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}