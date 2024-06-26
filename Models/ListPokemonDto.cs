using System.Text;
using System.Text.Json.Serialization;

namespace AluraTamagotchiPokemon.Models;

public class ListPokemonDto
{

     [JsonPropertyName("count")]
     public int Count { get; set; } = 0;

     [JsonPropertyName("next")]
     public string Next { get; set; } = String.Empty;

     [JsonPropertyName("previous")]
     public string Previous { get; set; } = String.Empty;

     [JsonPropertyName("results")]
     public List<PokemonResumeDto> Results { get; set; } = new List<PokemonResumeDto>();

     public override string ToString()
     {
          StringBuilder st = new StringBuilder();
          this.Results.ForEach(p => st.Append(p.ToString()));

          return st.ToString();
     }

}
