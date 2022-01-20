namespace Sabuto.Trello.Core.Models.Interfaces.Board;

/// <summary>
/// The updateable board interface
/// </summary>

public interface IUpdateableBoard
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the desc
    /// </summary>
    string Desc { get; set; }
    /// <summary>
    /// Gets or sets the value of the closed
    /// </summary>
    bool Closed { get; set; }
}