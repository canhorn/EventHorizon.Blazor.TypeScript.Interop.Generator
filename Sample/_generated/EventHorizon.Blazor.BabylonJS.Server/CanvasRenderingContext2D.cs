/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        
        public async ValueTask<bool> get_msImageSmoothingEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "msImageSmoothingEnabled"
                );
        }
        public ValueTask set_msImageSmoothingEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msImageSmoothingEnabled",
                    value
                );
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