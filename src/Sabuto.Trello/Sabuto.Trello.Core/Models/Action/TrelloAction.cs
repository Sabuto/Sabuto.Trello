using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sabuto.Trello.Core.Models.Action;

public class TrelloAction
{
    [JsonProperty("id")] public string Id { get; set; }
    [JsonProperty("idMemberCreator")] public string IdMemberCreator { get; set; }
    [JsonProperty("data")] public JObject Data { get; set; }
    [JsonProperty("type")] public string Type { get; set; }
    [JsonProperty("date")] public string Date { get; set; }
    [JsonProperty("limits")] public JObject Limits { get; set; }
    [JsonProperty("display")] public JObject Display { get; set; }
    [JsonProperty("memberCreator")] public JObject MemberCreator { get; set; }
}