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

    public interface IMeshDataOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMeshDataOptionsCachedEntity>))]
    public class IMeshDataOptionsCachedEntity : CachedEntityObject, IMeshDataOptions
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

        public async ValueTask<bool> get_applySkeleton()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "applySkeleton");
        }

        public ValueTask set_applySkeleton(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "applySkeleton", value);
        }

        public async ValueTask<bool> get_applyMorph()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "applyMorph");
        }

        public ValueTask set_applyMorph(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "applyMorph", value);
        }

        public async ValueTask<bool> get_updatePositionsArray()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "updatePositionsArray");
        }

        public ValueTask set_updatePositionsArray(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "updatePositionsArray", value);
        }

        private IMeshDataCacheCachedEntity __cache;

        public async ValueTask<IMeshDataCacheCachedEntity> get_cache()
        {
            if (__cache == null)
            {
                __cache = await EventHorizonBlazorInterop.GetClass<IMeshDataCacheCachedEntity>(
                    this.___guid,
                    "cache",
                    (entity) =>
                    {
                        return new IMeshDataCacheCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __cache;
        }

        public ValueTask set_cache(IMeshDataCacheCachedEntity value)
        {
            __cache = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "cache", value);
        }
        #endregion

        #region Constructor
        public IMeshDataOptionsCachedEntity()
            : base() { }

        public IMeshDataOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
