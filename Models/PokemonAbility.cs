using System.Text.Json.Serialization;

namespace AluraTamagotchiPokemon.Models;

public class PokemonAbility
{

    [JsonPropertyName("name")]
    public PokemonResumeDto Ability { get; set; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public int Slot { get; set; }

    public override string ToString()
    {
        return this.Ability.Name;
    }

}
