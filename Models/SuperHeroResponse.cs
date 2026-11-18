
using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;
public class SuperHeroResponse
{
    [JsonPropertyName("response")]
    public string? Response { get; set; }

    [JsonPropertyName("results-for")]
    public string? ResultsFor { get; set; }

    [JsonPropertyName("results")]
    public List<SuperHero>? Results { get; set; }
}
