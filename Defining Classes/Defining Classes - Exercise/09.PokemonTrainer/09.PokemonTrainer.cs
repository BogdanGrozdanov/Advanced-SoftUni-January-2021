using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> allTrainers = new List<Trainer>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Tournament")
            {
                Pokemon currPokemon = new Pokemon(input);
                Trainer currTrainer = new Trainer(input);
                if (!allTrainers.Any(t => t.Name == currTrainer.Name))
                {
                    allTrainers.Add(currTrainer);
                }
                var trainer = allTrainers.First(t => t.Name == currTrainer.Name);
                trainer.Pokemons.Add(currPokemon);
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                foreach (var trainer in allTrainers)
                {
                    if (trainer.Pokemons.Any(t => t.PokemonElement == comand))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(t => t.PokemonHealth -= 10);
                    }

                    trainer.Pokemons = trainer.Pokemons.Where(p => p.PokemonHealth > 0).ToList();
                }
                comand = Console.ReadLine();
            }
            var filterTrainers = allTrainers.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (var trainers in filterTrainers)
            {
                Console.WriteLine(trainers);
            }

            //foreach (var item in allTrainers)
            //{
            //    Console.WriteLine($"{item.Name}  {item.NumberOfBadges} ");
            //    foreach (var po in item.Pokemons)
            //    {
            //        Console.WriteLine(po.PokemonName + "  " + po.PokemonHealth + "  " + po.PokemonElement);
            //    }
            //}

        }
    }
}
