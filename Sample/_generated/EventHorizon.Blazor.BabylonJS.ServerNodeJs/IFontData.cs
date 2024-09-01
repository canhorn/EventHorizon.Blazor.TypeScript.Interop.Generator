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

        public async ValueTask<decimal> get_resolution()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "resolution");
        }

        public ValueTask set_resolution(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "resolution", value);
        }

        public async ValueTask<decimal> get_underlineThickness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "underlineThickness");
        }

        public ValueTask set_underlineThickness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "underlineThickness", value);
        }

        public async ValueTask<CachedEntity> get_boundingBox()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "boundingBox",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_boundingBox(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "boundingBox", value);
        }

        public async ValueTask<CachedEntity> get_glyphs()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "glyphs",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_glyphs(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "glyphs", value);
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
