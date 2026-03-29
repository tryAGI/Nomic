
#nullable enable

namespace Nomic
{
    /// <summary>
    /// The model to use for image embedding.<br/>
    /// Default Value: nomic-embed-vision-v1.5
    /// </summary>
    public enum ImageEmbeddingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        NomicEmbedVisionV1,
        /// <summary>
        /// 
        /// </summary>
        NomicEmbedVisionV15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEmbeddingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEmbeddingRequestModel value)
        {
            return value switch
            {
                ImageEmbeddingRequestModel.NomicEmbedVisionV1 => "nomic-embed-vision-v1",
                ImageEmbeddingRequestModel.NomicEmbedVisionV15 => "nomic-embed-vision-v1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEmbeddingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "nomic-embed-vision-v1" => ImageEmbeddingRequestModel.NomicEmbedVisionV1,
                "nomic-embed-vision-v1.5" => ImageEmbeddingRequestModel.NomicEmbedVisionV15,
                _ => null,
            };
        }
    }
}