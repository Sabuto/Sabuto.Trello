using Sabuto.Trello.Core.Models.Interfaces.Board;

namespace Sabuto.Trello.Core.Models.Board;

public class UpdateableBoard : IUpdateableBoard
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public bool Closed { get; set; }
}