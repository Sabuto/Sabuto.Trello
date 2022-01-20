namespace Sabuto.Trello.Core.Extensions;

/// <summary>
/// The dictionary extensions class
/// </summary>
public static class Dictionary
{
    /// <summary>
    /// Adds the range using the specified source
    /// </summary>
    /// <typeparam name="T">The key</typeparam>
    /// <typeparam name="TS">The value</typeparam>
    /// <param name="source">The source Dictionary</param>
    /// <param name="target">The target Dictionary</param>
    /// <exception cref="ArgumentNullException">Target is null</exception>
    public static void AddRange<T, TS>(this Dictionary<T, TS> source, Dictionary<T, TS> target) where T : notnull
    {
        if (target == null)
            throw new ArgumentNullException("Target is null");

        foreach ((T? key, TS? value) in target.Where(se => !source.ContainsKey(se.Key)))
        {
            source.Add(key, value);
        }
    }
}