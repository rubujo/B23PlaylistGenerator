using System.Text.Json.Serialization;

namespace BilibiliApi.Models.VideoZone.Sports;

/// <summary>
/// ιε -> θΆ³η (football)
/// </summary>
public class Tag249
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}