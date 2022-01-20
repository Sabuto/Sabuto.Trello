namespace Sabuto.Trello.Core.Models.Member;

/// <summary>
/// The member
/// </summary>

public struct Member
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the activity blocked
    /// </summary>
    public bool ActivityBlocked { get; set; }
    /// <summary>
    /// Gets or sets the value of the avatar hash
    /// </summary>
    public string avatarHash { get; set; }
    /// <summary>
    /// Gets or sets the value of the avatar url
    /// </summary>
    public string AvatarUrl { get; set; }
    /// <summary>
    /// Gets or sets the value of the full name
    /// </summary>
    public string FullName { get; set; }
    /// <summary>
    /// Gets or sets the value of the id member referrer
    /// </summary>
    public string IdMemberReferrer { get; set; }
    /// <summary>
    /// Gets or sets the value of the initials
    /// </summary>
    public string Initials { get; set; }
    /// <summary>
    /// Gets or sets the value of the username
    /// </summary>
    public string Username { get; set; }
}