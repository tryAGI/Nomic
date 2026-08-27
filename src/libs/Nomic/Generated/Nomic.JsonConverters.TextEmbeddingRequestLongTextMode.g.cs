#nullable enable

namespace Nomic.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEmbeddingRequestLongTextModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nomic.TextEmbeddingRequestLongTextMode>
    {
        /// <inheritdoc />
        public override global::Nomic.TextEmbeddingRequestLongTextMode Read(
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
                        return global::Nomic.TextEmbeddingRequestLongTextModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nomic.TextEmbeddingRequestLongTextMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nomic.TextEmbeddingRequestLongTextMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nomic.TextEmbeddingRequestLongTextMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Nomic.TextEmbeddingRequestLongTextModeExtensions.ToValueString(value));
        }
    }
}
