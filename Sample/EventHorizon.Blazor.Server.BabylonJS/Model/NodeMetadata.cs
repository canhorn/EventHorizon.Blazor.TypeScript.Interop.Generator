namespace EventHorizon.Blazor.Server.BabylonJS.Model
{
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;

    [JsonConverter(typeof(CachedEntityConverter<NodeMetadata>))]
    public class NodeMetadata
        : CachedEntityObject
    {
        public NodeMetadata()
        {

        }
        public NodeMetadata(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<NodeMetadata> NewNodeMetadata()
        {
            var entity = await EventHorizonBlazorInterop.New(
                new object[]
                {
                    new string[] { "NodeMetadata" }
                }
            );

            return new NodeMetadata(entity);
        }

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "name"
            );
        }
        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "name",
                value
            );
        }
    }
}
