namespace Sabuto.Trello.Core.Models.Board;

public struct CustomField
{
    public string Id { get; set; }
    public string IdModel { get; set; }
    public string ModelType { get; set; }
    public string FieldGroup { get; set; }
    public CustomFieldDisplay Display { get; set; }
    public string Type { get; set; }
}