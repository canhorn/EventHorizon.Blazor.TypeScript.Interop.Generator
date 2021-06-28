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

    public interface CameraInputsMap<TCamera> : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<CameraInputsMapCachedEntity<CachedEntity>>))]
    public class CameraInputsMapCachedEntity<TCamera> : CachedEntityObject, CameraInputsMap<TCamera> where TCamera : CachedEntity, new()
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

        #endregion
        
        #region Constructor
        public CameraInputsMapCachedEntity() : base() { }

        public CameraInputsMapCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}