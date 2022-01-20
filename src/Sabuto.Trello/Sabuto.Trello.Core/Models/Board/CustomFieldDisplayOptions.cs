namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The custom field display options
/// </summary>

public struct CustomFieldDisplayOptions
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id custom field
    /// </summary>
    public string IdCustomField { get; set; }
    /// <summary>
    /// Gets or sets the value of the value
    /// </summary>
    public object Value { get; set; }
    /// <summary>
    /// Gets or sets the value of the color
    /// </summary>
    public string Color { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public int Pos { get; set; }
}