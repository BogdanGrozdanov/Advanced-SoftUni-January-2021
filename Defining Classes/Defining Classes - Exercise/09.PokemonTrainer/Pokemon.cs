using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon()
        {

        }
        public Pokemon(string pokemonName, string pokemonElement, int pokemonHealth) : this()
        {
            PokemonName = pokemonName;
            PokemonElement = pokemonElement;
            PokemonHealth = pokemonHealth;
        }
        public Pokemon(string[] inputData)
        {
            PokemonName = inputData[1];
            PokemonElement = inputData[2];
            PokemonHealth = int.Parse(inputData[3]);
        }

        private string pokemonName;
        private string pokemonElement;
        private int health;

        public string PokemonName { get; set; }
        public string PokemonElement { get; set; }
        public int PokemonHealth { get; set; }
    }

}
