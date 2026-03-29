
#nullable enable

namespace Nomic
{
    public partial class NomicClient
    {
        partial void PrepareEmbedTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Nomic.TextEmbeddingRequest request);
        partial void PrepareEmbedTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Nomic.TextEmbeddingRequest request);
        partial void ProcessEmbedTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEmbedTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate text embeddings<br/>
        /// Generates embeddings for the given texts using the specified model. The task_type parameter controls how the embeddings are optimized (e.g. for search queries vs documents, classification, or clustering). Supports Matryoshka-style dimensionality reduction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Nomic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedTextAsync(

            global::Nomic.TextEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEmbedTextArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Nomic.PathBuilder(
                path: "/v1/embedding/text",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEmbedTextRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEmbedTextResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Nomic.ValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Nomic.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Nomic.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Nomic.ApiException<global::Nomic.ValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessEmbedTextResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Nomic.EmbeddingResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Nomic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Nomic.EmbeddingResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Nomic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Nomic.EmbeddingResponse> EmbedTextAsync(
            global::System.Collections.Generic.IList<string> texts,
            global::Nomic.TextEmbeddingRequestModel model = global::Nomic.TextEmbeddingRequestModel.NomicEmbedTextV15,
            global::Nomic.TextEmbeddingRequestTaskType taskType = global::Nomic.TextEmbeddingRequestTaskType.SearchDocument,
            int? dimensionality = default,
            global::Nomic.TextEmbeddingRequestLongTextMode? longTextMode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Nomic.TextEmbeddingRequest
            {
                Texts = texts,
                Model = model,
                TaskType = taskType,
                Dimensionality = dimensionality,
                LongTextMode = longTextMode,
            };

            return await EmbedTextAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}