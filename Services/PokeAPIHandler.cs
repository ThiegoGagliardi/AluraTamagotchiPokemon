using AluraTamagotchiPokemon.Models;

namespace AluraTamagotchiPokemon.Utils.PokeApiutils;

public static class PokeAPIHandler
{
    const string URI_POKE_API = "https://pokeapi.co/api/v2";

    private static HttpClient pokeApi = new HttpClient();

    public static async Task<ListPokemonDto> GetAllPokemonsAsync()
    {
        ListPokemonDto pokemons = null;

        string path = $"{URI_POKE_API}/pokemon/?offset=0&limit=9999";

        HttpResponseMessage response = await pokeApi.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {

            // var results = response.Content.ReadAsStringAsync().Result;
            // pokemons    = JsonSerializer.Deserialize<ListPokemonDto>(results);
            pokemons = await response.Content.ReadAsAsync<ListPokemonDto>();
        }
        else
        {
            throw new Exception($"Erro ao buscar pokemon {response.Content.ReadAsStringAsync()}");
        }

        return pokemons;
    }

    public static async Task<Pokemon> GetPokemonsAsync(string name)
    {
        Pokemon pokemon = null;

        string path = $"{URI_POKE_API}/pokemon/{name}";

        HttpResponseMessage response = await pokeApi.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {

            // var results = response.Content.ReadAsStringAsync().Result;
            // pokemons    = JsonSerializer.Deserialize<ListPokemonDto>(results);
            pokemon = await response.Content.ReadAsAsync<Pokemon>();
        }
        else
        {
            throw new Exception($"{await response.Content.ReadAsStringAsync()}");
        }

        return pokemon;
    }
}