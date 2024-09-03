namespace EventHorizon.Blazor.BabylonJS.Model;

using System.Text.Json.Serialization;
using EventHorizon.Blazor.Interop;

[JsonConverter(typeof(CachedEntityConverter<ClientObject>))]
public class ClientObject : CachedEntityObject
{
    public ClientObject(object data)
    {
        var entity = EventHorizonBlazorInterop.New(
            new object[] { new string[] { "ClientObject" } },
            data
        );
        ___guid = entity.___guid;
    }
}
