using Flurl;
using Flurl.Http;
using RestSharp;
using Sabuto.Trello.Core.Endpoints;
using Sabuto.Trello.Core.Extensions;
using Sabuto.Trello.Core.Models;
using Sabuto.Trello.Core.Models.Board;

namespace Sabuto.Trello.Core;

public class TelloClient
{
    private readonly Url _baseUrl = new Url("https://trello.com/1");
    // private readonly Url _baseUrl = new Url("https://jsonplaceholder.typicode.com");

    private readonly string _applicationKey;
    private readonly string _apiToken;

    public Boards Boards;

    public TelloClient(string applicationKey, string apiToken)
    {
        _applicationKey = applicationKey;
        _apiToken = apiToken;

        Boards = new Boards(applicationKey, apiToken);
    }

    public async Task<Board> GetTodos()
    {
        var user = await _baseUrl.AppendPathSegment("boards").AppendPathSegment("6134f437aaa1854eaca84b19")
            .SetQueryParam("key", "c292397a9d6b53f6b59b771a33882203").SetQueryParam("token",
                "2fc9843ca0c8de99988798c14a651b40c7ed6c50719d90c6876085b32a6362fd")
            .GetJsonAsync<Board>();
        return user;
    }

    public async Task<T> Get<T>(IEnumerable<string> paths, Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).GetJsonAsync<T>();
    }

    public async Task Post(IEnumerable<string> paths, object? json = null,
        Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());

        var d = await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PutJsonAsync(json).ReceiveJson();

        // return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PostJsonAsync(json);
    }

    private Dictionary<string, string> SetupAuthentication()
    {
        var queryParams = new Dictionary<string, string>();
        queryParams.Add("key", _applicationKey);
        queryParams.Add("token", _apiToken);
        return queryParams;
    }

    public string GetApiKey() => _applicationKey;

    public string GetApiToken() => _apiToken;
}