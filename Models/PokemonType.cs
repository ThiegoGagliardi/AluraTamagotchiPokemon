
namespace AluraTamagotchiPokemon.Models;

public class PokemonType
{

    public int Slot { get; set; }
    public PokemonResumeDto Type { get; set; }

    public override string ToString()
    {
        return this.Type.Name;
    }
}
