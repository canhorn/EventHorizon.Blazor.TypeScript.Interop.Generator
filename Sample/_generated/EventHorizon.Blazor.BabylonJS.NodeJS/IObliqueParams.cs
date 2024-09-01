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

    public interface IObliqueParams : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IObliqueParamsCachedEntity>))]
    public class IObliqueParamsCachedEntity : CachedEntityObject, IObliqueParams
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

        public decimal angle
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "angle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "angle", value);
            }
        }

        public decimal length
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "length"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "length", value);
            }
        }

        public decimal offset
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "offset"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "offset", value);
            }
        }
        #endregion

        #region Constructor
        public IObliqueParamsCachedEntity()
            : base() { }

        public IObliqueParamsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
