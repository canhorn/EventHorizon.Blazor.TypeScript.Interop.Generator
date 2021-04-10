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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AlphaState>))]
    public class AlphaState : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isDirty()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
        }

        
        public async ValueTask<bool> get_alphaBlend()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alphaBlend"
                );
        }
        public ValueTask set_alphaBlend(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBlend",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public AlphaState() : base() { } 

        public AlphaState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask setAlphaBlendConstants(decimal r, decimal g, decimal b, decimal a)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAlphaBlendConstants" }, r, g, b, a
                }
            );
        }

        public async ValueTask setAlphaBlendFunctionParameters(decimal value0, decimal value1, decimal value2, decimal value3)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAlphaBlendFunctionParameters" }, value0, value1, value2, value3
                }
            );
        }

        public async ValueTask setAlphaEquationParameters(decimal rgb, decimal alpha)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAlphaEquationParameters" }, rgb, alpha
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask apply(WebGLRenderingContext gl)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "apply" }, gl
                }
            );
        }
        #endregion
    }
}