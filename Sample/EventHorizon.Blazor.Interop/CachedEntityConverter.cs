using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EventHorizon.Blazor.Interop
{
    public class CachedEntityConverter
        : JsonConverter<CachedEntity>
    {
        public override bool CanConvert(Type typeToConvert) =>
            typeof(CachedEntity).IsAssignableFrom(typeToConvert);

        public override CachedEntity Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            //var entity = new CachedEntity();
            var entity = (CachedEntity)Activator.CreateInstance(typeToConvert);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return entity;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "___guid":
                            entity.___guid = reader.GetString();
                            break;
                    }
                }
            }
            throw new JsonException("___guid was not found");
        }

        public override void Write(Utf8JsonWriter writer, CachedEntity value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("___guid", value.___guid);

            writer.WriteEndObject();
        }
    }
}