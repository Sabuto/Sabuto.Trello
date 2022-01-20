namespace Sabuto.Trello.Core.Models.Board;

public struct CustomFieldDisplay
{
    public bool CardFront { get; set; }
    public string Name { get; set; }
    public string Pos { get; set; }
    public List<CustomFieldDisplayOptions> Options { get; set; }
}