#nullable enable

namespace Nomic.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEmbeddingRequestModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Nomic.TextEmbeddingRequestModel>
    {
        /// <inheritdoc />
        public override global::Nomic.TextEmbeddingRequestModel Read(
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
                        return global::Nomic.TextEmbeddingRequestModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Nomic.TextEmbeddingRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Nomic.TextEmbeddingRequestModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Nomic.TextEmbeddingRequestModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Nomic.TextEmbeddingRequestModelExtensions.ToValueString(value));
        }
    }
}
