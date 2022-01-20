using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The board filter enum
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BoardFilter
{
    /// <summary>
    /// The all board filter
    /// </summary>
    all,
    /// <summary>
    /// The closed board filter
    /// </summary>
    closed,
    /// <summary>
    /// The none board filter
    /// </summary>
    none,
    /// <summary>
    /// The open board filter
    /// </summary>
    open,
    /// <summary>
    /// The visible board filter
    /// </summary>
    visible
}