using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using NUnit.Framework;
using Sabuto.Trello.Core;
using Sabuto.Trello.Core.Models;
using Sabuto.Trello.Core.Models.Board;

namespace Sabuto.Trello.Tests;

[TestFixture]
public class ClientTests
{
    private TrelloClient _trelloClient;

    [SetUp]
    public void Setup()
    {
        _trelloClient = new TrelloClient("c292397a9d6b53f6b59b771a33882203",
            "2fc9843ca0c8de99988798c14a651b40c7ed6c50719d90c6876085b32a6362fd");
    }

    [Test]
    public void AssertApiKeyAndTokenAreSet()
    {
        Assert.IsNotNull(_trelloClient.GetApiKey());
        Assert.IsNotNull(_trelloClient.GetApiToken());
        Assert.IsNotEmpty(_trelloClient.GetApiKey());
        Assert.IsNotEmpty(_trelloClient.GetApiToken());
    }
}