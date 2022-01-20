namespace Sabuto.Trello.Core.Models.List;

/// <summary>
/// The trello list
/// </summary>

public struct TrelloList
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
    /// Gets or sets the value of the closed
    /// </summary>
    public bool Closed { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public int Pos { get; set; }
    /// <summary>
    /// Gets or sets the value of the soft limit
    /// </summary>
    public string SoftLimit { get; set; }
    /// <summary>
    /// Gets or sets the value of the id board
    /// </summary>
    public string IdBoard { get; set; }
    /// <summary>
    /// Gets or sets the value of the subscribed
    /// </summary>
    public bool Subscribed { get; set; }
    /// <summary>
    /// Gets or sets the value of the limits
    /// </summary>
    public object Limits { get; set; }
}