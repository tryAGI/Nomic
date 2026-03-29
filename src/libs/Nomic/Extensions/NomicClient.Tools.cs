#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Nomic;

public static class NomicClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that generates text embeddings using Nomic AI.
    /// </summary>
    public static AIFunction AsEmbedTextTool(this NomicClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The texts to generate embeddings for")] string[] texts,
                   [Description("The task type: search_query, search_document, classification, or clustering")] string? taskType,
                   [Description("The embedding dimensionality (64-768). Defaults to 768.")] int? dimensionality,
                   CancellationToken cancellationToken) =>
            {
                var parsedTaskType = taskType switch
                {
                    "search_query" => TextEmbeddingRequestTaskType.SearchQuery,
                    "classification" => TextEmbeddingRequestTaskType.Classification,
                    "clustering" => TextEmbeddingRequestTaskType.Clustering,
                    _ => TextEmbeddingRequestTaskType.SearchDocument,
                };

                var response = await client.EmbedTextAsync(
                    texts: texts,
                    model: TextEmbeddingRequestModel.NomicEmbedTextV15,
                    taskType: parsedTaskType,
                    dimensionality: dimensionality,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Model,
                    EmbeddingCount = response.Embeddings.Count,
                    Dimensions = response.Embeddings.Count > 0 ? response.Embeddings[0].Count : 0,
                    response.Usage,
                };
            },
            name: "Nomic_EmbedText",
            description: "Generate text embeddings using Nomic AI nomic-embed-text-v1.5 model. Supports task types for search, classification, and clustering with configurable dimensionality (64-768).");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates image embeddings using Nomic AI.
    /// </summary>
    public static AIFunction AsEmbedImageTool(this NomicClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The image URLs to generate embeddings for (PNG, JPEG, or WebP)")] string[] urls,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.EmbedImageAsync(
                    urls: urls,
                    model: ImageEmbeddingRequestModel.NomicEmbedVisionV15,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Model,
                    EmbeddingCount = response.Embeddings.Count,
                    Dimensions = response.Embeddings.Count > 0 ? response.Embeddings[0].Count : 0,
                    response.Usage,
                };
            },
            name: "Nomic_EmbedImage",
            description: "Generate image embeddings using Nomic AI nomic-embed-vision-v1.5 model. Accepts image URLs in PNG, JPEG, or WebP format.");
    }
}
