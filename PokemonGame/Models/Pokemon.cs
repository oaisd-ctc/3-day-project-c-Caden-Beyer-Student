namespace PokemonGame.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public StatusCondition Status { get; set; } = StatusCondition.None;

        public List<Move> Moves = new();

        public Pokemon Clone()
        {
            return new Pokemon
            {
                Name = Name,
                Type = Type,
                MaxHP = MaxHP,
                HP = MaxHP,
                Attack = Attack,
                Defense = Defense,
                Speed = Speed,
                Moves = Moves,
                Status = StatusCondition.None
            };
        }
    }
}
