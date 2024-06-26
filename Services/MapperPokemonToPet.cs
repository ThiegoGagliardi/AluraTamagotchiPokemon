using AutoMapper;

using AluraTamagotchiPokemon.Models;

namespace AluraTamagotchiPokemon.Services;

public class MapperPokemonToPet
{
    public Pet CreatePet(Pokemon pokemon)
    {
        var configuration = new MapperConfiguration(cfg =>
        cfg.CreateMap<Pokemon, Pet>());

        var mapper = configuration.CreateMapper();
        return mapper.Map<Pokemon, Pet>(pokemon);
    }
}
