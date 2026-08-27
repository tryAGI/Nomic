
#nullable enable

namespace Nomic
{
    /// <summary>
    /// The model to use for embedding.<br/>
    /// Default Value: nomic-embed-text-v1.5
    /// </summary>
    public enum TextEmbeddingRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        NomicEmbedTextV1,
        /// <summary>
        ///
        /// </summary>
        NomicEmbedTextV15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingRequestModel value)
        {
            return value switch
            {
                TextEmbeddingRequestModel.NomicEmbedTextV1 => "nomic-embed-text-v1",
                TextEmbeddingRequestModel.NomicEmbedTextV15 => "nomic-embed-text-v1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "nomic-embed-text-v1" => TextEmbeddingRequestModel.NomicEmbedTextV1,
                "nomic-embed-text-v1.5" => TextEmbeddingRequestModel.NomicEmbedTextV15,
                _ => null,
            };
        }
    }
}