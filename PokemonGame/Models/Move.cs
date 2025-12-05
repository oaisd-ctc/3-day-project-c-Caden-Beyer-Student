namespace PokemonGame.Models
{
    public class Move
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public double CritChance { get; set; } = 0.1;

        public Move(string name, string type, int power, int accuracy)
        {
            Name = name;
            Type = type.ToLower();
            Power = power;
            Accuracy = accuracy;
        }
    }
}
