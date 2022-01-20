using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The voting permission enum
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VotingPermission
{
    /// <summary>
    /// The unknown voting permission
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// The disabled voting permission
    /// </summary>
    Disabled,
    /// <summary>
    /// The members voting permission
    /// </summary>
    Members,
    /// <summary>
    /// The org voting permission
    /// </summary>
    Org,
    /// <summary>
    /// The public voting permission
    /// </summary>
    Public
}