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

    public interface IPointerEvent : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPointerEventCachedEntity>))]
    public class IPointerEventCachedEntity : CachedEntityObject, IPointerEvent
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

        public decimal pointerId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pointerId", value);
            }
        }

        public string pointerType
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "pointerType"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pointerType", value);
            }
        }
        #endregion

        #region Constructor
        public IPointerEventCachedEntity()
            : base() { }

        public IPointerEventCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
