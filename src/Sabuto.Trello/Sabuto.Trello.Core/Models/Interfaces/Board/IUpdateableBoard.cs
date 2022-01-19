namespace Sabuto.Trello.Core.Models.Interfaces.Board;

public interface IUpdateableBoard
{
    string Id { get; set; }
    string Name { get; set; }
    string Desc { get; set; }
    bool Closed { get; set; }
}