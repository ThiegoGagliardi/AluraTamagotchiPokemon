using System.Text.Json.Serialization;

namespace AluraTamagotchiPokemon.Models;

public class PokemonResumeDto
{

    [JsonPropertyName("name")]
    public string Name { get; set; } = String.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = String.Empty;

    public override string ToString()
    {
        return $"Name:{this.Name}; URL:{this.Url}";
    }

}
