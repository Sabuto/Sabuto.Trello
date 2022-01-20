using Newtonsoft.Json;

namespace Sabuto.Trello.Core.Models.Card;

public struct Cover
{
    public string IdAttachment { get; set; }
    [JsonProperty("cover")] public object CoverObject { get; set; }
    public string IdUploadedBackground { get; set; }
    public object Size { get; set; }
    public object Brightness { get; set; }
    public string IdPlugin { get; set; }
}