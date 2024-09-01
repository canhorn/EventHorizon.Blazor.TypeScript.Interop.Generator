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

        public bool applySkeleton
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "applySkeleton"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "applySkeleton", value);
            }
        }

        public bool applyMorph
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "applyMorph"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "applyMorph", value);
            }
        }

        public bool updatePositionsArray
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "updatePositionsArray");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "updatePositionsArray", value);
            }
        }

        private IMeshDataCacheCachedEntity __cache;
        public IMeshDataCacheCachedEntity cache
        {
            get
            {
                if (__cache == null)
                {
                    __cache = EventHorizonBlazorInterop.GetClass<IMeshDataCacheCachedEntity>(
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
            set
            {
                __cache = null;
                EventHorizonBlazorInterop.Set(this.___guid, "cache", value);
            }
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
