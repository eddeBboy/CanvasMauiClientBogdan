using System.Text.Json.Serialization;
namespace CanvasMauiClientBogdan.Models;

public record class Group 
{
    [JsonPropertyName("id")]
    public int GroupId { get; set; }

    [JsonPropertyName("name")]
    public string GroupName { get; set; }

    [JsonPropertyName("created_at")]
    public string GroupStart { get; set; }

    [JsonPropertyName("members_count")]
    
    public int CountMembers { get; set; }
}