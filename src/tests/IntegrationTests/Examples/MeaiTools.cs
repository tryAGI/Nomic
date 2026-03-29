/*
order: 25
title: MEAI Tools
slug: meai-tools

Use the Nomic AI client as MEAI AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Nomic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Nomic AI client.
        var embedTextTool = client.AsEmbedTextTool();
        var embedImageTool = client.AsEmbedImageTool();

        embedTextTool.Should().NotBeNull();
        embedTextTool.Name.Should().Be("Nomic_EmbedText");

        embedImageTool.Should().NotBeNull();
        embedImageTool.Name.Should().Be("Nomic_EmbedImage");
    }
}
