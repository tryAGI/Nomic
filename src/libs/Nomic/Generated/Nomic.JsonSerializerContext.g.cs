
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Nomic
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestModelJsonConverter),

            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestTaskTypeJsonConverter),

            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestTaskTypeNullableJsonConverter),

            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestLongTextModeJsonConverter),

            typeof(global::Nomic.JsonConverters.TextEmbeddingRequestLongTextModeNullableJsonConverter),

            typeof(global::Nomic.JsonConverters.ImageEmbeddingRequestModelJsonConverter),

            typeof(global::Nomic.JsonConverters.ImageEmbeddingRequestModelNullableJsonConverter),

            typeof(global::Nomic.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Nomic.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.TextEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.TextEmbeddingRequestModel), TypeInfoPropertyName = "TextEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.TextEmbeddingRequestTaskType), TypeInfoPropertyName = "TextEmbeddingRequestTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.TextEmbeddingRequestLongTextMode), TypeInfoPropertyName = "TextEmbeddingRequestLongTextMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.ImageEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.ImageEmbeddingRequestModel), TypeInfoPropertyName = "ImageEmbeddingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nomic.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.ValidationErrorDetailItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Nomic.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Nomic.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nomic.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Nomic.OneOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}