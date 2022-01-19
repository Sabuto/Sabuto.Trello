namespace Sabuto.Trello.Core.Models.Board;

public struct Preferences
{
    public InvitationPermission Invitations { get; set; }
    public CommentPermission Comments { get; set; }
    public VotingPermission Voting { get; set; }
    public PermissionLevel PermissionLevel { get; set; }
}