#nullable enable

namespace Nomic.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEmbeddingRequestTaskTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nomic.TextEmbeddingRequestTaskType>
    {
        /// <inheritdoc />
        public override global::Nomic.TextEmbeddingRequestTaskType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Nomic.TextEmbeddingRequestTaskTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nomic.TextEmbeddingRequestTaskType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nomic.TextEmbeddingRequestTaskType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nomic.TextEmbeddingRequestTaskType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Nomic.TextEmbeddingRequestTaskTypeExtensions.ToValueString(value));
        }
    }
}
