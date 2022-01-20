using Flurl;
using Flurl.Http;
using RestSharp;
using Sabuto.Trello.Core.Endpoints;
using Sabuto.Trello.Core.Extensions;
using Sabuto.Trello.Core.Models;
using Sabuto.Trello.Core.Models.Board;

namespace Sabuto.Trello.Core;

/// <summary>
/// The tello client class
/// </summary>
public class TrelloClient
{
    /// <summary>
    /// The url
    /// </summary>
    private readonly Url _baseUrl = new Url("https://trello.com/1");
    // private readonly Url _baseUrl = new Url("https://jsonplaceholder.typicode.com");

    /// <summary>
    /// The application key
    /// </summary>
    private readonly string _applicationKey;

    /// <summary>
    /// The api token
    /// </summary>
    private readonly string _apiToken;

    /// <summary>
    /// The boards
    /// </summary>
    public Boards Boards;

    /// <summary>
    /// Initializes a new instance of the <see cref="TrelloClient"/> class
    /// </summary>
    /// <param name="applicationKey">The application key</param>
    /// <param name="apiToken">The api token</param>
    public TrelloClient(string applicationKey, string apiToken)
    {
        _applicationKey = applicationKey;
        _apiToken = apiToken;

        Boards = new Boards(applicationKey, apiToken);
    }

    /// <summary>
    /// Gets the paths
    /// </summary>
    /// <typeparam name="T">The </typeparam>
    /// <param name="paths">The paths</param>
    /// <param name="queryParams">The query params</param>
    /// <returns>A task containing the</returns>
    public async Task<T> Get<T>(IEnumerable<string> paths, Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).GetJsonAsync<T>();
    }

    /// <summary>
    /// Posts the paths
    /// </summary>
    /// <param name="paths">The paths</param>
    /// <param name="json">The json</param>
    /// <param name="queryParams">The query params</param>
    public async Task Post(IEnumerable<string> paths, object? json = null,
        Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());

        var d = await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PutJsonAsync(json).ReceiveJson();

        // return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PostJsonAsync(json);
    }

    /// <summary>
    /// Setup the authentication
    /// </summary>
    /// <returns>The query params</returns>
    private Dictionary<string, string> SetupAuthentication()
    {
        var queryParams = new Dictionary<string, string>();
        queryParams.Add("key", _applicationKey);
        queryParams.Add("token", _apiToken);
        return queryParams;
    }

    /// <summary>
    /// Gets the api key
    /// </summary>
    /// <returns>The string</returns>
    public string GetApiKey() => _applicationKey;

    /// <summary>
    /// Gets the api token
    /// </summary>
    /// <returns>The string</returns>
    public string GetApiToken() => _apiToken;
}