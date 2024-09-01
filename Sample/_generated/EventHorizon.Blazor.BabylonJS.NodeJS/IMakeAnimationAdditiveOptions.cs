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

        public decimal referenceFrame
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "referenceFrame"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "referenceFrame", value);
            }
        }

        public string range
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "range"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "range", value);
            }
        }

        public bool cloneOriginalAnimation
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "cloneOriginalAnimation");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cloneOriginalAnimation", value);
            }
        }

        public string clonedAnimationName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(this.___guid, "clonedAnimationName");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clonedAnimationName", value);
            }
        }

        public decimal fromFrame
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fromFrame"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fromFrame", value);
            }
        }

        public decimal toFrame
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "toFrame"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "toFrame", value);
            }
        }

        public bool clipKeys
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipKeys"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clipKeys", value);
            }
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
