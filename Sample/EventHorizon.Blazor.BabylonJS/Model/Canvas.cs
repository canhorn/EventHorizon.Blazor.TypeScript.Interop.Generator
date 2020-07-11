using System.Text.Json.Serialization;
using EventHorizon.Blazor.Interop;

namespace EventHorizon.Blazor.BabylonJS.Model
{
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Canvas : CachedEntity
    {
        public static Canvas GetElementById(
            string elementId
        ) => EventHorizonBlazorInteropt.FuncClass(
            entity => new Canvas(entity),
            new string[] { "document", "getElementById" },
            elementId
        );

        private Canvas(
            ICachedEntity entity
        )
        {
            ___guid = entity.___guid;
        }
    }
}
