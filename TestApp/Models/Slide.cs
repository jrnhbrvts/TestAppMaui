using System.Text.Json.Serialization;

namespace TestApp.Models;

public class Slide
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("image")]
    public string Image { get; set; }
    [JsonPropertyName("position")]
    public int Position { get; set; }
    [JsonPropertyName("contenttype")]
    public int? ContentType { get; set; }
    [JsonPropertyName("buttontext")]
    public string? ButtonText { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}