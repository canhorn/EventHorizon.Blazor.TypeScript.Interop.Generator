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

    public interface ISceneLoaderProgressEvent : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISceneLoaderProgressEventCachedEntity>))]
    public class ISceneLoaderProgressEventCachedEntity : CachedEntityObject, ISceneLoaderProgressEvent
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
        
        public bool lengthComputable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lengthComputable"
                );
            }
        }

        
        public decimal loaded
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loaded"
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
        }
        #endregion
        
        #region Constructor
        public ISceneLoaderProgressEventCachedEntity() : base() { }

        public ISceneLoaderProgressEventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}