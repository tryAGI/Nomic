/*
order: 20
title: MEAI Embedding Generator
slug: meai-embedding-generator

Use the Microsoft.Extensions.AI IEmbeddingGenerator interface.
*/

using Microsoft.Extensions.AI;

namespace Nomic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiEmbeddingGenerator()
    {
        using var client = GetAuthenticatedClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        //// Generate embeddings using the MEAI IEmbeddingGenerator interface.
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new EmbeddingGenerationOptions
            {
                ModelId = "nomic-embed-text-v1.5",
            });

        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
        embeddings.Usage.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_MeaiEmbeddingGenerator_CustomDimensions()
    {
        using var client = GetAuthenticatedClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        //// Request custom dimensions via the MEAI options.
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new EmbeddingGenerationOptions
            {
                ModelId = "nomic-embed-text-v1.5",
                Dimensions = 128,
            });

        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().Be(128);
    }

    [TestMethod]
    public async Task Example_MeaiEmbeddingGenerator_GetServiceMetadata()
    {
        using var client = GetAuthenticatedClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        //// Retrieve embedding generator metadata.
        var metadata = generator.GetService<EmbeddingGeneratorMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(NomicClient));
        metadata.ProviderUri.Should().NotBeNull();
    }
}
