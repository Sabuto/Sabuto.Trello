using Bogus;
using Newtonsoft.Json;
using Sabuto.Trello.Core.Models.Interfaces.Board;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The board class
/// </summary>

/// <seealso cref="IUpdateableBoard"/>

public class Board : IUpdateableBoard
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    [JsonProperty("id")] public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    [JsonProperty("name")] public string Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the desc
    /// </summary>
    [JsonProperty("desc")] public string Desc { get; set; }

    // [JsonProperty("descData")] public string DescriptionData { get; set; }
    /// <summary>
    /// Gets or sets the value of the closed
    /// </summary>
    [JsonProperty("closed")] public bool Closed { get; set; }
    /// <summary>
    /// Gets or sets the value of the id member creator
    /// </summary>
    [JsonProperty("idMemberCreator")] public string IdMemberCreator { get; set; }
    /// <summary>
    /// Gets or sets the value of the id organization
    /// </summary>
    [JsonProperty("idOrganization")] public string IdOrganization { get; set; }
    /// <summary>
    /// Gets or sets the value of the pinned
    /// </summary>
    [JsonProperty("pinned")] public bool Pinned { get; set; }
    /// <summary>
    /// Gets or sets the value of the url
    /// </summary>
    [JsonProperty("url")] public string Url { get; set; }
    /// <summary>
    /// Gets or sets the value of the short url
    /// </summary>
    [JsonProperty("shortUrl")] public string ShortUrl { get; set; }
    /// <summary>
    /// Gets or sets the value of the preferences
    /// </summary>
    [JsonProperty("prefs")] public Preferences Preferences { get; set; }
    /// <summary>
    /// Gets or sets the value of the starred
    /// </summary>
    [JsonProperty("starred")] public bool Starred { get; set; }
    /// <summary>
    /// Gets or sets the value of the memberships
    /// </summary>
    [JsonProperty("memberships")] public string Memberships { get; set; }
    /// <summary>
    /// Gets or sets the value of the short link
    /// </summary>
    [JsonProperty("shortLink")] public string ShortLink { get; set; }
    /// <summary>
    /// Gets or sets the value of the subscribed
    /// </summary>
    [JsonProperty("subscribed")] public bool Subscribed { get; set; }
    /// <summary>
    /// Gets or sets the value of the power ups
    /// </summary>
    [JsonProperty("powerUps")] public string PowerUps { get; set; }
    /// <summary>
    /// Gets or sets the value of the date last activity
    /// </summary>
    [JsonProperty("dateLastActivity")] public string DateLastActivity { get; set; }
    /// <summary>
    /// Gets or sets the value of the date last view
    /// </summary>
    [JsonProperty("datelastView")] public string DateLastView { get; set; }
    /// <summary>
    /// Gets or sets the value of the id tags
    /// </summary>
    [JsonProperty("idTags")] public string IdTags { get; set; }
    /// <summary>
    /// Gets or sets the value of the date plugin disable
    /// </summary>
    [JsonProperty("datePluginDisable")] public string? DatePluginDisable { get; set; }
    /// <summary>
    /// Gets or sets the value of the creation method
    /// </summary>
    [JsonProperty("creationMethod")] public string? CreationMethod { get; set; }
    /// <summary>
    /// Gets or sets the value of the id update
    /// </summary>
    [JsonProperty("idUpdate")] public int IdUpdate { get; set; }
    /// <summary>
    /// Gets or sets the value of the template gallery
    /// </summary>
    [JsonProperty("templateGallery")] public string? TemplateGallery { get; set; }
    /// <summary>
    /// Gets or sets the value of the enterprise owned
    /// </summary>
    [JsonProperty("enterpriseOwned")] public bool EnterpriseOwned { get; set; }

    /// <summary>
    /// Gets the value of the fake data
    /// </summary>
    public static Faker<Board> FakeData { get; } =
        new Faker<Board>()
            .RuleFor(p => p.Id, f => f.Random.Guid().ToString())
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Closed, f => f.Random.Bool())
            .RuleFor(p => p.IdMemberCreator, f => f.Random.Guid().ToString())
            .RuleFor(p => p.IdOrganization, f => f.Random.Guid().ToString())
            .RuleFor(p => p.Pinned, f => f.Random.Bool())
            .RuleFor(p => p.Url, f => f.Internet.Url())
            .RuleFor(p => p.ShortUrl, f => f.Internet.Url())
            .RuleFor(p => p.Starred, f => f.Random.Bool());
}