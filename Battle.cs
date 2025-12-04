using System;
using System.Collections.Generic;

namespace PokemonGame.Models
{
    public class Battle
    {
        private Pokemon player;
        private Pokemon enemy;

        public Battle(Pokemon playerPokemon, Pokemon enemyPokemon)
        {
            player = playerPokemon;
            enemy = enemyPokemon;
        }

        private bool MoveHits(Move move)
        {
            Random r = new Random();
            return r.Next(1, 101) <= move.Accuracy;
        }

        private bool Crits(Move move)
        {
            Random r = new Random();
            return r.NextDouble() <= move.CritChance;
        }

        private int CalculateDamage(Pokemon attacker, Pokemon defender, Move move)
        {
            double modifier = TypeChart.Effectiveness(move.Type.ToLower(), defender.Type.ToLower());

            if (Crits(move))
                modifier *= 2;

            return (int)((((2 * attacker.Attack / 5 + 2) * move.Power * attacker.Attack / defender.Defense) / 50 + 2) * modifier);
        }

        private void ExecuteAttack(Pokemon attacker, Pokemon defender, Move move)
        {
            if (!MoveHits(move))
            {
                Console.WriteLine($"{attacker.Name}'s {move.Name} missed!");
                return;
            }

            int dmg = CalculateDamage(attacker, defender, move);
            defender.CurrentHP -= dmg;

            Console.WriteLine($"{attacker.Name} used {move.Name} and dealt {dmg} damage!");
            if (defender.IsFainted)
                Console.WriteLine($"{defender.Name} fainted!");
        }

        public Pokemon RunTurn()
        {
            while (!player.IsFainted && !enemy.IsFainted)
            {
                Move playerMove = ChooseMove(player);

                if (player.Speed >= enemy.Speed)
                {
                    ExecuteAttack(player, enemy, playerMove);
                    if (enemy.IsFainted) break;

                    ExecuteAttack(enemy, player, EnemyChooseMove());
                }
                else
                {
                    ExecuteAttack(enemy, player, EnemyChooseMove());
                    if (player.IsFainted) break;

                    ExecuteAttack(player, enemy, playerMove);
                }
            }

            return player.IsFainted ? enemy : player;
        }

        private Move ChooseMove(Pokemon mon)
        {
            Console.WriteLine("Choose a move:");
            for (int i = 0; i < mon.Moves.Count; i++)
                Console.WriteLine($"{i + 1}. {mon.Moves[i].Name}");

            int choice = int.Parse(Console.ReadLine()) - 1;
            return mon.Moves[choice];
        }

        private Move EnemyChooseMove()
        {
            Random r = new Random();
            return enemy.Moves[r.Next(enemy.Moves.Count)];
        }
    }
}
