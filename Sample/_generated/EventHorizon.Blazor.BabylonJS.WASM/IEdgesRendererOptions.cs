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
        
        public bool useAlternateEdgeFinder
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlternateEdgeFinder"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAlternateEdgeFinder",
                    value
                );
            }
        }

        
        public bool useFastVertexMerger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useFastVertexMerger"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useFastVertexMerger",
                    value
                );
            }
        }

        
        public decimal epsilonVertexMerge
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilonVertexMerge"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilonVertexMerge",
                    value
                );
            }
        }

        
        public bool applyTessellation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyTessellation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyTessellation",
                    value
                );
            }
        }

        
        public decimal epsilonVertexAligned
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "epsilonVertexAligned"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "epsilonVertexAligned",
                    value
                );
            }
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