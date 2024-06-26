namespace AluraTamagotchiPokemon.View.MenuUtils;

public class Menu : MenuBase
{
    public string Message { get; set; }

    public Menu(string name, string title, string message) : base(name, title)
    {
        this.Message = message;
    }

    internal override void Execute()
    {
        this.ShowMenuOptions();
    }

    internal override void ShowMenuOptions()
    {

        ShowTitle(this.Title);

        int key = -1;
        string selectedOption = String.Empty;

        do
        {

            Console.WriteLine($"{Name}, {Message}");

            base.ShowMenuOptions();

            selectedOption = Console.ReadLine();

            ExecuteMenuOptionSelected(selectedOption, out key);

        } while (!(Exit(key)));
    }
    internal override void ExecuteMenuOptionSelected(string selectedOption, out int key)
    {
        if (!IsValidMenuOptionSelected(selectedOption, out key))
        {
            Console.WriteLine("Opcao Inválida");
            WaitAnyKeytoContinue();
            return;
        }

        if (menuOptions[key].Subsection())
        {
            ShowTitle("");
        }

        menuOptions[key].Execute();
    }

    internal bool IsValidMenuOptionSelected(string selectedOption, out int key)
    {

        if (!int.TryParse(selectedOption, out key))
        {
            return false;
        }

        if (!menuOptions.ContainsKey(key))
        {
            return false;
        }
        return true;
    }


    public static void ShowLogo()
    {

        Console.Clear();

        string logo = @"
▀█▀ ▄▀█ █▀▄▀█ ▄▀█ █▀▀ █▀█ █▀▀ █░█ █
░█░ █▀█ █░▀░█ █▀█ █▄█ █▄█ █▄▄ █▀█ █";

        Console.WriteLine(logo);
        Console.WriteLine();
    }

    internal static void ShowEgg()
    {

        string egg = @"
   ░██ 
  ░█████ 
░████████
░████████ 
░████████ 
  ░████ 
   ░██
   ░";

        Console.WriteLine(egg);
        Console.WriteLine();
    }


    internal bool Exit(int key)
    {

        if (!menuOptions.ContainsKey(key))
        {

            return false;
        }

        return menuOptions[key].Exit();
    }
}
