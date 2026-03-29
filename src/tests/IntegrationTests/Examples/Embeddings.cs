/*
order: 15
title: Text Embeddings
slug: text-embeddings

Generate text embeddings with different task types and dimensionality.
*/

namespace Nomic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextEmbeddings()
    {
        using var client = GetAuthenticatedClient();

        //// Generate text embeddings for documents using nomic-embed-text-v1.5.
        var response = await client.EmbedTextAsync(
            texts: [
                "The quick brown fox jumps over the lazy dog.",
                "Machine learning is a subset of artificial intelligence.",
            ],
            model: TextEmbeddingRequestModel.NomicEmbedTextV15,
            taskType: TextEmbeddingRequestTaskType.SearchDocument);

        response.Embeddings.Should().HaveCount(2);
        response.Embeddings[0].Count.Should().Be(768);
        response.Model.Should().NotBeNullOrEmpty();
        response.Usage.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_TextEmbeddings_CustomDimensionality()
    {
        using var client = GetAuthenticatedClient();

        //// Nomic supports Matryoshka-style dimensionality reduction (64-768).
        var response = await client.EmbedTextAsync(
            texts: ["Hello, world!"],
            model: TextEmbeddingRequestModel.NomicEmbedTextV15,
            taskType: TextEmbeddingRequestTaskType.SearchQuery,
            dimensionality: 256);

        response.Embeddings.Should().HaveCount(1);
        response.Embeddings[0].Count.Should().Be(256);
    }

    [TestMethod]
    public async Task Example_TextEmbeddings_Classification()
    {
        using var client = GetAuthenticatedClient();

        //// Use classification task type for text classification scenarios.
        var response = await client.EmbedTextAsync(
            texts: ["This is a positive review of the product."],
            model: TextEmbeddingRequestModel.NomicEmbedTextV15,
            taskType: TextEmbeddingRequestTaskType.Classification);

        response.Embeddings.Should().HaveCount(1);
        response.Embeddings[0].Count.Should().BeGreaterThan(0);
    }
}
