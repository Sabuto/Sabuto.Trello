using System.Web;
using Flurl;
using Sabuto.Trello.Core.Extensions;

namespace Sabuto.Trello.Core.Services.Handler;

/// <summary>

/// The query string inject http message handler class

/// </summary>

/// <seealso cref="DelegatingHandler"/>

public class QueryStringInjectHttpMessageHandler : DelegatingHandler
{
    /// <summary>
    /// The injected params
    /// </summary>
    private readonly (string key, string value)[] _injectedParams;
    /// <summary>
    /// The key
    /// </summary>
    private string _key;
    /// <summary>
    /// The token
    /// </summary>
    private string _token;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryStringInjectHttpMessageHandler"/> class
    /// </summary>
    /// <param name="injectedParams">The injected params</param>
    public QueryStringInjectHttpMessageHandler(params (string key, string value)[] injectedParams) :
        this()
    {
        _injectedParams = injectedParams;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryStringInjectHttpMessageHandler"/> class
    /// </summary>
    public QueryStringInjectHttpMessageHandler() : base(new HttpClientHandler())
    {
    }

    /// <summary>
    /// Sends the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing the http response message</returns>
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var finalUri = InjectIntoQuery(request.RequestUri, _injectedParams);
        request.RequestUri = finalUri;
        return base.SendAsync(request, cancellationToken);
    }

    /// <summary>
    /// Injects the into query using the specified uri
    /// </summary>
    /// <param name="uri">The uri</param>
    /// <param name="parameters">The parameters</param>
    /// <returns>The final uri</returns>
    private static Uri InjectIntoQuery(Uri uri, IEnumerable<(string key, string value)> parameters)
    {
        var uriStr = uri.ToString();

        var queryString = new string(uriStr.SkipWhile(c => c != '?').ToArray());
        var baseUri = uriStr.Substring(0, uriStr.Length - queryString.Length);
        var currentparams = HttpUtility.ParseQueryString(queryString);

        foreach (var (key, value) in parameters)
        {
            currentparams[key] = value;
        }

        var tuples = currentparams.ToTuples();

        var newUri =
            string.Join("&", tuples.Select(t =>
            {
                if (t.name == null)
                    return t.value;
                return t.name + "=" + t.value;
            }));

        var suffix = newUri == "" ? "" : "?" + newUri;
        var finalUri = new Uri(baseUri + suffix);
        return finalUri;
    }
}