using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Refit;
using Sabuto.Trello.Core.Converters;
using Sabuto.Trello.Core.Models.Board;
using Sabuto.Trello.Core.Services.Handler;
using Sabuto.Trello.Core.Services.Interfaces;

namespace Sabuto.Trello.Core.Services;

/// <summary>
/// The trello client class
/// </summary>
public class TrelloClient
{
    /// <summary>
    /// The http client
    /// </summary>
    private readonly HttpClient _httpClient;

    /// <summary>
    /// The boards
    /// </summary>
    public readonly IBoard Boards;

    /// <summary>
    /// The lists
    /// </summary>
    public readonly IList Lists;

    /// <summary>
    /// The checklists
    /// </summary>
    public readonly IChecklist Checklists;

    public readonly ICard Cards;

    /// <summary>
    /// Initializes a new instance of the <see cref="TrelloClient"/> class
    /// </summary>
    /// <param name="apiKey">The api key</param>
    /// <param name="apiToken">The api token</param>
    public TrelloClient(string apiKey, string apiToken)
    {
        JsonConvert.DefaultSettings = () => new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver(),
            Converters = { new BoolToLowerConverter() }
        };
        _httpClient = new HttpClient(new QueryStringInjectHttpMessageHandler(("key", apiKey), ("token", apiToken)))
            { BaseAddress = new Uri("https://trello.com/1") };
        Boards = RestService.For<IBoard>(_httpClient, new RefitSettings(new NewtonsoftJsonContentSerializer()));
        Lists = RestService.For<IList>(_httpClient, new RefitSettings(new NewtonsoftJsonContentSerializer()));
        Checklists = RestService.For<IChecklist>(_httpClient, new RefitSettings(new NewtonsoftJsonContentSerializer()));
        Cards = RestService.For<ICard>(_httpClient, new RefitSettings(new NewtonsoftJsonContentSerializer()));
        // Boards = RestService.For<IBoard>(_httpClient,
        //     new RefitSettings(new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
        //         { Converters = { new BoolToLowerConverter() }, ContractResolver = new CamelCasePropertyNamesContractResolver()})));
    }
}