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

    [JsonConverter(typeof(CachedEntityConverter<StencilStateComposer>))]
    public class StencilStateComposer : CachedEntityObject
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
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDirty");
        }

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

        #region Properties
        private IStencilStateCachedEntity __stencilGlobal;

        public async ValueTask<IStencilStateCachedEntity> get_stencilGlobal()
        {
            if (__stencilGlobal == null)
            {
                __stencilGlobal =
                    await EventHorizonBlazorInterop.GetClass<IStencilStateCachedEntity>(
                        this.___guid,
                        "stencilGlobal",
                        (entity) =>
                        {
                            return new IStencilStateCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __stencilGlobal;
        }

        public ValueTask set_stencilGlobal(IStencilStateCachedEntity value)
        {
            __stencilGlobal = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilGlobal", value);
        }

        private IStencilStateCachedEntity __stencilMaterial;

        public async ValueTask<IStencilStateCachedEntity> get_stencilMaterial()
        {
            if (__stencilMaterial == null)
            {
                __stencilMaterial =
                    await EventHorizonBlazorInterop.GetClass<IStencilStateCachedEntity>(
                        this.___guid,
                        "stencilMaterial",
                        (entity) =>
                        {
                            return new IStencilStateCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __stencilMaterial;
        }

        public ValueTask set_stencilMaterial(IStencilStateCachedEntity value)
        {
            __stencilMaterial = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "stencilMaterial", value);
        }

        public async ValueTask<bool> get_useStencilGlobalOnly()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useStencilGlobalOnly");
        }

        public ValueTask set_useStencilGlobalOnly(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useStencilGlobalOnly", value);
        }
        #endregion

        #region Constructor
        public StencilStateComposer()
            : base() { }

        public StencilStateComposer(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<StencilStateComposer> NewStencilStateComposer(
            System.Nullable<bool> reset = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "StencilStateComposer" },
                reset
            );

            return new StencilStateComposer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public async ValueTask apply(WebGLRenderingContext gl = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "apply" }, gl }
            );
        }
        #endregion
    }
}
