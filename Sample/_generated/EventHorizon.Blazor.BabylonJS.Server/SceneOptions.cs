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
        
        public async ValueTask<bool> get_useGeometryUniqueIdsMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGeometryUniqueIdsMap"
                );
        }
        public ValueTask set_useGeometryUniqueIdsMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useGeometryUniqueIdsMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useMaterialMeshMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
        }
        public ValueTask set_useMaterialMeshMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useMaterialMeshMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useClonedMeshMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useClonedMeshMap"
                );
        }
        public ValueTask set_useClonedMeshMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useClonedMeshMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_virtual()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "virtual"
                );
        }
        public ValueTask set_virtual(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "virtual",
                    value
                );
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