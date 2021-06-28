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

    public interface SceneOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<SceneOptionsCachedEntity>))]
    public class SceneOptionsCachedEntity : CachedEntityObject, SceneOptions
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
        
        public bool useGeometryUniqueIdsMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGeometryUniqueIdsMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useGeometryUniqueIdsMap",
                    value
                );
            }
        }

        
        public bool useMaterialMeshMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useMaterialMeshMap",
                    value
                );
            }
        }

        
        public bool useClonedMeshMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useClonedMeshMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useClonedMeshMap",
                    value
                );
            }
        }

        
        public bool @virtual
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "virtual"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "virtual",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SceneOptionsCachedEntity() : base() { }

        public SceneOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}