/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<CachedEntity[]> get_colorStops()
        {
            return await EventHorizonBlazorInterop.GetArray<CachedEntity>(
                this.___guid,
                "colorStops"
            );
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
        public async ValueTask<CanvasGradient> getCanvasGradient(ICanvasRenderingContext context)
        {
            return await EventHorizonBlazorInterop.FuncClass<CanvasGradient>(
                entity => new CanvasGradient() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getCanvasGradient" }, context }
            );
        }

        public async ValueTask addColorStop(decimal offset, string color)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addColorStop" }, offset, color }
            );
        }

        public async ValueTask removeColorStop(decimal offset)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeColorStop" }, offset }
            );
        }

        public async ValueTask clearColorStops()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearColorStops" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask serialize(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializationObject }
            );
        }

        public async ValueTask parse(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, serializationObject }
            );
        }
        #endregion
    }
}
