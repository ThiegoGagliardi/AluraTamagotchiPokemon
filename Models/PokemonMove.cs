using System.Text.Json.Serialization;

namespace AluraTamagotchiPokemon.Models;

public class PokemonMove
{

    [JsonPropertyName("move")]
    public PokemonResumeDto Move { get; set; }

    public override string ToString()
    {
        return this.Move.Name;
    }
}
