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

    [JsonConverter(typeof(CachedEntityConverter<StencilState>))]
    public class StencilState : CachedEntityObject, IStencilState
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal ALWAYS
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.ALWAYS"); }
        }

        public static decimal KEEP
        {
            get { return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.KEEP"); }
        }

        public static decimal REPLACE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "StencilState.REPLACE");
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public decimal stencilFunc
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFunc"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilFunc", value);
            }
        }

        public decimal stencilFuncRef
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFuncRef"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilFuncRef", value);
            }
        }

        public decimal stencilFuncMask
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilFuncMask"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilFuncMask", value);
            }
        }

        public decimal stencilOpStencilFail
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilOpStencilFail");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilOpStencilFail", value);
            }
        }

        public decimal stencilOpDepthFail
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilOpDepthFail");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilOpDepthFail", value);
            }
        }

        public decimal stencilOpStencilDepthPass
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stencilOpStencilDepthPass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilOpStencilDepthPass", value);
            }
        }

        public decimal stencilMask
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stencilMask"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilMask", value);
            }
        }

        public bool stencilTest
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "stencilTest"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stencilTest", value);
            }
        }
        #endregion

        #region Properties

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

        #region Constructor
        public StencilState()
            : base() { }

        public StencilState(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
