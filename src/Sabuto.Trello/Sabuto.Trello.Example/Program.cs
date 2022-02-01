// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Sabuto.Trello.Core;
using Sabuto.Trello.Core.Models.Board;
using Sabuto.Trello.Core.Models.Label;

Console.WriteLine("Hello, World!");

var client = new Sabuto.Trello.Core.Services.TrelloClient("c292397a9d6b53f6b59b771a33882203",
    "4afdd62eb8b37bed2531e9253b24e3da9503b25c9e9ff89da48db9fd9f668fc3");

try
{
    // var newBoard = await newclient.Boards.CreateBoard(new NewBoard("New name") { Desc = "This is a test desc" });
    // var response = await client.Boards.GetBoard("61ce10c030fc715808881906");
    // var board = response.Content;
    // var actions = await newclient.Boards.GetActions(board.Id);

    // var members = await client.Boards.GetMemberships(board.Id);
    // var stars = await client.Boards.GetStars(board.Id);
    // var newlabel =
    //     await client.Boards.CreateLabel(board.Id, new Label { Color = LabelColor.orange, Name = "Testing Create" });
    // var labels = await client.Boards.GetLabels(board.Id);
    // var test = await client.Boards.MarkAsViewed(board.Id);
    //
    // var key = await client.Boards.CreateEmailKey(board.Id);
    // var Ckey = await client.Boards.CreateCalendarKey(board.Id);
    // var enabledPowerUps = await client.Boards.GetPowerUps(board.Id);
    // var disabledPowerUps = await client.Boards.GetPowerUps(board.Id, PowerUpsOptions.available);
    // var invite = await client.Boards.InviteMember(board3.Id, "bobnud@gmail.com");
    // var cards = await client.Boards.GetAllCards(board3.Id);
    // var card = await client.Boards.GetCard(board3.Id, cards.First().Id);
    // var filtered = await client.Boards.GetFilteredCards(board3.Id, BoardFilter.closed);
    // var customFields = await client.Boards.GetCustomFields(board3.Id);
    // var lists = await client.Boards.GetLists(board3.Id);
    // var check = await client.Boards.GetChecklists(board3.Id);

    var cards = await client.Lists.GetCards("61e46898e50bc738ecce2e33");

    var checkitems = await client.Checklists.GetCheckItems("61e6da9df7cfa76abc1f431e");
}
catch (Exception e)
{
    Console.WriteLine(e);
}