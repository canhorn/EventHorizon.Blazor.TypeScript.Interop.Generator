using System.Text.Json.Serialization;

namespace EventHorizon.Blazor.Interop
{
    [JsonConverter(typeof(CachedEntityConverter))]
    public class CachedEntity : ICachedEntity
    {
        public string ___guid { get; set; }
    }
}
