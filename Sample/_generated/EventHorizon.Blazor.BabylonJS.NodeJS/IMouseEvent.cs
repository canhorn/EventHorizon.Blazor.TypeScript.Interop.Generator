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

    public interface IMouseEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMouseEventCachedEntity>))]
    public class IMouseEventCachedEntity : CachedEntityObject, IMouseEvent
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

        public int inputIndex
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "inputIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "inputIndex", value);
            }
        }

        public bool altKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "altKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "altKey", value);
            }
        }

        public decimal button
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "button"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "button", value);
            }
        }

        public decimal buttons
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "buttons"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "buttons", value);
            }
        }

        public decimal clientX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "clientX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clientX", value);
            }
        }

        public decimal clientY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "clientY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clientY", value);
            }
        }

        public bool ctrlKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "ctrlKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "ctrlKey", value);
            }
        }

        public decimal detail
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "detail"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "detail", value);
            }
        }

        public bool metaKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "metaKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "metaKey", value);
            }
        }

        public decimal movementX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "movementX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "movementX", value);
            }
        }

        public decimal movementY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "movementY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "movementY", value);
            }
        }

        public decimal mozMovementX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mozMovementX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mozMovementX", value);
            }
        }

        public decimal mozMovementY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mozMovementY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mozMovementY", value);
            }
        }

        public decimal msMovementX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "msMovementX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "msMovementX", value);
            }
        }

        public decimal msMovementY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "msMovementY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "msMovementY", value);
            }
        }

        public decimal offsetX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offsetX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "offsetX", value);
            }
        }

        public decimal offsetY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offsetY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "offsetY", value);
            }
        }

        public decimal pageX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pageX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pageX", value);
            }
        }

        public decimal pageY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pageY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pageY", value);
            }
        }

        public bool shiftKey
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "shiftKey"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shiftKey", value);
            }
        }

        public decimal webkitMovementX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webkitMovementX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "webkitMovementX", value);
            }
        }

        public decimal webkitMovementY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "webkitMovementY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "webkitMovementY", value);
            }
        }

        public decimal x
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "x"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "x", value);
            }
        }

        public decimal y
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "y"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "y", value);
            }
        }
        #endregion

        #region Constructor
        public IMouseEventCachedEntity()
            : base() { }

        public IMouseEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
