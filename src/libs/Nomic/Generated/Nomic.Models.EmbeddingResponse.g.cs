
#nullable enable

namespace Nomic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingResponse
    {
        /// <summary>
        /// The generated embeddings as arrays of floats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> Embeddings { get; set; }

        /// <summary>
        /// The model used for generating embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nomic.Usage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// The generated embeddings as arrays of floats.
        /// </param>
        /// <param name="model">
        /// The model used for generating embeddings.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> embeddings,
            string model,
            global::Nomic.Usage usage)
        {
            this.Embeddings = embeddings ?? throw new global::System.ArgumentNullException(nameof(embeddings));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        public EmbeddingResponse()
        {
        }

    }
}