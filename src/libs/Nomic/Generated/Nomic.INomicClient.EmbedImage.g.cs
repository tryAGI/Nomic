#nullable enable

namespace Nomic
{
    public partial interface INomicClient
    {
        /// <summary>
        /// Generate image embeddings<br/>
        /// Generates embeddings for the given images using the specified model. Images can be provided as URLs. Supported formats include PNG, JPEG, and WebP.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nomic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedImageAsync(

            global::Nomic.ImageEmbeddingRequest request,
            global::Nomic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image embeddings<br/>
        /// Generates embeddings for the given images using the specified model. Images can be provided as URLs. Supported formats include PNG, JPEG, and WebP.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nomic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Nomic.AutoSDKHttpResponse<global::Nomic.EmbeddingResponse>> EmbedImageAsResponseAsync(

            global::Nomic.ImageEmbeddingRequest request,
            global::Nomic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image embeddings<br/>
        /// Generates embeddings for the given images using the specified model. Images can be provided as URLs. Supported formats include PNG, JPEG, and WebP.
        /// </summary>
        /// <param name="urls">
        /// The list of image URLs to embed. Supports PNG, JPEG, and WebP formats.
        /// </param>
        /// <param name="model">
        /// The model to use for image embedding.<br/>
        /// Default Value: nomic-embed-vision-v1.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedImageAsync(
            global::System.Collections.Generic.IList<string> urls,
            global::Nomic.ImageEmbeddingRequestModel model = global::Nomic.ImageEmbeddingRequestModel.NomicEmbedVisionV15,
            global::Nomic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}