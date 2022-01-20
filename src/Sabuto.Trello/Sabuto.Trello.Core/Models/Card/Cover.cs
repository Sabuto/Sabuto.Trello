using Newtonsoft.Json;

namespace Sabuto.Trello.Core.Models.Card;

/// <summary>
/// The cover
/// </summary>

public struct Cover
{
    /// <summary>
    /// Gets or sets the value of the id attachment
    /// </summary>
    public string IdAttachment { get; set; }
    /// <summary>
    /// Gets or sets the value of the cover object
    /// </summary>
    [JsonProperty("cover")] public object CoverObject { get; set; }
    /// <summary>
    /// Gets or sets the value of the id uploaded background
    /// </summary>
    public string IdUploadedBackground { get; set; }
    /// <summary>
    /// Gets or sets the value of the size
    /// </summary>
    public object Size { get; set; }
    /// <summary>
    /// Gets or sets the value of the brightness
    /// </summary>
    public object Brightness { get; set; }
    /// <summary>
    /// Gets or sets the value of the id plugin
    /// </summary>
    public string IdPlugin { get; set; }
}