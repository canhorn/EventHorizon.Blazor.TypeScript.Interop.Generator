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

        public bool enabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
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
        #endregion

        #region Constructor
        public IStencilStateCachedEntity()
            : base() { }

        public IStencilStateCachedEntity(ICachedEntity entity)
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
