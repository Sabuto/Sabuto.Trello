using Newtonsoft.Json;

namespace Sabuto.Trello.Core.Models.Card;

public class NewCard
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("idList")]
    public string idList { get; set; }

    [JsonProperty("desc")]
    public string desc { get; set; }

    public NewCard(string name, string idList)
    {
        this.idList = idList;
        this.name = name;
    }
}