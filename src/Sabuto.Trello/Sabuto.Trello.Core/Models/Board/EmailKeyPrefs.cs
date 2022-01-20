namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The email key prefs
/// </summary>

public struct EmailKeyPrefs
{
    /// <summary>
    /// Gets or sets the value of the show sidebar
    /// </summary>
    public bool ShowSidebar { get; set; }
    /// <summary>
    /// Gets or sets the value of the show sidebar members
    /// </summary>
    public bool ShowSidebarMembers { get; set; }
    /// <summary>
    /// Gets or sets the value of the show sidebar board actions
    /// </summary>
    public bool ShowSidebarBoardActions { get; set; }
    /// <summary>
    /// Gets or sets the value of the show sidebar activity
    /// </summary>
    public bool showSidebarActivity { get; set; }
    /// <summary>
    /// Gets or sets the value of the show list guide
    /// </summary>
    public bool ShowListGuide { get; set; }
    /// <summary>
    /// Gets or sets the value of the id email list
    /// </summary>
    public string IdEmailList { get; set; }
    /// <summary>
    /// Gets or sets the value of the email position
    /// </summary>
    public string EmailPosition { get; set; }
}