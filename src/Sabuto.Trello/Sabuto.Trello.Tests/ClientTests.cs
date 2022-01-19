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
    private TelloClient _telloClient;

    [SetUp]
    public void Setup()
    {
        _telloClient = new TelloClient("c292397a9d6b53f6b59b771a33882203", "2fc9843ca0c8de99988798c14a651b40c7ed6c50719d90c6876085b32a6362fd");
    }

    [Test]
    public void AssertApiKeyAndTokenAreSet()
    {
        Assert.IsNotNull(_telloClient.GetApiKey());
        Assert.IsNotNull(_telloClient.GetApiToken());
        Assert.IsNotEmpty(_telloClient.GetApiKey());
        Assert.IsNotEmpty(_telloClient.GetApiToken());
    }

    [Test]
    public async Task FlurlTest()
    {
        using (var httpTest = new HttpTest())
        {
            httpTest.RespondWithJson(body: new List<Board>());

            await _telloClient.GetTodos();

            httpTest.ShouldHaveCalled("https://jsonplaceholder.typicode.com/todos?userId=1").WithVerb(HttpMethod.Get);
        }
    }
}