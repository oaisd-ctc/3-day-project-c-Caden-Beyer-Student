namespace PokemonGame.Models
{
    public class Move
    {
        public string Name { get; }
        public string Type { get; }
        public int Power { get; }
        public int Accuracy { get; }
        public double CritChance { get; } = 0.1;

        public Move(string name, string type, int power, int accuracy)
        {
            Name = name;
            Type = type;
            Power = power;
            Accuracy = accuracy;
        }
    }
}