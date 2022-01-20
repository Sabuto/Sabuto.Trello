using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sabuto.Trello.Core.Models.Action;

/// <summary>
/// The trello action class
/// </summary>
public class TrelloAction
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    [JsonProperty("id")] public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id member creator
    /// </summary>
    [JsonProperty("idMemberCreator")] public string IdMemberCreator { get; set; }
    /// <summary>
    /// Gets or sets the value of the data
    /// </summary>
    [JsonProperty("data")] public JObject Data { get; set; }
    /// <summary>
    /// Gets or sets the value of the type
    /// </summary>
    [JsonProperty("type")] public string Type { get; set; }
    /// <summary>
    /// Gets or sets the value of the date
    /// </summary>
    [JsonProperty("date")] public string Date { get; set; }
    /// <summary>
    /// Gets or sets the value of the limits
    /// </summary>
    [JsonProperty("limits")] public JObject Limits { get; set; }
    /// <summary>
    /// Gets or sets the value of the display
    /// </summary>
    [JsonProperty("display")] public JObject Display { get; set; }
    /// <summary>
    /// Gets or sets the value of the member creator
    /// </summary>
    [JsonProperty("memberCreator")] public JObject MemberCreator { get; set; }
}