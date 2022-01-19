using System.Text.Json.Serialization;

namespace Sabuto.Trello.Core.Models.Label;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LabelColor
{
    yellow,
    purple,
    blue,
    red,
    green,
    orange,
    black,
    sky,
    pink,
    lime
}