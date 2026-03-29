/*
order: 10
title: Client Creation
slug: client-creation

Basic example showing how to create a Nomic AI client.
*/

namespace Nomic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ClientCreation()
    {
        //// Create a Nomic AI client using an API key from the environment.
        using var client = GetAuthenticatedClient();

        //// Generate a simple text embedding to verify the client works.
        var response = await client.EmbedTextAsync(
            texts: ["Hello, world!"],
            model: TextEmbeddingRequestModel.NomicEmbedTextV15,
            taskType: TextEmbeddingRequestTaskType.SearchDocument);

        response.Embeddings.Should().HaveCount(1);
        response.Embeddings[0].Count.Should().BeGreaterThan(0);
        response.Model.Should().NotBeNullOrEmpty();
    }
}
