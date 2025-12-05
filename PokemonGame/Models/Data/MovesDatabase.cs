using PokemonGame.Models;

namespace PokemonGame.Data
{
    public static class MovesDatabase
    {
        public static Move Scratch = new("Scratch", "normal", 40, 100);
        public static Move Tackle = new("Tackle", "normal", 40, 100);
        public static Move QuickAttack = new("Quick Attack", "normal", 40, 100);
        public static Move TakeDown = new("Take Down", "normal", 90, 85);
        public static Move Pound = new("Pound", "normal", 40, 100);
        public static Move Metronome = new("Metronome", "normal", 0, 100);
        public static Move Rest = new("Rest", "normal", 0, 100);
        public static Move Slam = new("Slam", "normal", 80, 75);
        public static Move Bind = new("Bind", "normal", 15, 85);
        public static Move BodySlam = new("Body Slam", "normal", 85, 100);
        public static Move TailWhip = new("Tail Whip", "normal", 0, 100);

        public static Move Flamethrower = new("Flamethrower", "fire", 90, 100);

        public static Move HydroPump = new("Hydro Pump", "water", 110, 80);

        public static Move RazorLeaf = new("Razor Leaf", "grass", 55, 95);
        public static Move LeechSeed = new("Leech Seed", "grass", 20, 90);

        public static Move ThunderShock = new("Thunder Shock", "electric", 40, 100);
        public static Move Thunder = new("Thunder", "electric", 110, 70);

        public static Move Bite = new("Bite", "dark", 60, 100);
        public static Move FaintAttack = new("Faint Attack", "dark", 60, 100);
        public static Move MeanLook = new("Mean Look", "dark", 0, 100);

        public static Move DragonRage = new("Dragon Rage", "dragon", 60, 100);
        public static Move HyperBeam = new("Hyper Beam", "normal", 150, 90);

        public static Move SandAttack = new("Sand-Attack", "ground", 0, 100);
        public static Move Earthquake = new("Earthquake", "ground", 100, 100);

        public static Move FocusEnergy = new("Focus Energy", "normal", 0, 100);
        public static Move RockSmash = new("Rock Smash", "rock", 40, 100);
        public static Move SeismicToss = new("Seismic Toss", "fighting", 60, 100);

        public static Move Psybeam = new("Psybeam", "psychic", 65, 100);
        public static Move Reflect = new("Reflect", "psychic", 0, 100);
        public static Move Recover = new("Recover", "psychic", 0, 100);
        public static Move ConfuseRay = new("Confuse Ray", "psychic", 0, 100);

        public static Move Smog = new("Smog", "poison", 30, 70);
        public static Move Smokescreen = new("Smokescreen", "normal", 0, 100);

        public static Move Lick = new("Lick", "ghost", 30, 100);
        public static Move NightShade = new("Night Shade", "ghost", 60, 100);
        public static Move DreamEater = new("Dream Eater", "psychic", 100, 100);

        public static Move Peck = new("Peck", "flying", 35, 100);
        public static Move AerialAce = new("Aerial Ace", "flying", 60, 999);
        public static Move Sing = new("Sing", "normal", 0, 55);

        public static Move RockThrow = new("Rock Throw", "rock", 50, 90);

        public static Move StringShot = new("String Shot", "bug", 0, 95);
        public static Move BugBite = new("Bug Bite", "bug", 60, 100);

        public static Move DisarmingVoice = new("Disarming Voice", "fairy", 40, 999);

        public static Move IceBeam = new("Ice Beam", "ice", 90, 100);

        public static Move GyroBall = new("Gyro Ball", "steel", 50, 100);

        public static Move Wrap = new("Wrap", "normal", 15, 90);
    }
}