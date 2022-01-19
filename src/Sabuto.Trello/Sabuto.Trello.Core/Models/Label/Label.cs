namespace Sabuto.Trello.Core.Models.Label;

public struct Label
{
    public string Id { get; set; }
    public string IdBoard { get; set; }
    public string Name { get; set; }
    public LabelColor Color { get; set; }
}