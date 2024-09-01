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

    public interface IDrawContext : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IDrawContextCachedEntity>))]
    public class IDrawContextCachedEntity : CachedEntityObject, IDrawContext
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

        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
            }
        }

        public bool useInstancing
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useInstancing"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useInstancing", value);
            }
        }
        #endregion

        #region Constructor
        public IDrawContextCachedEntity()
            : base() { }

        public IDrawContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
