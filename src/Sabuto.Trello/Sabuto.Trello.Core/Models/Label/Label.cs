namespace Sabuto.Trello.Core.Models.Label;

/// <summary>
/// The label
/// </summary>
public struct Label
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id board
    /// </summary>
    public string IdBoard { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the color
    /// </summary>
    public LabelColor Color { get; set; }
}