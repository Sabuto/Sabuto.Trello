// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Sabuto.Trello.Core;
using Sabuto.Trello.Core.Models.Board;
using Sabuto.Trello.Core.Models.Label;

Console.WriteLine("Hello, World!");

var client = new TelloClient("c292397a9d6b53f6b59b771a33882203",
    "4afdd62eb8b37bed2531e9253b24e3da9503b25c9e9ff89da48db9fd9f668fc3");

try
{
    var board3 = await client.Boards.GetBoard("61e46898e50bc738ecce2e32");
    board3.Desc = "Welcome to the jungle";
    board3.Name = "new 2!";

    // var test = await client.Boards.GetActions(board3.Id);
    var members = await client.Boards.GetMemberships(board3.Id);
    // var stars = await client.Boards.GetStars(board3.Id);
    // var newlabel =
    //     await client.Boards.CreateLabel(board3.Id, new Label { Color = LabelColor.orange, Name = "Testing Create" });
    // var labels = await client.Boards.GetLabels(board3.Id);
    // await client.Boards.MarkAsViewed(board3.Id);
    // var key = await client.Boards.CreateEmailKey(board3.Id);
    // var key = await client.Boards.CreateCalendarKey(board3.Id);
    var enabledPowerUps = await client.Boards.GetPowerUps(board3.Id);
    var disabledPowerUps = await client.Boards.GetPowerUps(board3.Id, PowerUpsOptions.available);
}
catch (Exception e)
{
    Console.WriteLine(e);
}