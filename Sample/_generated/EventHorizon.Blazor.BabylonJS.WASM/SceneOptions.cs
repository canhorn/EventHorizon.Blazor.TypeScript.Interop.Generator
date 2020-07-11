/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface SceneOptions { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useGeometryUniqueIdsMap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useClonedMeshMap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "virtual"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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