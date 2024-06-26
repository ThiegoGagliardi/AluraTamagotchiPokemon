using AluraTamagotchiPokemon.Models;
using AluraTamagotchiPokemon.View.MenuUtils;
using AluraTamagotchiPokemon.View;
using AluraTamagotchiPokemon.Services;
using System.Linq.Expressions;

namespace AluraTamagotchiPokemon.Controller;

public class TamagotchiController
{
    Pet _pet;
    private string _name;

    private Pokemon _pokemon;

    private PokeApiController _pokeApi = new PokeApiController();

    internal void Execute()
    {
        Menu.ShowLogo();
        this.AskName();

        new TamagotchiView().BuildMainMenu(_name, SpecieMenuBuilder, InterationMenuBuilder, Exit).Execute();
    }

    internal void SpecieMenuBuilder()
    {
        new TamagotchiView().BuildSpecieMenu(_name, GetPoke).Execute();
    }

    internal void AdoptionMenuBuilder()
    {
        new TamagotchiView().BuildAdoptionMenu(_name, _pokemon, ShowPokemonDetails, AddPet).Execute();
    }

    internal void InterationMenuBuilder()
    {
        if (this._pet is null)
        {
            Console.WriteLine("Sem mascotes adotados.");
            Menu.WaitAnyKeytoContinue();
            return;
        }

        new TamagotchiView().BuildInterationMenu(_name, _pet, ShowPetDetails, FeedPet, PlayPet).Execute();
    }

    internal void GetPoke(string name)
    {
        try { 
            this._pokemon = _pokeApi.GetPokemon(name);
            AdoptionMenuBuilder();
        }catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public void AddPet()
    {
        _pet = new MapperPokemonToPet().CreatePet(this._pokemon);
        Console.WriteLine($"{_name} mascote adotado com sucesso, o ovo de {_pet.Name} está chocando:");
        Menu.ShowEgg();
        Menu.WaitAnyKeytoContinue();
    }

    internal void ShowPokemonDetails()
    {
        Console.WriteLine(_pokemon);
        Console.WriteLine();
        Menu.WaitAnyKeytoContinue();
    }

    public void ShowPetDetails()
    {
        Console.WriteLine(this._pet);
        Console.WriteLine();
    }

    public void FeedPet()
    {
        this._pet.Feed();
    }

    public void PlayPet()
    {
        this._pet.Play();
    }

    internal void AskName()
    {
        Console.Write("Qual é seu nome?");
        this._name = Console.ReadLine();
    }

    public void Exit()
    {
        Console.Clear();
        Console.WriteLine("Tchau!!!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}