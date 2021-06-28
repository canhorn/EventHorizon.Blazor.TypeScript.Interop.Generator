/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector2WithInfo>))]
    public class Vector2WithInfo : Vector2
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
        
        public decimal buttonIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buttonIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buttonIndex",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Vector2WithInfo() : base() { }

        public Vector2WithInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Vector2WithInfo(
            Vector2 source, System.Nullable<decimal> buttonIndex = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Vector2WithInfo" },
                source, buttonIndex
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}