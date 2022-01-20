namespace Sabuto.Trello.Core.Models.Board;

/// <summary>
/// The board member
/// </summary>

public struct BoardMember
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the id member
    /// </summary>
    public string IdMember { get; set; }
    /// <summary>
    /// Gets or sets the value of the member type
    /// </summary>
    public string MemberType { get; set; }
    /// <summary>
    /// Gets or sets the value of the unconfirmed
    /// </summary>
    public bool Unconfirmed { get; set; }
    /// <summary>
    /// Gets or sets the value of the deactivated
    /// </summary>
    public bool Deactivated { get; set; }
    /// <summary>
    /// Gets or sets the value of the member
    /// </summary>
    public Member.Member Member { get; set; }
}