using System;
using System.Collections.Generic;

namespace PokemonGame.Models
{
    public class Pokemon
    {
        public string Name { get; }
        public string Type { get; }
        public int MaxHP { get; }
        public int CurrentHP { get; set; }
        public int Attack { get; }
        public int Defense { get; }
        public int Speed { get; }
        public List<Move> Moves { get; }

        public Pokemon(string name, string type, int hp, int atk, int def, int speed, List<Move> moves)
        {
            Name = name;
            Type = type;
            MaxHP = hp;
            CurrentHP = hp;
            Attack = atk;
            Defense = def;
            Speed = speed;
            Moves = moves;
        }

        public void ResetHP() => CurrentHP = MaxHP;

        public bool IsFainted => CurrentHP <= 0;
    }
}
