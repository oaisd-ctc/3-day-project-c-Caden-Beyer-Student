using System.Collections.Generic;

namespace PokemonGame.Models
{
    public static class TypeChart
    {
        private static readonly Dictionary<(string, string), double> Chart =
            new Dictionary<(string, string), double>
        {
            {("fire", "grass"), 2}, {("grass", "fire"), 0.5},
            {("water", "fire"), 2}, {("fire", "water"), 0.5},
            {("electric", "water"), 2},
            {("ground", "electric"), 2}, {("electric", "ground"), 0},

            // Add all based on type chart
        };

        public static double Effectiveness(string moveType, string targetType)
        {
            return Chart.TryGetValue((moveType, targetType), out double value)
                ? value : 1.0;
        }
    }
}
