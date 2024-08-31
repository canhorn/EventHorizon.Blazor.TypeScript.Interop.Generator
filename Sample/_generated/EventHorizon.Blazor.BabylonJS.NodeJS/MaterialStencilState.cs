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

    [JsonConverter(typeof(CachedEntityConverter<MaterialStencilState>))]
    public class MaterialStencilState : CachedEntityObject, IStencilState
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

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

        #endregion

        #region Constructor
        public MaterialStencilState()
            : base() { }

        public MaterialStencilState(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void copyTo(MaterialStencilState stencilState)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyTo" }, stencilState }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public void parse(object source, Scene scene, string rootUrl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, source, scene, rootUrl }
            );
        }
        #endregion
    }
}
