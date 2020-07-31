/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneLoaderProgressEvent>))]
    public class SceneLoaderProgressEvent : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static SceneLoaderProgressEvent FromProgressEvent(ProgressEvent @event)
        {
            return EventHorizonBlazorInterop.FuncClass<SceneLoaderProgressEvent>(
                entity => new SceneLoaderProgressEvent() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoaderProgressEvent", "FromProgressEvent" }, @event
                }
            );
        }
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
        public SceneLoaderProgressEvent() : base() { } 

        public SceneLoaderProgressEvent(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SceneLoaderProgressEvent(
            bool lengthComputable, decimal loaded, decimal total
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SceneLoaderProgressEvent" },
                lengthComputable, loaded, total
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}