#nullable enable

using Microsoft.Extensions.AI;

namespace Nomic;

public partial class NomicClient : IEmbeddingGenerator<string, Embedding<float>>
{
    private EmbeddingGeneratorMetadata? _embeddingMetadata;

    /// <inheritdoc />
    object? IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(EmbeddingGeneratorMetadata)
                ? (_embeddingMetadata ??= new(nameof(NomicClient), BaseUri))
                : serviceType.IsInstanceOfType(this) ? this
                : null;
    }

    /// <inheritdoc />
    async Task<GeneratedEmbeddings<Embedding<float>>>
        IEmbeddingGenerator<string, Embedding<float>>.GenerateAsync(
            IEnumerable<string> values,
            EmbeddingGenerationOptions? options,
            CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var textList = values.ToList();

        var response = await EmbedTextAsync(
            texts: textList,
            model: options?.ModelId switch
            {
                "nomic-embed-text-v1" => TextEmbeddingRequestModel.NomicEmbedTextV1,
                _ => TextEmbeddingRequestModel.NomicEmbedTextV15,
            },
            taskType: TextEmbeddingRequestTaskType.SearchDocument,
            dimensionality: options?.Dimensions,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new GeneratedEmbeddings<Embedding<float>>();

        foreach (var embedding in response.Embeddings)
        {
            var floatArray = new float[embedding.Count];
            for (var i = 0; i < embedding.Count; i++)
            {
                floatArray[i] = embedding[i];
            }

            embeddings.Add(new Embedding<float>(floatArray)
            {
                ModelId = response.Model,
            });
        }

        if (response.Usage is { } usage)
        {
            embeddings.Usage = new UsageDetails
            {
                InputTokenCount = usage.PromptTokens,
                TotalTokenCount = usage.TotalTokens,
            };
        }

        return embeddings;
    }
}
