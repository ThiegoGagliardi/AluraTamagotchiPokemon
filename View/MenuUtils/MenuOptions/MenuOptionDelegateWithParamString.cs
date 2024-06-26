namespace AluraTamagotchiPokemon.View.MenuUtils.MenuOptions;

public class MenuOptionDelegateWithParam : IMenuOption
{
    public string Title { get; set; }
    public string Param { get; set; }
    public bool IsExit { get; set; } = false;
    public bool IsSubsection { get; set; } = false;

    public delegate void DelegateWithParam(string pokemonName);

    public DelegateWithParam GetPoke { get; set; }

    public MenuOptionDelegateWithParam(string title, string param, DelegateWithParam getPokemon, bool isExit, bool isSubsection)
    {
        this.Param = param;
        this.Title = title;
        this.GetPoke = getPokemon;
        this.IsExit = isExit;
        this.IsSubsection = isSubsection;
    }

    public void Execute()
    {
        this.GetPoke(Param);
    }

    public string GetTitle()
    {
        return Title;
    }

    public bool Exit()
    {
        return IsExit;
    }

    public bool Subsection()
    {
        return IsSubsection;
    }
}