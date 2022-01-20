namespace Sabuto.Trello.Core.Models.Checklist;

/// <summary>
/// The check item
/// </summary>

public struct CheckItem
{
    /// <summary>
    /// Gets or sets the value of the id check list
    /// </summary>
    public string IdCheckList { get; set; }
    /// <summary>
    /// Gets or sets the value of the state
    /// </summary>
    public string State { get; set; }
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public string Pos { get; set; }
    /// <summary>
    /// Gets or sets the value of the due
    /// </summary>
    public DateTime? Due { get; set; }
    /// <summary>
    /// Gets or sets the value of the id member
    /// </summary>
    public string IdMember { get; set; }
}