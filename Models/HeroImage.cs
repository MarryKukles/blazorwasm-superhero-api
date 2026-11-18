
using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;
public class HeroImage
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
