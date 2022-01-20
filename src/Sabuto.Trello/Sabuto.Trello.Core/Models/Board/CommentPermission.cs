using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The comment permission enum
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CommentPermission
{
    /// <summary>
    /// The unknown comment permission
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// The disabled comment permission
    /// </summary>
    Disabled,
    /// <summary>
    /// The members comment permission
    /// </summary>
    Members,
    /// <summary>
    /// The observers comment permission
    /// </summary>
    Observers,
    /// <summary>
    /// The org comment permission
    /// </summary>
    Org,
    /// <summary>
    /// The public comment permission
    /// </summary>
    Public
}