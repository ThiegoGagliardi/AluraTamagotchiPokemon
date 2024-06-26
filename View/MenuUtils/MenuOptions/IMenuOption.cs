namespace AluraTamagotchiPokemon.View.MenuUtils.MenuOptions;

public interface IMenuOption
{
    string GetTitle();

    void Execute();

    bool Exit();

    bool Subsection();

}
