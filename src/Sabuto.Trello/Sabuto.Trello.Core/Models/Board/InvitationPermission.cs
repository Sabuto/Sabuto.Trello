using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The invitation permission enum
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InvitationPermission
{
    /// <summary>
    /// The unknown invitation permission
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// The members invitation permission
    /// </summary>
    Members,
    /// <summary>
    /// The owners invitation permission
    /// </summary>
    Owners,
}