/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<StencilState>))]
    public class StencilState : CachedEntityObject, IStencilState
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_ALWAYS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.ALWAYS");
        }

        public static async ValueTask<decimal> get_KEEP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.KEEP");
        }

        public static async ValueTask<decimal> get_REPLACE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.REPLACE");
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<decimal> get_stencilFunc()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFunc");
        }

        public ValueTask set_stencilFunc(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilFunc", value);
        }

        public async ValueTask<decimal> get_stencilFuncRef()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFuncRef");
        }

        public ValueTask set_stencilFuncRef(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilFuncRef", value);
        }

        public async ValueTask<decimal> get_stencilFuncMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFuncMask");
        }

        public ValueTask set_stencilFuncMask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilFuncMask", value);
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
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilOpStencilFail", value);
        }

        public async ValueTask<decimal> get_stencilOpDepthFail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilOpDepthFail");
        }

        public ValueTask set_stencilOpDepthFail(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilOpDepthFail", value);
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
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilOpStencilDepthPass", value);
        }

        public async ValueTask<decimal> get_stencilMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilMask");
        }

        public ValueTask set_stencilMask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilMask", value);
        }

        public async ValueTask<bool> get_stencilTest()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "stencilTest");
        }

        public ValueTask set_stencilTest(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilTest", value);
        }
        #endregion

        #region Properties

        public async ValueTask<decimal> get_func()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "func");
        }

        public ValueTask set_func(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "func", value);
        }

        public async ValueTask<decimal> get_funcRef()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "funcRef");
        }

        public ValueTask set_funcRef(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "funcRef", value);
        }

        public async ValueTask<decimal> get_funcMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "funcMask");
        }

        public ValueTask set_funcMask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "funcMask", value);
        }

        public async ValueTask<decimal> get_opStencilFail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opStencilFail");
        }

        public ValueTask set_opStencilFail(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "opStencilFail", value);
        }

        public async ValueTask<decimal> get_opDepthFail()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opDepthFail");
        }

        public ValueTask set_opDepthFail(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "opDepthFail", value);
        }

        public async ValueTask<decimal> get_opStencilDepthPass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opStencilDepthPass");
        }

        public ValueTask set_opStencilDepthPass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "opStencilDepthPass", value);
        }

        public async ValueTask<decimal> get_mask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mask");
        }

        public ValueTask set_mask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
        }

        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled");
        }

        public ValueTask set_enabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
        }
        #endregion

        #region Constructor
        public StencilState()
            : base() { }

        public StencilState(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
