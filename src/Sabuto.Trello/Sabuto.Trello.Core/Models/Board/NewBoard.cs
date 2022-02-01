using Refit;

namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// Represents a new board when creating via the api
/// </summary>
public class NewBoard
{
    /// <summary>
    /// The name of the board. 1 to 16384 characters long
    /// </summary>
    [AliasAs("name")]
    public string Name { get; set; }

    /// <summary>
    /// Determines whether to use the default set of labels.
    /// </summary>
    [AliasAs("defaultLabels")]
    public bool DefaultLabels { get; set; } = true;

    /// <summary>
    /// Determines whether to add the default set of lists to a board (To Do, Doing, Done). It is ignored if <see cref="IdBoardSource"/> is provided.
    /// </summary>
    [AliasAs("defaultLists")]
    public bool DefaultLists { get; set; } = true;

    /// <summary>
    /// A new description for the board, 0 to 16384 characters long
    /// </summary>
    public string? Desc { get; set; }

    /// <summary>
    /// The id or name of the Workspace the board should belong to.
    /// </summary>
    public string? IdOrganization { get; set; }

    /// <summary>
    /// The id of a board to copy into the new board.
    /// </summary>
    public string IdBoardSource { get; set; }

    /// <summary>
    /// Create a new instance with the name property filled out
    /// </summary>
    /// <param name="name">The name of the board</param>
    public NewBoard(string name)
    {
        Name = name;
    }
}