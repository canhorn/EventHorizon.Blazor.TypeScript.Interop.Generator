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

    public interface IFontData : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IFontDataCachedEntity>))]
    public class IFontDataCachedEntity : CachedEntityObject, IFontData
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

        public decimal resolution
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "resolution"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "resolution", value);
            }
        }

        public decimal underlineThickness
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "underlineThickness");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "underlineThickness", value);
            }
        }

        public CachedEntity boundingBox
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "boundingBox",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "boundingBox", value);
            }
        }

        public CachedEntity glyphs
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "glyphs",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "glyphs", value);
            }
        }
        #endregion

        #region Constructor
        public IFontDataCachedEntity()
            : base() { }

        public IFontDataCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
