namespace Sabuto.Trello.Core.Models.Card;

/// <summary>
/// The card
/// </summary>

public struct Card
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the closed
    /// </summary>
    public bool Closed { get; set; }
    /// <summary>
    /// Gets or sets the value of the date last activity
    /// </summary>
    public DateTime DateLastActivity { get; set; }
    /// <summary>
    /// Gets or sets the value of the desc
    /// </summary>
    public string Desc { get; set; }
    /// <summary>
    /// Gets or sets the value of the desc data
    /// </summary>
    public object DescData { get; set; }
    /// <summary>
    /// Gets or sets the value of the due reminder
    /// </summary>
    public string DueReminder { get; set; }
    /// <summary>
    /// Gets or sets the value of the id board
    /// </summary>
    public string IdBoard { get; set; }
    /// <summary>
    /// Gets or sets the value of the id list
    /// </summary>
    public string IdList { get; set; }
    /// <summary>
    /// Gets or sets the value of the idembers voted
    /// </summary>
    public List<object> IdembersVoted { get; set; }
    /// <summary>
    /// Gets or sets the value of the id short
    /// </summary>
    public int IdShort { get; set; }
    /// <summary>
    /// Gets or sets the value of the id attachment cover
    /// </summary>
    public string IdAttachmentCover { get; set; }
    /// <summary>
    /// Gets or sets the value of the id labels
    /// </summary>
    public List<string> IdLabels { get; set; }
    /// <summary>
    /// Gets or sets the value of the manual cover attachment
    /// </summary>
    public bool ManualCoverAttachment { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the pos
    /// </summary>
    public int Pos { get; set; }
    /// <summary>
    /// Gets or sets the value of the short link
    /// </summary>
    public string ShortLink { get; set; }
    /// <summary>
    /// Gets or sets the value of the is template
    /// </summary>
    public bool IsTemplate { get; set; }
    /// <summary>
    /// Gets or sets the value of the card role
    /// </summary>
    public object CardRole { get; set; }
    /// <summary>
    /// Gets or sets the value of the badges
    /// </summary>
    public Badge.Badge Badges { get; set; }
    /// <summary>
    /// Gets or sets the value of the due complete
    /// </summary>
    public bool DueComplete { get; set; }
    /// <summary>
    /// Gets or sets the value of the id checklists
    /// </summary>
    public List<string> IdChecklists { get; set; }
    /// <summary>
    /// Gets or sets the value of the id members
    /// </summary>
    public List<string> IdMembers { get; set; }
    /// <summary>
    /// Gets or sets the value of the labels
    /// </summary>
    public List<object> Labels { get; set; }
    /// <summary>
    /// Gets or sets the value of the short url
    /// </summary>
    public string ShortUrl { get; set; }
    /// <summary>
    /// Gets or sets the value of the start
    /// </summary>
    public object Start { get; set; }
    /// <summary>
    /// Gets or sets the value of the subscribed
    /// </summary>
    public bool Subscribed { get; set; }
    /// <summary>
    /// Gets or sets the value of the url
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Gets or sets the value of the cover
    /// </summary>
    public Cover Cover { get; set; }
}