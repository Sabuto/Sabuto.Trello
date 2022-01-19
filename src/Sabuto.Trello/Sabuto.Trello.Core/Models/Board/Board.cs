using Newtonsoft.Json;
using Sabuto.Trello.Core.Models.Interfaces.Board;

namespace Sabuto.Trello.Core.Models.Board;

public struct Board : IUpdateableBoard
{
    [JsonProperty("id")] public string Id { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("desc")] public string Desc { get; set; }
    // [JsonProperty("descData")] public string DescriptionData { get; set; }
    [JsonProperty("closed")] public bool Closed { get; set; }
    [JsonProperty("idMemberCreator")] public string IdMemberCreator { get; set; }
    [JsonProperty("idOrganization")] public string IdOrganization { get; set; }
    [JsonProperty("pinned")] public bool Pinned { get; set; }
    [JsonProperty("url")] public string Url { get; set; }
    [JsonProperty("shortUrl")] public string ShortUrl { get; set; }
    [JsonProperty("prefs")] public Preferences Preferences { get; set; }
    [JsonProperty("starred")] public bool Starred { get; set; }
    [JsonProperty("memberships")] public string Memberships { get; set; }
    [JsonProperty("shortLink")] public string ShortLink { get; set; }
    [JsonProperty("subscribed")] public bool Subscribed { get; set; }
    [JsonProperty("powerUps")] public string PowerUps { get; set; }
    [JsonProperty("dateLastActivity")] public string DateLastActivity { get; set; }
    [JsonProperty("datelastView")] public string DateLastView { get; set; }
    [JsonProperty("idTags")] public string IdTags { get; set; }
    [JsonProperty("datePluginDisable")] public string? DatePluginDisable { get; set; }
    [JsonProperty("creationMethod")] public string? CreationMethod { get; set; }
    [JsonProperty("idUpdate")] public int IdUpdate { get; set; }
    [JsonProperty("templateGallery")] public string? TemplateGallery { get; set; }
    [JsonProperty("enterpriseOwned")] public bool EnterpriseOwned { get; set; }
}