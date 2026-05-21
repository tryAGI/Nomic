
#nullable enable

namespace Nomic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageEmbeddingRequest
    {
        /// <summary>
        /// The list of image URLs to embed. Supports PNG, JPEG, and WebP formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// The model to use for image embedding.<br/>
        /// Default Value: nomic-embed-vision-v1.5
        /// </summary>
        /// <default>global::Nomic.ImageEmbeddingRequestModel.NomicEmbedVisionV15</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nomic.JsonConverters.ImageEmbeddingRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nomic.ImageEmbeddingRequestModel Model { get; set; } = global::Nomic.ImageEmbeddingRequestModel.NomicEmbedVisionV15;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="urls">
        /// The list of image URLs to embed. Supports PNG, JPEG, and WebP formats.
        /// </param>
        /// <param name="model">
        /// The model to use for image embedding.<br/>
        /// Default Value: nomic-embed-vision-v1.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEmbeddingRequest(
            global::System.Collections.Generic.IList<string> urls,
            global::Nomic.ImageEmbeddingRequestModel model)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingRequest" /> class.
        /// </summary>
        public ImageEmbeddingRequest()
        {
        }

    }
}