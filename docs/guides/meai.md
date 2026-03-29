# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Nomic SDK implements `IEmbeddingGenerator<string, Embedding<float>>` and provides `AIFunction` tool wrappers, all compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Installation

```bash
dotnet add package Nomic
```

## IEmbeddingGenerator

The `NomicClient` directly implements `IEmbeddingGenerator<string, Embedding<float>>` for generating text embeddings using the `nomic-embed-text-v1.5` model (default) or `nomic-embed-text-v1`.

### Generate Embeddings

```csharp
using Microsoft.Extensions.AI;
using Nomic;

IEmbeddingGenerator<string, Embedding<float>> generator =
    new NomicClient(apiKey: Environment.GetEnvironmentVariable("NOMIC_API_KEY")!);

var embeddings = await generator.GenerateAsync(["Hello, world!"]);

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
Console.WriteLine($"Model: {embeddings[0].ModelId}");
```

### Custom Dimensions (Matryoshka)

Nomic models support Matryoshka embeddings with custom dimensionality (64-768):

```csharp
using Microsoft.Extensions.AI;
using Nomic;

IEmbeddingGenerator<string, Embedding<float>> generator =
    new NomicClient(apiKey: Environment.GetEnvironmentVariable("NOMIC_API_KEY")!);

var embeddings = await generator.GenerateAsync(
    ["Compact embedding for efficient storage."],
    new EmbeddingGenerationOptions
    {
        ModelId = "nomic-embed-text-v1.5",
        Dimensions = 256, // Reduce from default 768
    });

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}"); // 256
```

### Batch Embeddings

```csharp
using Microsoft.Extensions.AI;
using Nomic;

IEmbeddingGenerator<string, Embedding<float>> generator =
    new NomicClient(apiKey: Environment.GetEnvironmentVariable("NOMIC_API_KEY")!);

var texts = new[]
{
    "The quick brown fox jumps over the lazy dog.",
    "Machine learning is a subset of artificial intelligence.",
    "Embeddings represent text as numerical vectors.",
};

var embeddings = await generator.GenerateAsync(texts);

Console.WriteLine($"Generated {embeddings.Count} embeddings");
Console.WriteLine($"Total tokens: {embeddings.Usage?.TotalTokenCount}");
```

### Provider Metadata

```csharp
var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "NomicClient"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```

### Dependency Injection

```csharp
using Microsoft.Extensions.AI;
using Nomic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmbeddingGenerator<string, Embedding<float>>>(
    new NomicClient(apiKey: builder.Configuration["Nomic:ApiKey"]!));
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsEmbedTextTool()` | `Nomic_EmbedText` | Generate text embeddings with task type and dimensionality options (64-768) |
| `AsEmbedImageTool()` | `Nomic_EmbedImage` | Generate image embeddings from URLs (PNG, JPEG, WebP) |

## Usage

```csharp
using Nomic;
using Microsoft.Extensions.AI;

var nomicClient = new NomicClient(
    apiKey: Environment.GetEnvironmentVariable("NOMIC_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        nomicClient.AsEmbedTextTool(),
        nomicClient.AsEmbedImageTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Generate embeddings for the texts 'Hello world' and 'Machine learning is fascinating'."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
