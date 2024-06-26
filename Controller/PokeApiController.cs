using AluraTamagotchiPokemon.Models;
using AluraTamagotchiPokemon.Utils.PokeApiutils;

namespace AluraTamagotchiPokemon.Controller;

public class PokeApiController
{
    public Pokemon GetPokemon(string name)
    {
        try
        {
            return PokeAPIHandler.GetPokemonsAsync(name).GetAwaiter().GetResult();
        }
        catch (System.Exception e)
        {

            throw new Exception($"Erro ao buscar pokemon: {e.Message}");
        }

    }

}