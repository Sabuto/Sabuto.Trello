namespace Sabuto.Trello.Core.Models.Badge;

public struct Badge
{
    public bool Location { get; set; }
    public int Votes { get; set; }
    public bool ViewingMemberVoted { get; set; }
    public bool Subscribed { get; set; }
    public object Fogbugz { get; set; }
    public int CheckItems { get; set; }
    public int CheckItemsChecked { get; set; }
    public object CheckItemsEarliestDue { get; set; }
    public object Comments { get; set; }
    public object Attachments { get; set; }
    public bool Description { get; set; }
    public object Due { get; set; }
    public bool DueComplete { get; set; }
    public object Start { get; set; }
}