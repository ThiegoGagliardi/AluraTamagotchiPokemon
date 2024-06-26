namespace AluraTamagotchiPokemon.View.MenuUtils.MenuOptions;

public class MenuOptionDelegate : IMenuOption
{

    public string Title { get; set; }

    public bool IsExit { get; set; } = false;

    public bool IsSubsection { get; set; } = false;

    public delegate void optionDelegate();

    public optionDelegate handler { get; set; }

    public MenuOptionDelegate(string Title, optionDelegate callback, bool isExit, bool isSubsection)
    {
        this.Title = Title;
        this.handler = callback;
        this.IsExit = isExit;
        this.IsSubsection = isSubsection;
    }

    public void Execute()
    {
        if (handler != null)
        {
            handler();
        }
    }

    public string GetTitle()
    {
        return this.Title;
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