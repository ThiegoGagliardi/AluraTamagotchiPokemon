using System.Text;

namespace AluraTamagotchiPokemon.Models;

public class Pokemon
{
    public List<PokemonAbility> Abilities { get; set; }
    public int Base_experience { get; set; }
    public int Height { get; set; }
    public int Id { get; set; }
    public bool Is_default { get; set; }
    public List<PokemonMove> Moves { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public List<PokemonStatus> Stats { get; set; }
    public List<PokemonType> Types { get; set; }
    public int Weight { get; set; }

    public override string ToString()
    {
        StringBuilder st = new StringBuilder();

        st.Append($"Order-Nome:{this.Order} - {this.Name}");
        st.Append($"{Environment.NewLine}");
        st.Append($"Altura: {this.Height}");
        st.Append($"{Environment.NewLine}");
        st.Append($"Peso: {this.Weight}");
        st.Append($"{Environment.NewLine}");
        st.Append("Tipos: ");
        Types.ForEach(t => st.Append(t.ToString() + ";"));
        st.Append($"{Environment.NewLine}");
        st.Append("Habilitades: ");
        Abilities.ForEach(t => st.Append(t.ToString() + ";"));
        st.Append($"{Environment.NewLine}");


        return st.ToString();
    }
}
