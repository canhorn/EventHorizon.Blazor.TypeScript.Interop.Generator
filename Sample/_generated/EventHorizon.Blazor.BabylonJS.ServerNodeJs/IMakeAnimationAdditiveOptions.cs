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

    public interface IMakeAnimationAdditiveOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMakeAnimationAdditiveOptionsCachedEntity>))]
    public class IMakeAnimationAdditiveOptionsCachedEntity
        : CachedEntityObject,
            IMakeAnimationAdditiveOptions
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

        public async ValueTask<decimal> get_referenceFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "referenceFrame");
        }

        public ValueTask set_referenceFrame(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "referenceFrame", value);
        }

        public async ValueTask<string> get_range()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "range");
        }

        public ValueTask set_range(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "range", value);
        }

        public async ValueTask<bool> get_cloneOriginalAnimation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "cloneOriginalAnimation"
            );
        }

        public ValueTask set_cloneOriginalAnimation(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "cloneOriginalAnimation", value);
        }

        public async ValueTask<string> get_clonedAnimationName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "clonedAnimationName");
        }

        public ValueTask set_clonedAnimationName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clonedAnimationName", value);
        }

        public async ValueTask<decimal> get_fromFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fromFrame");
        }

        public ValueTask set_fromFrame(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fromFrame", value);
        }

        public async ValueTask<decimal> get_toFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "toFrame");
        }

        public ValueTask set_toFrame(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "toFrame", value);
        }

        public async ValueTask<bool> get_clipKeys()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipKeys");
        }

        public ValueTask set_clipKeys(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clipKeys", value);
        }
        #endregion

        #region Constructor
        public IMakeAnimationAdditiveOptionsCachedEntity()
            : base() { }

        public IMakeAnimationAdditiveOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
