/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface CanvasRenderingContext2D : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<CanvasRenderingContext2DCachedEntity>))]
public class CanvasRenderingContext2DCachedEntity : CachedEntityObject, CanvasRenderingContext2D
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
        
        public bool msImageSmoothingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "msImageSmoothingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msImageSmoothingEnabled",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public CanvasRenderingContext2DCachedEntity() : base() { }

        public CanvasRenderingContext2DCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
