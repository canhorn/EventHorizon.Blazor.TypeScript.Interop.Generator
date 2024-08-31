/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<BaseGradient>))]
    public class BaseGradient : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public CachedEntity[] colorStops
        {
            get
            {
                return EventHorizonBlazorInterop.GetArray<CachedEntity>(this.___guid, "colorStops");
            }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public BaseGradient()
            : base() { }

        public BaseGradient(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods
        public CanvasGradient getCanvasGradient(ICanvasRenderingContext context)
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasGradient>(
                entity => new CanvasGradient() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCanvasGradient" }, context }
            );
        }

        public void addColorStop(decimal offset, string color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColorStop" }, offset, color }
            );
        }

        public void removeColorStop(decimal offset)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeColorStop" }, offset }
            );
        }

        public void clearColorStops()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearColorStops" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void serialize(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializationObject }
            );
        }

        public void parse(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, serializationObject }
            );
        }
        #endregion
    }
}
