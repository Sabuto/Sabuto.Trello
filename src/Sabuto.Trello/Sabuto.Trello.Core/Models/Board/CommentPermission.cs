using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CommentPermission
{
    Unknown = 0,
    Disabled,
    Members,
    Observers,
    Org,
    Public
}