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

    public interface IMaterialContext : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMaterialContextCachedEntity>))]
    public class IMaterialContextCachedEntity : CachedEntityObject, IMaterialContext
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

        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public ValueTask set_uniqueId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
        }
        #endregion

        #region Constructor
        public IMaterialContextCachedEntity()
            : base() { }

        public IMaterialContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }
        #endregion
    }
}
