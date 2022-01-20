using Flurl;
using Flurl.Http;
using Sabuto.Trello.Core.Exceptions;
using Sabuto.Trello.Core.Extensions;

namespace Sabuto.Trello.Core.Base;

/// <summary>
///     The base Client class
/// </summary>
public abstract class Client
{
    /// <summary>
    ///     The api token
    /// </summary>
    private readonly string _apiToken;

    /// <summary>
    ///     The application key
    /// </summary>
    private readonly string _applicationKey;

    /// <summary>
    ///     The base url for trello
    /// </summary>
    private readonly Url _baseUrl = new("https://api.trello.com/1");

    /// <summary>
    ///     Initializes a new instance of the <see cref="Client" /> class
    /// </summary>
    /// <param name="applicationKey">The application key</param>
    /// <param name="apiToken">The api token</param>
    public Client(string applicationKey, string apiToken)
    {
        _applicationKey = applicationKey;
        _apiToken = apiToken;
        FlurlHttp.Configure(c =>
        {
            c.BeforeCall = call => Console.WriteLine($"calling {call.Request.Url} with the verb {call.Request.Verb}");
            c.OnError = call => Console.WriteLine($"call failed: {call.Exception}");
            c.AfterCall += call => { _baseUrl.Reset(); };
        });
    }

    /// <summary>
    ///     Sends a Get Request to the trello Api with the paths and query params and returns a model serialized from json
    /// </summary>
    /// <param name="paths">The url paths to be appended to the url</param>
    /// <param name="queryParams">The query parameters to be appended to the url</param>
    /// <typeparam name="T">The return type of the Get request normally a model.</typeparam>
    /// <returns>Returns a serialized model or object</returns>
    public async Task<T> Get<T>(IEnumerable<string> paths, Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        try
        {
            return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).GetJsonAsync<T>();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    /// <summary>
    ///     Sends a Post Request to the trello Api with the paths and query params
    /// </summary>
    /// <param name="paths">The url paths to be appended to the url</param>
    /// <param name="queryParams">The query parameters to be appended to the url</param>
    public async Task Post(IEnumerable<string> paths,
        Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());

        try
        {
            await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PostAsync()
                .ReceiveJson();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }
    }

    /// <summary>
    ///     Sends a Post Request to the trello Api with the paths and query params and returns a serialized model from json.
    /// </summary>
    /// <param name="paths">The url paths to be appended to the url</param>
    /// <param name="queryParams">The query parameters to be appended to the url</param>
    /// <typeparam name="TR">The return model type for the json to be serialized to.</typeparam>
    /// <returns>Returns a serialized model or object</returns>
    protected async Task<TR> Post<TR>(IEnumerable<string> paths,
        Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        try
        {
            return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams)
                .PostAsync().ReceiveJson<TR>();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }
    }

    /// <summary>
    ///     Deletes the paths
    /// </summary>
    /// <param name="paths">The paths</param>
    /// <param name="queryParams">The query params</param>
    /// <returns>A task containing the bool</returns>
    protected async Task<bool> Delete(IEnumerable<string> paths, Dictionary<string, string>? queryParams = null)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        try
        {
            await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).DeleteAsync();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }

        return true;
    }

    /// <summary>
    /// Puts the paths
    /// </summary>
    /// <param name="paths">The paths</param>
    /// <param name="queryParams">The query params</param>
    /// <returns>A task containing the bool</returns>
    protected async Task<bool> Put(IEnumerable<string> paths, Dictionary<string, string>? queryParams)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        try
        {
            var result = await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PutAsync();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }

        return true;
    }

    protected async Task<T> Put<T>(IEnumerable<string> paths, Dictionary<string, string>? queryParams)
    {
        queryParams ??= new Dictionary<string, string>();
        queryParams.AddRange(SetupAuthentication());
        try
        {
            return await _baseUrl.AppendPathSegments(paths).SetQueryParams(queryParams).PutAsync()
                .ReceiveJson<T>();
        }
        catch (FlurlHttpException e)
        {
            throw new TrelloHttpError(await e.GetResponseStringAsync());
        }
    }

    /// <summary>
    /// Set's up the authentication query parameters
    /// </summary>
    /// <returns>The query params</returns>
    private Dictionary<string, string> SetupAuthentication()
    {
        var queryParams = new Dictionary<string, string>();
        queryParams.Add("key", _applicationKey);
        queryParams.Add("token", _apiToken);
        return queryParams;
    }
}