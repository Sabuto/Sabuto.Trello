namespace Sabuto.Trello.Core.Models.Checklist;

/// <summary>
/// The checklist
/// </summary>
public struct Checklist
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
    /// Gets or sets the value of the id card
    /// </summary>
    public string IdCard { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public int Pos { get; set; }
    /// <summary>
    /// Gets or sets the value of the id board
    /// </summary>
    public string IdBoard { get; set; }
    /// <summary>
    /// Gets or sets the value of the check items
    /// </summary>
    public List<CheckItem> CheckItems { get; set; }
}