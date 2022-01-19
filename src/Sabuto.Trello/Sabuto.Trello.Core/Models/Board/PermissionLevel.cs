using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PermissionLevel
{
    Unknown = 0,
    Private,
    Org,
    Public
}