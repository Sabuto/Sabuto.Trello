using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VotingPermission
{
    Unknown = 0,
    Disabled,
    Members,
    Org,
    Public
}