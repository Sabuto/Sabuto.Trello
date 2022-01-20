namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The custom field
/// </summary>

public struct CustomField
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id model
    /// </summary>
    public string IdModel { get; set; }
    /// <summary>
    /// Gets or sets the value of the model type
    /// </summary>
    public string ModelType { get; set; }
    /// <summary>
    /// Gets or sets the value of the field group
    /// </summary>
    public string FieldGroup { get; set; }
    /// <summary>
    /// Gets or sets the value of the display
    /// </summary>
    public CustomFieldDisplay Display { get; set; }
    /// <summary>
    /// Gets or sets the value of the type
    /// </summary>
    public string Type { get; set; }
}