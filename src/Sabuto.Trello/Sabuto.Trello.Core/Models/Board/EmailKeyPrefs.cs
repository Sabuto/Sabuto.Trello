namespace Sabuto.Trello.Core.Models.Board;

public struct EmailKeyPrefs
{
    public bool ShowSidebar { get; set; }
    public bool ShowSidebarMembers { get; set; }
    public bool ShowSidebarBoardActions { get; set; }
    public bool showSidebarActivity { get; set; }
    public bool ShowListGuide { get; set; }
    public string IdEmailList { get; set; }
    public string EmailPosition { get; set; }
}