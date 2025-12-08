using PokemonGame.Models;

namespace PokemonGame.Data
{
    public static class PokemonDatabase
    {
        public static List<Pokemon> All = new()
        {
            new Pokemon {
    Name = "Charmander", Type="fire",
    MaxHP=78, Attack=62, Defense=72, Speed=80,
    Moves = new() { MovesDatabase.Scratch, MovesDatabase.Flamethrower, MovesDatabase.DragonRage }
},

new Pokemon {
    Name = "Squirtle", Type="water",
    MaxHP=82, Attack=60, Defense=85, Speed=60,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.HydroPump, MovesDatabase.Bite }
},

new Pokemon {
    Name = "Bulbasaur", Type="grass",
    MaxHP=80, Attack=61, Defense=78, Speed=65,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.RazorLeaf, MovesDatabase.LeechSeed }
},

new Pokemon {
    Name = "Eevee", Type="normal",
    MaxHP=75, Attack=60, Defense=70, Speed=80,
    Moves = new() { MovesDatabase.TailWhip, MovesDatabase.SandAttack, MovesDatabase.TakeDown }
},

new Pokemon {
    Name = "Pikachu", Type="electric",
    MaxHP=65, Attack=66, Defense=55, Speed=105,
    Moves = new() { MovesDatabase.QuickAttack, MovesDatabase.Thunder, MovesDatabase.ThunderShock }
},

new Pokemon {
    Name = "Machop", Type="fighting",
    MaxHP=88, Attack=78, Defense=72, Speed=55,
    Moves = new() { MovesDatabase.FocusEnergy, MovesDatabase.RockSmash, MovesDatabase.SeismicToss }
},

new Pokemon {
    Name = "Abra", Type="psychic",
    MaxHP=55, Attack=36, Defense=40, Speed=95,
    Moves = new() { MovesDatabase.Reflect, MovesDatabase.Recover, MovesDatabase.Psybeam }
},

new Pokemon {
    Name = "Koffing", Type="poison",
    MaxHP=85, Attack=56, Defense=100, Speed=50,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.Smokescreen, MovesDatabase.Smog }
},

new Pokemon {
    Name = "Dratini", Type="dragon",
    MaxHP=78, Attack=74, Defense=70, Speed=72,
    Moves = new() { MovesDatabase.Wrap, MovesDatabase.DragonRage, MovesDatabase.HyperBeam }
},

new Pokemon {
    Name = "Gastly", Type="ghost",
    MaxHP=60, Attack=40, Defense=45, Speed=95,
    Moves = new() { MovesDatabase.Lick, MovesDatabase.NightShade, MovesDatabase.DreamEater }
},

new Pokemon {
    Name = "Murkrow", Type="dark",
    MaxHP=70, Attack=72, Defense=55, Speed=100,
    Moves = new() { MovesDatabase.Peck, MovesDatabase.FaintAttack, MovesDatabase.MeanLook }
},

new Pokemon {
    Name = "Geodude", Type="ground",
    MaxHP=82, Attack=74, Defense=110, Speed=40,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.RockThrow, MovesDatabase.Earthquake }
},

new Pokemon {
    Name = "Clefairy", Type="fairy",
    MaxHP=90, Attack=52, Defense=78, Speed=55,
    Moves = new() { MovesDatabase.Pound, MovesDatabase.DisarmingVoice, MovesDatabase.Metronome }
},

new Pokemon {
    Name = "Pidgey", Type="flying",
    MaxHP=70, Attack=52, Defense=60, Speed=85,
    Moves = new() { MovesDatabase.Rest, MovesDatabase.Sing, MovesDatabase.AerialAce }
},

new Pokemon {
    Name = "Onix", Type="rock",
    MaxHP=95, Attack=56, Defense=140, Speed=70,
    Moves = new() { MovesDatabase.Bind, MovesDatabase.RockThrow, MovesDatabase.Slam }
},

new Pokemon {
    Name = "Caterpie", Type="bug",
    MaxHP=60, Attack=44, Defense=55, Speed=55,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.StringShot, MovesDatabase.BugBite }
},

new Pokemon {
    Name = "Lapras", Type="ice",
    MaxHP=110, Attack=72, Defense=85, Speed=70,
    Moves = new() { MovesDatabase.BodySlam, MovesDatabase.ConfuseRay, MovesDatabase.IceBeam }
},

new Pokemon {
    Name = "Magnemite", Type="steel",
    MaxHP=65, Attack=56, Defense=90, Speed=55,
    Moves = new() { MovesDatabase.Tackle, MovesDatabase.ThunderShock, MovesDatabase.GyroBall }
},

        };
    }
}
