# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Nomic SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Nomic AI text and image embedding capabilities.

## Installation

```bash
dotnet add package Nomic
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
