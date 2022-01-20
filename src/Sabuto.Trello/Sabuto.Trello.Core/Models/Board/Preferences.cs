namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The preferences class
/// </summary>

public class Preferences
{
    /// <summary>
    /// Gets or sets the value of the invitations
    /// </summary>
    public InvitationPermission Invitations { get; set; }
    /// <summary>
    /// Gets or sets the value of the comments
    /// </summary>
    public CommentPermission Comments { get; set; }
    /// <summary>
    /// Gets or sets the value of the voting
    /// </summary>
    public VotingPermission Voting { get; set; }
    /// <summary>
    /// Gets or sets the value of the permission level
    /// </summary>
    public PermissionLevel PermissionLevel { get; set; }
}