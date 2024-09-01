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

    public interface IStencilState : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IStencilStateCachedEntity>))]
    public class IStencilStateCachedEntity : CachedEntityObject, IStencilState
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

        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled");
        }

        public ValueTask set_enabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
        }

        public async ValueTask<decimal> get_mask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mask");
        }

        public ValueTask set_mask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
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

        public async ValueTask<decimal> get_opStencilDepthPass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opStencilDepthPass");
        }

        public ValueTask set_opStencilDepthPass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "opStencilDepthPass", value);
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
        #endregion

        #region Constructor
        public IStencilStateCachedEntity()
            : base() { }

        public IStencilStateCachedEntity(ICachedEntity entity)
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
