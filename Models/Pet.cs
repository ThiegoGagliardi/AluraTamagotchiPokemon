using System.Text;
namespace AluraTamagotchiPokemon.Models;

public class Pet
{

    const double FATTENING_PERCENTAGE = 0.02;
    public string Name { get; set; }

    public List<PokemonType> Types { get; set; }

    public double Weight { get; private set; }    
        
    public int Height { get;  private set; }    

    public int Feeding { get; private set; } = 0;

    public int Humor { get; private set; }

    public Pet(string name,  List<PokemonType> types, int weight, int height)
    {
        this.Name = name;
        this.Weight = weight;
        this.Height = height;
        this.Types = types;
        
        Feeding = 0;
        Humor = 0;
    }

    public void Play()
    {
        if (Feeding > 0)
        {
            Humor++;
            Feeding--;
        }

        this.Weight -= this.Weight *= FATTENING_PERCENTAGE;
    }

    public void Feed()
    {
        if (Feeding < 10)
        {
            Feeding++;
        }

        this.Weight += this.Weight *= FATTENING_PERCENTAGE;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"Name: {this.Name} {Environment.NewLine}");        
        sb.Append($"Peso: {this.Weight} {Environment.NewLine}");
        sb.Append($"Humor: {this.Humor} {Environment.NewLine}");
        sb.Append($"Alimentaçao: {this.Feeding} {Environment.NewLine}");

        return sb.ToString();
    }
}

