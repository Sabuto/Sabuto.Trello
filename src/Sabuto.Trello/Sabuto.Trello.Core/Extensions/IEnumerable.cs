using System.Collections.Specialized;

namespace Sabuto.Trello.Core.Extensions;

/// <summary>

/// The enumerable class

/// </summary>

public static class IEnumerable
{
    /// <summary>
    /// Returns the tuples using the specified collection
    /// </summary>
    /// <param name="collection">The collection</param>
    /// <exception cref="ArgumentNullException">collection</exception>
    /// <returns>An enumerable of string name and string value</returns>
    public static IEnumerable<(string name, string value)> ToTuples(this NameValueCollection collection)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        return
            from key in collection.Cast<string>()
            from value in collection.GetValues(key)
            select (key, value);
    }
}