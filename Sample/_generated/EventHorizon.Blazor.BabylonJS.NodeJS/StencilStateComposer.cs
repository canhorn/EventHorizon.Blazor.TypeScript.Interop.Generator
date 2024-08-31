/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
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

        public bool isDirty
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDirty"); }
        }

        public decimal func
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "func"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "func", value);
            }
        }

        public decimal funcRef
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "funcRef"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "funcRef", value);
            }
        }

        public decimal funcMask
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "funcMask"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "funcMask", value);
            }
        }

        public decimal opStencilFail
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opStencilFail"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "opStencilFail", value);
            }
        }

        public decimal opDepthFail
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opDepthFail"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "opDepthFail", value);
            }
        }

        public decimal opStencilDepthPass
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "opStencilDepthPass");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "opStencilDepthPass", value);
            }
        }

        public decimal mask
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mask"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
            }
        }

        public bool enabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
            }
        }
        #endregion

        #region Properties
        private IStencilStateCachedEntity __stencilGlobal;
        public IStencilStateCachedEntity stencilGlobal
        {
            get
            {
                if (__stencilGlobal == null)
                {
                    __stencilGlobal = EventHorizonBlazorInterop.GetClass<IStencilStateCachedEntity>(
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
            set
            {
                __stencilGlobal = null;
                EventHorizonBlazorInterop.Set(this.___guid, "stencilGlobal", value);
            }
        }

        private IStencilStateCachedEntity __stencilMaterial;
        public IStencilStateCachedEntity stencilMaterial
        {
            get
            {
                if (__stencilMaterial == null)
                {
                    __stencilMaterial =
                        EventHorizonBlazorInterop.GetClass<IStencilStateCachedEntity>(
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
            set
            {
                __stencilMaterial = null;
                EventHorizonBlazorInterop.Set(this.___guid, "stencilMaterial", value);
            }
        }

        public bool useStencilGlobalOnly
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useStencilGlobalOnly");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useStencilGlobalOnly", value);
            }
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

        public StencilStateComposer(System.Nullable<bool> reset = null)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "StencilStateComposer" },
                reset
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public void apply(WebGLRenderingContext gl = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "apply" }, gl }
            );
        }
        #endregion
    }
}
