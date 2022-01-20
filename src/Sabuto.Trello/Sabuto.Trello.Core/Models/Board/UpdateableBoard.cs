using Sabuto.Trello.Core.Models.Interfaces.Board;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The updateable board class
/// </summary>

/// <seealso cref="IUpdateableBoard"/>

public class UpdateableBoard : IUpdateableBoard
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the desc
    /// </summary>
    public string Desc { get; set; }
    /// <summary>
    /// Gets or sets the value of the closed
    /// </summary>
    public bool Closed { get; set; }
}