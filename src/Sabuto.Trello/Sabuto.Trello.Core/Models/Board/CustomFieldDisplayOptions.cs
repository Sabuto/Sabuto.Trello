namespace Sabuto.Trello.Core.Models.Board;

public struct CustomFieldDisplayOptions
{
    public string Id { get; set; }
    public string IdCustomField { get; set; }
    public object Value { get; set; }
    public string Color { get; set; }
    public int Pos { get; set; }
}