
using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;
public class SuperHero
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("powerstats")]
    public PowerStats? PowerStats { get; set; }

    [JsonPropertyName("biography")]
    public Biography? Biography { get; set; }

    [JsonPropertyName("appearance")]
    public Appearance? Appearance { get; set; }

    [JsonPropertyName("work")]
    public Work? Work { get; set; }

    [JsonPropertyName("connections")]
    public Connections? Connections { get; set; }

    [JsonPropertyName("image")]
    public HeroImage? Image { get; set; }
}
