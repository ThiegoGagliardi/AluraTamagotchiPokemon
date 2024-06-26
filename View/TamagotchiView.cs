using AluraTamagotchiPokemon.View.MenuUtils;
using AluraTamagotchiPokemon.View.MenuUtils.MenuOptions;
using static AluraTamagotchiPokemon.View.MenuUtils.MenuOptions.MenuOptionDelegateWithParam;
using static AluraTamagotchiPokemon.View.MenuUtils.MenuOptions.MenuOptionDelegate;
using AluraTamagotchiPokemon.Models;

namespace AluraTamagotchiPokemon.View;

public class TamagotchiView
{
    public Menu BuildMainMenu(string name, optionDelegate specieMenuBuilder, optionDelegate interationMenuBuilder, optionDelegate  exit)
    {
        Menu menu = new(name, "Menu", "você deseja:");

        menu.AddMenuOption(new MenuOptionDelegate("Adotar um mascote virtual", specieMenuBuilder, false, true));
        menu.AddMenuOption(new MenuOptionDelegate("Ver seus mascote", interationMenuBuilder, false, true));
        menu.AddMenuOption(new MenuOptionDelegate("Sair", exit, true, false));

        return menu;
    }

    public Menu BuildSpecieMenu(string name,DelegateWithParam getPoke)
    {
        Menu specieMenu = new(name, "ADOTAR UM MASCOTE", "escolha uma espécie:");

        specieMenu.AddMenuOption(new MenuOptionDelegateWithParam("Squirtle", "squirtle", getPoke, true, false));
        specieMenu.AddMenuOption(new MenuOptionDelegateWithParam("Charmander", "charmander", getPoke, true, false));
        specieMenu.AddMenuOption(new MenuOptionDelegateWithParam("Bulbasaur", "bulbasaur", getPoke, true, false));
        specieMenu.AddMenuOption(new MenuOptionDelegateWithParam("Pikachu", "pikachu", getPoke, true, false));        

        return specieMenu;
    }

    public Menu BuildAdoptionMenu(string name,Pokemon pokemon, optionDelegate showPokemonDetails,optionDelegate addPet){

        Menu adoptionMenu = new(name, "", "você deseja:");

        adoptionMenu.AddMenuOption(new MenuOptionDelegate($"Saber mais sobre {pokemon.Name}", showPokemonDetails, false, true));
        adoptionMenu.AddMenuOption(new MenuOptionDelegate($"Adotar {pokemon.Name}", addPet, true, true));
        adoptionMenu.AddMenuOption(new MenuOptionDelegate("Voltar", null, true, false));

        return  adoptionMenu;  

    }

    public Menu BuildInterationMenu(string name, Pet pet,optionDelegate showPetDetails, optionDelegate feedPet, optionDelegate playPet){
        
        Menu interationMenu = new(name, "", "você deseja:");

        interationMenu.AddMenuOption(new MenuOptionDelegate($"Saber como o {pet.Name}", showPetDetails, false, true));
        interationMenu.AddMenuOption(new MenuOptionDelegate($"Alimentar o {pet.Name}", feedPet, false, true));
        interationMenu.AddMenuOption(new MenuOptionDelegate($"Brincar com {pet.Name}", playPet, false, true));
        interationMenu.AddMenuOption(new MenuOptionDelegate("Voltar", null, true, false));

        return interationMenu;       
    }
}
