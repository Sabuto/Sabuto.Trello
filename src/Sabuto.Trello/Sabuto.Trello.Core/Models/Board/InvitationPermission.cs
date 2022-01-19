using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InvitationPermission
{
    Unknown = 0,
    Members,
    Owners,
}