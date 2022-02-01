using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using Sabuto.Trello.Core.Services.Interfaces;

namespace Sabuto.Trello.Tests;

[TestFixture]
public class BoardsTests
{
    private readonly IBoard? _mock = Substitute.For<IBoard>();

    [Test]
    public async Task GetBoard()
    {
        var test = await _mock?.GetBoard("test");

        await _mock.Received().GetBoard("test");
    }

    [Test]
    public async Task GetAllCards()
    {
        await _mock?.GetAllCards("test");

        await _mock.Received().GetAllCards("test");
    }
}