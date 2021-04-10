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

    
    
    [JsonConverter(typeof(CachedEntityConverter<StencilState>))]
    public class StencilState : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_ALWAYS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "StencilState.ALWAYS"
                );
        }

        
        public static async ValueTask<decimal> get_KEEP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "StencilState.KEEP"
                );
        }

        
        public static async ValueTask<decimal> get_REPLACE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "StencilState.REPLACE"
                );
        }
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

        
        public async ValueTask<decimal> get_stencilFunc()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilFunc"
                );
        }
        public ValueTask set_stencilFunc(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilFunc",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilFuncRef()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilFuncRef"
                );
        }
        public ValueTask set_stencilFuncRef(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilFuncRef",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilFuncMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilFuncMask"
                );
        }
        public ValueTask set_stencilFuncMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilFuncMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilOpStencilFail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilOpStencilFail"
                );
        }
        public ValueTask set_stencilOpStencilFail(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilOpStencilFail",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilOpDepthFail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilOpDepthFail"
                );
        }
        public ValueTask set_stencilOpDepthFail(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilOpDepthFail",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilOpStencilDepthPass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilOpStencilDepthPass"
                );
        }
        public ValueTask set_stencilOpStencilDepthPass(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilOpStencilDepthPass",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stencilMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilMask"
                );
        }
        public ValueTask set_stencilMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilMask",
                    value
                );
        }

        
        public async ValueTask<bool> get_stencilTest()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencilTest"
                );
        }
        public ValueTask set_stencilTest(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencilTest",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public StencilState() : base() { } 

        public StencilState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
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