using System.Text;
using AluraTamagotchiPokemon.View.MenuUtils.MenuOptions;

namespace AluraTamagotchiPokemon.View.MenuUtils;

public abstract class MenuBase
{
    protected string Name { get; set; }

    protected string Title { get; set; }

    protected Dictionary<int, IMenuOption> menuOptions = new();

    public MenuBase(string name, string title)
    {
        this.Name = name;
        this.Title = title;
    }

    internal abstract void Execute();

    internal virtual void ShowMenuOptions()
    {
        foreach (var m in menuOptions)
        {
            Console.WriteLine($"{m.Key}-{m.Value.GetTitle()}");
        }
    }

    internal void AddMenuOption(IMenuOption menuOption)
    {

        int index = menuOptions.Count + 1;

        menuOptions.Add(index, menuOption);
    }

    internal abstract void ExecuteMenuOptionSelected(string selectedOption, out int key);

    protected void ShowTitle(string title)
    {
        if (string.IsNullOrEmpty(title))
        {
            Console.WriteLine("********************");
            Console.WriteLine();
            return;
        }

        StringBuilder sb = new StringBuilder("*", title.Length + 2);

        for (int i = 0; i < title.Length + 2; i++)
        {
            sb.Insert(0, "*");
        }

        string label = sb.ToString();

        Console.WriteLine();
        Console.WriteLine(label);
        Console.WriteLine("  " + Title);
        Console.WriteLine(label);
        Console.WriteLine();
    }

    internal static void WaitAnyKeytoContinue()
    {

        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
    }
}