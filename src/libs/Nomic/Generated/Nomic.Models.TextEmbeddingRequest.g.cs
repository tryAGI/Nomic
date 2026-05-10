
#nullable enable

namespace Nomic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextEmbeddingRequest
    {
        /// <summary>
        /// The list of texts to embed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Texts { get; set; }

        /// <summary>
        /// The model to use for embedding.<br/>
        /// Default Value: nomic-embed-text-v1.5
        /// </summary>
        /// <default>global::Nomic.TextEmbeddingRequestModel.NomicEmbedTextV15</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nomic.JsonConverters.TextEmbeddingRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nomic.TextEmbeddingRequestModel Model { get; set; } = global::Nomic.TextEmbeddingRequestModel.NomicEmbedTextV15;

        /// <summary>
        /// The task type to optimize embeddings for. search_document is for embedding document chunks in retrieval scenarios. search_query is for embedding user search queries. classification is for text classification. clustering is for cluster visualization.<br/>
        /// Default Value: search_document
        /// </summary>
        /// <default>global::Nomic.TextEmbeddingRequestTaskType.SearchDocument</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nomic.JsonConverters.TextEmbeddingRequestTaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Nomic.TextEmbeddingRequestTaskType TaskType { get; set; } = global::Nomic.TextEmbeddingRequestTaskType.SearchDocument;

        /// <summary>
        /// The embedding dimension for Matryoshka-capable models. Accepts values from 64 to 768. If not specified, defaults to full-size (768).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensionality")]
        public int? Dimensionality { get; set; }

        /// <summary>
        /// How to handle texts longer than the model can accept. truncate cuts at the max token length. mean averages embeddings of chunks.<br/>
        /// Default Value: truncate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_text_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Nomic.JsonConverters.TextEmbeddingRequestLongTextModeJsonConverter))]
        public global::Nomic.TextEmbeddingRequestLongTextMode? LongTextMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="texts">
        /// The list of texts to embed.
        /// </param>
        /// <param name="model">
        /// The model to use for embedding.<br/>
        /// Default Value: nomic-embed-text-v1.5
        /// </param>
        /// <param name="taskType">
        /// The task type to optimize embeddings for. search_document is for embedding document chunks in retrieval scenarios. search_query is for embedding user search queries. classification is for text classification. clustering is for cluster visualization.<br/>
        /// Default Value: search_document
        /// </param>
        /// <param name="dimensionality">
        /// The embedding dimension for Matryoshka-capable models. Accepts values from 64 to 768. If not specified, defaults to full-size (768).
        /// </param>
        /// <param name="longTextMode">
        /// How to handle texts longer than the model can accept. truncate cuts at the max token length. mean averages embeddings of chunks.<br/>
        /// Default Value: truncate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextEmbeddingRequest(
            global::System.Collections.Generic.IList<string> texts,
            global::Nomic.TextEmbeddingRequestModel model,
            global::Nomic.TextEmbeddingRequestTaskType taskType,
            int? dimensionality,
            global::Nomic.TextEmbeddingRequestLongTextMode? longTextMode)
        {
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
            this.Model = model;
            this.TaskType = taskType;
            this.Dimensionality = dimensionality;
            this.LongTextMode = longTextMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingRequest" /> class.
        /// </summary>
        public TextEmbeddingRequest()
        {
        }

    }
}