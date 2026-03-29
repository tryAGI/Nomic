#nullable enable

namespace Nomic
{
    public partial interface INomicClient
    {
        /// <summary>
        /// Generate text embeddings<br/>
        /// Generates embeddings for the given texts using the specified model. The task_type parameter controls how the embeddings are optimized (e.g. for search queries vs documents, classification, or clustering). Supports Matryoshka-style dimensionality reduction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nomic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedTextAsync(

            global::Nomic.TextEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate text embeddings<br/>
        /// Generates embeddings for the given texts using the specified model. The task_type parameter controls how the embeddings are optimized (e.g. for search queries vs documents, classification, or clustering). Supports Matryoshka-style dimensionality reduction.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedTextAsync(
            global::System.Collections.Generic.IList<string> texts,
            global::Nomic.TextEmbeddingRequestModel model = global::Nomic.TextEmbeddingRequestModel.NomicEmbedTextV15,
            global::Nomic.TextEmbeddingRequestTaskType taskType = global::Nomic.TextEmbeddingRequestTaskType.SearchDocument,
            int? dimensionality = default,
            global::Nomic.TextEmbeddingRequestLongTextMode? longTextMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}