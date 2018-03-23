using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        List<Trainer> trainers = new List<Trainer>();
        
        string input = Console.ReadLine();
        AddPokemonAndTrainerInformationToCollections(input, pokemons, trainers);

        string element = Console.ReadLine();
        CheckForPokemonElementsAndPlay(element, pokemons, trainers);

        PrintTrainers(trainers);
        
    }

    private static void PrintTrainers(List<Trainer> trainers)
    {
        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    private static void CheckForPokemonElementsAndPlay(string element, List<Pokemon> pokemons, List<Trainer> trainers)
    {
        while (element != "End")
        {
            foreach (var trainer in trainers)
            {
                var IsElementExist = trainer.Pokemons.Exists(p => p.Element == element);
                if (IsElementExist)
                {
                    trainer.AddBadge();
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.LoseHealth();
                        if (pokemon.Health <= 0)
                        {
                            trainer.RemovePokemon(pokemon);
                            break;
                        }
                    }
                }
            }

            element = Console.ReadLine();
        }
    }

    private static void AddPokemonAndTrainerInformationToCollections(string input, List<Pokemon> pokemons, List<Trainer> trainers)
    {
        while (input != "Tournament")
        {
            string[] pokemonArgs = input.Split();
            string trainerName = pokemonArgs[0];
            string pokemonName = pokemonArgs[1];
            string pokemonElement = pokemonArgs[2];
            int pokemonHealth = int.Parse(pokemonArgs[3]);

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            pokemons.Add(pokemon);

            if (!trainers.Any(t => t.Name == trainerName))
            {
                Trainer trainer = new Trainer(trainerName, 0);
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);
            }
            else
            {
                var Trainer = trainers.Where(t => t.Name == trainerName).First();
                Trainer.Pokemons.Add(pokemon);

            }

            input = Console.ReadLine();
        }
    }
}

