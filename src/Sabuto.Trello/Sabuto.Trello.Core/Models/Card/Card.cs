namespace Sabuto.Trello.Core.Models.Card;

public struct Card
{
    public string Id { get; set; }
    public bool Closed { get; set; }
    public DateTime DateLastActivity { get; set; }
    public string Desc { get; set; }
    public object DescData { get; set; }
    public string DueReminder { get; set; }
    public string IdBoard { get; set; }
    public string IdList { get; set; }
    public List<object> IdembersVoted { get; set; }
    public int IdShort { get; set; }
    public string IdAttachmentCover { get; set; }
    public List<string> IdLabels { get; set; }
    public bool ManualCoverAttachment { get; set; }
    public string Name { get; set; }
    public int Pos { get; set; }
    public string ShortLink { get; set; }
    public bool IsTemplate { get; set; }
    public object CardRole { get; set; }
    public Badge.Badge Badges { get; set; }
    public bool DueComplete { get; set; }
    public List<string> IdChecklists { get; set; }
    public List<string> IdMembers { get; set; }
    public List<object> Labels { get; set; }
    public string ShortUrl { get; set; }
    public object Start { get; set; }
    public bool Subscribed { get; set; }
    public string Url { get; set; }
    public Cover Cover { get; set; }
}