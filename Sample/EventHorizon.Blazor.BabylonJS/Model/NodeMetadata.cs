namespace EventHorizon.Blazor.BabylonJS.Model;

using System.Text.Json.Serialization;
using EventHorizon.Blazor.Interop;

[JsonConverter(typeof(CachedEntityConverter<NodeMetadata>))]
public class NodeMetadata : CachedEntity
{
    public NodeMetadata()
    {
        var entity = EventHorizonBlazorInterop.New(
            new object[] { new string[] { "NodeMetadata" } }
        );
        ___guid = entity.___guid;
    }

    public string name
    {
        get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
        set { EventHorizonBlazorInterop.Set(this.___guid, "name", value); }
    }
}
