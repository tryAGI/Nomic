# CLAUDE.md -- Nomic SDK

## Overview

Auto-generated C# SDK for [Nomic AI](https://www.nomic.ai/) -- text and image embeddings with nomic-embed-text-v1.5 and nomic-embed-vision-v1.5 models, plus Atlas data visualization.
OpenAPI spec manually created from Nomic API documentation and Python client source.

## Build & Test

```bash
dotnet build Nomic.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Nomic API key:

```csharp
var client = new NomicClient(apiKey); // NOMIC_API_KEY env var
```

## Key Files

- `src/libs/Nomic/openapi.yaml` -- Manually maintained OpenAPI 3.0.3 spec
- `src/libs/Nomic/generate.sh` -- Runs autosdk to generate code from local spec
- `src/libs/Nomic/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Nomic/Extensions/NomicClient.EmbeddingGenerator.cs` -- MEAI `IEmbeddingGenerator` implementation
- `src/libs/Nomic/Extensions/NomicClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints

- `POST /v1/embedding/text` -- Generate text embeddings (nomic-embed-text-v1/v1.5)
- `POST /v1/embedding/image` -- Generate image embeddings from URLs (nomic-embed-vision-v1/v1.5)

## Task Types (Text Embeddings)

- `search_document` -- For embedding document chunks in retrieval scenarios (default)
- `search_query` -- For embedding user search queries
- `classification` -- For text classification
- `clustering` -- For cluster visualization

## MEAI Integration

### IEmbeddingGenerator

```csharp
IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "nomic-embed-text-v1.5",
        Dimensions = 256, // Matryoshka: 64-768
    });
```

### AIFunction Tools

- `AsEmbedTextTool()` -- Generate text embeddings with task type and dimensionality options
- `AsEmbedImageTool()` -- Generate image embeddings from URLs (PNG, JPEG, WebP)

## NuGet

- **PackageId:** `Nomic` (available on NuGet)
