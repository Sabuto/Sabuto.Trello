namespace Sabuto.Trello.Core.Models.Board;

public struct BoardMember
{
    public string Id { get; set; }
    public string IdMember { get; set; }
    public string MemberType { get; set; }
    public bool Unconfirmed { get; set; }
    public bool Deactivated { get; set; }
    public Member.Member Member { get; set; }
}