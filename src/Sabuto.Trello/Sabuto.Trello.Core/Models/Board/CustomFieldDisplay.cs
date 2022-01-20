namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The custom field display
/// </summary>
public struct CustomFieldDisplay
{
    /// <summary>
    /// Gets or sets the value of the card front
    /// </summary>
    public bool CardFront { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public string Pos { get; set; }
    /// <summary>
    /// Gets or sets the value of the options
    /// </summary>
    public List<CustomFieldDisplayOptions> Options { get; set; }
}