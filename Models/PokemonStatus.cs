namespace AluraTamagotchiPokemon.Models;

public class PokemonStatus
{

    public int base_stat { get; set; }
    public int effort { get; set; }
    public PokemonResumeDto Status { get; set; }

    public override string ToString()
    {
        return this.Status.Name;
    }
}