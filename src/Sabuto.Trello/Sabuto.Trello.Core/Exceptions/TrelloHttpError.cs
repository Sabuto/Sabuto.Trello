namespace Sabuto.Trello.Core.Exceptions;

/// <summary>
/// The trello http error class
/// </summary>

/// <seealso cref="Exception"/>

public class TrelloHttpError : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrelloHttpError"/> class
    /// </summary>
    /// <param name="message">The message returned to the user</param>
    public TrelloHttpError(string message) : base(message)
    {
    }
}