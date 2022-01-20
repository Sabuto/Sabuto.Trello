using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Label;

/// <summary>
/// The label color enum
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LabelColor
{
    /// <summary>
    /// The yellow label color
    /// </summary>
    yellow,
    /// <summary>
    /// The purple label color
    /// </summary>
    purple,
    /// <summary>
    /// The blue label color
    /// </summary>
    blue,
    /// <summary>
    /// The red label color
    /// </summary>
    red,
    /// <summary>
    /// The green label color
    /// </summary>
    green,
    /// <summary>
    /// The orange label color
    /// </summary>
    orange,
    /// <summary>
    /// The black label color
    /// </summary>
    black,
    /// <summary>
    /// The sky label color
    /// </summary>
    sky,
    /// <summary>
    /// The pink label color
    /// </summary>
    pink,
    /// <summary>
    /// The lime label color
    /// </summary>
    lime
}