using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Board;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BoardFilter
{
    all,
    closed,
    none,
    open,
    visible
}