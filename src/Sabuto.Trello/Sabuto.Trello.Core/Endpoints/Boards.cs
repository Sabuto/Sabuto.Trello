using System.Reflection;
using Flurl.Util;
using Newtonsoft.Json.Linq;
using Sabuto.Trello.Core.Base;
using Sabuto.Trello.Core.Exceptions;
using Sabuto.Trello.Core.Extensions;
using Sabuto.Trello.Core.Models.Action;
using Sabuto.Trello.Core.Models.Board;
using Sabuto.Trello.Core.Models.Interfaces.Board;
using Sabuto.Trello.Core.Models.Label;

namespace Sabuto.Trello.Core.Endpoints;

/// <summary>
/// The boards Wrapper class
/// </summary>
/// <seealso cref="Client"/>
public class Boards : Client
{
    /// <summary>
    /// A list of default paths to add to every request
    /// </summary>
    private readonly List<string> _paths = new List<string> { "boards" };

    /// <summary>
    /// Initializes a new instance of the <see cref="Boards"/> class
    /// </summary>
    /// <param name="applicationKey">The application key</param>
    /// <param name="apiToken">The api token</param>
    public Boards(string applicationKey, string apiToken) : base(applicationKey, apiToken)
    {
    }

    /// <summary>
    /// Gets the board using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing the board</returns>
    public async Task<Board> GetBoard(string boardId)
    {
        var paths = new List<string>(_paths) { boardId };
        return await Get<Board>(paths);
    }

    /// <summary>
    /// Creates the board using the specified board
    /// </summary>
    /// <param name="board">The board</param>
    /// <returns>A task containing the created board</returns>
    public async Task<Board> CreateBoard(NewBoard board)
    {
        Dictionary<string, string> qp = new Dictionary<string, string>();
        foreach (PropertyInfo property in board.GetType().GetProperties())
        {
            if (property.GetValue(board) == null)
                continue;
            qp.Add(property.Name.ToLower(), property.GetValue(board)?.ToString());
        }

        return await Post<Board>(_paths, qp);
    }

    /// <summary>
    /// Deletes the board using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing the result</returns>
    public async Task<bool> DeleteBoard(string boardId)
    {
        var paths = new List<string>(_paths) { boardId };
        return await Delete(paths);
    }

    /// <summary>
    /// Updates the board using the specified board
    /// </summary>
    /// <param name="board">The board</param>
    /// <returns>A task containing the bool</returns>
    public async Task<bool> UpdateBoard(IUpdateableBoard board)
    {
        Dictionary<string, string> qp = new Dictionary<string, string>();
        foreach (PropertyInfo property in board.GetType().GetInterfaces().SelectMany(i => i.GetProperties()))
        {
            var value = property.GetValue(board);
            if (value == null)
                continue;
            if (property.Name == "Id")
                continue;
            if (value.ToString() == "True" || value.ToString() == "False")
                value = value.ToString().ToLower();
            else
                value = value.ToString();
            qp.Add(property.Name.ToLower(), (string)value);
        }

        var paths = new List<string>(_paths) { board.Id };
        return await Put(paths, qp);
    }

    /// <summary>
    /// Gets the actions of a board using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing a list of TrelloActions</returns>
    public async Task<List<TrelloAction>> GetActions(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "actions" };
        return await Get<List<TrelloAction>>(paths);
    }

    /// <summary>
    /// Gets the stars using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing a list of board stars</returns>
    public async Task<List<BoardStars>> GetStars(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "boardStars" };
        return await Get<List<BoardStars>>(paths);
    }

    /// <summary>
    /// Gets the labels using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing a list of label</returns>
    public async Task<List<Label>> GetLabels(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "labels" };
        return await Get<List<Label>>(paths);
    }

    /// <summary>
    /// Creates the label using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <param name="label">The label</param>
    /// <exception cref="TrelloHttpError">Label name and Colour cannot be null</exception>
    /// <returns>A task containing the bool</returns>
    public async Task<bool> CreateLabel(string boardId, Label label)
    {
        var paths = new List<string>(_paths) { boardId, "labels" };
        var qp = new Dictionary<string, string>();
        if (label.Name == null && label.Color == null)
            throw new TrelloHttpError("Label name and Colour cannot be null");
        qp.Add("name", label.Name);
        qp.Add("color", Enum.GetName(label.Color));
        await Post(paths, qp);
        return true;
    }

    /// <summary>
    /// Gets the memberships using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing a list of board member</returns>
    public async Task<List<BoardMember>> GetMemberships(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "memberships" };
        var qp = new Dictionary<string, string>();
        qp.Add("member", "true");
        qp.Add("activity", "true");
        qp.Add("orgMemberType ", "true");
        return await Get<List<BoardMember>>(paths, qp);
    }

    /// <summary>
    /// Gets the field using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <param name="field">The field</param>
    /// <returns>A task containing the object</returns>
    public async Task<object> GetField(string boardId, BoardFields field)
    {
        var paths = new List<string>(_paths) { boardId, Enum.GetName(field) };
        return await Get<object>(paths);
    }

    /// <summary>
    /// Marks the as viewed using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    public async Task MarkAsViewed(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "markedAsViewed" };
        await Post(paths);
    }

    /// <summary>
    /// Creates the email key using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing the email key</returns>
    public async Task<EmailKey> CreateEmailKey(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "emailKey", "generate" };
        return await Post<EmailKey>(paths);
    }

    /// <summary>
    /// Creates the calendar key using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <returns>A task containing the object</returns>
    public async Task<object> CreateCalendarKey(string boardId)
    {
        var paths = new List<string>(_paths) { boardId, "calendarKey", "generate" };
        return await Post<object>(paths);
    }

    /// <summary>
    /// Gets the power ups using the specified board id
    /// </summary>
    /// <param name="boardId">The board id</param>
    /// <param name="filter">The filter</param>
    /// <returns>A task containing the object</returns>
    public async Task<object> GetPowerUps(string boardId, PowerUpsOptions filter = PowerUpsOptions.enabled)
    {
        var paths = new List<string>(_paths) { boardId, "plugins" };
        var qp = new Dictionary<string, string>();
        qp.Add("filter", Enum.GetName(filter));
        return await Get<object>(paths, qp);
    }
}