using PokemonGame.Data;

namespace PokemonGame.Models
{
    public class Battle
    {
        private List<Pokemon> playerTeam;
        private List<Pokemon> enemyTeam;
        private Pokemon playerActive;
        private Pokemon enemyActive;
        private Random rng = new Random();

        public Battle(List<Pokemon> pTeam, List<Pokemon> eTeam)
        {
            playerTeam = pTeam.Select(p => p.Clone()).ToList();
            enemyTeam = eTeam.Select(p => p.Clone()).ToList();
            playerActive = playerTeam[0];
            enemyActive = enemyTeam[0];
        }

        public void Start()
        {
            Console.WriteLine("\n=== Battle Start ===");

            while (playerTeam.Any(p => p.HP > 0) && enemyTeam.Any(p => p.HP > 0))
            {
                if (playerActive.HP <= 0) ForcePlayerSwap();
                if (enemyActive.HP <= 0) EnemySwap();

                PlayerTurn();
                if (enemyTeam.All(p => p.HP <= 0)) break;

                EnemyTurn();
            }

            Console.WriteLine(playerTeam.Any(p => p.HP > 0) ? "You win the battle!" : "You lost the battle!");
        }

        private void PlayerTurn()
        {
            Console.WriteLine();
            Console.WriteLine($"{playerActive.Name} HP: {playerActive.HP}/{playerActive.MaxHP}");
            Console.WriteLine($"{enemyActive.Name} HP: {enemyActive.HP}/{enemyActive.MaxHP}");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Switch Pokémon");

            int choice = GetInput(1, 2);

            if (choice == 1)
                PlayerChooseMove();
            else
                PlayerSwap();
        }

        private void PlayerChooseMove()
        {
            for (int i = 0; i < playerActive.Moves.Count; i++)
                Console.WriteLine($"{i + 1}. {playerActive.Moves[i].Name}");

            int choice = GetInput(1, playerActive.Moves.Count);
            ExecuteMove(playerActive, enemyActive, playerActive.Moves[choice - 1]);
        }

        private void PlayerSwap()
        {
            Console.WriteLine("Choose a Pokémon:");

            List<Pokemon> available = playerTeam.Where(p => p.HP > 0 && p != playerActive).ToList();

            for (int i = 0; i < available.Count; i++)
                Console.WriteLine($"{i + 1}. {available[i].Name} ({available[i].HP}/{available[i].MaxHP})");

            int choice = GetInput(1, available.Count);
            playerActive = available[choice - 1];
            Console.WriteLine($"You sent out {playerActive.Name}!");
        }

        private void ForcePlayerSwap()
        {
            Console.WriteLine($"{playerActive.Name} fainted! Choose another Pokémon.");

            List<Pokemon> available = playerTeam.Where(p => p.HP > 0).ToList();

            for (int i = 0; i < available.Count; i++)
                Console.WriteLine($"{i + 1}. {available[i].Name}");

            int choice = GetInput(1, available.Count);
            playerActive = available[choice - 1];
        }

        private void EnemyTurn()
        {
            if (enemyActive.HP <= 0) return;

            Move move = enemyActive.Moves[rng.Next(enemyActive.Moves.Count)];
            ExecuteMove(enemyActive, playerActive, move);
        }

        private void EnemySwap()
        {
            Pokemon next = enemyTeam.First(p => p.HP > 0);
            enemyActive = next;
            Console.WriteLine($"Enemy sent out {enemyActive.Name}!");
        }

        private void ExecuteMove(Pokemon attacker, Pokemon defender, Move move)
        {
            if (rng.Next(100) >= move.Accuracy)
            {
                Console.WriteLine($"{attacker.Name}'s {move.Name} missed!");
                return;
            }

            double crit = rng.NextDouble() < move.CritChance ? 1.5 : 1.0;
            double eff = TypeChart.GetEffectiveness(move.Type, defender.Type);

            int dmg = (int)((move.Power + attacker.Attack - defender.Defense / 2.0) * crit * eff);
            if (dmg < 1) dmg = 1;

            defender.HP -= dmg;
            if (defender.HP < 0) defender.HP = 0;

            Console.WriteLine($"{attacker.Name} used {move.Name}!");
            if (crit > 1) Console.WriteLine("Critical hit!");
            if (eff > 1) Console.WriteLine("It's super effective!");
            if (eff < 1) Console.WriteLine("It's not very effective...");
            Console.WriteLine($"{defender.Name} HP: {defender.HP}/{defender.MaxHP}");
        }

        private int GetInput(int min, int max)
        {
            while (true)
            {
                Console.Write("> ");
                if (int.TryParse(Console.ReadLine(), out int x) && x >= min && x <= max)
                    return x;
            }
        }
    }
}