namespace EventHorizon.Blazor.Server.BabylonJS.Model;

using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;

[JsonConverter(typeof(CachedEntityConverter<ClientObject>))]
public class ClientObject : CachedEntityObject
{
    public ClientObject() { }

    public ClientObject(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    public static async ValueTask<NodeMetadata> NewClientObject(object data)
    {
        var entity = await EventHorizonBlazorInterop.New(
            new object[] { new string[] { "ClientObject" } },
            data
        );

        return new NodeMetadata(entity);
    }
}
