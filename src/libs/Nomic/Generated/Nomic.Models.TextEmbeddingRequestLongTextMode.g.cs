
#nullable enable

namespace Nomic
{
    /// <summary>
    /// How to handle texts longer than the model can accept. truncate cuts at the max token length. mean averages embeddings of chunks.<br/>
    /// Default Value: truncate
    /// </summary>
    public enum TextEmbeddingRequestLongTextMode
    {
        /// <summary>
        /// 
        /// </summary>
        Mean,
        /// <summary>
        /// 
        /// </summary>
        Truncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingRequestLongTextModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingRequestLongTextMode value)
        {
            return value switch
            {
                TextEmbeddingRequestLongTextMode.Mean => "mean",
                TextEmbeddingRequestLongTextMode.Truncate => "truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingRequestLongTextMode? ToEnum(string value)
        {
            return value switch
            {
                "mean" => TextEmbeddingRequestLongTextMode.Mean,
                "truncate" => TextEmbeddingRequestLongTextMode.Truncate,
                _ => null,
            };
        }
    }
}