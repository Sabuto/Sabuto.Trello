namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The power up
/// </summary>

public struct PowerUp
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id organization owner
    /// </summary>
    public string idOrganizationOwner { get; set; }
    /// <summary>
    /// Gets or sets the value of the author
    /// </summary>
    public string Author { get; set; }
    /// <summary>
    /// Gets or sets the value of the capabilities
    /// </summary>
    public List<string> Capabilities { get; set; }
    /// <summary>
    /// Gets or sets the value of the categories
    /// </summary>
    public List<string> Categories { get; set; }
}