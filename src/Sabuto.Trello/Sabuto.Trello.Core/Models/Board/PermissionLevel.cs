using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The permission level enum
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PermissionLevel
{
    /// <summary>
    /// The unknown permission level
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// The private permission level
    /// </summary>
    Private,
    /// <summary>
    /// The org permission level
    /// </summary>
    Org,
    /// <summary>
    /// The public permission level
    /// </summary>
    Public
}