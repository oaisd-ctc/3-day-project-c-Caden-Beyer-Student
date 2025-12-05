using PokemonGame.Models;

namespace PokemonGame.Data
{
    public static class MovesDatabase
    {
        public static Move Scratch = new("Scratch", "normal", 36, 100, false);
        public static Move Tackle = new("Tackle", "normal", 36, 100, false);
        public static Move QuickAttack = new("Quick Attack", "normal", 36, 100, false);
        public static Move TakeDown = new("Take Down", "normal", 81, 85, false);
        public static Move Pound = new("Pound", "normal", 36, 100, false);
        public static Move Metronome = new("Metronome", "normal", 0, 100, false);
        public static Move Rest = new("Rest", "normal", 0, 100, true);
        public static Move Slam = new("Slam", "normal", 72, 75, false);
        public static Move Bind = new("Bind", "normal", 15, 85, false);
        public static Move BodySlam = new("Body Slam", "normal", 78, 100, false);
        public static Move TailWhip = new("Tail Whip", "normal", 0, 100, false);

        public static Move Flamethrower = new("Flamethrower", "fire", 81, 100, false);

        public static Move HydroPump = new("Hydro Pump", "water", 99, 80, false);

        public static Move RazorLeaf = new("Razor Leaf", "grass", 50, 95, false);
        public static Move LeechSeed = new("Leech Seed", "grass", 18, 90, true);

        public static Move ThunderShock = new("Thunder Shock", "electric", 36, 100, false);
        public static Move Thunder = new("Thunder", "electric", 99, 70, false);

        public static Move Bite = new("Bite", "dark", 54, 100, false);
        public static Move FaintAttack = new("Faint Attack", "dark", 54, 100, false);
        public static Move MeanLook = new("Mean Look", "dark", 0, 100, false);

        public static Move DragonRage = new("Dragon Rage", "dragon", 54, 100, false);
        public static Move HyperBeam = new("Hyper Beam", "normal", 135, 90, false);

        public static Move SandAttack = new("Sand-Attack", "ground", 0, 100, false);
        public static Move Earthquake = new("Earthquake", "ground", 90, 100, false);

        public static Move FocusEnergy = new("Focus Energy", "normal", 0, 100, false);
        public static Move RockSmash = new("Rock Smash", "rock", 36, 100, false);
        public static Move SeismicToss = new("Seismic Toss", "fighting", 54, 100, false);

        public static Move Psybeam = new("Psybeam", "psychic", 60, 100, false);
        public static Move Reflect = new("Reflect", "psychic", 0, 100, false);
        public static Move Recover = new("Recover", "psychic", 0, 100, true);
        public static Move ConfuseRay = new("Confuse Ray", "psychic", 0, 100, false);

        public static Move Smog = new("Smog", "poison", 27, 70, false);
        public static Move Smokescreen = new("Smokescreen", "normal", 0, 100, false);

        public static Move Lick = new("Lick", "ghost", 27, 100, false);
        public static Move NightShade = new("Night Shade", "ghost", 54, 100, false);
        public static Move DreamEater = new("Dream Eater", "psychic", 90, 100, false);

        public static Move Peck = new("Peck", "flying", 32, 100, false);
        public static Move AerialAce = new("Aerial Ace", "flying", 54, 999, false);
        public static Move Sing = new("Sing", "normal", 0, 55, false);

        public static Move RockThrow = new("Rock Throw", "rock", 45, 90, false);

        public static Move StringShot = new("String Shot", "bug", 0, 95, false);
        public static Move BugBite = new("Bug Bite", "bug", 54, 100, false);

        public static Move DisarmingVoice = new("Disarming Voice", "fairy", 36, 999, false);

        public static Move IceBeam = new("Ice Beam", "ice", 81, 100, false);

        public static Move GyroBall = new("Gyro Ball", "steel", 45, 100, false);

        public static Move Wrap = new("Wrap", "normal", 15, 90, false);
    }
}