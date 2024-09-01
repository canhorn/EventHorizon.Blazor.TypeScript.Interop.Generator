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

    public interface ICanvas : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ICanvasCachedEntity>))]
    public class ICanvasCachedEntity : CachedEntityObject, ICanvas
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

        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width");
        }

        public ValueTask set_width(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "width", value);
        }

        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height");
        }

        public ValueTask set_height(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "height", value);
        }
        #endregion

        #region Constructor
        public ICanvasCachedEntity()
            : base() { }

        public ICanvasCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<ICanvasRenderingContextCachedEntity> getContext(
            string contextType,
            object contextAttributes = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ICanvasRenderingContextCachedEntity>(
                entity => new ICanvasRenderingContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" },
                    contextType,
                    contextAttributes
                }
            );
        }

        public async ValueTask<string> toDataURL(string mime)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toDataURL" }, mime }
            );
        }

        public async ValueTask remove()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "remove" } }
            );
        }
        #endregion
    }
}
