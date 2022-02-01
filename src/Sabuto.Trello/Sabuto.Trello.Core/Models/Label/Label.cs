using Newtonsoft.Json;
using Refit;

namespace Sabuto.Trello.Core.Models.Label;

/// <summary>
/// The label
/// </summary>
public struct Label
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    [AliasAs("id")]
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id board
    /// </summary>
    [AliasAs("idBoard")]
    public string IdBoard { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    [AliasAs("name")]
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the color
    /// </summary>
    [AliasAs("color")]
    public LabelColor Color { get; set; }
}