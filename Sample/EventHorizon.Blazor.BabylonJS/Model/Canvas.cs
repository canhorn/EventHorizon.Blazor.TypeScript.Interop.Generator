using System.Text.Json.Serialization;
using BABYLON;
using EventHorizon.Blazor.Interop;

namespace EventHorizon.Blazor.BabylonJS.Model
{
    [JsonConverter(typeof(CachedEntityConverter<Canvas>))]
    public class Canvas : HTMLCanvasElementCachedEntity
    {
        public static Canvas GetElementById(string elementId) =>
            EventHorizonBlazorInterop.FuncClass(
                entity => new Canvas(entity),
                new string[] { "document", "getElementById" },
                elementId
            );

        private Canvas(ICachedEntity entity)
        {
            ___guid = entity.___guid;
        }
    }
}
