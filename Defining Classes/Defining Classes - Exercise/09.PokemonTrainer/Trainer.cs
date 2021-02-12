using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer()
        {

        }
        public Trainer(string[] inputData) : this()
        {
            Name = inputData[0];
            NumberOfBadges = defaultNumberOfBadges;
            Pokemons = new List<Pokemon>();
        }
        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {Pokemons.Count}";
        }
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;
        private const int defaultNumberOfBadges = 0;


        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
