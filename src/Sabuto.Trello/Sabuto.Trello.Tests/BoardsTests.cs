using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using NUnit.Framework;
using Sabuto.Trello.Core;
using Sabuto.Trello.Core.Models.Board;

namespace Sabuto.Trello.Tests;

[TestFixture]
public class BoardsTests
{
    private TrelloClient _trelloClient;
    private HttpTest _httpTest;

    [SetUp]
    public void Setup()
    {
        _trelloClient = new TrelloClient("apikey",
            "apitoken");
        _httpTest = new HttpTest();
    }

    [Test]
    public async Task GetBoard()
    {
        _httpTest
            .RespondWithJson(Board.FakeData.Generate());


        var board = await _trelloClient.Boards.GetBoard("anyId");

        _httpTest.ShouldHaveCalled(
            "https://api.trello.com/1/boards/anyId?key=apikey&token=apitoken").WithVerb(HttpMethod.Get).Times(1);
    }

    [TearDown]
    public void Dispose()
    {
        _httpTest.Dispose();
    }
}