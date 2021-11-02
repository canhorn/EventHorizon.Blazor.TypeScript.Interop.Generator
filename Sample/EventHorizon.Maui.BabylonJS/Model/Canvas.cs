namespace EventHorizon.Maui.BabylonJS.Model
{
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using Microsoft.Maui.Controls;

    [JsonConverter(typeof(CachedEntityConverter<Canvas>))]
    public class Canvas : HTMLCanvasElementCachedEntity
    {
        public static async ValueTask<Canvas> GetElementById(
            string elementId
        ) => await EventHorizonBlazorInterop.FuncClass(
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

        public static async Task RemoveBlur(
            string elementId
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "removeBlur" }, elementId
                }
            );
        }
    }
}
