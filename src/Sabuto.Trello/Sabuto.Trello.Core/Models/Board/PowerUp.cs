namespace Sabuto.Trello.Core.Models.Board;

public struct PowerUp
{
    public string Id { get; set; }
    public string idOrganizationOwner { get; set; }
    public string Author { get; set; }
    public List<string> Capabilities { get; set; }
    public List<string> Categories { get; set; }
}