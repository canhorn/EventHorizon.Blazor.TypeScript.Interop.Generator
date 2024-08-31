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

        public async ValueTask<int> get_inputIndex()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "inputIndex");
        }

        public ValueTask set_inputIndex(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "inputIndex", value);
        }

        public async ValueTask<decimal> get_pointerId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerId");
        }

        public ValueTask set_pointerId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pointerId", value);
        }

        public async ValueTask<string> get_pointerType()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "pointerType");
        }

        public ValueTask set_pointerType(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pointerType", value);
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
