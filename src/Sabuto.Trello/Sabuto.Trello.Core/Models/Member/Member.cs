namespace Sabuto.Trello.Core.Models.Member;

public struct Member
{
    public string Id { get; set; }
    public bool ActivityBlocked { get; set; }
    public string avatarHash { get; set; }
    public string AvatarUrl { get; set; }
    public string FullName { get; set; }
    public string IdMemberReferrer { get; set; }
    public string Initials { get; set; }
    public string Username { get; set; }
}