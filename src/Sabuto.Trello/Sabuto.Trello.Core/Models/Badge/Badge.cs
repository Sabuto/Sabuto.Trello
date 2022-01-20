namespace Sabuto.Trello.Core.Models.Badge;

/// <summary>
/// The badge
/// </summary>

public struct Badge
{
    /// <summary>
    /// Gets or sets the value of the location
    /// </summary>
    public bool Location { get; set; }
    /// <summary>
    /// Gets or sets the value of the votes
    /// </summary>
    public int Votes { get; set; }
    /// <summary>
    /// Gets or sets the value of the viewing member voted
    /// </summary>
    public bool ViewingMemberVoted { get; set; }
    /// <summary>
    /// Gets or sets the value of the subscribed
    /// </summary>
    public bool Subscribed { get; set; }
    /// <summary>
    /// Gets or sets the value of the fogbugz
    /// </summary>
    public object Fogbugz { get; set; }
    /// <summary>
    /// Gets or sets the value of the check items
    /// </summary>
    public int CheckItems { get; set; }
    /// <summary>
    /// Gets or sets the value of the check items checked
    /// </summary>
    public int CheckItemsChecked { get; set; }
    /// <summary>
    /// Gets or sets the value of the check items earliest due
    /// </summary>
    public object CheckItemsEarliestDue { get; set; }
    /// <summary>
    /// Gets or sets the value of the comments
    /// </summary>
    public object Comments { get; set; }
    /// <summary>
    /// Gets or sets the value of the attachments
    /// </summary>
    public object Attachments { get; set; }
    /// <summary>
    /// Gets or sets the value of the description
    /// </summary>
    public bool Description { get; set; }
    /// <summary>
    /// Gets or sets the value of the due
    /// </summary>
    public object Due { get; set; }
    /// <summary>
    /// Gets or sets the value of the due complete
    /// </summary>
    public bool DueComplete { get; set; }
    /// <summary>
    /// Gets or sets the value of the start
    /// </summary>
    public object Start { get; set; }
}