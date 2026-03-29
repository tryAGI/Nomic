namespace Nomic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NomicClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NOMIC_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NOMIC_API_KEY environment variable is not found.");

        var client = new NomicClient(apiKey);
        
        return client;
    }
}
