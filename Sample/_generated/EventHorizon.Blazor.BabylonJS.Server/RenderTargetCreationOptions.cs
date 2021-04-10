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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RenderTargetCreationOptions>))]
    public class RenderTargetCreationOptions : CachedEntityObject
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
        
        public async ValueTask<bool> get_generateMipMaps()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateMipMaps"
                );
        }
        public ValueTask set_generateMipMaps(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateMipMaps",
                    value
                );
        }

        
        public async ValueTask<bool> get_generateDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateDepthBuffer"
                );
        }
        public ValueTask set_generateDepthBuffer(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateDepthBuffer",
                    value
                );
        }

        
        public async ValueTask<bool> get_generateStencilBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateStencilBuffer"
                );
        }
        public ValueTask set_generateStencilBuffer(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateStencilBuffer",
                    value
                );
        }

        
        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
        }
        public ValueTask set_type(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
        }

        
        public async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samplingMode"
                );
        }
        public ValueTask set_samplingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samplingMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_format()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "format"
                );
        }
        public ValueTask set_format(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public RenderTargetCreationOptions() : base() { } 

        public RenderTargetCreationOptions(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}