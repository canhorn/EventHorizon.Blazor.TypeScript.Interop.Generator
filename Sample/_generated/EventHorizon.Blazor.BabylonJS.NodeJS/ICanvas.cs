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

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "width", value);
            }
        }

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "height", value);
            }
        }
        #endregion

        #region Constructor
        public ICanvasCachedEntity()
            : base() { }

        public ICanvasCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public ICanvasRenderingContextCachedEntity getContext(
            string contextType,
            object contextAttributes = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ICanvasRenderingContextCachedEntity>(
                entity => new ICanvasRenderingContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" },
                    contextType,
                    contextAttributes
                }
            );
        }

        public string toDataURL(string mime)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toDataURL" }, mime }
            );
        }

        public void remove()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "remove" } }
            );
        }
        #endregion
    }
}
